Imports System.Data.OleDb

Public Class bajasproveedor


    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim NL As String = Environment.NewLine

        If (MessageBox.Show("¿DESEAS BORRAR ESTE REGISTRO?" & NL, _
            "ELIMINACION DE REGISTROS", MessageBoxButtons.YesNo, _
            MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            If Me.cmbclave.Text.Length > 0 Then
                Dim ocn As New OleDbConnection
                ocn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ALEX\Desktop\bueno\ZAPATOS3\zapatos\zapatos\Resources\Novoc@lss.accdb;")
                Dim sql As String = "delete from ADMINISTRADOR where CLAVE, CODIGO DEL PRODUCTO, NOMBRE DE LA COMPANIA, TELEFONO, CIUDAD DE ORIGEN = '" & Me.cmbclave.Text & "'"
                Dim ocmd As New OleDbCommand(sql, ocn)
                Dim odr As OleDbDataReader
                ocn.Open()
                odr = ocmd.ExecuteReader()
                odr.Close()
                ocn.Close()
                MessageBox.Show("EL REGISTRO HA SIDO ELIMINADO", "BAJA DE PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                Me.cmbclave.Text = " "
                Me.cmbclave.Focus()

            End If
        Else
            btncancelar.PerformClick()
            Me.cmbclave.Text = ""
            Me.txtcodproducto.Focus()
        End If
    End Sub
End Class