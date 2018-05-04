Imports System.Drawing.Text
Imports System.IO
Imports System
Imports System.Drawing
Imports System.ComponentModel


Public Class Editor

    Dim font1 As PrivateFontCollection = New PrivateFontCollection
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim saved As Boolean
    Dim b As New CheckBox

    Public Sub savedt()
        saved = True
    End Sub
    Public Sub savedf()
        saved = False
    End Sub

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

    Public Sub savefile()
        If saved = False Then
            If My.Settings.Language = "Türkçe" Then
                Dim result As Integer = MessageBox.Show("Belgeyi kaydetmek istiyor musun?", "Spez Bijiben", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If result = DialogResult.Yes Then
                    Try
                        Dim dlg As SaveFileDialog = New SaveFileDialog
                        dlg.Title = "Kaydet"
                        dlg.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Spez Bijiben Documents"
                        dlg.Filter = "Spez Bijiben Dosyası|*.bjn|Word 2007(+) Dosyası|*.docx|Word 97(+) Dosyası|*.doc|Zengin metin dosyası|*rtf|Tüm Dosyalar|*"
                        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            RichTextBox1.SaveFile(dlg.FileName)
                        End If
                    Catch ex As Exception
                    End Try
                End If
            ElseIf My.Settings.Language = "English" Then
                Dim result As Integer = MessageBox.Show("Do You Want To Save the Document?", "Spez Bijiben", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If result = DialogResult.Yes Then
                    Try
                        Dim dlg As SaveFileDialog = New SaveFileDialog
                        dlg.Title = "Save"
                        dlg.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Spez Bijiben Documents"
                        dlg.Filter = "Spez Bijiben File|*.bjn|Word 2007(+) File|*.docx|Word 97(+) File|*.doc|Rich Text Format|*rtf|All Files|*"
                        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                            RichTextBox1.SaveFile(dlg.FileName)
                        End If
                    Catch ex As Exception
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Close_Button.Click
        savefile()
        Form1.Close()
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
        font1.AddFontFile("data/Karla.ttf")
        ItalicButton.Font = New Font(font1.Families(0), 10, FontStyle.Italic)
        UnderlineButton.Font = New Font(font1.Families(0), 10, FontStyle.Underline)
        StrikeoutButton.Font = New Font(font1.Families(0), 10, FontStyle.Strikeout)
        BoldButton.Font = New Font(font1.Families(0), 10, FontStyle.Bold)
        BackButton.Font = New Font(font1.Families(0), 10)
        LeftB.Font = New Font(font1.Families(0), 10)
        CenterB.Font = New Font(font1.Families(0), 10)
        RightB.Font = New Font(font1.Families(0), 10)
        Me.Font = New Font(font1.Families(0), 8)
        '-----------------------------------------------------------
        Dim InstalledFonts As New InstalledFontCollection
        Dim fontfamilies() As FontFamily = InstalledFonts.Families()
        For Each fontFamily As FontFamily In fontfamilies
            ComboBox1.Items.Add(fontFamily.Name)
        Next
        '-----------------------------------------------------------
        If Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Spez Bijiben Documents") Then
        Else
            IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Spez Bijiben Documents")
        End If
        '-----------------------------------------------------------
        savedt()
    End Sub


    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        SendKeys.Send("+{F10}")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub SearchDocumentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        FindDoc.Show()
    End Sub

    Private Sub BackButton_Click(sender As System.Object, e As System.EventArgs) Handles BackButton.Click
        savefile()
        Me.Close()
        Form1.RefreshToolStripMenuItem.PerformClick()
        Form1.Show()
        Form1.Location = Me.Location
        Form1.WindowState = Me.WindowState
        Form1.Size = Me.Size
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        RichTextBox1.SelectionFont = New Font(ComboBox1.Text, ComboBox2.Text)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        RichTextBox1.SelectionFont = New Font(ComboBox1.Text, ComboBox2.Text)
    End Sub

    Private Sub BoldButton_Click(sender As System.Object, e As System.EventArgs) Handles BoldButton.Click
        Dim i As Integer
        i = Convert.ToInt64(ComboBox2.Text)
        Try
            If RichTextBox1.SelectionFont.Bold = False Then
                RichTextBox1.SelectionFont = New Font(ComboBox1.Text, i, FontStyle.Bold)
            Else
                RichTextBox1.SelectionFont = New Font(ComboBox1.Text, i, FontStyle.Regular)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ItalicButton_Click(sender As System.Object, e As System.EventArgs) Handles ItalicButton.Click
        Dim i As Integer
        i = Convert.ToInt64(ComboBox2.Text)
        Try
            If RichTextBox1.SelectionFont.Italic = False Then
                RichTextBox1.SelectionFont = New Font(ComboBox1.Text, i, FontStyle.Italic)
            Else
                RichTextBox1.SelectionFont = New Font(ComboBox1.Text, i, FontStyle.Regular)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UnderlineButton_Click(sender As System.Object, e As System.EventArgs) Handles UnderlineButton.Click
        Dim i As Integer
        i = Convert.ToInt64(ComboBox2.Text)
        Try
            If RichTextBox1.SelectionFont.Underline = False Then
                RichTextBox1.SelectionFont = New Font(ComboBox1.Text, i, FontStyle.Underline)
            Else
                RichTextBox1.SelectionFont = New Font(ComboBox1.Text, i, FontStyle.Regular)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub StrikeoutButton_Click(sender As System.Object, e As System.EventArgs) Handles StrikeoutButton.Click
        Dim i As Integer
        i = Convert.ToInt64(ComboBox2.Text)
        Try
            If RichTextBox1.SelectionFont.Strikeout = False Then
                RichTextBox1.SelectionFont = New Font(ComboBox1.Text, i, FontStyle.Strikeout)
            Else
                RichTextBox1.SelectionFont = New Font(ComboBox1.Text, i, FontStyle.Regular)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LeftB_Click(sender As System.Object, e As System.EventArgs) Handles LeftB.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub CenterB_Click(sender As System.Object, e As System.EventArgs) Handles CenterB.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub RightB_Click(sender As System.Object, e As System.EventArgs) Handles RightB.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close_Button.PerformClick()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles RichTextBox1.TextChanged
        savedf()
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RedToolStripMenuItem.Click
        Clipboard.SetImage(My.Resources.sqred)
        Me.RichTextBox1.Paste()
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BlueToolStripMenuItem.Click
        Clipboard.SetImage(My.Resources.sqblu)
        Me.RichTextBox1.Paste()
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GreenToolStripMenuItem.Click
        Clipboard.SetImage(My.Resources.sqgre)
        Me.RichTextBox1.Paste()
    End Sub

    Private Sub RedToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RedToolStripMenuItem1.Click
        Clipboard.SetImage(My.Resources.ovred)
        Me.RichTextBox1.Paste()
    End Sub

    Private Sub BlueToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles BlueToolStripMenuItem1.Click
        Clipboard.SetImage(My.Resources.ovblu)
        Me.RichTextBox1.Paste()
    End Sub

    Private Sub GreenToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles GreenToolStripMenuItem1.Click
        Clipboard.SetImage(My.Resources.ovgre)
        Me.RichTextBox1.Paste()
    End Sub

    Private Sub RedToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles RedToolStripMenuItem2.Click
        Clipboard.SetImage(My.Resources.trred)
        Me.RichTextBox1.Paste()
    End Sub

    Private Sub BlueToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles BlueToolStripMenuItem2.Click
        Clipboard.SetImage(My.Resources.trblu)
        Me.RichTextBox1.Paste()
    End Sub

    Private Sub GreenToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles GreenToolStripMenuItem2.Click
        Clipboard.SetImage(My.Resources.trgre)
        Me.RichTextBox1.Paste()
    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImageToolStripMenuItem.Click
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Title = "Open Image"
            dlg.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            dlg.Filter = "PNG|*.png|JPG|*.jpg|BMP|*.bmp|All Files|*"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Clipboard.SetImage(Image.FromFile(dlg.FileName))
                Me.RichTextBox1.Paste()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub TextHighlightColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TextHighlightColorToolStripMenuItem.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.RichTextBox1.SelectionBackColor = dlg.Color
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TextColorToolStripMenuItem.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.RichTextBox1.SelectionColor = dlg.Color
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FindToolStripMenuItem.Click
        Dialog2.Show()
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReplaceToolStripMenuItem.Click
        Dialog2.Show()
        Dialog2.TabControl1.SelectedIndex = 1
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub BackgroundThemesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackgroundThemesToolStripMenuItem.Click
        bgthm.ShowDialog()
    End Sub

    Private Sub AboutSpezBijibenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutSpezBijibenToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub Editor_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs)
        Close_Button.PerformClick()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        Dialog3.ShowDialog()
    End Sub

    Private Sub Editor_FormClosed_1(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.Save()
        My.Settings.Save()
        My.Settings.Save()
    End Sub
End Class
