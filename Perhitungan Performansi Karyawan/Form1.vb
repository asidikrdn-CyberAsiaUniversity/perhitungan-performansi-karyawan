Imports System.IO

Public Class Form1
    ' Declaration
    Dim NIP As String
    Dim Fullname As String
    Dim CurrentYearProduction As Integer
    Dim LastYearProduction As Integer
    Dim Performance As Integer
    Dim Bonus As Integer
    Dim myStreamWriter As StreamWriter
    Dim myStreamReader As StreamReader

    ' App Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set some textbox to readonly (Karyawan, Performance, Bonus, List Penerima Bonus)
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        RichTextBox1.ReadOnly = True
        TextBox7.ReadOnly = True

        PrintToRichTextBox()
    End Sub

    ' Reset Database Button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClearDatabase()
        PrintToRichTextBox()

        MsgBox("Successfully reset database...")
    End Sub

    ' Hitung Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get inputed data from textbox
        NIP = TextBox1.Text
        Fullname = TextBox2.Text
        CurrentYearProduction = TextBox3.Text
        LastYearProduction = TextBox4.Text

        ' Double Input Validation
        myStreamReader = New StreamReader("C:\program_performansi\data.txt")
        Do While Not myStreamReader.EndOfStream
            If myStreamReader.ReadLine().Contains(NIP & " - ") Then
                MsgBox("Karyawan dengan NIP : " & NIP & " telah diinputkan !")
                myStreamReader.Close()
                Return
            End If
        Loop
        myStreamReader.Close()

        ' Calculate Performance
        Performance = CurrentYearProduction - LastYearProduction

        If Performance > 0 Then
            If Performance <= 1000 Then
                Bonus = 250000
            ElseIf Performance <= 3000 Then
                Bonus = 500000
            ElseIf Performance <= 6000 Then
                Bonus = 1000000
            Else
                Bonus = 2000000
            End If
        Else
            Bonus = 0
        End If

        ' Print Output
        TextBox7.Text = NIP & " - " & Fullname
        TextBox5.Text = Performance
        TextBox6.Text = Bonus.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"))

        If Bonus > 0 Then
            ' Save to file
            myStreamWriter = New StreamWriter("C:\program_performansi\data.txt", True)
            myStreamWriter.WriteLine(NIP & " - " & Fullname & " : " & Bonus.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID")))
            myStreamWriter.Close()
        Else
            MsgBox(NIP & " - " & Fullname & " tidak mendapatkan bonus, silahkan perbaiki kinerja !")
        End If

        PrintToRichTextBox()


        ' Call ClearInput Procedure
        ClearInput()
    End Sub


    ' Validasi jumlah produksi tahun ini
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If Not IsNumeric(TextBox3.Text) Then
            MessageBox.Show("Hanya angka yang diizinkan.")
            TextBox3.Clear()
        End If
    End Sub

    ' Validasi jumlah produksi tahun lalu
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If Not IsNumeric(TextBox4.Text) Then
            MessageBox.Show("Hanya angka yang diizinkan.")
            TextBox4.Clear()
        End If
    End Sub

    Private Sub ClearInput()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Text = 0
        TextBox4.Text = 0
    End Sub

    Private Sub ClearPreview()
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub ClearDatabase()
        File.WriteAllText("C:\program_performansi\data.txt", String.Empty)
        PrintToRichTextBox()
    End Sub

    Private Sub PrintToRichTextBox()
        ' Print on rich text box
        myStreamReader = New StreamReader("C:\program_performansi\data.txt")
        RichTextBox1.Text = ""
        Do While Not myStreamReader.EndOfStream
            RichTextBox1.AppendText(myStreamReader.ReadLine() & vbCrLf)
        Loop
        myStreamReader.Close()
    End Sub

    ' Clear Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearInput()
        ClearPreview()
    End Sub
End Class
