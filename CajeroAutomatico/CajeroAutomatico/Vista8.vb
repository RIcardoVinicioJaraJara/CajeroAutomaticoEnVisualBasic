Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Vista8
    Private cn As SqlConnection
    
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If txtNew1.Text = txtNew2.Text Then
            Try
                cn = New SqlConnection
                cn.ConnectionString = "Server=RICI-PC; database=Diaz_Gutierrez_Coop; Integrated Security=true;"
                cn.Open()
                Dim validacion As String = "SELECT * FROM [dbo].[Clientes] WHERE [cli_num_cuenta] = '" + Datos.cli_num_cuenta + " '"
                Dim cmd As New SqlCommand(validacion, cn)
                Dim dr As SqlDataReader = cmd.ExecuteReader
                If dr.Read() Then
                    If dr("cli_contrasenia").ToString = txtAntiagua.Text Then
                        cn.Close()
                        cn.Open()

                        Dim actSaldoCliente1 As String = "UPDATE [dbo].[Clientes]  SET [cli_contrasenia] =  @contra WHERE [cli_num_cuenta] = @cuenta"
                        Dim act1 As SqlCommand = New SqlCommand(actSaldoCliente1, cn)

                        act1.Parameters.AddWithValue("@contra", txtNew1.Text)
                        act1.Parameters.AddWithValue("@cuenta", Datos.cli_num_cuenta)
                        Dim act11 As Integer = act1.ExecuteNonQuery()
                        MessageBox.Show("CONTRASEÑA ACTUALIZADA")
                        Vista.Show()
                        Me.Close()


                    Else
                        MessageBox.Show("CONTRASEÑA ACTUAL INCORRECTA")
                    End If
                End If
                cn.Close()
            Catch exc As Exception
                MessageBox.Show(exc.Message)
            End Try
        Else
            MessageBox.Show("NUEVAS CONTRASEÑAS NO SON IGUALES")
        End If
    End Sub

    
End Class