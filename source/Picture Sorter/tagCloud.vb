Public Class tagCloud

    Dim cc As New Counter


    Sub RefreshToolBox()
        ToolStrip1.Items.Clear()
        For Each x As tag In cc.GetTags
            Dim i As New ToolStripButton
            i.Text = x.Text
            i.Font = New Font(FontFamily.GenericMonospace, e(x.Count), FontStyle.Regular, GraphicsUnit.Pixel)
            ToolStrip1.Items.Add(i)
        Next
    End Sub

    Function e(ByVal s As Integer) As Integer
        If s < 15 Then
            Return 15
        Else
            Return s
        End If

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not TextBox1.Text = "" Then
            cc.PlusOne(TextBox1.Text)
            TextBox1.Text = ""
            RefreshToolBox()
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        cc.PlusOne(e.ClickedItem.Text)
        Form1.TagClicked(e.ClickedItem.Text)
        RefreshToolBox()
    End Sub
End Class

Class Counter

    Private _dic As New Dictionary(Of String, Integer)

    Sub New()

    End Sub


    Public Sub PlusOne(ByVal value As String)
        If _dic.ContainsKey(value) Then
            _dic.Item(value) = _dic.Item(value) + 1
        Else
            _dic.Add(value, 1)
        End If
    End Sub

    Public Function GetTagCount() As Integer
        Return _dic.Keys.Count
    End Function

    Public Function GetTagRank(ByVal tag As String) As Integer
        If _dic.ContainsKey(tag) Then
            Return _dic.Item(tag)
        Else
            Return 0
        End If
    End Function

    Public Function GetTags() As tag()
        Dim il As New List(Of tag)
        For i As Integer = 0 To _dic.Keys.Count - 1 Step 1
            Dim a As String = _dic.Keys.ElementAt(i)
            Dim b As Integer = _dic.Item(a)

            il.Add(New tag(a, b))

        Next
        Return il.ToArray
    End Function

End Class

Class tag
    Public Text As String
    Public Count As Integer
    Sub New(ByVal t As String, ByVal c As Integer)
        Text = t
        Count = c
    End Sub
End Class