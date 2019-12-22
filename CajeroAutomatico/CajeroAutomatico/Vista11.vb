Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Vista11
    Private cn As SqlConnection

    Private Sub Vista11_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = "Server=RICI-PC; database=Diaz_Gutierrez_Coop; Integrated Security=true;"
    End Sub


    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If retirarDinero(10) Then
            MessageBox.Show("Pago realizado")
            Me.Close()
            Vista.Show()
        End If
    End Sub
    Public Function maxIdMovimiento()
        Try
            cn.Open()
            Dim getId As String = "SELECT MAX(mov_num_registro)+1 as id FROM [dbo].[Movimientos]"
            Dim cmd As New SqlCommand(getId, cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                Datos.max_movimientos = dr("id").ToString
            End If
            cn.Close()
            Return True
        Catch exc As Exception
            MessageBox.Show(exc.Message)
            Return False
        End Try
    End Function

    Public Function maxIdServicios()
        Try
            cn.Open()
            Dim getId As String = "SELECT MAX(ser_codigo_servicio)+1 as id FROM [dbo].[Servicios]"
            Dim cmd As New SqlCommand(getId, cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                Datos.max_servicios = dr("id").ToString
            End If
            cn.Close()
            Return True
        Catch exc As Exception
            MessageBox.Show(exc.Message)
            Return False
        End Try
    End Function

    Public Function retirarDinero(ByVal cantidad As String)
        maxIdMovimiento()
        maxIdServicios()
        Try
            cn.Open()
            Dim salirMovimiento As String = "insert into [dbo].[Movimientos] values(@id,@fecha,'PAGO AGUA',@catidada,@documento,@numcuenta)"
            Dim cmd1 As SqlCommand = New SqlCommand(salirMovimiento, cn)
            cmd1.Parameters.AddWithValue("@id", Datos.max_movimientos)
            cmd1.Parameters.AddWithValue("@fecha", Date.Now.Date)
            cmd1.Parameters.AddWithValue("@catidada", "10")
            cmd1.Parameters.AddWithValue("@documento", "AGU" + Datos.cli_num_cuenta)
            cmd1.Parameters.AddWithValue("@numcuenta", Datos.cli_num_cuenta)
            Dim cant As Integer = cmd1.ExecuteNonQuery()
            cn.Close()

            cn.Open()
            Dim servicio As String = "insert into [dbo].[Servicios] values(@id,'AGUA',@documento,@numcuenta)"
            Dim cmd2 As SqlCommand = New SqlCommand(servicio, cn)
            cmd2.Parameters.AddWithValue("@id", Datos.max_servicios)
            cmd2.Parameters.AddWithValue("@documento", "AGU" + Datos.cli_num_cuenta)
            cmd2.Parameters.AddWithValue("@numcuenta", Datos.cli_num_cuenta)
            Dim cant1 As Integer = cmd2.ExecuteNonQuery()
            cn.Close()

            cn.Open()
            Dim actSaldoCliente1 As String = "UPDATE [dbo].[Clientes]  SET [cli_saldo] = [cli_saldo] - @cantidad WHERE [cli_num_cuenta] = @cuenta"
            Dim act1 As SqlCommand = New SqlCommand(actSaldoCliente1, cn)

            act1.Parameters.AddWithValue("@cantidad", "10")
            act1.Parameters.AddWithValue("@cuenta", Datos.cli_num_cuenta)
            Dim act11 As Integer = act1.ExecuteNonQuery()
            cn.Close()
            
            Return True
        Catch exc As Exception
            MessageBox.Show(exc.Message)
            Return False
        End Try
    End Function

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click

    End Sub

    Private Sub txtMensaje_Click(sender As System.Object, e As System.EventArgs) Handles txtMensaje.Click

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
End Class