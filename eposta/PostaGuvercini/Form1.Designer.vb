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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonGonder = New System.Windows.Forms.Button()
        Me.TextBoxKonu = New System.Windows.Forms.TextBox()
        Me.TextBoxGizli = New System.Windows.Forms.TextBox()
        Me.TextBoxBilgi = New System.Windows.Forms.TextBox()
        Me.TextBoxKime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RichTextBoxPosta = New System.Windows.Forms.RichTextBox()
        Me.ButtonDosyaEki = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxDosya = New System.Windows.Forms.TextBox()
        Me.OpenFileDialogDosyaEki = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBoxDosya)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ButtonDosyaEki)
        Me.Panel1.Controls.Add(Me.ButtonGonder)
        Me.Panel1.Controls.Add(Me.TextBoxKonu)
        Me.Panel1.Controls.Add(Me.TextBoxGizli)
        Me.Panel1.Controls.Add(Me.TextBoxBilgi)
        Me.Panel1.Controls.Add(Me.TextBoxKime)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(620, 138)
        Me.Panel1.TabIndex = 0
        '
        'ButtonGonder
        '
        Me.ButtonGonder.Image = Global.PostaGuvercini.My.Resources.Resources.eposta1
        Me.ButtonGonder.Location = New System.Drawing.Point(513, 8)
        Me.ButtonGonder.Name = "ButtonGonder"
        Me.ButtonGonder.Size = New System.Drawing.Size(95, 96)
        Me.ButtonGonder.TabIndex = 8
        Me.ButtonGonder.Text = "Gönder"
        Me.ButtonGonder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonGonder.UseVisualStyleBackColor = True
        '
        'TextBoxKonu
        '
        Me.TextBoxKonu.Location = New System.Drawing.Point(82, 84)
        Me.TextBoxKonu.Name = "TextBoxKonu"
        Me.TextBoxKonu.Size = New System.Drawing.Size(407, 20)
        Me.TextBoxKonu.TabIndex = 7
        '
        'TextBoxGizli
        '
        Me.TextBoxGizli.Location = New System.Drawing.Point(82, 58)
        Me.TextBoxGizli.Name = "TextBoxGizli"
        Me.TextBoxGizli.Size = New System.Drawing.Size(407, 20)
        Me.TextBoxGizli.TabIndex = 6
        '
        'TextBoxBilgi
        '
        Me.TextBoxBilgi.Location = New System.Drawing.Point(82, 32)
        Me.TextBoxBilgi.Name = "TextBoxBilgi"
        Me.TextBoxBilgi.Size = New System.Drawing.Size(407, 20)
        Me.TextBoxBilgi.TabIndex = 5
        '
        'TextBoxKime
        '
        Me.TextBoxKime.Location = New System.Drawing.Point(82, 8)
        Me.TextBoxKime.Name = "TextBoxKime"
        Me.TextBoxKime.Size = New System.Drawing.Size(407, 20)
        Me.TextBoxKime.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Konu:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gizli:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bilgi:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kime:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 377)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(620, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RichTextBoxPosta)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 138)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(620, 239)
        Me.Panel2.TabIndex = 2
        '
        'RichTextBoxPosta
        '
        Me.RichTextBoxPosta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxPosta.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBoxPosta.Name = "RichTextBoxPosta"
        Me.RichTextBoxPosta.Size = New System.Drawing.Size(620, 239)
        Me.RichTextBoxPosta.TabIndex = 0
        Me.RichTextBoxPosta.Text = ""
        '
        'ButtonDosyaEki
        '
        Me.ButtonDosyaEki.Location = New System.Drawing.Point(319, 109)
        Me.ButtonDosyaEki.Name = "ButtonDosyaEki"
        Me.ButtonDosyaEki.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDosyaEki.TabIndex = 9
        Me.ButtonDosyaEki.Text = "Dosya Seç"
        Me.ButtonDosyaEki.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Dosya Eki:"
        '
        'TextBoxDosya
        '
        Me.TextBoxDosya.Location = New System.Drawing.Point(82, 110)
        Me.TextBoxDosya.Name = "TextBoxDosya"
        Me.TextBoxDosya.ReadOnly = True
        Me.TextBoxDosya.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxDosya.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 399)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonGonder As System.Windows.Forms.Button
    Friend WithEvents TextBoxKonu As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxGizli As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBilgi As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKime As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RichTextBoxPosta As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBoxDosya As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonDosyaEki As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialogDosyaEki As System.Windows.Forms.OpenFileDialog

End Class
