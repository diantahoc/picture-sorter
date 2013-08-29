Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Public Class Form1

    Dim Categories As New List(Of String)
    Dim FTypes As New List(Of String)
    Dim BasePath As String = "not set"
    Dim CurrentINDEXPOSITION As Integer = 0
    Dim memStream As IO.MemoryStream

    Dim lastAction As String = ""

    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Sub LoadCategories()
        Categories.Clear()
        ToolStrip1.Items.Clear()
        For Each x As DirectoryInfo In FileSystem.GetDirectoryInfo(BasePath).GetDirectories
            'NAME;FULL_PATH
            Categories.Add(x.Name & ";" & x.FullName)
            ToolStrip1.Items.Add(new_ite(x.Name, x.FullName))
            'ToolStripLabel1
        Next
        AppendCategoiesIntoComboBox()
    End Sub

    Function new_ite(ByVal name As String, ByVal fullname As String) As ToolStripButton
        Dim d As New ToolStripButton(name)
        d.Tag = fullname
        Return d
    End Function

    Sub AppendCategoiesIntoComboBox()
        H_CAT_COMBO.Items.Clear()
        For Each x In Categories
            H_CAT_COMBO.Items.Add(CStr(x.Split(CChar(";")).ElementAt(0)))
        Next
    End Sub

    Function GetCategorieFullpath(ByVal CatName As String) As String
        Return BasePath & "\" & CatName
    End Function

    Sub LoadFilesIntoFinder()
        H_FILE_LIST.Items.Clear()
        EncodeFT(H_FT_INPUT.Text)
        Try
            For Each o As String In FTypes
                For Each x As FileInfo In FileSystem.GetDirectoryInfo(BasePath).GetFiles("*" & o)
                    H_FILE_LIST.Items.Add(x.FullName)
                Next
            Next
            H_FILE_CONUT.Text = H_FILE_LIST.Items.Count & " file(s)"
        Catch ex As Exception
            MsgBox("Could not load files:" & vbNewLine & vbNewLine & ex.Message)
        End Try
    End Sub

    Sub EncodeFT(ByVal t As String)
        FTypes.Clear()
        For Each x In t.Split(CChar(","))
            FTypes.Add(x)
        Next
    End Sub

    Sub LoadImageWithoutLock(ByVal Path As String)
        Dim barr As Byte() = File.ReadAllBytes(Path)
        H_IMAGE.Image = Nothing
        If Not (memStream Is Nothing) Then memStream.Dispose()
        memStream = New MemoryStream
        memStream.Write(barr, 0, barr.Count)
        Try
            Dim i As Image = Image.FromStream(memStream)
            H_IMAGE.Image = i
        Catch ex As Exception
            H_IMAGE.Image = H_IMAGE.ErrorImage
        End Try
    End Sub

    Sub NextFile()
        CurrentINDEXPOSITION += 1
        Try
            H_FILE_LIST.SelectedIndex = CurrentINDEXPOSITION
            LoadImageWithoutLock(H_FILE_LIST.Items.Item(H_FILE_LIST.SelectedIndex))
        Catch ex As Exception
            CurrentINDEXPOSITION = H_FILE_LIST.Items.Count - 1
            MsgBox("No next file")
        End Try
    End Sub

    Sub PrevFile()
        CurrentINDEXPOSITION -= 1
        Try
            H_FILE_LIST.SelectedIndex = CurrentINDEXPOSITION
            LoadImageWithoutLock(H_FILE_LIST.Items.Item(H_FILE_LIST.SelectedIndex))
        Catch ex As Exception
            CurrentINDEXPOSITION = 0
            MsgBox("No previous file")
        End Try
    End Sub

    Sub MoveFile(ByVal filepath As String, ByVal catPath As String)
        FileSystem.MoveFile(filepath, catPath & "\" & FileSystem.GetFileInfo(filepath).Name, False)
        lastAction = "FILEMOVE?" & filepath & "?" & catPath & "\" & FileSystem.GetFileInfo(filepath).Name
        LoadFilesIntoFinder()
        Try
            H_FILE_LIST.SelectedIndex = CurrentINDEXPOSITION
        Catch ex As Exception
            H_IMAGE.Image = Nothing
        End Try
    End Sub

    Sub DeleteFile(ByVal filepath As String)
        Dim opt As FileIO.RecycleOption
        If CheckBox3.Checked Then
            opt = RecycleOption.SendToRecycleBin
        Else
            opt = RecycleOption.DeletePermanently
        End If
        FileIO.FileSystem.DeleteFile(filepath, UIOption.OnlyErrorDialogs, opt)
        LoadFilesIntoFinder()
        H_FILE_LIST.SelectedIndex = CurrentINDEXPOSITION
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoadCategories()
    End Sub

    Private Sub H_FILE_LIST_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H_FILE_LIST.SelectedIndexChanged
        LoadImageWithoutLock(H_FILE_LIST.Items.Item(H_FILE_LIST.SelectedIndex))
        H_FILE_NAME_LABEL.Text = H_FILE_LIST.Items.Item(H_FILE_LIST.SelectedIndex)
        CurrentINDEXPOSITION = H_FILE_LIST.SelectedIndex
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LoadFilesIntoFinder()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If H_CAT_COMBO.SelectedIndex = -1 Then Return
        MoveFile(H_FILE_LIST.Items.Item(H_FILE_LIST.SelectedIndex), GetCategorieFullpath(H_CAT_COMBO.Items.Item(H_CAT_COMBO.SelectedIndex)))
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PrevFile()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        NextFile()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BasePath = My.Settings.bs
        If BasePath = "not set" Then
            MsgBox("Select a folder to begin sorting")
            choose_new_basepath()
        Else
            SetBasePath(BasePath)
        End If
        ToolTip1.SetToolTip(CheckBox1, "Enable image moving by clicking on the image to the selected category")
    End Sub

    Sub SetBasePath(ByVal path As String)
        My.Settings.bs = path
        My.Settings.Save()
        TextBox1.Text = path
        BasePath = path
        CheckDirs()
        LoadCategories()
        LoadFilesIntoFinder()
        CurrentINDEXPOSITION = 0
        If H_FILE_LIST.Items.Count > 0 Then H_FILE_LIST.SelectedIndex = CurrentINDEXPOSITION
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        choose_new_basepath()
    End Sub

    Sub choose_new_basepath()
        Dim i As New FolderBrowserDialog
        Try
            i.SelectedPath = TextBox1.Text
        Catch ex As Exception
        End Try
        If i.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = i.SelectedPath
            SetBasePath(TextBox1.Text)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        FileSystem.CreateDirectory(BasePath & "\" & H_CAT_NAME_TEXTBOX.Text)
        H_CAT_NAME_TEXTBOX.Text = ""
        LoadCategories()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        DeleteFile(H_FILE_LIST.Items.Item(H_FILE_LIST.SelectedIndex))
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        MoveFile(H_FILE_LIST.Items.Item(H_FILE_LIST.SelectedIndex), GetCategorieFullpath(e.ClickedItem.Text))
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        My.Settings.FT = H_FT_INPUT.Text
        My.Settings.Save()
        LoadFilesIntoFinder()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Process.Start(H_FILE_LIST.Items.Item(H_FILE_LIST.SelectedIndex))
    End Sub

    Private Sub Form1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        Try
            CurrentINDEXPOSITION += (e.Delta / 120)
            H_FILE_LIST.SelectedIndex = CurrentINDEXPOSITION
            LoadImageWithoutLock(H_FILE_LIST.Items.Item(H_FILE_LIST.SelectedIndex))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub H_IMAGE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H_IMAGE.Click
        If CheckBox1.Checked Then MoveFile(H_FILE_LIST.Items.Item(H_FILE_LIST.SelectedIndex), GetCategorieFullpath(H_CAT_COMBO.Items.Item(H_CAT_COMBO.SelectedIndex)))
    End Sub

    Private Sub H_IMAGE_LoadProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles H_IMAGE.LoadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub H_IMAGE_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H_IMAGE.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub H_IMAGE_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles H_IMAGE.MouseLeave
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Focus()
    End Sub

    Public Sub TagClicked(ByVal tag As String)

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim data As String() = lastAction.Split(CChar("?"))
        Select Case data(0)
            Case "FILEMOVE"
                File.Move(data(2), data(1))
                LoadFilesIntoFinder()
                lastAction = ""
            Case Else
                lastAction = ""
        End Select
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        Button12.Enabled = Not (lastAction = "")
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        'Dim w As Image = Image.FromStream(memStream)
        'Dim p As IO.FileInfo = FileSystem.GetFileInfo(H_FILE_LIST.Items.Item(H_FILE_LIST.SelectedIndex))
        'Dim newp As String = p.FullName.Replace(p.Extension, ".jpg")
        'w.Save(newp, Imaging.ImageFormat.Jpeg)
        'LoadImageWithoutLock(newp)
        'FileSystem.DeleteFile(p.FullName, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin)
        'w.Dispose()
        'LoadFilesIntoFinder()
        ConvertImage(Drawing.Imaging.ImageFormat.Jpeg, "jpg")
        LoadFilesIntoFinder()
        LoadImageWithoutLock(GetFilePathByIndex(CurrentINDEXPOSITION))
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        ConvertImage(Drawing.Imaging.ImageFormat.Png, "png")
        LoadFilesIntoFinder()
        LoadImageWithoutLock(GetFilePathByIndex(CurrentINDEXPOSITION))
    End Sub

    Private Sub ConvertImage(ByVal t As Drawing.Imaging.ImageFormat, ByVal ext As String)
        'Get file info

        Dim fIndo As IO.FileInfo = FileIO.FileSystem.GetFileInfo(GetSelectFilePath)
        If fIndo.Extension = "." & ext Then
            MsgBox("The file is already " & ext)
            Return
        End If



        'Backup check
        If CheckBox2.Checked Then
            'Rename the old file
            FileSystem.RenameFile(fIndo.FullName, fIndo.Name.Split(CChar("."))(0) & ".bak")
        End If

        'Open a new file stream using the old file path
        Dim fs As New IO.FileStream(fIndo.FullName, FileMode.OpenOrCreate)

        'Make a temporary image
        Dim w As Image = Image.FromStream(memStream)
        Dim tempImage As Image = w.Clone
        'Release the old file
        w.Dispose()


        'Save the tempImage in required format

        tempImage.Save(fs, t)
        tempImage.Dispose()

        'Close the file
        fs.Close()


        'Finally correct the new file extension

        FileSystem.RenameFile(fIndo.FullName, fIndo.Name.Split(CChar("."))(0) & "." & ext)
    End Sub

    Private Function GetSelectFilePath() As String
        Return CStr(H_FILE_LIST.Items.Item(H_FILE_LIST.SelectedIndex))
    End Function

    Private Function GetFilePathByIndex(ByRef index As Int32) As String
        Return CStr(H_FILE_LIST.Items.Item(index))
    End Function

    Private Sub CheckDirs()
        If Not FileIO.FileSystem.DirectoryExists(BasePath) Then
            FileIO.FileSystem.CreateDirectory(BasePath)
        End If
    End Sub

    Private Sub CheckBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        If CheckBox2.Checked Then
            MsgBox("A .bak file will be made")
        End If
    End Sub
End Class
