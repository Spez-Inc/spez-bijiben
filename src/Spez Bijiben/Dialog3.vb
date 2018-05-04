Imports System.Windows.Forms
Imports System.Drawing.Text

Public Class Dialog3

    Dim font1 As PrivateFontCollection = New PrivateFontCollection

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        '------------
        If ComboBox1.Text = "English" Then
            Me.Text = "Settings"
            bgthm.Text = "Background Themes (Not Saved)"
            GroupBox1.Text = "Language"
            OK_Button.Text = "Apply"
            Cancel_Button.Text = "Cancel"
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
            Form1.Button1.Text = "New"
            Form1.Label1.Text = "New and Recent"
            Form1.OpenDocumentToolStripMenuItem.Text = "Open Document"
            Form1.RenameDocumentToolStripMenuItem.Text = "Rename Document"
            Form1.DeleteDocumentToolStripMenuItem.Text = "Delete Document"
            Form1.DetailsToolStripMenuItem.Text = "Details"
            Form1.ViewToolStripMenuItem.Text = "View"
            Form1.LargeIconToolStripMenuItem.Text = "Large Icon"
            Form1.SmallIconToolStripMenuItem.Text = "Small Icon"
            Form1.DetailsToolStripMenuItem.Text = "Details"
            Form1.ListToolStripMenuItem.Text = "List"
            Form1.TileToolStripMenuItem.Text = "Tile"
            Form1.SearchDocumentToolStripMenuItem.Text = "Find Document"
            Form1.RefreshToolStripMenuItem.Text = "Refresh"
            Form1.SettingsToolStripMenuItem.Text = "Settings"
            Form1.AboutSpezBijibenToolStripMenuItem.Text = "About Spez Bijiben"
            Form1.ExitToolStripMenuItem.Text = "Exit"
        ElseIf ComboBox1.Text = "Türkçe" Then
            Me.Text = "Ayarlar"
            bgthm.Text = "Arkaplan Temaları (Kaydedilmez)"
            GroupBox1.Text = "Dil"
            OK_Button.Text = "Uygula"
            Cancel_Button.Text = "Vazgeç"
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
            Form1.Button1.Text = "Yeni"
            Form1.Label1.Text = "Yeni ve Son Açılan"
            Form1.OpenDocumentToolStripMenuItem.Text = "Belgeyi Aç"
            Form1.RenameDocumentToolStripMenuItem.Text = "Belgeyi Yeniden İsimlendir"
            Form1.DeleteDocumentToolStripMenuItem.Text = "Belgeyi Sil"
            Form1.DetailsToolStripMenuItem1.Text = "Detaylar"
            Form1.ViewToolStripMenuItem.Text = "Görünüm"
            Form1.LargeIconToolStripMenuItem.Text = "Büyük Simge"
            Form1.SmallIconToolStripMenuItem.Text = "Küçük Simge"
            Form1.DetailsToolStripMenuItem.Text = "Detaylar"
            Form1.ListToolStripMenuItem.Text = "Liste"
            Form1.TileToolStripMenuItem.Text = "Tile"
            Form1.SearchDocumentToolStripMenuItem.Text = "Belge Bul"
            Form1.RefreshToolStripMenuItem.Text = "Yinele"
            Form1.SettingsToolStripMenuItem.Text = "Ayarlar"
            Form1.AboutSpezBijibenToolStripMenuItem.Text = "Spez Bijiben Hakkında"
            Form1.ExitToolStripMenuItem.Text = "Çıkış"
        End If
        '------------
        My.Settings.Language = ComboBox1.Text
        My.Settings.Save()
        My.Settings.Save()
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        font1.AddFontFile("data/Karla.ttf")
        Me.Font = New Font(font1.Families(0), 8)
        '------------
        ComboBox1.Text = My.Settings.Language.ToString
    End Sub
End Class
