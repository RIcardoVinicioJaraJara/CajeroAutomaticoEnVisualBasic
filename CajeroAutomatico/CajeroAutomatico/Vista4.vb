Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Vista4
    Private cn As SqlConnection

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Close()
        Vista.Show()

    End Sub

    Private Sub Vista4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       Try
            cn = New SqlConnection
            cn.ConnectionString = "Server=RICI-PC; database=Diaz_Gutierrez_Coop; Integrated Security=true;"
            cn.Open()
            Dim validacion As String = "SELECT * FROM [dbo].[Clientes] WHERE [cli_num_cuenta] = '" + Datos.cli_num_cuenta + " '"
            Dim cmd As New SqlCommand(validacion, cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                lblNumero.Text = dr("cli_num_cuenta").ToString
                lblCedula.Text = dr("cli_cedula").ToString
                lblNombre.Text = dr("cli_nombre").ToString
                lblApellido.Text = dr("cli_apellido").ToString
                lblCelular.Text = dr("cli_celular").ToString
                lblDireccion.Text = dr("cli_direccion").ToString
                lblSaldo.Text = dr("cli_saldo").ToString

            End If
            cn.Close()
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub
End Class