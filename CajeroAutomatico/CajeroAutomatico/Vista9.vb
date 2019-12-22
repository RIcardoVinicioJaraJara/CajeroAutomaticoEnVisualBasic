Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Vista9
    Private cn As SqlConnection

    Private Sub Vista9_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            cn = New SqlConnection
            cn.ConnectionString = "Server=RICI-PC; database=Diaz_Gutierrez_Coop; Integrated Security=true;"
            cn.Open()
            cn.Close()
        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try

    End Sub
    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Vista.Show()
        Me.Close()

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If billetesCinco(5) Then
            If tieneValor("5") Then
                If retirarDinero("5") Then
                    DesglosaBilletes(5)
                    Me.Close()
                    Vista.Show()

                Else
                    MessageBox.Show("ERROR AL RETIRAR")
                End If
            Else
                MessageBox.Show("No cuenta con esa cantidad")
            End If

        Else
            MessageBox.Show("No se puede retirar esta cantidad, Ingrese una cantidad de 5")
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
    Public Function retirarDinero(ByVal cantidad As String)
        maxIdMovimiento()
        Try
            cn.Open()
            Dim salirMovimiento As String = "insert into [dbo].[Movimientos] values(@id,@fecha,'Retiro',@catidada,@documento,@numcuenta)"
            Dim cmd1 As SqlCommand = New SqlCommand(salirMovimiento, cn)
            cmd1.Parameters.AddWithValue("@id", Datos.max_movimientos)
            cmd1.Parameters.AddWithValue("@fecha", Date.Now.Date)
            cmd1.Parameters.AddWithValue("@catidada", cantidad)
            cmd1.Parameters.AddWithValue("@documento", "RET" + Datos.cli_num_cuenta)
            cmd1.Parameters.AddWithValue("@numcuenta", Datos.cli_num_cuenta)
            Dim cant As Integer = cmd1.ExecuteNonQuery()
            cn.Close()

            cn.Open()
            Dim actSaldoCliente1 As String = "UPDATE [dbo].[Clientes]  SET [cli_saldo] = [cli_saldo] - @cantidad WHERE [cli_num_cuenta] = @cuenta"
            Dim act1 As SqlCommand = New SqlCommand(actSaldoCliente1, cn)

            act1.Parameters.AddWithValue("@cantidad", cantidad)
            act1.Parameters.AddWithValue("@cuenta", Datos.cli_num_cuenta)
            Dim act11 As Integer = act1.ExecuteNonQuery()
            cn.Close()

            Return True
        Catch exc As Exception
            MessageBox.Show(exc.Message)
            Return False
        End Try
    End Function
    Public Function billetesCinco(ByVal cantidad As Integer)
        Dim res As Integer = cantidad Mod 5
        If res = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

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
    Function DesglosaBilletes(ByVal cantidad As Integer)
        Dim b5 As Integer = 0
        Dim b10 As Integer = 0
        Dim b20 As Integer = 0
        Dim b50 As Integer = 0
        Dim suma As Integer = 0
        Dim billete As Integer = 50

        While suma <= cantidad

            If suma + billete > cantidad Then
                billete = 20
            End If

            If suma + billete > cantidad Then
                billete = 10
            End If

            If suma + billete > cantidad Then
                billete = 5
            End If

            If suma + 5 > cantidad Then
                billete = 4
            End If


            If billete = 50 Then
                b50 = b50 + 1
                suma = suma + 50
            End If

            If billete = 20 Then
                b20 = b20 + 1
                suma = suma + 20
            End If

            If billete = 10 Then
                b10 = b10 + 1
                suma = suma + 10
            End If

            If billete = 5 Then
                b5 = b5 + 1
                suma = suma + 5
            End If

            If billete = 4 Then
                suma = cantidad + 1
            End If

        End While
        MessageBox.Show("Saldran: " & vbNewLine & " " + b50.ToString() + " Billetes de 50" & vbNewLine & " " + b20.ToString() + " Billetes de 20" & vbNewLine & " " + b10.ToString() + " Billetes de 10" & vbNewLine & " " + b5.ToString() + " Billetes de 5")
        Return True
    End Function

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If billetesCinco(10) Then
            If tieneValor("10") Then
                If retirarDinero("10") Then
                    DesglosaBilletes(10)
                    Me.Close()
                    Vista.Show()

                Else
                    MessageBox.Show("ERROR AL RETIRAR")
                End If
            Else
                MessageBox.Show("No cuenta con esa cantidad")
            End If

        Else
            MessageBox.Show("No se puede retirar esta cantidad, Ingrese una cantidad de 5")
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If billetesCinco(15) Then
            If tieneValor("15") Then
                If retirarDinero("15") Then
                    DesglosaBilletes(15)
                    Me.Close()
                    Vista.Show()

                Else
                    MessageBox.Show("ERROR AL RETIRAR")
                End If
            Else
                MessageBox.Show("No cuenta con esa cantidad")
            End If

        Else
            MessageBox.Show("No se puede retirar esta cantidad, Ingrese una cantidad de 5")
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If billetesCinco(20) Then
            If tieneValor("20") Then
                If retirarDinero("20") Then
                    DesglosaBilletes(20)
                    Me.Close()
                    Vista.Show()

                Else
                    MessageBox.Show("ERROR AL RETIRAR")
                End If
            Else
                MessageBox.Show("No cuenta con esa cantidad")
            End If

        Else
            MessageBox.Show("No se puede retirar esta cantidad, Ingrese una cantidad de 5")
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If billetesCinco(25) Then
            If tieneValor("25") Then
                If retirarDinero("25") Then
                    DesglosaBilletes(25)
                    Me.Close()
                    Vista.Show()

                Else
                    MessageBox.Show("ERROR AL RETIRAR")
                End If
            Else
                MessageBox.Show("No cuenta con esa cantidad")
            End If

        Else
            MessageBox.Show("No se puede retirar esta cantidad, Ingrese una cantidad de 5")
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If billetesCinco(30) Then
            If tieneValor("30") Then
                If retirarDinero("30") Then
                    DesglosaBilletes(30)
                    Me.Close()
                    Vista.Show()

                Else
                    MessageBox.Show("ERROR AL RETIRAR")
                End If
            Else
                MessageBox.Show("No cuenta con esa cantidad")
            End If

        Else
            MessageBox.Show("No se puede retirar esta cantidad, Ingrese una cantidad de 5")
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If billetesCinco(CInt(txtMonto.Text)) Then
            If tieneValor(CInt(txtMonto.Text)) Then
                If retirarDinero(CInt(txtMonto.Text)) Then
                    DesglosaBilletes(txtMonto.Text)
                    Me.Close()
                    Vista.Show()

                Else
                    MessageBox.Show("ERROR AL RETIRAR")
                End If
            Else
                MessageBox.Show("No cuenta con esa cantidad")
            End If

        Else
            MessageBox.Show("No se puede retirar esta cantidad, Ingrese una cantidad de 5")
        End If
    End Sub
End Class