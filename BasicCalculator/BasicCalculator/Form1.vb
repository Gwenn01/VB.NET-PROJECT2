Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim output As Integer
        Dim firstNum As Integer
        Dim secondNum As Integer

        firstNum = txtFirstNum.Text
        secondNum = txtSecondNum.Text


        If rdbtnAdd.Checked Then
            output = firstNum + secondNum
        ElseIf rdbtnSubtrac.Checked Then
            output = firstNum - secondNum
        ElseIf rdbtnMultiply.Checked Then
            output = firstNum * secondNum
        ElseIf rdbtnDivide.Checked Then
            output = firstNum / secondNum
        Else
            MsgBox("Please select Operator!!")
        End If

        lblOutput.Text = output

    End Sub
End Class
