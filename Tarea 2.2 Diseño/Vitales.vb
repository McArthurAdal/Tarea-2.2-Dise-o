Public Class Vitales
    Private Sub Vitales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultorioDBVBDataSet1.VitalesTBL3' table. You can move, or remove it, as needed.
        Me.VitalesTBL3TableAdapter.Fill(Me.ConsultorioDBVBDataSet1.VitalesTBL3)

    End Sub

    Private Sub VitSintomtb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VitSintomtb.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite letras")
        End If
    End Sub

    Private Sub VitDiagtb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VitDiagtb.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite letras")
        End If
    End Sub

    Private Sub VitBuscartb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VitBuscartb.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite letras")
        End If
    End Sub

    Private Sub VitTemptb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VitTemptb.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite numeros")
        End If
    End Sub

    Private Sub VitPresiontb_TextChanged(sender As Object, e As EventArgs) Handles VitPresiontb.TextChanged

    End Sub

    Private Sub VitPresiontb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VitPresiontb.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite numeros")
        End If
    End Sub

    Private Sub VitPesotb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VitPesotb.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite numeros")
        End If
    End Sub

    Private Sub VitAlturatb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VitAlturatb.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite numeros")
        End If
    End Sub

    Private Sub VitPulsotb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VitPulsotb.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite numeros")
        End If
    End Sub

    Private Sub VitAlturatb_TextChanged(sender As Object, e As EventArgs) Handles VitAlturatb.TextChanged

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

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        Hide()
        Dim Obj = New Médico
        Obj.Show()
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        Close()
        Dim Obj = New Login
        Obj.Show()
    End Sub

    Private Sub VitBuscarbt_Click(sender As Object, e As EventArgs) Handles VitBuscarbt.Click
        
    End Sub
End Class