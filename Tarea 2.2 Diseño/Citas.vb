Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Citas
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ConsultorioDBVB.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CitDentalcb.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CitPediatrachb.CheckedChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CitBorrarbt.Click

    End Sub

    Private Sub CitGuardarbt_Click(sender As Object, e As EventArgs) Handles CitGuardarbt.Click
        Dim TipoCita As String
        TipoCita = ""
        If CitEnferchb.Checked = True Then
            TipoCita = "Enfermería"
        End If
        If CitPediatrachb.Checked = True Then
            TipoCita = "Pediatría"
        End If
        If CitMedicinachb.Checked = True Then
            TipoCita = "Medicina Familiar"
        End If
        If CitSaludcb.Checked = True Then
            TipoCita = "Salud Mental"
        End If
        If CitOdontologiacb.Checked = True Then
            TipoCita = "Odontología"
        End If
        If CitDentalcb.Checked = True Then
            TipoCita = "Dental"
        Else MessageBox.Show("Por favor escoja el tipo de cita")
        End If
    End Sub

    Private Sub Citas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Citbuscartb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Citbuscartb.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite letras")
        End If
    End Sub

    Private Sub Citas_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating
        If CitFechadp.Value < DateTime.Now.ToShortDateString Then
            MessageBox.Show("Porfavor selecionar una fecha correcta")
            e.Cancel = True
        End If
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Hide()
        Dim Obj = New Registro_de_Paciente
        Obj.Show()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        Hide()
        Dim Obj = New Médico
        Obj.Show()
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        Hide()
        Dim Obj = New Vitales
        Obj.Show()
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        Close()
        Dim Obj = New Login
        Obj.Show()
    End Sub
End Class