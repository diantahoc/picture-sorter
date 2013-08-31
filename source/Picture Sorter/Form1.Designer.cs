namespace Picture_Sorter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.H_IMAGE = new System.Windows.Forms.PictureBox();
            this.Button9 = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Button7 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.H_FILE_NAME_LABEL = new System.Windows.Forms.Label();
            this.Button14 = new System.Windows.Forms.Button();
            this.H_FILE_LIST = new System.Windows.Forms.ListBox();
            this.Button12 = new System.Windows.Forms.Button();
            this.Button11 = new System.Windows.Forms.Button();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.H_FILE_CONUT = new System.Windows.Forms.Label();
            this.Button13 = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.Button8 = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.H_CAT_NAME_TEXTBOX = new System.Windows.Forms.TextBox();
            this.Button6 = new System.Windows.Forms.Button();
            this.H_CAT_COMBO = new System.Windows.Forms.ComboBox();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.H_FT_INPUT = new System.Windows.Forms.TextBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.button15 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.H_IMAGE)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // H_IMAGE
            // 
            this.H_IMAGE.Location = new System.Drawing.Point(16, 21);
            this.H_IMAGE.Name = "H_IMAGE";
            this.H_IMAGE.Size = new System.Drawing.Size(712, 530);
            this.H_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.H_IMAGE.TabIndex = 1;
            this.H_IMAGE.TabStop = false;
            this.H_IMAGE.WaitOnLoad = true;
            this.H_IMAGE.MouseLeave += new System.EventHandler(this.H_IMAGE_MouseLeave);
            this.H_IMAGE.Click += new System.EventHandler(this.H_IMAGE_Click);
            this.H_IMAGE.LoadProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.H_IMAGE_LoadProgressChanged);
            this.H_IMAGE.MouseEnter += new System.EventHandler(this.H_IMAGE_MouseEnter);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(507, 12);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(52, 25);
            this.Button9.TabIndex = 4;
            this.Button9.Text = "Filter";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Button9);
            this.GroupBox3.Controls.Add(this.H_FT_INPUT);
            this.GroupBox3.Controls.Add(this.Button7);
            this.GroupBox3.Controls.Add(this.TextBox1);
            this.GroupBox3.Location = new System.Drawing.Point(223, 13);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(713, 44);
            this.GroupBox3.TabIndex = 16;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Base path";
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(432, 14);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(25, 25);
            this.Button7.TabIndex = 1;
            this.Button7.Text = "....";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(6, 16);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(420, 22);
            this.TextBox1.TabIndex = 0;
            // 
            // H_FILE_NAME_LABEL
            // 
            this.H_FILE_NAME_LABEL.AutoSize = true;
            this.H_FILE_NAME_LABEL.Location = new System.Drawing.Point(6, 554);
            this.H_FILE_NAME_LABEL.Name = "H_FILE_NAME_LABEL";
            this.H_FILE_NAME_LABEL.Size = new System.Drawing.Size(43, 14);
            this.H_FILE_NAME_LABEL.TabIndex = 0;
            this.H_FILE_NAME_LABEL.Text = "Label1";
            // 
            // Button14
            // 
            this.Button14.Location = new System.Drawing.Point(762, 45);
            this.Button14.Name = "Button14";
            this.Button14.Size = new System.Drawing.Size(75, 25);
            this.Button14.TabIndex = 14;
            this.Button14.Text = "To JPG";
            this.Button14.UseVisualStyleBackColor = true;
            this.Button14.Click += new System.EventHandler(this.Button14_Click);
            // 
            // H_FILE_LIST
            // 
            this.H_FILE_LIST.FormattingEnabled = true;
            this.H_FILE_LIST.ItemHeight = 14;
            this.H_FILE_LIST.Location = new System.Drawing.Point(11, 84);
            this.H_FILE_LIST.Name = "H_FILE_LIST";
            this.H_FILE_LIST.Size = new System.Drawing.Size(185, 536);
            this.H_FILE_LIST.TabIndex = 15;
            this.H_FILE_LIST.SelectedIndexChanged += new System.EventHandler(this.H_FILE_LIST_SelectedIndexChanged);
            // 
            // Button12
            // 
            this.Button12.Location = new System.Drawing.Point(756, 14);
            this.Button12.Name = "Button12";
            this.Button12.Size = new System.Drawing.Size(48, 25);
            this.Button12.TabIndex = 13;
            this.Button12.Text = "Undo";
            this.Button12.UseVisualStyleBackColor = true;
            this.Button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // Button11
            // 
            this.Button11.Location = new System.Drawing.Point(166, 56);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(22, 25);
            this.Button11.TabIndex = 12;
            this.Button11.Text = ".";
            this.Button11.UseVisualStyleBackColor = true;
            this.Button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(12, 56);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(133, 18);
            this.CheckBox1.TabIndex = 13;
            this.CheckBox1.Text = "Enable Image Move";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // H_FILE_CONUT
            // 
            this.H_FILE_CONUT.AutoSize = true;
            this.H_FILE_CONUT.Location = new System.Drawing.Point(9, 623);
            this.H_FILE_CONUT.Name = "H_FILE_CONUT";
            this.H_FILE_CONUT.Size = new System.Drawing.Size(43, 14);
            this.H_FILE_CONUT.TabIndex = 10;
            this.H_FILE_CONUT.Text = "Label1";
            // 
            // Button13
            // 
            this.Button13.Location = new System.Drawing.Point(843, 45);
            this.Button13.Name = "Button13";
            this.Button13.Size = new System.Drawing.Size(75, 25);
            this.Button13.TabIndex = 14;
            this.Button13.Text = "To PNG";
            this.Button13.UseVisualStyleBackColor = true;
            this.Button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // Button10
            // 
            this.Button10.Location = new System.Drawing.Point(810, 14);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(108, 25);
            this.Button10.TabIndex = 12;
            this.Button10.Text = "Open Image";
            this.Button10.UseVisualStyleBackColor = true;
            this.Button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.ToolStrip1);
            this.Panel1.Location = new System.Drawing.Point(311, 23);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(402, 119);
            this.Panel1.TabIndex = 11;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(402, 119);
            this.ToolStrip1.TabIndex = 10;
            this.ToolStrip1.Text = "ToolStrip1";
            this.ToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(620, 558);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(100, 11);
            this.ProgressBar1.TabIndex = 2;
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(821, 145);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(97, 25);
            this.Button8.TabIndex = 9;
            this.Button8.Text = "Delete this file";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ProgressBar1);
            this.GroupBox2.Controls.Add(this.H_IMAGE);
            this.GroupBox2.Controls.Add(this.H_FILE_NAME_LABEL);
            this.GroupBox2.Location = new System.Drawing.Point(202, 56);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(734, 581);
            this.GroupBox2.TabIndex = 14;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "File";
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(791, 101);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(59, 25);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "<< Previous";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(856, 101);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(62, 25);
            this.Button4.TabIndex = 3;
            this.Button4.Text = "Next >>";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.button15);
            this.GroupBox1.Controls.Add(this.CheckBox3);
            this.GroupBox1.Controls.Add(this.CheckBox2);
            this.GroupBox1.Controls.Add(this.Button14);
            this.GroupBox1.Controls.Add(this.Button12);
            this.GroupBox1.Controls.Add(this.Button13);
            this.GroupBox1.Controls.Add(this.Button10);
            this.GroupBox1.Controls.Add(this.Panel1);
            this.GroupBox1.Controls.Add(this.Button8);
            this.GroupBox1.Controls.Add(this.H_CAT_NAME_TEXTBOX);
            this.GroupBox1.Controls.Add(this.Button6);
            this.GroupBox1.Controls.Add(this.H_CAT_COMBO);
            this.GroupBox1.Controls.Add(this.Button5);
            this.GroupBox1.Controls.Add(this.Button3);
            this.GroupBox1.Controls.Add(this.Button4);
            this.GroupBox1.Location = new System.Drawing.Point(12, 644);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(924, 175);
            this.GroupBox1.TabIndex = 11;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Actions";
            // 
            // H_CAT_NAME_TEXTBOX
            // 
            this.H_CAT_NAME_TEXTBOX.Location = new System.Drawing.Point(154, 83);
            this.H_CAT_NAME_TEXTBOX.Name = "H_CAT_NAME_TEXTBOX";
            this.H_CAT_NAME_TEXTBOX.Size = new System.Drawing.Size(123, 22);
            this.H_CAT_NAME_TEXTBOX.TabIndex = 8;
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(154, 113);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(123, 25);
            this.Button6.TabIndex = 7;
            this.Button6.Text = "New Category";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // H_CAT_COMBO
            // 
            this.H_CAT_COMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.H_CAT_COMBO.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H_CAT_COMBO.FormattingEnabled = true;
            this.H_CAT_COMBO.Location = new System.Drawing.Point(21, 25);
            this.H_CAT_COMBO.Name = "H_CAT_COMBO";
            this.H_CAT_COMBO.Size = new System.Drawing.Size(256, 48);
            this.H_CAT_COMBO.TabIndex = 1;
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(21, 84);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(127, 58);
            this.Button5.TabIndex = 0;
            this.Button5.Text = "Move To Selected";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(141, 13);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 36);
            this.Button2.TabIndex = 9;
            this.Button2.Text = "Refresh File List";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 13);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(123, 36);
            this.Button1.TabIndex = 8;
            this.Button1.Text = "Refresh Categories";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // H_FT_INPUT
            // 
            this.H_FT_INPUT.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Picture_Sorter.Properties.Settings.Default, "ft", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.H_FT_INPUT.Location = new System.Drawing.Point(565, 14);
            this.H_FT_INPUT.Name = "H_FT_INPUT";
            this.H_FT_INPUT.Size = new System.Drawing.Size(142, 22);
            this.H_FT_INPUT.TabIndex = 3;
            this.H_FT_INPUT.Text = global::Picture_Sorter.Properties.Settings.Default.ft;
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Checked = global::Picture_Sorter.Properties.Settings.Default.sendTobin;
            this.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Picture_Sorter.Properties.Settings.Default, "sendTobin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CheckBox3.Location = new System.Drawing.Point(692, 148);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(128, 18);
            this.CheckBox3.TabIndex = 16;
            this.CheckBox3.Text = "Send to recycle bin";
            this.CheckBox3.UseVisualStyleBackColor = true;
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Checked = global::Picture_Sorter.Properties.Settings.Default.backupBeforeConvert;
            this.CheckBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Picture_Sorter.Properties.Settings.Default, "backupBeforeConvert", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CheckBox2.Location = new System.Drawing.Point(756, 77);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(162, 18);
            this.CheckBox2.TabIndex = 15;
            this.CheckBox2.Text = "Backup before converting";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox2.Click += new System.EventHandler(this.CheckBox2_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(21, 146);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(155, 23);
            this.button15.TabIndex = 17;
            this.button15.Text = "Sort images by color...";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 831);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.H_FILE_LIST);
            this.Controls.Add(this.Button11);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.H_FILE_CONUT);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Sorter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.H_IMAGE)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox CheckBox3;
        internal System.Windows.Forms.PictureBox H_IMAGE;
        internal System.Windows.Forms.Button Button9;
        internal System.Windows.Forms.CheckBox CheckBox2;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox H_FT_INPUT;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label H_FILE_NAME_LABEL;
        internal System.Windows.Forms.Button Button14;
        internal System.Windows.Forms.ListBox H_FILE_LIST;
        internal System.Windows.Forms.Button Button12;
        internal System.Windows.Forms.Button Button11;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Label H_FILE_CONUT;
        internal System.Windows.Forms.Button Button13;
        internal System.Windows.Forms.Button Button10;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.Button Button8;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox H_CAT_NAME_TEXTBOX;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.ComboBox H_CAT_COMBO;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.Button button15;
    }
}

