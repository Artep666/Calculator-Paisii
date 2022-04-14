Public Class Form1
    Dim Nigerian_Naira As Double = 247.87
    Dim Usa_Dollar As Double = 0.62
    Dim Kenyan_Shilling As Double = 68.61
    Dim Brazilian_Real As Double = 3.38
    Dim Indonesian_Rupiah As Double = 8834.27
    Dim Indian_Rupee As Double = 45.86
    Dim Philippine_Peso As Double = 30.03

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Amount As Decimal
        Dim Rate As Decimal
        Dim Result As Decimal
        Dim Name As String

        Amount = CDec(TextBox1.Text)
        Rate = CDec(TextBox2.Text)
        Name = UCase(TextBox3.Text)

        Result = Amount * Rate

        MsgBox(Name & ", вашият резултат е " & Result & ".", MsgBoxStyle.OkOnly, "Резултат")
        TextBox4.Text = Result

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = Date.Now.ToString("dd/MM/yyyy  HH:mm:ss")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Щатски долар: " & Usa_Dollar & " лв." & vbNewLine _
            & "Нигерийска найра: " & Nigerian_Naira & " лв." & vbNewLine _
            & "Кенийски шилинг: " & Kenyan_Shilling & " лв." & vbNewLine _
            & "Бразилски реал: " & Brazilian_Real & " лв." & vbNewLine _
            & "Индонезийска рупия: " & Indonesian_Rupiah & " лв." & vbNewLine _
            & "Индийска рупия: " & Indian_Rupee & " лв." & vbNewLine _
            & "Филипинско песо: " & Philippine_Peso & " лв.", "Валутни курсове")
    End Sub
End Class
