Imports System.Windows.Forms
Imports System.Drawing.Text

Public Class Dialog2
    Dim font1 As PrivateFontCollection = New PrivateFontCollection
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim a As String
        Dim b As String
        a = TextBox1.Text
        b = InStr(Editor.RichTextBox1.Text, a)
        If b Then
            Editor.RichTextBox1.Focus()
            Editor.RichTextBox1.SelectionStart = b - 1
            Editor.RichTextBox1.SelectionLength = Len(a)
        Else
            MsgBox("No text founded.", vbExclamation, "Sorry!")
        End If
        Editor.Show()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        font1.AddFontFile("data/Karla.ttf")
        Me.Font = New Font(font1.Families(0), 8)
    End Sub

    Private Sub Dialog1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK_Button.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Clipboard1 As New TextBox
        Clipboard1.Clear()
        Clipboard1.Paste()
        Dim a As String
        Dim b As String
        a = TextBox2.Text
        b = InStr(Editor.RichTextBox1.Text, a)
        If b Then
            Editor.RichTextBox1.Focus()
            Editor.RichTextBox1.SelectionStart = b - 1
            Editor.RichTextBox1.SelectionLength = Len(a)
            TextBox3.SelectAll()
            TextBox3.Copy()
            Editor.RichTextBox1.Paste()
            Clipboard1.SelectAll()
            Clipboard1.Copy()
            Clipboard1.SelectAll()
            Clipboard1.Copy()
        Else
            MsgBox("No text founded!", vbExclamation, "Sorry!")
        End If
        Editor.Show()
    End Sub
End Class
