<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Button8 = New System.Windows.Forms.Button
        Me.H_CAT_NAME_TEXTBOX = New System.Windows.Forms.TextBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.H_CAT_COMBO = New System.Windows.Forms.ComboBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.H_IMAGE = New System.Windows.Forms.PictureBox
        Me.H_FILE_NAME_LABEL = New System.Windows.Forms.Label
        Me.H_FILE_LIST = New System.Windows.Forms.ListBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button9 = New System.Windows.Forms.Button
        Me.H_FT_INPUT = New System.Windows.Forms.TextBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.H_FILE_CONUT = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Button11 = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.H_IMAGE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Refresh Categories"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(142, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 34)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Refresh File List"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(791, 94)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "<< Previous"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(856, 94)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Next >>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.Button14)
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.Button13)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.H_CAT_NAME_TEXTBOX)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.H_CAT_COMBO)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 588)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(924, 163)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actions"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = Global.Picture_Sorter.My.MySettings.Default.bbc
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Picture_Sorter.My.MySettings.Default, "bbc", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.Location = New System.Drawing.Point(762, 72)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(159, 17)
        Me.CheckBox2.TabIndex = 15
        Me.CheckBox2.Text = "Backup before converting"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(762, 42)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(75, 23)
        Me.Button14.TabIndex = 14
        Me.Button14.Text = "To JPG"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(756, 13)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(48, 23)
        Me.Button12.TabIndex = 13
        Me.Button12.Text = "Undo"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(843, 42)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 23)
        Me.Button13.TabIndex = 14
        Me.Button13.Text = "To PNG"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(810, 13)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(108, 23)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "Open Image"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Location = New System.Drawing.Point(311, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 110)
        Me.Panel1.TabIndex = 11
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(402, 110)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(821, 134)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(97, 23)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Delete this file"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'H_CAT_NAME_TEXTBOX
        '
        Me.H_CAT_NAME_TEXTBOX.Location = New System.Drawing.Point(154, 77)
        Me.H_CAT_NAME_TEXTBOX.Name = "H_CAT_NAME_TEXTBOX"
        Me.H_CAT_NAME_TEXTBOX.Size = New System.Drawing.Size(123, 22)
        Me.H_CAT_NAME_TEXTBOX.TabIndex = 8
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(154, 105)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(123, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "New Category"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'H_CAT_COMBO
        '
        Me.H_CAT_COMBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.H_CAT_COMBO.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H_CAT_COMBO.FormattingEnabled = True
        Me.H_CAT_COMBO.Location = New System.Drawing.Point(21, 23)
        Me.H_CAT_COMBO.Name = "H_CAT_COMBO"
        Me.H_CAT_COMBO.Size = New System.Drawing.Size(256, 48)
        Me.H_CAT_COMBO.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(21, 78)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 54)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Move To Selected"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Controls.Add(Me.H_IMAGE)
        Me.GroupBox2.Controls.Add(Me.H_FILE_NAME_LABEL)
        Me.GroupBox2.Location = New System.Drawing.Point(203, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(734, 540)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "File"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(620, 518)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 10)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Visible = False
        '
        'H_IMAGE
        '
        Me.H_IMAGE.Location = New System.Drawing.Point(16, 20)
        Me.H_IMAGE.Name = "H_IMAGE"
        Me.H_IMAGE.Size = New System.Drawing.Size(712, 492)
        Me.H_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.H_IMAGE.TabIndex = 1
        Me.H_IMAGE.TabStop = False
        Me.H_IMAGE.WaitOnLoad = True
        '
        'H_FILE_NAME_LABEL
        '
        Me.H_FILE_NAME_LABEL.AutoSize = True
        Me.H_FILE_NAME_LABEL.Location = New System.Drawing.Point(6, 515)
        Me.H_FILE_NAME_LABEL.Name = "H_FILE_NAME_LABEL"
        Me.H_FILE_NAME_LABEL.Size = New System.Drawing.Size(40, 13)
        Me.H_FILE_NAME_LABEL.TabIndex = 0
        Me.H_FILE_NAME_LABEL.Text = "Label1"
        '
        'H_FILE_LIST
        '
        Me.H_FILE_LIST.FormattingEnabled = True
        Me.H_FILE_LIST.Location = New System.Drawing.Point(12, 68)
        Me.H_FILE_LIST.Name = "H_FILE_LIST"
        Me.H_FILE_LIST.Size = New System.Drawing.Size(185, 498)
        Me.H_FILE_LIST.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.H_FT_INPUT)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(224, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(713, 41)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Base path"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(481, 11)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(42, 23)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "Filter"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'H_FT_INPUT
        '
        Me.H_FT_INPUT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Picture_Sorter.My.MySettings.Default, "FT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.H_FT_INPUT.Location = New System.Drawing.Point(529, 13)
        Me.H_FT_INPUT.Name = "H_FT_INPUT"
        Me.H_FT_INPUT.Size = New System.Drawing.Size(142, 22)
        Me.H_FT_INPUT.TabIndex = 3
        Me.H_FT_INPUT.Text = Global.Picture_Sorter.My.MySettings.Default.FT
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(432, 13)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(25, 23)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "...."
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(420, 22)
        Me.TextBox1.TabIndex = 0
        '
        'H_FILE_CONUT
        '
        Me.H_FILE_CONUT.AutoSize = True
        Me.H_FILE_CONUT.Location = New System.Drawing.Point(10, 568)
        Me.H_FILE_CONUT.Name = "H_FILE_CONUT"
        Me.H_FILE_CONUT.Size = New System.Drawing.Size(40, 13)
        Me.H_FILE_CONUT.TabIndex = 2
        Me.H_FILE_CONUT.Text = "Label1"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 42)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(126, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Enable Image Move"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(167, 42)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(22, 23)
        Me.Button11.TabIndex = 5
        Me.Button11.Text = "."
        Me.Button11.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = Global.Picture_Sorter.My.MySettings.Default.strb
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Picture_Sorter.My.MySettings.Default, "strb", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox3.Location = New System.Drawing.Point(692, 138)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(123, 17)
        Me.CheckBox3.TabIndex = 16
        Me.CheckBox3.Text = "Send to recycle bin"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 763)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.H_FILE_CONUT)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.H_FILE_LIST)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Picture Sorter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.H_IMAGE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents H_FILE_LIST As System.Windows.Forms.ListBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents H_IMAGE As System.Windows.Forms.PictureBox
    Friend WithEvents H_FILE_NAME_LABEL As System.Windows.Forms.Label
    Friend WithEvents H_CAT_COMBO As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents H_CAT_NAME_TEXTBOX As System.Windows.Forms.TextBox
    Friend WithEvents H_FILE_CONUT As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents H_FT_INPUT As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox

End Class
