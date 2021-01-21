Public Class Form1

    Private Sub btnDo_Click(sender As Object, e As EventArgs) Handles btnDo.Click
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intSkip As Integer

        intNum1 = Val(txtNum1.Text)
        intNum2 = Val(txtNum2.Text)
        intSkip = Val(txtSkip.Text)

        Do
            If intNum1 > intNum2 Then
                Do
                    MessageBox.Show(intNum1)
                    intNum1 = intNum1 - intSkip
                Loop While intNum1 > intNum2
            End If

            If intNum1 <= intNum2 Then
                MessageBox.Show(intNum1)
                intNum1 = intNum1 + intSkip
            End If

        Loop While intNum1 <= intNum2

    End Sub

    Private Sub btnFor_Click(sender As Object, e As EventArgs) Handles btnFor.Click
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intSkip As Integer
        Dim intCount As Integer

        intNum1 = Val(txtNum1.Text)
        intNum2 = Val(txtNum2.Text)
        intSkip = Val(txtSkip.Text)

        For intCount = intNum1 To intNum2 Step intSkip
            MessageBox.Show(intCount)
        Next

        If intNum1 > intNum2 Then
            For intCount = intNum1 To intNum2 Step -intSkip
                MessageBox.Show(intCount)
            Next
        End If
      
    End Sub
End Class
