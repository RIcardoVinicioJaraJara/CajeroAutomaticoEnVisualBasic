Public Class Vista

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Vista2.Show()
        Me.Hide()
    End Sub

    Private Sub Vista_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub


    
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class