Imports System.Data.OleDb

Public Class altasusuario


    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        Dim oConn As New OleDbConnection
        Dim oComn As New OleDbCommand
        Dim oData As OleDbDataReader 'Cadena de informaciòn para conectarse a la base de datos
        oConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ALEX\Desktop\bueno\ZAPATOS3\zapatos\zapatos\Resources\Novoc@lss.accdb;"


        Try 'Abrir base de datos 

            oConn.Open()
            'Cadena de texto que tiene la sentencia SQL para consultar el usuario que se quiere loguear




            oComn.CommandText = "INSERT INTO USUARIOS (NOMBRE) VALUES ( '" + txtnombre.Text + "')"
            'Asigna la conexion al comando de la consulta
            oComn.Connection = oConn 'Ejecutar la consulta SQL
            oData = oComn.ExecuteReader()
            MsgBox("Producto creado") 'Cerramos a conexion a la base de datos
            oConn.Close()
            btncancelar.PerformClick()
        Catch ex As Exception
            MessageBox.Show("DATOS GUARDADOS", "ALTA DE USUARIOS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub altasusuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class