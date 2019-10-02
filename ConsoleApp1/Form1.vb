Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre As String
        nombre = TextBox1.Text
        Console.WriteLine(nombre)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conexion As SqlConnection
        conexion = New SqlConnection("server=localhost;database=clinica;integrated security = true")
        conexion.Open()
        'MsgBox("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos")
        'conexion.Close()
        'MsgBox("Se cerró la conexión.")
        Dim id As Integer
        'id = Convert.ToInt32(TextBox2.Text)


        Dim cadena As String = "select nombre1,apellido1 from paciente"
        Dim comando As SqlCommand
        comando = New SqlCommand(cadena, conexion)
        Dim registros As SqlDataReader
        registros = comando.ExecuteReader()
        Do While registros.Read() = True

            Console.WriteLine(registros("nombre1") & registros("apellido1"))
        Loop
    End Sub
End Class