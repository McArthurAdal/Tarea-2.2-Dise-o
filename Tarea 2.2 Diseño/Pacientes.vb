Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Registro_de_Paciente
    ReadOnly Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ConsultorioDBVB.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Populate()
        Con.Open()
        Dim query = "Select * from PacientesTBL2"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        PacListadgv.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Reset()
        PacNombretb.Text = ""
        PacApellidotb.Text = ""
        PacEdadtb.Text = ""
        PacDirectb.Text = ""
        PacTeleftb.Text = ""
        PacEmailtb.Text = ""
        PacSegurotb.Text = ""
    End Sub
    Private Sub Registro_de_Paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultorioDBVBDataSet1.PacientesTBL2' table. You can move, or remove it, as needed.
        Me.PacientesTBL2TableAdapter.Fill(Me.ConsultorioDBVBDataSet1.PacientesTBL2)
        Populate()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles PacNombrelb.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles PacNombretb.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles PacEmailtb.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles PacDirecclb.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles PacTeleftb.TextChanged

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles PacApellidotb.TextChanged

    End Sub
    Private Sub PacGuardarbt_Click(sender As Object, e As EventArgs) Handles PacGuardarbt.Click
        If PacNombretb.Text = "" Or PacApellidotb.Text = "" Or PacEdadtb.Text = "" Or PacDirectb.Text = "" Or PacTeleftb.Text = "" Or PacEmailtb.Text = "" Or PacSegurotb.Text = "" Or PacSexocb.SelectedIndex = -1 Then
            MsgBox("Información Incompleta")
        Else
            Con.Open()
            Dim query = "insert into PacienteTB1 values('" + PacNombretb.Text + "','" + PacApellidotb.Text + "','" + PacEdadtb.Text + "','" + PacFechaNacdp.Value.Date + "','" + PacSexocb.SelectedItem.ToString() + "','" + PacDirectb.Text + "','" + PacTeleftb.Text + "','" + PacEmailtb.Text + "','" + PacSegurotb.Text + "')"
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Paciente Guardado")
            Con.Close()
            Populate()
            Reset()
        End If
    End Sub

    Private Sub PacListadgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PacListadgv.CellContentClick

    End Sub

    Private Sub PacBorrarbt_Click(sender As Object, e As EventArgs) Handles PacBorrarbt.Click
        If Key = 0 Then
            MsgBox("Información Incompleta")
        Else
            Con.Open()
            Dim query = "Delete from PacienteTB1 where Pid=" & Key & ""
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Paciente Borrado")
            Con.Close()
            Populate()
            Reset()
        End If
    End Sub
    Dim Key = 0
    Private Sub PacListadgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PacListadgv.CellMouseClick
        Dim row As DataGridViewRow = PacListadgv.Rows(e.RowIndex)
        PacNombretb.Text = row.Cells(1).Value.ToString
        PacApellidotb.Text = row.Cells(2).Value.ToString
        PacEdadtb.Text = row.Cells(3).Value.ToString
        PacFechaNacdp.Text = row.Cells(4).Value.ToString
        PacSexocb.SelectedItem = row.Cells(5).Value.ToString
        PacDirectb.Text = row.Cells(6).Value.ToString
        PacTeleftb.Text = row.Cells(7).Value.ToString
        PacEmailtb.Text = row.Cells(8).Value.ToString
        PacSegurotb.Text = row.Cells(9).Value.ToString
        If PacNombretb.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub PacEditarbt_Click(sender As Object, e As EventArgs) Handles PacEditarbt.Click
        If PacNombretb.Text = "" Or PacApellidotb.Text = "" Or PacEdadtb.Text = "" Or PacDirectb.Text = "" Or PacTeleftb.Text = "" Or PacEmailtb.Text = "" Or PacSegurotb.Text = "" Or PacSexocb.SelectedIndex = -1 Then
            MsgBox("Información Incompleta")
        Else
            Con.Open()
            Dim query = "Update PacienteTB1 set PNom= '" & PacNombretb.Text & "',PApell='" & PacApellidotb.Text & "',PEdad='" & PacEdadtb.Text & "',PFecha='" & PacFechaNacdp.Value.Date & "',PSexo='" & PacSexocb.SelectedItem.ToString & "',PDirec='" & PacDirectb.Text & "',PTele='" & PacTeleftb.Text & "',PEmail='" & PacEmailtb.Text & "',PSeguro='" & PacSegurotb.Text & "' where PId=" & Key & " "
            Dim cmd As New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Paciente Actualizado")
            Con.Close()
            Populate()
            Reset()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles CitasIconlb.Click
        Me.Hide()
        Dim Obj = New Citas
        Obj.Show()
    End Sub

    Private Sub MedicoIconlb_Click(sender As Object, e As EventArgs) Handles MedicoIconlb.Click
        Me.Hide()
        Dim Obj = New Médico
        Obj.Show()
    End Sub

    Private Sub VitalesIconlb_Click(sender As Object, e As EventArgs) Handles VitalesIconlb.Click
        Me.Hide()
        Dim Obj = New Vitales
        Obj.Show()
    End Sub

    Private Sub PacTeleftb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PacTeleftb.KeyPress

    End Sub

    Private Sub PacNombretb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PacNombretb.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite letras")
        End If
    End Sub

    Private Sub PacApellidotb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PacApellidotb.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite letras")
        End If
    End Sub

    Private Sub PacBusquedatb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PacBusquedatb.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite letras")
        End If
    End Sub

    Private Sub PacEdadtb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PacEdadtb.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Solo se permite numeros")
        End If
    End Sub

    Private Sub PacFechaNacdp_Validating(sender As Object, e As CancelEventArgs) Handles PacFechaNacdp.Validating
        If PacFechaNacdp.Value > DateTime.Now.ToShortDateString Then
            MessageBox.Show("Porfavor selecionar una fecha correcta")
            e.Cancel = True
        End If
    End Sub

    Private Sub Registro_de_Paciente_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validating

    End Sub

    Private Sub PacBusquedabt_Click(sender As Object, e As EventArgs) Handles PacBusquedabt.Click
        Dim nombre = Me.PacBusquedatb.Text
        If nombre <> "" Then
            Populate()
        End If


    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Me.Close()
        Dim Obj = New Login
        Obj.Show()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Close()
        Dim Obj = New Login
        Obj.Show()
    End Sub

    Private Sub PacFechaNacdp_ValueChanged(sender As Object, e As EventArgs) Handles PacFechaNacdp.ValueChanged

    End Sub
End Class

Class ConsultorioDBVBDataSet
End Class
