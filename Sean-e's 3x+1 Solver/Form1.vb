Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nums.ListBox1.Items.Clear()
        Dim input As Integer
        Dim current_cycle As Integer
        input = NumericUpDown1.Value
        nums.ListBox1.Items.Add(input)
        cn.Text = input
        ar.Text = 0
        current_cycle = 0
        While input <> 1
            current_cycle = current_cycle + 1
            ar.Text = current_cycle
            cn.Text = input
            If FormatNumber(input) Mod 2 = 0 Then
                input = input / 2
            Else
                input = input * 3
                input = input + 1
            End If
            nums.ListBox1.Items.Add(input)
        End While
        MsgBox("Your number got stuck in a 421 loop after " & current_cycle & " runs.", 0 + 64, "Finished!")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        nums.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell("cmd /c https://github.com/JrGamer410/Sean-e-s-3x-1-Solver")
    End Sub
End Class
