Public Class Médico
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Médico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultorioDBVBDataSet1.MedicoTBL4' table. You can move, or remove it, as needed.
        Me.MedicoTBL4TableAdapter.Fill(Me.ConsultorioDBVBDataSet1.MedicoTBL4)

    End Sub

    Private Sub MedNombretb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MedNombretb.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite letras")
        End If
    End Sub

    Private Sub MedApellidotb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MedApellidotb.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite letras")
        End If
    End Sub

    Private Sub MedEspectb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MedEspectb.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite letras")
        End If
    End Sub

    Private Sub MedBuscartb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MedBuscartb.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite letras")
        End If
    End Sub

    Private Sub MedLicensiatb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MedLicensiatb.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite numeros")
        End If
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        Close()
        Dim Obj = New Login
        Obj.Show()

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Hide()
        Dim Obj = New Registro_de_Paciente
        Obj.Show()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Hide()
        Dim Obj = New Citas
        Obj.Show()
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        Hide()
        Dim Obj = New Vitales
        Obj.Show()
    End Sub
End Class