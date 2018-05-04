Imports System.Drawing.Text

Public Class WelcomeScreen
    Dim font1 As PrivateFontCollection = New PrivateFontCollection
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim lang As String
    Dim a As Integer

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

    Private Sub WelcomeScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        font1.AddFontFile("data/Karla.ttf")
        Label1.Font = New Font(font1.Families(0), 1, FontStyle.Bold)
        Label4.Font = New Font(font1.Families(0), 1, FontStyle.Bold)
        Label2.Font = New Font(font1.Families(0), 1)
        Label3.Font = New Font(font1.Families(0), 1)
        Button1.Font = New Font(font1.Families(0), 10)
        Button2.Font = New Font(font1.Families(0), 10)
        Me.Font = New Font(font1.Families(0), 8)
    End Sub

    Private Sub Close_Button_Click(sender As System.Object, e As System.EventArgs) Handles Close_Button.Click
        End
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Minimaze_Button.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label1.Visible = True
        Label2.Visible = True
        Try
            If Label2.Font.Size >= 8 Then
                Label2.Font = New Font(font1.Families(0), 8)
            End If
            If Label1.Font.Size >= 22 Then
                Timer1.Interval = Timer1.Interval + 25
            End If
            If Label1.Font.Size = 22 Then
                Button1.Visible = True
                Button2.Visible = True
            End If
            If Label1.Font.Size = 24 Then
                Timer1.Enabled = False
                Timer1.Interval = 1
            End If
            Label1.Font = New Font(font1.Families(0), Label1.Font.Size + 1, FontStyle.Bold)
            Label2.Font = New Font(font1.Families(0), Label2.Font.Size + 0.3)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Try
            If Label2.Font.Size = 1 Then
                Label2.Visible = False
            End If
            If Label1.Font.Size = 1 Then
                Timer1.Enabled = False
                Timer1.Stop()
            End If
            If Timer1.Interval < 10 Then
                Timer1.Interval = Timer1.Interval + 1
            End If
            If Label1.Font.Size >= 19 Then
                Timer1.Interval = Timer1.Interval + 5
            End If
            If Label1.Font.Size = 22 Then
                Button1.Visible = False
                Button2.Visible = False
            End If
            If Label1.Font.Size = 5 Then
                Timer1.Enabled = False
                Label1.Visible = False
                Label2.Visible = False
                Timer3.Enabled = True
                Timer3.Start()
                Timer2.Interval = 1
            End If
            Label1.Font = New Font(font1.Families(0), Label1.Font.Size - 1, FontStyle.Bold)
            Label2.Font = New Font(font1.Families(0), Label2.Font.Size - 0.3)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer2.Enabled = True
        lang = "en"

        Label4.Text = "Welcome To Spez Bijiben!"
        Label3.Text = "You Finally Found The Best Quality, Most Professional And Best Text Editor!"
        btn_next_001.Text = "Next"
        Timer3.Interval = 1
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Timer2.Enabled = True
        lang = "tr"

        Label4.Text = "Spez Bijiben'e Hoşgeldiniz!"
        Label3.Text = "Sonunda Kaliteli, Profesyonel Ve En İyi Metin Editörü Buldun!"
        btn_next_001.Text = "İleri"
        Timer3.Interval = 1
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Label3.Visible = True
        Label4.Visible = True
        Try
            If Label3.Font.Size >= 8 Then
                Label3.Font = New Font(font1.Families(0), 8)
            End If
            If Label4.Font.Size >= 22 Then
                Timer3.Interval = Timer1.Interval + 15
            End If
            If Label4.Font.Size = 22 Then
                PictureBox1.Visible = True
                btn_next_001.Visible = True
                btn_next_001.Show()
            End If
            If Label4.Font.Size = 24 Then
                Timer3.Enabled = False
                Timer3.Interval = 1
            End If
            Label4.Font = New Font(font1.Families(0), Label4.Font.Size + 1, FontStyle.Bold)
            Label3.Font = New Font(font1.Families(0), Label3.Font.Size + 0.6)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Try
            If Label3.Font.Size = 1 Then
                Label3.Visible = False
            End If
            If Label4.Font.Size = 1 Then
                Timer3.Enabled = False
                Timer3.Stop()
            End If
            If Timer3.Interval < 10 Then
                Timer3.Interval = Timer3.Interval + 0.5
            End If
            If Label4.Font.Size >= 19 Then
                Timer3.Interval = Timer3.Interval + 1
            End If
            If Label4.Font.Size = 22 Then
                PictureBox1.Hide()
                btn_next_001.Hide()
            End If
            If Label4.Font.Size = 1 Then
                Timer3.Enabled = False
                Label4.Visible = False
                Label3.Visible = False
                If a = 2 Then
                    If lang = "en" Then
                        Label4.Text = "Our Multi-Feature Editor."
                        Label3.Text = "Our editor has been carefully coded for you. Besides our editor's professional" & vbNewLine & "features, you can use our beautifully prepared Background Themes."
                        PictureBox1.BackgroundImage = My.Resources.edit
                    Else
                        Label4.Text = "Çok Özellikli Editörümüz."
                        Label3.Text = "Editörümüz sizin için dikkatle kodlanmıştır. Editörümüzün profesyonel özelliklerinin" & vbNewLine & "yanı sıra, güzel hazırlanmış Arka Plan Temalarımızı kullanabilirsiniz."
                        PictureBox1.BackgroundImage = My.Resources.edit
                    End If
                End If
                If a = 3 Then
                    If lang = "en" Then
                        Label4.Text = "See Your Documents."
                        Label3.Text = "There is no need to open files. When you open Spez Bijiben, a window opens with" & vbNewLine & "your documents. So you do not waste much time."
                        PictureBox1.BackgroundImage = My.Resources.edit
                        btn_next_001.Text = "Start"
                    Else
                        Label4.Text = "Belgelerinizi Görün."
                        Label3.Text = "Dosyalardan açmaya gerek yoktur. Spez Bijiben'i açtığınızda belgelerinizle birlikte" & vbNewLine & "bir pencere açılır. Yani fazla zaman kaybetmiyorsun."
                        PictureBox1.BackgroundImage = My.Resources.str
                        btn_next_001.Text = "Başla"
                    End If
                End If
                If a = 4 Then
                    If lang = "en" Then
                        My.Settings.Language = "English"
                        My.Settings.WelcomeScreen = False
                        My.Settings.Save()
                        My.Settings.Save()
                        My.Settings.Save()
                        Threading.Thread.Sleep(1000)
                        Application.Restart()
                    Else
                        My.Settings.Language = "Türkçe"
                        My.Settings.WelcomeScreen = False
                        My.Settings.Save()
                        My.Settings.Save()
                        My.Settings.Save()
                        Threading.Thread.Sleep(1000)
                        Application.Restart()
                    End If
                End If
                Timer4.Enabled = False
                Timer5.Enabled = True
                Timer5.Start()
                Timer4.Interval = 1
            End If
            Label4.Font = New Font(font1.Families(0), Label4.Font.Size - 1, FontStyle.Bold)
            Label3.Font = New Font(font1.Families(0), Label3.Font.Size - 0.3)
        Catch ex As Exception
        End Try
        End Sub

    Private Sub btn_next_001_Click(sender As System.Object, e As System.EventArgs) Handles btn_next_001.Click
        If a = 0 Then
            a = 1
        End If
        a = a + 1
        Timer5.Interval = 1
        Timer4.Interval = 1
        Timer4.Enabled = True
        Timer4.Start()
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Label3.Visible = True
        Label4.Visible = True
        Try
            If Label3.Font.Size >= 8 Then
                Label3.Font = New Font(font1.Families(0), 8)
            End If
            If Label4.Font.Size >= 22 Then
                Timer5.Interval = Timer1.Interval + 15
            End If
            If Label4.Font.Size = 22 Then
                PictureBox1.Visible = True
                btn_next_001.Visible = True
                btn_next_001.Show()
            End If
            If Label4.Font.Size = 24 Then
                Timer5.Enabled = False
                Timer5.Interval = 1
                Timer5.Interval = 1
                Timer5.Interval = 1
            End If
            Label4.Font = New Font(font1.Families(0), Label4.Font.Size + 1, FontStyle.Bold)
            Label3.Font = New Font(font1.Families(0), Label3.Font.Size + 0.6)
        Catch ex As Exception
        End Try
    End Sub
End Class