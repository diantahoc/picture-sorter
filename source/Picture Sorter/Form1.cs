using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Picture_Sorter
{
    public partial class Form1 : Form
    {

        string lastAction;
        List<string> Categories = new List<string>();
        List<string> FileTypes = new List<string>();
        string BasePath = "not set";
        MemoryStream memStream;
        int CurrentIndex;
        

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        public void LoadCategories()
        {
            Categories.Clear();
            ToolStrip1.Items.Clear();
            foreach (DirectoryInfo x in FileSystem.GetDirectoryInfo(BasePath).GetDirectories())
            {
                //NAME;FULL_PATH
                Categories.Add(x.Name + ";" + x.FullName);
                ToolStrip1.Items.Add(new_ite(x.Name, x.FullName));
                //ToolStripLabel1
            }
            AppendCategoiesIntoComboBox();
        }

        public ToolStripButton new_ite(string name, string fullname)
        {
            ToolStripButton d = new ToolStripButton(name);
            d.Tag = fullname;
            return d;
        }

        public void AppendCategoiesIntoComboBox()
        {
            H_CAT_COMBO.Items.Clear();
            foreach (string x in Categories)
            {
                H_CAT_COMBO.Items.Add(Convert.ToString(x.Split(Convert.ToChar(";")).ElementAt(0)));
            }
        }

        public string GetCategorieFullpath(string CatName)
        {
            return Path.Combine(BasePath, CatName);
        }

        public void LoadFilesIntoFinder()
        {
            H_FILE_LIST.Items.Clear();
            EncodeFT(H_FT_INPUT.Text);
            try
            {
                foreach (string o in FileTypes)
                {
                    foreach (FileInfo x in FileSystem.GetDirectoryInfo(BasePath).GetFiles("*" + o))
                    {
                        H_FILE_LIST.Items.Add(x.FullName);
                    }
                }
                H_FILE_CONUT.Text = H_FILE_LIST.Items.Count + " file(s)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load files: \n\n" + ex.Message);
            }
        }

        public void EncodeFT(string t)
        {
            FileTypes.Clear();
            foreach (string x in t.Split(Convert.ToChar(",")))
            {
                FileTypes.Add(x);
            }
        }

        public void LoadImageWithoutLock(string Path)
        {
            byte[] barr = File.ReadAllBytes(Path);
            H_IMAGE.Image = null;
            if ((memStream != null))
                memStream.Dispose();
            memStream = new MemoryStream();

            memStream.Write(barr, 0, barr.Count());

            try
            {
                Image i = Image.FromStream(memStream);
                H_IMAGE.Image = i;
            }
            catch (Exception ex)
            {
                H_IMAGE.Image = H_IMAGE.ErrorImage;
            }
        }

        public void NextFile()
        {
            CurrentIndex += 1;
            try
            {
                H_FILE_LIST.SelectedIndex = CurrentIndex;
                LoadImageWithoutLock((string)H_FILE_LIST.Items[H_FILE_LIST.SelectedIndex]);
            }
            catch (Exception ex)
            {
                CurrentIndex = H_FILE_LIST.Items.Count - 1;
                MessageBox.Show("No next file");
            }
        }

        public void PrevFile()
        {
            CurrentIndex -= 1;
            try
            {
                H_FILE_LIST.SelectedIndex = CurrentIndex;
                LoadImageWithoutLock((string)H_FILE_LIST.Items[H_FILE_LIST.SelectedIndex]);
            }
            catch (Exception ex)
            {
                CurrentIndex = 0;
                MessageBox.Show("No previous file");
            }
        }

        public void MoveFile(string filepath, string catPath)
        {
            string newPath = Path.Combine(catPath , FileSystem.GetFileInfo(filepath).Name);
            FileSystem.MoveFile(filepath, newPath, false);
            lastAction = "FILEMOVE?" + filepath + "?" + newPath;
            LoadFilesIntoFinder();
            try
            {
                H_FILE_LIST.SelectedIndex = CurrentIndex;
            }
            catch (Exception ex)
            {
                H_IMAGE.Image = null;
            }
        }

        public void DeleteFile(string filepath)
        {
            RecycleOption opt = default(RecycleOption);

            if (CheckBox3.Checked)
            {
                opt = RecycleOption.SendToRecycleBin;
            }
            else
            {
                opt = RecycleOption.DeletePermanently;
            }
            FileSystem.DeleteFile(filepath, UIOption.OnlyErrorDialogs, opt);
            LoadFilesIntoFinder();
            H_FILE_LIST.SelectedIndex = CurrentIndex;
        }

        public void SetBasePath(string path)
        {
            Properties.Settings.Default.bs = path;
            Properties.Settings.Default.Save();
            TextBox1.Text = path;
            BasePath = path;
            CheckDirs();
            LoadCategories();
            LoadFilesIntoFinder();
            CurrentIndex = 0;
            if (H_FILE_LIST.Items.Count > 0)
            { H_FILE_LIST.SelectedIndex = CurrentIndex; }
        }

        public void choose_new_basepath()
        {
            FolderBrowserDialog i = new FolderBrowserDialog();
            try
            {
                i.SelectedPath = TextBox1.Text;
            }
            catch (Exception ex)
            {
            }
            if (i.ShowDialog() == DialogResult.OK)
            {
                TextBox1.Text = i.SelectedPath;
                SetBasePath(TextBox1.Text);
            }
        }


        private void ConvertImage(System.Drawing.Imaging.ImageFormat t, string ext)
        {
            //Get file info
            System.IO.FileInfo fIndo = FileSystem.GetFileInfo(GetSelectFilePath());
           
            if (fIndo.Extension == "." + ext)
            {
                MessageBox.Show("The file is already " + ext);
                return;
            }

            //Backup check
            if (CheckBox2.Checked)
            {
                //Rename the old file
                FileSystem.RenameFile(fIndo.FullName, fIndo.Name.Split(Convert.ToChar("."))[0] + ".bak");
            }

            //Open a new file stream using the old file path
            System.IO.FileStream fs = new System.IO.FileStream(fIndo.FullName, FileMode.OpenOrCreate);

            //Make a temporary image
            Image w = Image.FromStream(memStream);
            Image tempImage = (Image)w.Clone();
            //Release the old file
            w.Dispose();


            //Save the tempImage in required format

            tempImage.Save(fs, t);
            tempImage.Dispose();

            //Close the file
            fs.Close();


            //Finally correct the new file extension

            FileSystem.RenameFile(fIndo.FullName, fIndo.Name.Split(Convert.ToChar("."))[0] + "." + ext);
        }

        private string GetSelectFilePath()
        {
            return Convert.ToString(H_FILE_LIST.Items[H_FILE_LIST.SelectedIndex]);
        }

        private string GetFilePathByIndex(ref Int32 index)
        {
            return Convert.ToString(H_FILE_LIST.Items[index]);
        }

        private void CheckDirs()
        {
            if (!FileSystem.DirectoryExists(BasePath))
            {
                FileSystem.CreateDirectory(BasePath);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LoadFilesIntoFinder();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            choose_new_basepath();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ft = H_FT_INPUT.Text;
            Properties.Settings.Default .Save();
            LoadFilesIntoFinder();
        }

        private void H_FILE_LIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadImageWithoutLock((string)H_FILE_LIST.Items[H_FILE_LIST.SelectedIndex]);
            H_FILE_NAME_LABEL.Text = (string)H_FILE_LIST.Items[H_FILE_LIST.SelectedIndex];
            CurrentIndex = H_FILE_LIST.SelectedIndex;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (H_CAT_COMBO.SelectedIndex == -1) {return;}
            MoveFile((string)H_FILE_LIST.Items[H_FILE_LIST.SelectedIndex], GetCategorieFullpath((string)H_CAT_COMBO.Items[H_CAT_COMBO.SelectedIndex]));
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (H_CAT_NAME_TEXTBOX.Text.Length > 0)
            {
                string path = Path.Combine(BasePath, H_CAT_NAME_TEXTBOX.Text);
                if (FileSystem.DirectoryExists(path))
                {
                    MessageBox.Show("Category already exist");
                }
                else
                {
                    FileSystem.CreateDirectory(path);
                    H_CAT_NAME_TEXTBOX.Text = "";
                    LoadCategories();
                }
            }
            else 
            {
                MessageBox.Show("Enter category name");
            }
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MoveFile((string)H_FILE_LIST.Items[H_FILE_LIST.SelectedIndex], GetCategorieFullpath(e.ClickedItem.Text));
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }

        private void H_IMAGE_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked){
                MoveFile((string)H_FILE_LIST.Items[H_FILE_LIST.SelectedIndex], GetCategorieFullpath((string)H_CAT_COMBO.Items[H_CAT_COMBO.SelectedIndex]));
            }
        }

        private void H_IMAGE_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void H_IMAGE_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void H_IMAGE_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar1.Value = e.ProgressPercentage;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            string[] data = lastAction.Split(Convert.ToChar("?"));
            switch (data[0])
            {
                case "FILEMOVE":
                    File.Move(data[2], data[1]);
                    LoadFilesIntoFinder();
                    lastAction = "";
                    break;
                default:
                    lastAction = "";
                    break;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Button12.Enabled = !(lastAction == "");
        }

        private void CheckBox2_Click(object sender, EventArgs e)
        {
            if (CheckBox2.Checked) { MessageBox.Show("A .bak file will be made"); } 
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            DeleteFile((string)H_FILE_LIST.Items[H_FILE_LIST.SelectedIndex]);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            NextFile();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            PrevFile();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
          ConvertImage(System.Drawing.Imaging.ImageFormat.Jpeg, "jpg");
          LoadFilesIntoFinder();
          LoadImageWithoutLock(GetFilePathByIndex(ref CurrentIndex));
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            ConvertImage(System.Drawing.Imaging.ImageFormat.Png, "png");
            LoadFilesIntoFinder();
            LoadImageWithoutLock(GetFilePathByIndex(ref CurrentIndex));
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start((string)H_FILE_LIST.Items[H_FILE_LIST.SelectedIndex]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BasePath = Properties.Settings.Default.bs;
            if (BasePath == "not set")
            {
                MessageBox.Show("Select a folder to begin sorting");
                choose_new_basepath();
            }
            else
            {
                SetBasePath(BasePath);
            }
            ToolTip1.SetToolTip(CheckBox1, "Enable image moving by clicking on the image to the selected category");
        }
        private void button15_Click(object sender, EventArgs e)
        {
            ColorSorter i = new ColorSorter();
            i.Show();
        }
    }
}
