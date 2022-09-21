<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Citas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Citas))
        Me.Cittitulolb = New System.Windows.Forms.Label()
        Me.CitPacientelb = New System.Windows.Forms.Label()
        Me.CitPacientecb = New System.Windows.Forms.ComboBox()
        Me.CitDoctorlb = New System.Windows.Forms.Label()
        Me.CitFechalb = New System.Windows.Forms.Label()
        Me.CitDoctorcb = New System.Windows.Forms.ComboBox()
        Me.CitTipolb = New System.Windows.Forms.Label()
        Me.CitMedicinachb = New System.Windows.Forms.CheckBox()
        Me.CitOdontologiacb = New System.Windows.Forms.CheckBox()
        Me.CitPediatrachb = New System.Windows.Forms.CheckBox()
        Me.CitDentalcb = New System.Windows.Forms.CheckBox()
        Me.CitEnferchb = New System.Windows.Forms.CheckBox()
        Me.CitSaludcb = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CitBorrarbt = New System.Windows.Forms.Button()
        Me.CitGuardarbt = New System.Windows.Forms.Button()
        Me.CitEditarbt = New System.Windows.Forms.Button()
        Me.CitFechadp = New System.Windows.Forms.DateTimePicker()
        Me.CitHoratp = New System.Windows.Forms.DateTimePicker()
        Me.CitHoralb = New System.Windows.Forms.Label()
        Me.CitListadgv = New System.Windows.Forms.DataGridView()
        Me.Citbuscarlb = New System.Windows.Forms.Label()
        Me.Citbuscarbt = New System.Windows.Forms.Button()
        Me.Citbuscartb = New System.Windows.Forms.TextBox()
        Me.CitImprimirbt = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CitListadgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cittitulolb
        '
        Me.Cittitulolb.AutoSize = True
        Me.Cittitulolb.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cittitulolb.Location = New System.Drawing.Point(176, 6)
        Me.Cittitulolb.Name = "Cittitulolb"
        Me.Cittitulolb.Size = New System.Drawing.Size(231, 29)
        Me.Cittitulolb.TabIndex = 0
        Me.Cittitulolb.Text = "Citas de Pacientes"
        '
        'CitPacientelb
        '
        Me.CitPacientelb.AutoSize = True
        Me.CitPacientelb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitPacientelb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.CitPacientelb.Location = New System.Drawing.Point(362, 50)
        Me.CitPacientelb.Name = "CitPacientelb"
        Me.CitPacientelb.Size = New System.Drawing.Size(97, 24)
        Me.CitPacientelb.TabIndex = 1
        Me.CitPacientelb.Text = "Paciente:"
        '
        'CitPacientecb
        '
        Me.CitPacientecb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitPacientecb.FormattingEnabled = True
        Me.CitPacientecb.Items.AddRange(New Object() {"AD", "AE", "AF", "AG", "AI", "AL", "AM", "AN", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AZ", "BA", "BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BM", "BN", "BO", "BR", "BT", "BS", "BV", "BW", "BY", "BZ", "CA", "CC", "CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO", "CR", "CS", "CU", "CV", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM", "DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI", "FJ", "FK", "FM", "FO", "FR", "GA", "GD", "GE", "GF", "GG", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS", "GT", "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU", "ID", "IE", "IL", "IM", "IN", "IO", "IQ", "IR", "IS", "IT", "JM", "JE", "JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR", "KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS", "LT", "LU", "LV", "LY", "MA", "MC", "MD", "MG", "MK", "MH", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG", "NI", "NL", "NO", "NP", "NR", "NT", "NU", "NZ", "OM", "PA", "PE", "PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PS", "PT", "PW", "PY", "QA", "RE", "RO", "RU", "RW", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SR", "SU", "ST", "SV", "SY", "SZ", "TC", "TD", "TF", "TG", "TH", "TJ", "TK", "TM", "TN", "TO", "TP", "TR", "TT", "TV", "TW", "TZ", "UA", "UG", "UK", "UM", "US", "UY", "UZ", "VA", "VC", "VE", "VG", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "YU", "ZA", "ZM", "ZR", "ZW"})
        Me.CitPacientecb.Location = New System.Drawing.Point(308, 77)
        Me.CitPacientecb.Name = "CitPacientecb"
        Me.CitPacientecb.Size = New System.Drawing.Size(251, 28)
        Me.CitPacientecb.TabIndex = 29
        Me.CitPacientecb.Text = "Elegir"
        '
        'CitDoctorlb
        '
        Me.CitDoctorlb.AutoSize = True
        Me.CitDoctorlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitDoctorlb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.CitDoctorlb.Location = New System.Drawing.Point(689, 50)
        Me.CitDoctorlb.Name = "CitDoctorlb"
        Me.CitDoctorlb.Size = New System.Drawing.Size(77, 24)
        Me.CitDoctorlb.TabIndex = 30
        Me.CitDoctorlb.Text = "Doctor:"
        '
        'CitFechalb
        '
        Me.CitFechalb.AutoSize = True
        Me.CitFechalb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitFechalb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.CitFechalb.Location = New System.Drawing.Point(344, 123)
        Me.CitFechalb.Name = "CitFechalb"
        Me.CitFechalb.Size = New System.Drawing.Size(143, 24)
        Me.CitFechalb.TabIndex = 33
        Me.CitFechalb.Text = "Fecha de cita:"
        '
        'CitDoctorcb
        '
        Me.CitDoctorcb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitDoctorcb.FormattingEnabled = True
        Me.CitDoctorcb.Items.AddRange(New Object() {"AD", "AE", "AF", "AG", "AI", "AL", "AM", "AN", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AZ", "BA", "BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BM", "BN", "BO", "BR", "BT", "BS", "BV", "BW", "BY", "BZ", "CA", "CC", "CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO", "CR", "CS", "CU", "CV", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM", "DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI", "FJ", "FK", "FM", "FO", "FR", "GA", "GD", "GE", "GF", "GG", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS", "GT", "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU", "ID", "IE", "IL", "IM", "IN", "IO", "IQ", "IR", "IS", "IT", "JM", "JE", "JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR", "KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS", "LT", "LU", "LV", "LY", "MA", "MC", "MD", "MG", "MK", "MH", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG", "NI", "NL", "NO", "NP", "NR", "NT", "NU", "NZ", "OM", "PA", "PE", "PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PS", "PT", "PW", "PY", "QA", "RE", "RO", "RU", "RW", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SR", "SU", "ST", "SV", "SY", "SZ", "TC", "TD", "TF", "TG", "TH", "TJ", "TK", "TM", "TN", "TO", "TP", "TR", "TT", "TV", "TW", "TZ", "UA", "UG", "UK", "UM", "US", "UY", "UZ", "VA", "VC", "VE", "VG", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "YU", "ZA", "ZM", "ZR", "ZW"})
        Me.CitDoctorcb.Location = New System.Drawing.Point(612, 77)
        Me.CitDoctorcb.Name = "CitDoctorcb"
        Me.CitDoctorcb.Size = New System.Drawing.Size(251, 28)
        Me.CitDoctorcb.TabIndex = 41
        Me.CitDoctorcb.Text = "Elegir"
        '
        'CitTipolb
        '
        Me.CitTipolb.AutoSize = True
        Me.CitTipolb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitTipolb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.CitTipolb.Location = New System.Drawing.Point(503, 188)
        Me.CitTipolb.Name = "CitTipolb"
        Me.CitTipolb.Size = New System.Drawing.Size(126, 24)
        Me.CitTipolb.TabIndex = 42
        Me.CitTipolb.Text = "Tipo de cita:"
        '
        'CitMedicinachb
        '
        Me.CitMedicinachb.AutoSize = True
        Me.CitMedicinachb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitMedicinachb.Location = New System.Drawing.Point(507, 228)
        Me.CitMedicinachb.Name = "CitMedicinachb"
        Me.CitMedicinachb.Size = New System.Drawing.Size(149, 20)
        Me.CitMedicinachb.TabIndex = 43
        Me.CitMedicinachb.Text = "Medicina Familiar"
        Me.CitMedicinachb.UseVisualStyleBackColor = True
        '
        'CitOdontologiacb
        '
        Me.CitOdontologiacb.AutoSize = True
        Me.CitOdontologiacb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitOdontologiacb.Location = New System.Drawing.Point(775, 228)
        Me.CitOdontologiacb.Name = "CitOdontologiacb"
        Me.CitOdontologiacb.Size = New System.Drawing.Size(111, 20)
        Me.CitOdontologiacb.TabIndex = 44
        Me.CitOdontologiacb.Text = "Odontología"
        Me.CitOdontologiacb.UseVisualStyleBackColor = True
        '
        'CitPediatrachb
        '
        Me.CitPediatrachb.AutoSize = True
        Me.CitPediatrachb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitPediatrachb.Location = New System.Drawing.Point(293, 274)
        Me.CitPediatrachb.Name = "CitPediatrachb"
        Me.CitPediatrachb.Size = New System.Drawing.Size(89, 20)
        Me.CitPediatrachb.TabIndex = 45
        Me.CitPediatrachb.Text = "Pediatría"
        Me.CitPediatrachb.UseVisualStyleBackColor = True
        '
        'CitDentalcb
        '
        Me.CitDentalcb.AutoSize = True
        Me.CitDentalcb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitDentalcb.Location = New System.Drawing.Point(775, 274)
        Me.CitDentalcb.Name = "CitDentalcb"
        Me.CitDentalcb.Size = New System.Drawing.Size(71, 20)
        Me.CitDentalcb.TabIndex = 46
        Me.CitDentalcb.Text = "Dental"
        Me.CitDentalcb.UseVisualStyleBackColor = True
        '
        'CitEnferchb
        '
        Me.CitEnferchb.AutoSize = True
        Me.CitEnferchb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitEnferchb.Location = New System.Drawing.Point(293, 228)
        Me.CitEnferchb.Name = "CitEnferchb"
        Me.CitEnferchb.Size = New System.Drawing.Size(101, 20)
        Me.CitEnferchb.TabIndex = 47
        Me.CitEnferchb.Text = "Enfermería"
        Me.CitEnferchb.UseVisualStyleBackColor = True
        '
        'CitSaludcb
        '
        Me.CitSaludcb.AutoSize = True
        Me.CitSaludcb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitSaludcb.Location = New System.Drawing.Point(507, 274)
        Me.CitSaludcb.Name = "CitSaludcb"
        Me.CitSaludcb.Size = New System.Drawing.Size(116, 20)
        Me.CitSaludcb.TabIndex = 48
        Me.CitSaludcb.Text = "Salud mental"
        Me.CitSaludcb.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Cittitulolb)
        Me.Panel2.Location = New System.Drawing.Point(264, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(636, 38)
        Me.Panel2.TabIndex = 50
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 622)
        Me.Panel1.TabIndex = 49
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label22.Location = New System.Drawing.Point(128, 537)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(67, 29)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Salir"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(55, 524)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 13
        Me.PictureBox7.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label20.Location = New System.Drawing.Point(106, 310)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 29)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Vitales"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label19.Location = New System.Drawing.Point(100, 238)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(99, 29)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "Médico"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(7, 228)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(9, 301)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label17.Location = New System.Drawing.Point(100, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 29)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Pacientes"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 150)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label14.Location = New System.Drawing.Point(70, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(187, 29)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Oficina Médica"
        '
        'CitBorrarbt
        '
        Me.CitBorrarbt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.CitBorrarbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitBorrarbt.Location = New System.Drawing.Point(589, 565)
        Me.CitBorrarbt.Name = "CitBorrarbt"
        Me.CitBorrarbt.Size = New System.Drawing.Size(134, 51)
        Me.CitBorrarbt.TabIndex = 71
        Me.CitBorrarbt.Text = "Borrar"
        Me.CitBorrarbt.UseVisualStyleBackColor = False
        '
        'CitGuardarbt
        '
        Me.CitGuardarbt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.CitGuardarbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitGuardarbt.Location = New System.Drawing.Point(293, 565)
        Me.CitGuardarbt.Name = "CitGuardarbt"
        Me.CitGuardarbt.Size = New System.Drawing.Size(134, 51)
        Me.CitGuardarbt.TabIndex = 70
        Me.CitGuardarbt.Text = "Guardar"
        Me.CitGuardarbt.UseVisualStyleBackColor = False
        '
        'CitEditarbt
        '
        Me.CitEditarbt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.CitEditarbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitEditarbt.Location = New System.Drawing.Point(445, 565)
        Me.CitEditarbt.Name = "CitEditarbt"
        Me.CitEditarbt.Size = New System.Drawing.Size(134, 51)
        Me.CitEditarbt.TabIndex = 69
        Me.CitEditarbt.Text = "Editar"
        Me.CitEditarbt.UseVisualStyleBackColor = False
        '
        'CitFechadp
        '
        Me.CitFechadp.Location = New System.Drawing.Point(322, 150)
        Me.CitFechadp.Name = "CitFechadp"
        Me.CitFechadp.Size = New System.Drawing.Size(200, 20)
        Me.CitFechadp.TabIndex = 72
        '
        'CitHoratp
        '
        Me.CitHoratp.Location = New System.Drawing.Point(618, 150)
        Me.CitHoratp.Name = "CitHoratp"
        Me.CitHoratp.Size = New System.Drawing.Size(200, 20)
        Me.CitHoratp.TabIndex = 74
        '
        'CitHoralb
        '
        Me.CitHoralb.AutoSize = True
        Me.CitHoralb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitHoralb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.CitHoralb.Location = New System.Drawing.Point(689, 123)
        Me.CitHoralb.Name = "CitHoralb"
        Me.CitHoralb.Size = New System.Drawing.Size(55, 24)
        Me.CitHoralb.TabIndex = 73
        Me.CitHoralb.Text = "Hora"
        '
        'CitListadgv
        '
        Me.CitListadgv.AllowUserToAddRows = False
        Me.CitListadgv.AllowUserToDeleteRows = False
        Me.CitListadgv.AllowUserToResizeColumns = False
        Me.CitListadgv.AllowUserToResizeRows = False
        Me.CitListadgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.CitListadgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CitListadgv.Location = New System.Drawing.Point(308, 374)
        Me.CitListadgv.Name = "CitListadgv"
        Me.CitListadgv.ReadOnly = True
        Me.CitListadgv.Size = New System.Drawing.Size(551, 150)
        Me.CitListadgv.TabIndex = 76
        '
        'Citbuscarlb
        '
        Me.Citbuscarlb.AutoSize = True
        Me.Citbuscarlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Citbuscarlb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Citbuscarlb.Location = New System.Drawing.Point(362, 341)
        Me.Citbuscarlb.Name = "Citbuscarlb"
        Me.Citbuscarlb.Size = New System.Drawing.Size(164, 20)
        Me.Citbuscarlb.TabIndex = 75
        Me.Citbuscarlb.Text = "Buscar Por Nombre"
        '
        'Citbuscarbt
        '
        Me.Citbuscarbt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Citbuscarbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Citbuscarbt.Location = New System.Drawing.Point(718, 333)
        Me.Citbuscarbt.Name = "Citbuscarbt"
        Me.Citbuscarbt.Size = New System.Drawing.Size(130, 33)
        Me.Citbuscarbt.TabIndex = 77
        Me.Citbuscarbt.Text = "Buscar"
        Me.Citbuscarbt.UseVisualStyleBackColor = False
        '
        'Citbuscartb
        '
        Me.Citbuscartb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Citbuscartb.Location = New System.Drawing.Point(561, 341)
        Me.Citbuscartb.Name = "Citbuscartb"
        Me.Citbuscartb.Size = New System.Drawing.Size(100, 22)
        Me.Citbuscartb.TabIndex = 79
        '
        'CitImprimirbt
        '
        Me.CitImprimirbt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.CitImprimirbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitImprimirbt.Location = New System.Drawing.Point(739, 565)
        Me.CitImprimirbt.Name = "CitImprimirbt"
        Me.CitImprimirbt.Size = New System.Drawing.Size(134, 51)
        Me.CitImprimirbt.TabIndex = 80
        Me.CitImprimirbt.Text = "Imprimir"
        Me.CitImprimirbt.UseVisualStyleBackColor = False
        '
        'Citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(897, 622)
        Me.Controls.Add(Me.CitImprimirbt)
        Me.Controls.Add(Me.Citbuscartb)
        Me.Controls.Add(Me.Citbuscarbt)
        Me.Controls.Add(Me.CitListadgv)
        Me.Controls.Add(Me.Citbuscarlb)
        Me.Controls.Add(Me.CitHoratp)
        Me.Controls.Add(Me.CitHoralb)
        Me.Controls.Add(Me.CitFechadp)
        Me.Controls.Add(Me.CitBorrarbt)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CitGuardarbt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CitEditarbt)
        Me.Controls.Add(Me.CitSaludcb)
        Me.Controls.Add(Me.CitEnferchb)
        Me.Controls.Add(Me.CitDentalcb)
        Me.Controls.Add(Me.CitPediatrachb)
        Me.Controls.Add(Me.CitOdontologiacb)
        Me.Controls.Add(Me.CitMedicinachb)
        Me.Controls.Add(Me.CitTipolb)
        Me.Controls.Add(Me.CitDoctorcb)
        Me.Controls.Add(Me.CitFechalb)
        Me.Controls.Add(Me.CitDoctorlb)
        Me.Controls.Add(Me.CitPacientecb)
        Me.Controls.Add(Me.CitPacientelb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Citas"
        Me.Text = "Citas"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CitListadgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cittitulolb As Label
    Friend WithEvents CitPacientelb As Label
    Friend WithEvents CitPacientecb As ComboBox
    Friend WithEvents CitDoctorlb As Label
    Friend WithEvents CitFechalb As Label
    Friend WithEvents CitDoctorcb As ComboBox
    Friend WithEvents CitTipolb As Label
    Friend WithEvents CitMedicinachb As CheckBox
    Friend WithEvents CitOdontologiacb As CheckBox
    Friend WithEvents CitPediatrachb As CheckBox
    Friend WithEvents CitDentalcb As CheckBox
    Friend WithEvents CitEnferchb As CheckBox
    Friend WithEvents CitSaludcb As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents CitBorrarbt As Button
    Friend WithEvents CitGuardarbt As Button
    Friend WithEvents CitEditarbt As Button
    Friend WithEvents CitFechadp As DateTimePicker
    Friend WithEvents CitHoratp As DateTimePicker
    Friend WithEvents CitHoralb As Label
    Friend WithEvents CitListadgv As DataGridView
    Friend WithEvents Citbuscarlb As Label
    Friend WithEvents Citbuscarbt As Button
    Friend WithEvents Citbuscartb As TextBox
    Friend WithEvents CitImprimirbt As Button
End Class
