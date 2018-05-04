Imports System.Windows.Forms
Imports System.Drawing.Text

Public Class FindDoc
    Dim font1 As PrivateFontCollection = New PrivateFontCollection
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim searchstring As String = TextBox1.Text
        Form1.ListView1.SelectedIndices.Clear()
        For Each lvi As ListViewItem In Form1.ListView1.Items
            For Each lvisub As ListViewItem.ListViewSubItem In lvi.SubItems
                If lvisub.Text = searchstring Then
                    Form1.ListView1.SelectedIndices.Add(lvi.Index)
                    Exit For
                Else
                    Exit For
                    Dim result As Integer = MessageBox.Show(TextBox1.Text & ": File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    If result = DialogResult.OK Then
                        Exit For
                    End If
                End If
            Next
        Next
        Form1.ListView1.Focus()
        Form1.Show()
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
End Class
