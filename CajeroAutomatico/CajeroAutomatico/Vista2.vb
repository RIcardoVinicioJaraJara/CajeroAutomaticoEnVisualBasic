Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Vista2

    Private cn As SqlConnection
   


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            cn = New SqlConnection
            cn.ConnectionString = "Server=RICI-PC; database=Diaz_Gutierrez_Coop; Integrated Security=true;"
            cn.Open()
            Dim validacion As String = "SELECT * FROM [dbo].[Clientes] WHERE [cli_cedula] = '" + txtCedula.Text + "' AND [cli_contrasenia] = '" + txtContra.Text + " '"
            Dim cmd As New SqlCommand(validacion, cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                Datos.cli_num_cuenta = (dr("cli_num_cuenta").ToString)
                Me.Close()
                Vista3.Show()
            Else
                MessageBox.Show("LOGIN INCORRECTO")
                Me.Hide()
                Vista.Show()
            End If
            cn.Close()
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub

    Private Sub Vista2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class