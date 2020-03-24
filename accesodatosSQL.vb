Imports System.Data.SqlClient
Public Class accesodatosSQL

    Private Shared conexion As New SqlConnection
    Private Shared comando As New SqlCommand
    Public Shared Function conectar() As String
        Try
            ' conexion.ConnectionString = “Data Source=tcp:hadsg12a.database.windows.net,1433;Initial Catalog=HADSG12;User ID=xabipersonape@gmail.com@hadsg12a;Password=RM3D2kt6"
            conexion.ConnectionString = "Data Source=tcp : hads.database.windows.net, 1433;Initial Catalog=Amigos;Persist Security Info=False;User ID=vadillo@ehu.es@hads;Password=curso19-20;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30"


            conexion.Open()
        Catch ex As Exception
            Return "ERROR DE CONEXIÓN: " + ex.Message
        End Try
        Return "CONEXION OK"
    End Function

    Public Shared Function getConexion() As SqlConnection
        Return conexion
    End Function
    Public Shared Sub cerrarConexion()
        conexion.Close()
    End Sub

    Public Shared Function Registrar(ByVal nombre As String, ByVal apellidos As String, ByVal email As String, ByVal tipo As String,
                                    ByVal pass As String, ByVal numconfir As Integer, ByVal codpass As Integer, ByVal confirmado As Integer
                                    ) As String
        Dim st = "insert into Usuarios (email, nombre, apellidos, numconfir, confirmado, tipo, pass, codpass) 
        values ('" & email & "','" & nombre & "','" & apellidos & "','" & numconfir & "','" & confirmado & "','" & tipo & "',
        '" & pass & "', '" & codpass & "')"

        Dim numregs As Integer
        comando = New SqlCommand(st, conexion)
        Try
            numregs = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try
        Return (numregs & " registro insertado en la base de datos")
    End Function

    Public Shared Function CambiarEstado(ByVal email As String) As String
        Dim st = "update Usuarios set confirmado='1' where email='" & email & "'"
        Dim numregs As Integer
        comando = New SqlCommand(st, conexion)
        Try
            numregs = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try
        Return ("estado de usuario cambiado en la base de datos, ahora su valor es")
    End Function

    Public Shared Function Login(ByVal email As String, ByRef pass As String) As SqlDataReader
        Dim st = "select * from Usuarios where email='" & email & "' and pass='" & pass & "'"
        comando = New SqlCommand(st, conexion)
        Try
            Return comando.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Shared Function CambiarPass(ByVal codpass As Integer, ByVal email As String, ByVal pass As String) As String
        Dim st = "select codpass from Usuarios where email='" & email & "'"

        comando = New SqlCommand(st, conexion)
        Try
            Dim codigo = comando.ExecuteReader()
            If (codigo.Read.Equals(codpass)) Then
                Dim ch = "Update Usuarios set pass='" & pass & "' where email='" & email & "'"
                comando = New SqlCommand(ch, conexion)
                comando.ExecuteNonQuery()
                Dim m = MsgBox("La contraseña se ha cambiado con exito")
            End If
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Public Shared Function EstaRegistrado(ByVal email As String) As Boolean
        Dim st = "select count(*) from Usuarios where email='" & email & "'"
        comando = New SqlCommand(st, conexion)
        If comando.ExecuteScalar = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function TipoUsuario(ByVal email As String) As String
        Dim st = "select tipo from Usuarios where email='" & email & "'"
        comando = New SqlCommand(st, conexion)
        Try
            Dim tipo = comando.ExecuteReader()
            If (tipo.Read.Equals("Profesor")) Then
                Return "Profesor"
            ElseIf (tipo.Read.Equals("Alumno")) Then
                Return "Alumno"

            End If
        Catch ex As Exception
            MsgBox("")

        End Try


    End Function

End Class