<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        title = New Label()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        RichTextBox1 = New RichTextBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label13 = New Label()
        Button3 = New Button()
        TextBox7 = New TextBox()
        Label14 = New Label()
        Label15 = New Label()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' title
        ' 
        title.AutoSize = True
        title.Font = New Font("Segoe UI", 14F)
        title.Location = New Point(223, 9)
        title.Name = "title"
        title.Size = New Size(464, 25)
        title.TabIndex = 0
        title.Text = "PROGRAM PERHITUNGAN PERFORMANSI KARYAWAN"
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(21, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 19)
        Label1.TabIndex = 1
        Label1.Text = "NIP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(21, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 19)
        Label2.TabIndex = 2
        Label2.Text = "Nama Lengkap"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(21, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 19)
        Label3.TabIndex = 3
        Label3.Text = "Jumlah Produksi Tahun Ini"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(21, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(178, 19)
        Label4.TabIndex = 4
        Label4.Text = "Jumlah Produksi Tahun Lalu"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(223, 54)
        Label5.Name = "Label5"
        Label5.Size = New Size(20, 19)
        Label5.TabIndex = 5
        Label5.Text = " : "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(223, 100)
        Label6.Name = "Label6"
        Label6.Size = New Size(20, 19)
        Label6.TabIndex = 6
        Label6.Text = " : "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.Location = New Point(223, 142)
        Label7.Name = "Label7"
        Label7.Size = New Size(20, 19)
        Label7.TabIndex = 7
        Label7.Text = " : "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F)
        Label8.Location = New Point(223, 187)
        Label8.Name = "Label8"
        Label8.Size = New Size(20, 19)
        Label8.TabIndex = 8
        Label8.Text = " : "
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10F)
        TextBox1.Location = New Point(249, 54)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(266, 25)
        TextBox1.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 10F)
        TextBox2.Location = New Point(249, 100)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(266, 25)
        TextBox2.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 10F)
        TextBox3.Location = New Point(249, 142)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(266, 25)
        TextBox3.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 10F)
        TextBox4.Location = New Point(249, 187)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(266, 25)
        TextBox4.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(151, 245)
        Button1.Name = "Button1"
        Button1.Size = New Size(92, 42)
        Button1.TabIndex = 13
        Button1.Text = "Hitung"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button2.Font = New Font("Segoe UI", 12F)
        Button2.Location = New Point(249, 245)
        Button2.Name = "Button2"
        Button2.Size = New Size(92, 42)
        Button2.TabIndex = 14
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe UI", 8F)
        RichTextBox1.Location = New Point(577, 205)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(315, 180)
        RichTextBox1.TabIndex = 15
        RichTextBox1.Text = ""
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F)
        Label9.Location = New Point(577, 102)
        Label9.Name = "Label9"
        Label9.Size = New Size(81, 19)
        Label9.TabIndex = 16
        Label9.Text = "Performansi"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F)
        Label10.Location = New Point(577, 142)
        Label10.Name = "Label10"
        Label10.Size = New Size(47, 19)
        Label10.TabIndex = 17
        Label10.Text = "Bonus"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F)
        Label11.Location = New Point(664, 102)
        Label11.Name = "Label11"
        Label11.Size = New Size(20, 19)
        Label11.TabIndex = 18
        Label11.Text = " : "
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10F)
        Label12.Location = New Point(667, 142)
        Label12.Name = "Label12"
        Label12.Size = New Size(20, 19)
        Label12.TabIndex = 19
        Label12.Text = " : "
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 10F)
        TextBox5.Location = New Point(691, 102)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(201, 25)
        TextBox5.TabIndex = 20
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 10F)
        TextBox6.Location = New Point(691, 142)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(201, 25)
        TextBox6.TabIndex = 21
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 8F)
        Label13.Location = New Point(577, 189)
        Label13.Name = "Label13"
        Label13.Size = New Size(266, 13)
        Label13.TabIndex = 22
        Label13.Text = "Daftar Nama Karyawan Yang Mendapatkan Bonus :"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button3.Font = New Font("Segoe UI", 12F)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(347, 245)
        Button3.Name = "Button3"
        Button3.Size = New Size(92, 42)
        Button3.TabIndex = 23
        Button3.Text = "Reset Data"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 10F)
        TextBox7.Location = New Point(691, 54)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(201, 25)
        TextBox7.TabIndex = 26
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 10F)
        Label14.Location = New Point(664, 54)
        Label14.Name = "Label14"
        Label14.Size = New Size(20, 19)
        Label14.TabIndex = 25
        Label14.Text = " : "
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 10F)
        Label15.Location = New Point(577, 54)
        Label15.Name = "Label15"
        Label15.Size = New Size(68, 19)
        Label15.TabIndex = 24
        Label15.Text = "Karyawan"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(895, 450)
        Controls.Add(TextBox7)
        Controls.Add(Label14)
        Controls.Add(Label15)
        Controls.Add(Button3)
        Controls.Add(Label13)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(RichTextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(title)
        Name = "Form1"
        Text = "Form1"
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents title As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label

End Class
