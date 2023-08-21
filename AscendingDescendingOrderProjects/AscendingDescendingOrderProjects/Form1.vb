Public Class Form1
    Private Sub btnAcending_Click(sender As Object, e As EventArgs) Handles btnAcending.Click
        Dim symbol As String
        Dim size As Integer
        Dim result As String
        Dim row As Integer
        Dim col As Integer

        symbol = txtSmbol.Text
        size = nmcSize.Text

        result = ""

        For row = 0 To size - 1
            col = 0
            Do While col <= row
                result = result & symbol & " "
                col = col + 1
            Loop
            result = result & vbNewLine
        Next

        lblAcendingOutput.Text = result
    End Sub

    Private Sub btnDescending_Click(sender As Object, e As EventArgs) Handles btnDescending.Click
        Dim symbol As String
        Dim size As Integer
        Dim result As String
        Dim row As Integer
        Dim col As Integer

        symbol = txtSmbol.Text
        size = nmcSize.Text

        result = ""

        For row = 0 To size
            col = row
            Do While col < size
                result = result & symbol & " "
                col = col + 1
            Loop
            result = result & vbNewLine
        Next

        lblDecendingOutput.Text = result
    End Sub
End Class
