Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Vista5
    Private cn As SqlConnection
    Private dsgrid As DataSet
    Private dagrid As SqlDataAdapter
    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Me.Close()
        Vista.Show()
    End Sub

    Private Sub Vista5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            cn = New SqlConnection
            cn.ConnectionString = "Server=RICI-PC; database=Diaz_Gutierrez_Coop; Integrated Security=true;"
            Dim validacion As String = "SELECT * FROM [dbo].[Movimientos] WHERE [mov_cli_num_cuenta] = '" + Datos.cli_num_cuenta + " '"
            Dim cmd As New SqlCommand(validacion, cn)
            dagrid = New SqlDataAdapter
            dagrid.SelectCommand = cmd
            dsgrid = New DataSet
            dsgrid.Clear()
            cn.Open()
            dagrid.Fill(dsgrid, "Movimientos")
            cn.Close()
            Me.tabla.DataSource = dsgrid
            Me.tabla.DataMember = "Movimientos"

        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub
End Class