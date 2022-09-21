Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub accederbt_Click(sender As Object, e As EventArgs) Handles accederbt.Click
        If Nombreusuariotb.Text = "" Or Contrasenatb.Text = "" Then
            MsgBox("Entre el Nombre de usuario y contraseña")
        ElseIf Nombreusuariotb.Text = "Admin" And Contrasenatb.Text = "Password" Then
            Me.Hide()
            Dim Obj = New Citas
            Obj.Show()
        Else
            MsgBox("Nombre de usuario y Contraseña incorrecta")
        End If
    End Sub

    Private Sub Nombreusuariotb_TextChanged(sender As Object, e As EventArgs) Handles Nombreusuariotb.TextChanged

    End Sub
End Class
