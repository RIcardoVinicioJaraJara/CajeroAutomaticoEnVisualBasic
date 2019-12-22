Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Vista7
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
            Dim validacion As String = "SELECT * FROM [dbo].[Clientes] WHERE [cli_num_cuenta] = '" + Datos.cli_num_cuenta_tranferir + " '"
            Dim cmd As New SqlCommand(validacion, cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                txtMensaje.Text = "Esta seguro de trasnferir: " + Datos.monto_trasferir + "  a:"

                lblCedula.Text = dr("cli_cedula").ToString
                lblNombre.Text = dr("cli_nombre").ToString
                lblApellido.Text = dr("cli_apellido").ToString
                lblCelular.Text = dr("cli_celular").ToString
                lblDireccion.Text = dr("cli_direccion").ToString

            End If
            cn.Close()
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            cn.Open()
            Dim getId As String = "SELECT MAX(mov_num_registro)+1 as id FROM [dbo].[Movimientos]"
            Dim cmd As New SqlCommand(getId, cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                Datos.max_movimientos = dr("id").ToString
            End If
            cn.Close()

            cn.Open()

            Dim salirMovimiento As String = "insert into [dbo].[Movimientos] values(@id,@fecha,'Transaccion salida',@catidada,@documento,@numcuenta)"
            Dim cmd1 As SqlCommand = New SqlCommand(salirMovimiento, cn)

            cmd1.Parameters.AddWithValue("@id", Datos.max_movimientos)
            cmd1.Parameters.AddWithValue("@fecha", Date.Now.Date)
            cmd1.Parameters.AddWithValue("@catidada", Datos.monto_trasferir)
            cmd1.Parameters.AddWithValue("@documento", "CAJ" + Datos.cli_num_cuenta)
            cmd1.Parameters.AddWithValue("@numcuenta", Datos.cli_num_cuenta)
            Dim cant As Integer = cmd1.ExecuteNonQuery()
            cn.Close()


            cn.Open()
            Dim getId1 As String = "SELECT MAX(mov_num_registro)+1 as id FROM [dbo].[Movimientos]"
            Dim cmd3 As New SqlCommand(getId, cn)
            Dim dr3 As SqlDataReader = cmd3.ExecuteReader
            If dr3.Read() Then
                Datos.max_movimientos = dr3("id").ToString
            End If
            cn.Close()

            cn.Open()
            Dim ingresarMovimiento As String = "insert into [dbo].[Movimientos] values(@id,@fecha,'Transaccion Ingreso',@catidada,@documento,@numcuenta)"
            Dim cmd2 As SqlCommand = New SqlCommand(ingresarMovimiento, cn)

            cmd2.Parameters.AddWithValue("@id", Datos.max_movimientos)
            cmd2.Parameters.AddWithValue("@fecha", Date.Now.Date)
            cmd2.Parameters.AddWithValue("@catidada", Datos.monto_trasferir)
            cmd2.Parameters.AddWithValue("@documento", "CAJ" + Datos.cli_num_cuenta)
            cmd2.Parameters.AddWithValue("@numcuenta", Datos.cli_num_cuenta_tranferir)

            Dim cant1 As Integer = cmd2.ExecuteNonQuery()
            cn.Close()

            cn.Open()
            Dim actSaldoCliente1 As String = "UPDATE [dbo].[Clientes]  SET [cli_saldo] = [cli_saldo] - @cantidad WHERE [cli_num_cuenta] = @cuenta"
            Dim act1 As SqlCommand = New SqlCommand(actSaldoCliente1, cn)

            act1.Parameters.AddWithValue("@cantidad", Datos.monto_trasferir)
            act1.Parameters.AddWithValue("@cuenta", Datos.cli_num_cuenta)
            Dim act11 As Integer = act1.ExecuteNonQuery()
            cn.Close()

            cn.Open()
            Dim actSaldoCliente2 As String = "UPDATE [dbo].[Clientes]  SET [cli_saldo] = [cli_saldo] + @cantidad WHERE [cli_num_cuenta] = @cuenta"
            Dim act2 As SqlCommand = New SqlCommand(actSaldoCliente2, cn)

            act2.Parameters.AddWithValue("@cantidad", Datos.monto_trasferir)
            act2.Parameters.AddWithValue("@cuenta", Datos.cli_num_cuenta_tranferir)
            Dim act12 As Integer = act2.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("Transaccion Existosa")
            Me.Close()
            Vista.Show()

        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub
End Class