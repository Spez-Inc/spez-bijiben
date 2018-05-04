Imports System.Windows.Forms
Imports System.Drawing.Text

Public Class bgthm

    Dim font1 As PrivateFontCollection = New PrivateFontCollection

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If ListView1.SelectedItems.Count = 0 Then
            If My.Settings.Language = "Türkçe" Then
                MsgBox("Tema Seçin.", MsgBoxStyle.Exclamation, "Tema Uygulama Hatası:")
            ElseIf My.Settings.Language = "English" Then
                MsgBox("Select a theme.", MsgBoxStyle.Exclamation, "Error Applying Theme:")
            End If
        Else
            If ListView1.SelectedItems(0).Text = "None" Or ListView1.SelectedItems(0).Text = "Yok" Then
                Dim i As New TextBox
                i.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\themes\" & "Blue Board" & "\bgl.txt")
                Int32.TryParse(i.Text, Editor.BackgroundImageLayout)
                Editor.BackgroundImage = Nothing
                ListView1.Items.Clear()
                Me.Close()
            ElseIf ListView1.SelectedItems(0).Text = "Custom Image..." Or ListView1.SelectedItems(0).Text = "Özel Resim..." Then
                Try
                    Dim dlg As OpenFileDialog = New OpenFileDialog
                    dlg.Title = "Open Image"
                    dlg.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
                    dlg.Filter = "PNG|*.png|JPG|*.jpg|BMP|*.bmp|All Files|*"
                    If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        Editor.BackgroundImage = Image.FromFile(dlg.FileName)
                        Editor.BackgroundImageLayout = ImageLayout.Stretch
                    End If
                Catch ex As Exception
                End Try
                ListView1.Items.Clear()
                Me.Close()
            Else
                Dim i As New TextBox
                i.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\themes\" & ListView1.SelectedItems(0).Text & "\bgl.txt")
                Threading.Thread.Sleep(1000)
                Editor.BackgroundImage = Image.FromFile(Application.StartupPath & "\themes\" & ListView1.SelectedItems(0).Text & "\bg.png")
                Int32.TryParse(i.Text, Editor.BackgroundImageLayout)
                ListView1.Items.Clear()
                Editor.savedf()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub bgthm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        font1.AddFontFile("data/Karla.ttf")
        Me.Font = New Font(font1.Families(0), 8)
        '------------
        Dim itema As New ListViewItem
        If My.Settings.Language = "English" Then
            itema.Text = "None"
        ElseIf My.Settings.Language = "Türkçe" Then
            itema.Text = "Yok"
        End If
        ımageList1.Images.Add("NoneImg", My.Resources.dialog_no)
        itema.ImageKey = "NoneImg"
        ListView1.Items.Add(itema)
        '------------
        For Each fileName As String In System.IO.Directory.GetFiles(Application.StartupPath & "\themes")
            Dim item As New ListViewItem
            item.Text = System.IO.Path.GetFileNameWithoutExtension(fileName)
            ımageList1.Images.Add(System.IO.Path.GetFileName(fileName), Image.FromFile(Application.StartupPath & "\themes\" & System.IO.Path.GetFileName(fileName)))
            item.ImageKey = System.IO.Path.GetFileName(fileName)
            ListView1.Items.Add(item)
        Next
        '------------
        Dim itemb As New ListViewItem
        If My.Settings.Language = "English" Then
            itemb.Text = "Custom Image..."
        ElseIf My.Settings.Language = "Türkçe" Then
            itemb.Text = "Özel Resim..."
        End If
        ımageList1.Images.Add("Custom", My.Resources.pinta)
        itemb.ImageKey = "Custom"
        ListView1.Items.Add(itemb)
    End Sub
End Class
