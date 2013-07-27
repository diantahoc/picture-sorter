Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Public Class Form1

    Dim Categories As New List(Of String)
    Dim FTypes As New List(Of String)
    Dim BasePath As String = "not set"
    Dim CurrentINDEXPOSITION As Integer = 0
    Dim memStream As IO.MemoryStream

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
        LoadFilesIntoFinder()
        H_FILE_LIST.SelectedIndex = CurrentINDEXPOSITION
    End Sub

    Sub DeleteFile(ByVal filepath As String)
        FileIO.FileSystem.DeleteFile(filepath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin)
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
End Class
