Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Vista6
    Private cn As SqlConnection
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Close()
        Vista.Show()

    End Sub
    Private Sub Vista6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection
        cn.ConnectionString = "Server=RICI-PC; database=Diaz_Gutierrez_Coop; Integrated Security=true;"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If tieneValor(txtMonto.Text) Then
            Try
                cn.Open()
                Dim validacion As String = "SELECT * FROM [dbo].[Clientes] WHERE [cli_cedula] = '" + txtCedula.Text + " '"
                Dim cmd As New SqlCommand(validacion, cn)
                Dim dr As SqlDataReader = cmd.ExecuteReader
                If dr.Read() Then
                    Datos.cli_num_cuenta_tranferir = dr("cli_num_cuenta").ToString
                    Datos.monto_trasferir = txtMonto.Text
                    Me.Close()
                    Vista7.Show()
                Else
                    MessageBox.Show("Datos Inocrrecto")
                End If
                cn.Close()
            Catch exc As Exception
                MessageBox.Show(exc.Message)
            End Try
        Else
            MessageBox.Show("Con cuenta con esa coantidad")
        End If
        
    End Sub

    Public Function tieneValor(ByVal cantidad As String)
        Dim canExistente As Integer = 0
        Dim canNecesita As Integer = CInt(Int(cantidad))
        Try
            cn.Open()
            Dim validacion As String = "SELECT * FROM [dbo].[Clientes] WHERE [cli_num_cuenta] = '" + Datos.cli_num_cuenta + " '"
            Dim cmd As New SqlCommand(validacion, cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                canExistente = CInt(Int(dr("cli_saldo").ToString))
            End If
            cn.Close()

            If canExistente >= canNecesita Then
                Return True
            Else
                Return False
            End If

        Catch exc As Exception
            MessageBox.Show(exc.Message)
            Return False
        End Try
    End Function

    
End Class