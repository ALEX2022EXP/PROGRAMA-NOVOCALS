Imports System.Data.OleDb

Public Class bajasusuario

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim NL As String = Environment.NewLine

        If (MessageBox.Show("¿DESEAS BORRAR ESTE REGISTRO?" & NL, _
            "ELIMINACION DE REGISTROS", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            If Me.cmbnombre.Text.Length > 0 Then
                Dim ocn As New OleDbConnection
                ocn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ALEX\Desktop\bueno\ZAPATOS3\zapatos\zapatos\Resources\Novoc@lss.accdb;")
                Dim sql As String = "delete from ADMINISTRADOR where NOMBRE = '" & Me.cmbnombre.Text & "'"
                Dim ocmd As New OleDbCommand(sql, ocn)
                Dim odr As OleDbDataReader
                ocn.Open()
                odr = ocmd.ExecuteReader()
                odr.Close()
                ocn.Close()
                MessageBox.Show("EL REGISTRO HA SIDO ELIMINADO", "BAJA DE USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                Me.cmbnombre.Text = " "
                Me.cmbnombre.Focus()

            End If
        Else
            btncancelar.PerformClick()
            Me.cmbnombre.Text = ""
            Me.cmbnombre.Focus()
        End If
    End Sub
End Class