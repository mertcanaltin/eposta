Imports System.Net.Mail
Imports System.Net
Imports System.Text.RegularExpressions

Public Class Form1
    Private DosyaEki As String
    Public Function EmailKontrol(ByRef email As TextBox) As Boolean
        Dim rex As Match = Regex.Match(Trim(email.Text), "^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,3})$", RegexOptions.IgnoreCase)
        If rex.Success = False Then
            MsgBox("Geçersiz Email adresi!!" & vbCrLf & "Email adresi deneme@deneme.com biçiminde olması gerekiyor.")
            email.Focus()
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub ButtonGonder_Click(sender As Object, e As EventArgs) Handles ButtonGonder.Click
        Dim Kimden, Sifre As String
        If EPostaSifreForm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Kimden = EPostaSifreForm.TextBoxPosta.Text & "@gmail.com"
            Sifre = EPostaSifreForm.TextBoxSifre.Text
            Dim Posta As New MailMessage
            Dim SmtpSunucusu As New SmtpClient("smtp.gmail.com")
            'Posta oluşturma
            Posta.From = New MailAddress("mutluyali@gmail.com", "Mutlu YALI")
            Posta.To.Add(TextBoxKime.Text)
            If TextBoxBilgi.Text <> "" Then
                Posta.CC.Add(TextBoxBilgi.Text)
            End If
            If TextBoxGizli.Text <> "" Then
                Posta.Bcc.Add(TextBoxGizli.Text)
            End If
            Posta.Subject = TextBoxKonu.Text
            Posta.Body = RichTextBoxPosta.Text
            'Postaya dosya ekleme
            If DosyaEki <> "" Then
                Dim Ek As Attachment = New Attachment(DosyaEki)
                Posta.Attachments.Add(Ek)
            End If
            'Posta Gönderme
            SmtpSunucusu.Port = 587
            SmtpSunucusu.Credentials = New NetworkCredential(Kimden, Sifre)
            SmtpSunucusu.EnableSsl = True
            Try
                SmtpSunucusu.Send(Posta)
                MsgBox("e-posta başarı ile gönderildi.")
            Catch ex As SmtpException
                MsgBox("Hata Oluştu:" & ex.Message.ToString)
            End Try
            
        End If
    End Sub

    Private Sub TextBoxKime_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxKime.Validating
        EmailKontrol(sender)
    End Sub
    Private Sub TextBoxKontrolu_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxBilgi.Validating, TextBoxGizli.Validating
        Dim MetinKutusu As TextBox = sender
        If MetinKutusu.Text <> "" Then
            EmailKontrol(MetinKutusu)
        End If
    End Sub

    Private Sub ButtonDosyaEki_Click(sender As Object, e As EventArgs) Handles ButtonDosyaEki.Click
        If OpenFileDialogDosyaEki.ShowDialog = Windows.Forms.DialogResult.OK Then
            DosyaEki = OpenFileDialogDosyaEki.FileName
            TextBoxDosya.Text = My.Computer.FileSystem.GetFileInfo(DosyaEki).Name
        End If
    End Sub
End Class
