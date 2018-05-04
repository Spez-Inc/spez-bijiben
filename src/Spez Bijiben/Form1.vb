Imports System.Drawing.Text
Imports System.IO

Public Class Form1

    Dim font1 As PrivateFontCollection = New PrivateFontCollection
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Panel3_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles UpR.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + (Me.Location.Y - MousePosition.Y))
            Me.Location = New Point(Me.Location.X, MousePosition.Y)
        End If
    End Sub

    Private Sub Panel5_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DownR.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width, MousePosition.Y - Me.Location.Y)
        End If
    End Sub

    Private Sub Panel2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LeftR.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width + (Me.Location.X - MousePosition.X), Me.Size.Height)
            Me.Location = New Point(MousePosition.X, Me.Location.Y)
        End If
    End Sub

    Private Sub Panel4_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RightR.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(MousePosition.X - Me.Location.X, Me.Size.Height)
        End If
    End Sub

    Private Sub Close_Button_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close_Button.MouseHover
        Close_Button.BackgroundImage = My.Resources.close_hover
    End Sub

    Private Sub Close_Button_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Close_Button.MouseLeave
        Close_Button.BackgroundImage = My.Resources.close
    End Sub

    Private Sub Minimize_Button_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Minimaze_Button.MouseHover
        Minimaze_Button.BackgroundImage = My.Resources.minimize_hover
    End Sub

    Private Sub Minimize_Button_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Minimaze_Button.MouseLeave
        Minimaze_Button.BackgroundImage = My.Resources.minimize
    End Sub

    Private Sub Maximize_Button_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Maximaze_Button.MouseHover
        Maximaze_Button.BackgroundImage = My.Resources.fullscreen_hover
    End Sub

    Private Sub Maximize_Button_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Maximaze_Button.MouseLeave
        Maximaze_Button.BackgroundImage = My.Resources.fullscreen
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Close_Button.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Minimaze_Button.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Maximaze_Button.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Computer.Info.OSFullName.Contains("Windows XP") Then
            MsgBox("Spez Bijiben no more supports Windows XP and Vista.", vbCritical, "Sorry for that.")
            End
        End If
        If My.Computer.Info.OSFullName.Contains("Windows Vista") Then
            MsgBox("Spez Bijiben no more supports Windows XP and Vista.", vbCritical, "Sorry for that.")
            End
        End If
        '-----------------------------------------------------------
        If My.Settings.WelcomeScreen = True Then
            Me.Hide()
            WelcomeScreen.ShowDialog()
            WelcomeScreen.Location = Me.Location
            WelcomeScreen.WindowState = Me.WindowState
            WelcomeScreen.Size = Me.Size
        End If
        '-----------------------------------------------------------
        font1.AddFontFile("data/Karla.ttf")
        Label1.Font = New Font(font1.Families(0), 13, FontStyle.Bold)
        Button1.Font = New Font(font1.Families(0), 10)
        Me.Font = New Font(font1.Families(0), 8)
        '-----------------------------------------------------------
        If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Spez Bijiben Documents") Then
        Else
            IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Spez Bijiben Documents")
        End If
        '-----------------------------------------------------------
        If My.Settings.Language = "English" Then
            Dialog3.Text = "Settings"
            bgthm.Text = "Background Themes (Not Saved)"
            Dialog3.GroupBox1.Text = "Language"
            Dialog3.OK_Button.Text = "Apply"
            Dialog3.Cancel_Button.Text = "Cancel"
            bgthm.OK_Button.Text = "Apply"
            bgthm.Cancel_Button.Text = "Cancel"
            Editor.CutToolStripMenuItem.Text = "Cut"
            Editor.CopyToolStripMenuItem.Text = "Copy"
            Editor.PasteToolStripMenuItem.Text = "Paste"
            Editor.SelectAllToolStripMenuItem.Text = "Select All"
            FindDoc.Text = "Find Document"
            FindDoc.Label1.Text = "Find What:"
            FindDoc.OK_Button.Text = "Find Document"
            Dialog2.Text = "Find & Replace Text"
            Dialog2.Label1.Text = "Find What:"
            Dialog2.OK_Button.Text = "Find Text"
            Dialog2.Label2.Text = "Find What:"
            Dialog2.Label3.Text = "Replace With:"
            Dialog2.OK_Button.Text = "Replace Text"
            Editor.AddToolStripMenuItem.Text = "Add"
            Editor.ShapeToolStripMenuItem.Text = "Shape"
            Editor.ImageToolStripMenuItem.Text = "Image"
            Editor.SquareToolStripMenuItem.Text = "Square"
            Editor.OvalRoundToolStripMenuItem.Text = "Oval / Round"
            Editor.TriangleToolStripMenuItem.Text = "Triangle"
            Editor.RedToolStripMenuItem.Text = "Red"
            Editor.RedToolStripMenuItem1.Text = "Red"
            Editor.RedToolStripMenuItem2.Text = "Red"
            Editor.BlueToolStripMenuItem.Text = "Blue"
            Editor.BlueToolStripMenuItem1.Text = "Blue"
            Editor.BlueToolStripMenuItem2.Text = "Blue"
            Editor.GreenToolStripMenuItem.Text = "Green"
            Editor.GreenToolStripMenuItem1.Text = "Green"
            Editor.GreenToolStripMenuItem2.Text = "Green"
            Editor.FindToolStripMenuItem.Text = "Find"
            Editor.ReplaceToolStripMenuItem.Text = "Replace"
            Editor.BackgroundThemesToolStripMenuItem.Text = "Background Themes"
            Editor.TextHighlightColorToolStripMenuItem.Text = "Text Highlight Color"
            Editor.TextColorToolStripMenuItem.Text = "Text Color"
            Editor.UndoToolStripMenuItem.Text = "Undo"
            Editor.UndoToolStripMenuItem.Text = "Redo"
            Editor.SettingsToolStripMenuItem.Text = "Settings"
            Editor.AboutSpezBijibenToolStripMenuItem.Text = "About Spez Bijiben"
            Editor.ExitToolStripMenuItem.Text = "Exit"
            Button1.Text = "New"
            Label1.Text = "New and Recent"
            OpenDocumentToolStripMenuItem.Text = "Open Document"
            RenameDocumentToolStripMenuItem.Text = "Rename Document"
            DeleteDocumentToolStripMenuItem.Text = "Delete Document"
            DetailsToolStripMenuItem.Text = "Details"
            ViewToolStripMenuItem.Text = "View"
            LargeIconToolStripMenuItem.Text = "Large Icon"
            SmallIconToolStripMenuItem.Text = "Small Icon"
            DetailsToolStripMenuItem.Text = "Details"
            ListToolStripMenuItem.Text = "List"
            TileToolStripMenuItem.Text = "Tile"
            SearchDocumentToolStripMenuItem.Text = "Find Document"
            RefreshToolStripMenuItem.Text = "Refresh"
            SettingsToolStripMenuItem.Text = "Settings"
            AboutSpezBijibenToolStripMenuItem.Text = "About Spez Bijiben"
            ExitToolStripMenuItem.Text = "Exit"
        ElseIf My.Settings.Language = "Türkçe" Then
            Dialog3.Text = "Ayarlar"
            bgthm.Text = "Arkaplan Temaları (Kaydedilmez)"
            Dialog3.GroupBox1.Text = "Dil"
            Dialog3.OK_Button.Text = "Uygula"
            Dialog3.Cancel_Button.Text = "Vazgeç"
            bgthm.OK_Button.Text = "Uygula"
            bgthm.Cancel_Button.Text = "Vazgeç"
            Editor.CutToolStripMenuItem.Text = "Kes"
            Editor.CopyToolStripMenuItem.Text = "Kopyala"
            Editor.PasteToolStripMenuItem.Text = "Yapıştır"
            Editor.SelectAllToolStripMenuItem.Text = "Tümünü Seç"
            FindDoc.Text = "Belge Bul"
            FindDoc.Label1.Text = "Bulunacak:"
            FindDoc.OK_Button.Text = "Belgeyi Bul"
            Dialog2.Text = "Yazıyı Bul / Değiştir"
            Dialog2.Label1.Text = "Bulunacak:"
            Dialog2.OK_Button.Text = "Yazıyı Bul"
            Dialog2.Label2.Text = "Bulunacak:"
            Dialog2.Label3.Text = "Değiştir:"
            Dialog2.OK_Button.Text = "Yazıyı Değiştir"
            Editor.AddToolStripMenuItem.Text = "Ekle"
            Editor.ShapeToolStripMenuItem.Text = "Şekil"
            Editor.ImageToolStripMenuItem.Text = "Resim"
            Editor.SquareToolStripMenuItem.Text = "Kare"
            Editor.OvalRoundToolStripMenuItem.Text = "Oval / Daire"
            Editor.TriangleToolStripMenuItem.Text = "Üçgen"
            Editor.RedToolStripMenuItem.Text = "Kırmızı"
            Editor.RedToolStripMenuItem1.Text = "Kırmızı"
            Editor.RedToolStripMenuItem2.Text = "Kırmızı"
            Editor.BlueToolStripMenuItem.Text = "Mavi"
            Editor.BlueToolStripMenuItem1.Text = "Mavi"
            Editor.BlueToolStripMenuItem2.Text = "Mavi"
            Editor.GreenToolStripMenuItem.Text = "Yeşil"
            Editor.GreenToolStripMenuItem1.Text = "Yeşil"
            Editor.GreenToolStripMenuItem2.Text = "Yeşil"
            Editor.FindToolStripMenuItem.Text = "Bul"
            Editor.ReplaceToolStripMenuItem.Text = "Değiştir"
            Editor.BackgroundThemesToolStripMenuItem.Text = "Arkaplan Temaları"
            Editor.TextHighlightColorToolStripMenuItem.Text = "Yazı Vurgu Rengi"
            Editor.TextColorToolStripMenuItem.Text = "Yazı Rengi"
            Editor.UndoToolStripMenuItem.Text = "Geri al"
            Editor.RedoToolStripMenuItem.Text = "Yinele"
            Editor.SettingsToolStripMenuItem.Text = "Ayarlar"
            Editor.AboutSpezBijibenToolStripMenuItem.Text = "Spez Bijiben Hakkında"
            Editor.ExitToolStripMenuItem.Text = "Çıkış"
            Button1.Text = "Yeni"
            Label1.Text = "Yeni ve Son Açılan"
            OpenDocumentToolStripMenuItem.Text = "Belgeyi Aç"
            RenameDocumentToolStripMenuItem.Text = "Belgeyi Yeniden İsimlendir"
            DeleteDocumentToolStripMenuItem.Text = "Belgeyi Sil"
            DetailsToolStripMenuItem1.Text = "Detaylar"
            ViewToolStripMenuItem.Text = "Görünüm"
            LargeIconToolStripMenuItem.Text = "Büyük Simge"
            SmallIconToolStripMenuItem.Text = "Küçük Simge"
            DetailsToolStripMenuItem.Text = "Detaylar"
            ListToolStripMenuItem.Text = "Liste"
            TileToolStripMenuItem.Text = "Tile"
            SearchDocumentToolStripMenuItem.Text = "Belge Bul"
            RefreshToolStripMenuItem.Text = "Yinele"
            SettingsToolStripMenuItem.Text = "Ayarlar"
            AboutSpezBijibenToolStripMenuItem.Text = "Spez Bijiben Hakkında"
            ExitToolStripMenuItem.Text = "Çıkış"
        End If
        '-----------------------------------------------------------
        loadfiles()
    End Sub
    Public Sub loadfiles()
        For Each fileNamebjn As String In System.IO.Directory.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Spez Bijiben Documents", "*.bjn")
            Dim item As New ListViewItem
            item.Text = System.IO.Path.GetFileNameWithoutExtension(fileNamebjn)
            item.ImageKey = "bjn.png"
            item.SubItems.Add("Type")
            item.SubItems.Add("Created")
            item.SubItems.Add("filenamewithext")
            item.SubItems.Add("ext")
            item.SubItems(1).Text = "Type: ''" & Path.GetExtension(fileNamebjn.ToString) & "''" & " (Spez Bijiben File)"
            item.SubItems(2).Text = "Created in: " & File.GetCreationTimeUtc(fileNamebjn.ToString)
            item.SubItems(3).Text = System.IO.Path.GetFileName(fileNamebjn)
            item.SubItems(4).Text = System.IO.Path.GetExtension(fileNamebjn)
            ListView1.Items.Add(item)
        Next
        '-----------------------------------------------------------
        For Each fileNamedoc As String In System.IO.Directory.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Spez Bijiben Documents", "*.doc").Where(Function(file) file.EndsWith(".doc", StringComparison.CurrentCultureIgnoreCase))
            Dim item As New ListViewItem
            item.Text = System.IO.Path.GetFileNameWithoutExtension(fileNamedoc)
            item.ImageKey = "doc.png"
            item.SubItems.Add("Type")
            item.SubItems.Add("Created")
            item.SubItems.Add("filenamewithext")
            item.SubItems.Add("ext")
            item.SubItems(1).Text = "Type: ''" & Path.GetExtension(fileNamedoc.ToString) & "''" & " (Word 97(+) File)"
            item.SubItems(2).Text = "Created in: " & File.GetCreationTimeUtc(fileNamedoc.ToString)
            item.SubItems(3).Text = System.IO.Path.GetFileName(fileNamedoc)
            item.SubItems(4).Text = System.IO.Path.GetExtension(fileNamedoc)
            ListView1.Items.Add(item)
        Next
        '-----------------------------------------------------------
        For Each fileNameten As String In System.IO.Directory.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Spez Bijiben Documents", "*.docx")
            Dim item As New ListViewItem
            item.Text = System.IO.Path.GetFileNameWithoutExtension(fileNameten)
            item.ImageKey = "docten.png"
            item.SubItems.Add("Type")
            item.SubItems.Add("Created")
            item.SubItems.Add("filenamewithext")
            item.SubItems.Add("ext")
            item.SubItems(1).Text = "Type: ''" & Path.GetExtension(fileNameten.ToString) & "''" & " (Word 2007(+) File)"
            item.SubItems(2).Text = "Created in: " & File.GetCreationTimeUtc(fileNameten.ToString)
            item.SubItems(3).Text = System.IO.Path.GetFileName(fileNameten)
            item.SubItems(4).Text = System.IO.Path.GetExtension(fileNameten)
            ListView1.Items.Add(item)
        Next
        '-----------------------------------------------------------
        For Each fileNamertf As String In System.IO.Directory.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Spez Bijiben Documents", "*.rtf")
            Dim item As New ListViewItem
            item.Text = System.IO.Path.GetFileNameWithoutExtension(fileNamertf)
            item.ImageKey = "rtf.png"
            item.SubItems.Add("Type")
            item.SubItems.Add("Created")
            item.SubItems.Add("filenamewithext")
            item.SubItems.Add("ext")
            item.SubItems(1).Text = "Type: ''" & Path.GetExtension(fileNamertf.ToString) & "''" & " (Rich Text File)"
            item.SubItems(2).Text = "Created in: " & File.GetCreationTimeUtc(fileNamertf.ToString)
            item.SubItems(3).Text = System.IO.Path.GetFileName(fileNamertf)
            item.SubItems(4).Text = System.IO.Path.GetExtension(fileNamertf)
            ListView1.Items.Add(item)
        Next
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        SendKeys.Send("+{F10}")
    End Sub

    Private Sub LargeIconToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LargeIconToolStripMenuItem.Click
        LargeIconToolStripMenuItem.Checked = True
        SmallIconToolStripMenuItem.Checked = False
        DetailsToolStripMenuItem.Checked = False
        ListToolStripMenuItem.Checked = False
        TileToolStripMenuItem.Checked = False
        '-----------------------------------------------------------
        ListView1.View = View.LargeIcon
    End Sub

    Private Sub SmallIconToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SmallIconToolStripMenuItem.Click
        LargeIconToolStripMenuItem.Checked = False
        SmallIconToolStripMenuItem.Checked = True
        DetailsToolStripMenuItem.Checked = False
        ListToolStripMenuItem.Checked = False
        TileToolStripMenuItem.Checked = False
        '-----------------------------------------------------------
        ListView1.View = View.SmallIcon
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DetailsToolStripMenuItem.Click
        LargeIconToolStripMenuItem.Checked = False
        SmallIconToolStripMenuItem.Checked = False
        DetailsToolStripMenuItem.Checked = True
        ListToolStripMenuItem.Checked = False
        TileToolStripMenuItem.Checked = False
        '-----------------------------------------------------------
        ListView1.View = View.Details
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListToolStripMenuItem.Click
        LargeIconToolStripMenuItem.Checked = False
        SmallIconToolStripMenuItem.Checked = False
        DetailsToolStripMenuItem.Checked = False
        ListToolStripMenuItem.Checked = True
        TileToolStripMenuItem.Checked = False
        '-----------------------------------------------------------
        ListView1.View = View.List
    End Sub

    Private Sub TileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TileToolStripMenuItem.Click
        LargeIconToolStripMenuItem.Checked = False
        SmallIconToolStripMenuItem.Checked = False
        DetailsToolStripMenuItem.Checked = False
        ListToolStripMenuItem.Checked = False
        TileToolStripMenuItem.Checked = True
        '-----------------------------------------------------------
        ListView1.View = View.Tile
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SearchDocumentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SearchDocumentToolStripMenuItem.Click
        FindDoc.Show()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        ListView1.Items.Clear()
        loadfiles()
    End Sub

    Private Sub DetailsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DetailsToolStripMenuItem1.Click
        Try
            If My.Settings.Language = "Türkçe" Then
                MsgBox("Dosya Adı: ''" & ListView1.SelectedItems(0).Text & "''" & vbNewLine & "Dosya " & ListView1.SelectedItems(0).SubItems(1).Text & vbNewLine & ListView1.SelectedItems(0).SubItems(2).Text, MsgBoxStyle.Information, "Dosya Detayları")
            ElseIf My.Settings.Language = "English" Then
                MsgBox("File Name: ''" & ListView1.SelectedItems(0).Text & "''" & vbNewLine & "File " & ListView1.SelectedItems(0).SubItems(1).Text & vbNewLine & ListView1.SelectedItems(0).SubItems(2).Text, MsgBoxStyle.Information, "File Details")
            End If
        Catch ex As Exception
            If My.Settings.Language = "Türkçe" Then
                MsgBox("Belge Seçin.", MsgBoxStyle.Exclamation, "Hata")
            ElseIf My.Settings.Language = "English" Then
                MsgBox("Select a document.", MsgBoxStyle.Exclamation, "Error")
            End If
        End Try
    End Sub

    Private Sub DeleteDocumentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteDocumentToolStripMenuItem.Click
        Try
            Dim result As Integer = MessageBox.Show("Are you sure to delete the file?" & vbNewLine & vbNewLine & "File Name: ''" & ListView1.SelectedItems(0).SubItems(3).Text & "''" & vbNewLine & vbNewLine & "You Can Retrieve The File From The Recycle Bin.", "Delete File", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                For Each fileNamedel As String In System.IO.Directory.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Spez Bijiben Documents", ListView1.SelectedItems(0).SubItems(3).Text)
                    Try
                        My.Computer.FileSystem.DeleteFile(fileNamedel, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)
                    Catch ex As Exception
                        MsgBox("File not found: " & fileNamedel, MsgBoxStyle.Critical, "Error")
                    End Try
                Next
            Else
            End If
        Catch ex As Exception
        End Try
        ListView1.Items.Clear()
        loadfiles()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Editor.Show()
        Editor.Location = Me.Location
        Editor.WindowState = Me.WindowState
        Editor.Size = Me.Size
        Editor.savedt()
    End Sub

    Public Sub OpenFile()
        Me.Hide()
        Editor.Show()
        Editor.Location = Me.Location
        Editor.WindowState = Me.WindowState
        Editor.Size = Me.Size
        Dim sr As New StreamReader(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Spez Bijiben Documents\" & ListView1.SelectedItems(0).SubItems(3).Text)
        Dim conrtf As String = sr.ReadToEnd
        sr.Close()
        Try
            Editor.RichTextBox1.Rtf = conrtf
        Catch ex As Exception
            Editor.BackButton.PerformClick()
            MsgBox("Error Opening File: " & ListView1.SelectedItems(0).SubItems(3).Text & vbNewLine & "File Damaged or not compatible with Spez Bijiben.", vbCritical, "Error")
        End Try
        Editor.savedt()
        Editor.savedt()
        Editor.savedt()
        Editor.RichTextBox1.Focus()
        SendKeys.Send("^A")
        SendKeys.Send("{ESC}")
    End Sub

    Private Sub OpenDocumentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenDocumentToolStripMenuItem.Click
        OpenFile()
    End Sub

    Private Sub ListView1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count = 0 Then
        Else
            OpenFile()
        End If
    End Sub

    Private Sub RenameDocumentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RenameDocumentToolStripMenuItem.Click
        Try
            Dim strInput As String
            strInput = InputBox("Enter new filename:")
            If strInput = "" Then
            Else
                For Each fileNameren As String In System.IO.Directory.GetFiles(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Spez Bijiben Documents\", ListView1.SelectedItems(0).SubItems(3).Text)
                    Dim myFile As New System.IO.FileInfo(fileNameren)
                    myFile.MoveTo(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Spez Bijiben Documents\" & strInput & ListView1.SelectedItems(0).SubItems(4).Text)
                    ListView1.Items.Clear()
                    loadfiles()
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListView1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            OpenFile()
        End If
    End Sub

    Private Sub AboutSpezBijibenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutSpezBijibenToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        Dialog3.ShowDialog()
    End Sub

    Private Sub Form1_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.Save()
        My.Settings.Save()
        My.Settings.Save()
    End Sub
End Class
