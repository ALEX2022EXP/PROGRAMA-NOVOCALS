Public Class inicio

    Private Sub inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Administrador" And Me.TextBox2.Text = "ALEJANDRO" Then
            Menuu.Show()
        Else
            If ComboBox1.Text = "Usuario" And Me.TextBox2.Text = "1" Then
                Menuu.Show()
                Menuu.MenuStrip1.Enabled = False
            End If
        End If
    End Sub
End Class
