<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vitales
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vitales))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.VitTemptb = New System.Windows.Forms.TextBox()
        Me.VitalesTBL3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultorioDBVBDataSet1 = New Tarea_2._2_Diseño.ConsultorioDBVBDataSet1()
        Me.VitBorrarbt = New System.Windows.Forms.Button()
        Me.VitGuardarbt = New System.Windows.Forms.Button()
        Me.VitEditarbt = New System.Windows.Forms.Button()
        Me.VitTemplb = New System.Windows.Forms.Label()
        Me.VitPacientelb = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.VitTitulolb = New System.Windows.Forms.Label()
        Me.VitPacientecb = New System.Windows.Forms.ComboBox()
        Me.VitCitalb = New System.Windows.Forms.Label()
        Me.VitPresiontb = New System.Windows.Forms.TextBox()
        Me.VitPresionlb = New System.Windows.Forms.Label()
        Me.VitPesotb = New System.Windows.Forms.TextBox()
        Me.VitPesolb = New System.Windows.Forms.Label()
        Me.VitSintomtb = New System.Windows.Forms.TextBox()
        Me.VitSintomlb = New System.Windows.Forms.Label()
        Me.VitAlturatb = New System.Windows.Forms.TextBox()
        Me.VitAlturalb = New System.Windows.Forms.Label()
        Me.VitListaVitalesdgv = New System.Windows.Forms.DataGridView()
        Me.VitPulsolb = New System.Windows.Forms.Label()
        Me.VitPulsotb = New System.Windows.Forms.TextBox()
        Me.VitRecomtb = New System.Windows.Forms.TextBox()
        Me.VitRecomlb = New System.Windows.Forms.Label()
        Me.VitDiagtb = New System.Windows.Forms.TextBox()
        Me.VitDiaglb = New System.Windows.Forms.Label()
        Me.VitBuscartb = New System.Windows.Forms.TextBox()
        Me.VitBuscarbt = New System.Windows.Forms.Button()
        Me.VitBuscarlb = New System.Windows.Forms.Label()
        Me.VitCitacb = New System.Windows.Forms.ComboBox()
        Me.VitalesTBL3TableAdapter = New Tarea_2._2_Diseño.ConsultorioDBVBDataSet1TableAdapters.VitalesTBL3TableAdapter()
        Me.TableAdapterManager = New Tarea_2._2_Diseño.ConsultorioDBVBDataSet1TableAdapters.TableAdapterManager()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VitalesTBL3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultorioDBVBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.VitListaVitalesdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.PictureBox7)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(269, 578)
        Me.Panel3.TabIndex = 43
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label22.Location = New System.Drawing.Point(134, 540)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(67, 29)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Salir"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(61, 527)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 13
        Me.PictureBox7.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label19.Location = New System.Drawing.Point(94, 314)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(99, 29)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "Médico"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(0, 304)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label18.Location = New System.Drawing.Point(97, 237)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 29)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Citas"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(3, 228)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label17.Location = New System.Drawing.Point(97, 163)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 29)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Pacientes"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 153)
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
        'VitTemptb
        '
        Me.VitTemptb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VitalesTBL3BindingSource, "Vit_Temp", True))
        Me.VitTemptb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitTemptb.Location = New System.Drawing.Point(281, 181)
        Me.VitTemptb.Name = "VitTemptb"
        Me.VitTemptb.Size = New System.Drawing.Size(188, 22)
        Me.VitTemptb.TabIndex = 84
        '
        'VitalesTBL3BindingSource
        '
        Me.VitalesTBL3BindingSource.DataMember = "VitalesTBL3"
        Me.VitalesTBL3BindingSource.DataSource = Me.ConsultorioDBVBDataSet1
        '
        'ConsultorioDBVBDataSet1
        '
        Me.ConsultorioDBVBDataSet1.DataSetName = "ConsultorioDBVBDataSet1"
        Me.ConsultorioDBVBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VitBorrarbt
        '
        Me.VitBorrarbt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.VitBorrarbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitBorrarbt.Location = New System.Drawing.Point(705, 574)
        Me.VitBorrarbt.Name = "VitBorrarbt"
        Me.VitBorrarbt.Size = New System.Drawing.Size(169, 51)
        Me.VitBorrarbt.TabIndex = 83
        Me.VitBorrarbt.Text = "Borrar"
        Me.VitBorrarbt.UseVisualStyleBackColor = False
        '
        'VitGuardarbt
        '
        Me.VitGuardarbt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.VitGuardarbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitGuardarbt.Location = New System.Drawing.Point(297, 574)
        Me.VitGuardarbt.Name = "VitGuardarbt"
        Me.VitGuardarbt.Size = New System.Drawing.Size(169, 51)
        Me.VitGuardarbt.TabIndex = 82
        Me.VitGuardarbt.Text = "Guardar"
        Me.VitGuardarbt.UseVisualStyleBackColor = False
        '
        'VitEditarbt
        '
        Me.VitEditarbt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.VitEditarbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitEditarbt.Location = New System.Drawing.Point(501, 574)
        Me.VitEditarbt.Name = "VitEditarbt"
        Me.VitEditarbt.Size = New System.Drawing.Size(169, 51)
        Me.VitEditarbt.TabIndex = 81
        Me.VitEditarbt.Text = "Editar"
        Me.VitEditarbt.UseVisualStyleBackColor = False
        '
        'VitTemplb
        '
        Me.VitTemplb.AutoSize = True
        Me.VitTemplb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitTemplb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.VitTemplb.Location = New System.Drawing.Point(310, 140)
        Me.VitTemplb.Name = "VitTemplb"
        Me.VitTemplb.Size = New System.Drawing.Size(111, 20)
        Me.VitTemplb.TabIndex = 79
        Me.VitTemplb.Text = "Temperatura"
        '
        'VitPacientelb
        '
        Me.VitPacientelb.AutoSize = True
        Me.VitPacientelb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitPacientelb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.VitPacientelb.Location = New System.Drawing.Point(393, 55)
        Me.VitPacientelb.Name = "VitPacientelb"
        Me.VitPacientelb.Size = New System.Drawing.Size(79, 20)
        Me.VitPacientelb.TabIndex = 76
        Me.VitPacientelb.Text = "Paciente"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.VitTitulolb)
        Me.Panel2.Location = New System.Drawing.Point(275, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(636, 38)
        Me.Panel2.TabIndex = 87
        '
        'VitTitulolb
        '
        Me.VitTitulolb.AutoSize = True
        Me.VitTitulolb.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitTitulolb.Location = New System.Drawing.Point(176, 6)
        Me.VitTitulolb.Name = "VitTitulolb"
        Me.VitTitulolb.Size = New System.Drawing.Size(251, 29)
        Me.VitTitulolb.TabIndex = 0
        Me.VitTitulolb.Text = "Vitales de Pacientes"
        '
        'VitPacientecb
        '
        Me.VitPacientecb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VitalesTBL3BindingSource, "Vit_Paciente", True))
        Me.VitPacientecb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitPacientecb.FormattingEnabled = True
        Me.VitPacientecb.Items.AddRange(New Object() {"Hello", "World", "Vitales"})
        Me.VitPacientecb.Location = New System.Drawing.Point(355, 100)
        Me.VitPacientecb.Name = "VitPacientecb"
        Me.VitPacientecb.Size = New System.Drawing.Size(183, 23)
        Me.VitPacientecb.TabIndex = 88
        Me.VitPacientecb.Text = "Elegir"
        '
        'VitCitalb
        '
        Me.VitCitalb.AutoSize = True
        Me.VitCitalb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitCitalb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.VitCitalb.Location = New System.Drawing.Point(679, 55)
        Me.VitCitalb.Name = "VitCitalb"
        Me.VitCitalb.Size = New System.Drawing.Size(41, 20)
        Me.VitCitalb.TabIndex = 89
        Me.VitCitalb.Text = "Cita"
        '
        'VitPresiontb
        '
        Me.VitPresiontb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VitalesTBL3BindingSource, "Vit_Presion", True))
        Me.VitPresiontb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitPresiontb.Location = New System.Drawing.Point(492, 181)
        Me.VitPresiontb.Name = "VitPresiontb"
        Me.VitPresiontb.Size = New System.Drawing.Size(188, 22)
        Me.VitPresiontb.TabIndex = 92
        '
        'VitPresionlb
        '
        Me.VitPresionlb.AutoSize = True
        Me.VitPresionlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitPresionlb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.VitPresionlb.Location = New System.Drawing.Point(552, 140)
        Me.VitPresionlb.Name = "VitPresionlb"
        Me.VitPresionlb.Size = New System.Drawing.Size(69, 20)
        Me.VitPresionlb.TabIndex = 91
        Me.VitPresionlb.Text = "Presión"
        '
        'VitPesotb
        '
        Me.VitPesotb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VitalesTBL3BindingSource, "Vit_Peso", True))
        Me.VitPesotb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitPesotb.Location = New System.Drawing.Point(704, 181)
        Me.VitPesotb.Name = "VitPesotb"
        Me.VitPesotb.Size = New System.Drawing.Size(188, 22)
        Me.VitPesotb.TabIndex = 94
        '
        'VitPesolb
        '
        Me.VitPesolb.AutoSize = True
        Me.VitPesolb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitPesolb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.VitPesolb.Location = New System.Drawing.Point(775, 140)
        Me.VitPesolb.Name = "VitPesolb"
        Me.VitPesolb.Size = New System.Drawing.Size(49, 20)
        Me.VitPesolb.TabIndex = 93
        Me.VitPesolb.Text = "Peso"
        '
        'VitSintomtb
        '
        Me.VitSintomtb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VitalesTBL3BindingSource, "Vit_Sintomas", True))
        Me.VitSintomtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitSintomtb.Location = New System.Drawing.Point(633, 254)
        Me.VitSintomtb.Name = "VitSintomtb"
        Me.VitSintomtb.Size = New System.Drawing.Size(259, 22)
        Me.VitSintomtb.TabIndex = 98
        '
        'VitSintomlb
        '
        Me.VitSintomlb.AutoSize = True
        Me.VitSintomlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitSintomlb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.VitSintomlb.Location = New System.Drawing.Point(730, 218)
        Me.VitSintomlb.Name = "VitSintomlb"
        Me.VitSintomlb.Size = New System.Drawing.Size(84, 20)
        Me.VitSintomlb.TabIndex = 97
        Me.VitSintomlb.Text = "Síntomas"
        '
        'VitAlturatb
        '
        Me.VitAlturatb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VitalesTBL3BindingSource, "Vit_Altura", True))
        Me.VitAlturatb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitAlturatb.Location = New System.Drawing.Point(275, 254)
        Me.VitAlturatb.Name = "VitAlturatb"
        Me.VitAlturatb.Size = New System.Drawing.Size(188, 22)
        Me.VitAlturatb.TabIndex = 96
        '
        'VitAlturalb
        '
        Me.VitAlturalb.AutoSize = True
        Me.VitAlturalb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitAlturalb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.VitAlturalb.Location = New System.Drawing.Point(339, 214)
        Me.VitAlturalb.Name = "VitAlturalb"
        Me.VitAlturalb.Size = New System.Drawing.Size(57, 20)
        Me.VitAlturalb.TabIndex = 95
        Me.VitAlturalb.Text = "Altura"
        '
        'VitListaVitalesdgv
        '
        Me.VitListaVitalesdgv.AllowUserToAddRows = False
        Me.VitListaVitalesdgv.AllowUserToDeleteRows = False
        Me.VitListaVitalesdgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.VitListaVitalesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VitListaVitalesdgv.Location = New System.Drawing.Point(311, 409)
        Me.VitListaVitalesdgv.Name = "VitListaVitalesdgv"
        Me.VitListaVitalesdgv.ReadOnly = True
        Me.VitListaVitalesdgv.RowHeadersWidth = 102
        Me.VitListaVitalesdgv.Size = New System.Drawing.Size(551, 150)
        Me.VitListaVitalesdgv.TabIndex = 100
        '
        'VitPulsolb
        '
        Me.VitPulsolb.AutoSize = True
        Me.VitPulsolb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitPulsolb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.VitPulsolb.Location = New System.Drawing.Point(527, 214)
        Me.VitPulsolb.Name = "VitPulsolb"
        Me.VitPulsolb.Size = New System.Drawing.Size(53, 20)
        Me.VitPulsolb.TabIndex = 101
        Me.VitPulsolb.Text = "Pulso"
        '
        'VitPulsotb
        '
        Me.VitPulsotb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VitalesTBL3BindingSource, "Vit_Pulso", True))
        Me.VitPulsotb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitPulsotb.Location = New System.Drawing.Point(492, 254)
        Me.VitPulsotb.Name = "VitPulsotb"
        Me.VitPulsotb.Size = New System.Drawing.Size(113, 22)
        Me.VitPulsotb.TabIndex = 102
        '
        'VitRecomtb
        '
        Me.VitRecomtb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VitalesTBL3BindingSource, "Vit_Recom", True))
        Me.VitRecomtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitRecomtb.Location = New System.Drawing.Point(492, 327)
        Me.VitRecomtb.Name = "VitRecomtb"
        Me.VitRecomtb.Size = New System.Drawing.Size(370, 22)
        Me.VitRecomtb.TabIndex = 108
        '
        'VitRecomlb
        '
        Me.VitRecomlb.AutoSize = True
        Me.VitRecomlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitRecomlb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.VitRecomlb.Location = New System.Drawing.Point(601, 294)
        Me.VitRecomlb.Name = "VitRecomlb"
        Me.VitRecomlb.Size = New System.Drawing.Size(157, 20)
        Me.VitRecomlb.TabIndex = 107
        Me.VitRecomlb.Text = "Recomendaciones"
        '
        'VitDiagtb
        '
        Me.VitDiagtb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VitalesTBL3BindingSource, "Vit_Diag", True))
        Me.VitDiagtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitDiagtb.Location = New System.Drawing.Point(275, 327)
        Me.VitDiagtb.Name = "VitDiagtb"
        Me.VitDiagtb.Size = New System.Drawing.Size(188, 22)
        Me.VitDiagtb.TabIndex = 104
        '
        'VitDiaglb
        '
        Me.VitDiaglb.AutoSize = True
        Me.VitDiaglb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitDiaglb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.VitDiaglb.Location = New System.Drawing.Point(310, 294)
        Me.VitDiaglb.Name = "VitDiaglb"
        Me.VitDiaglb.Size = New System.Drawing.Size(104, 20)
        Me.VitDiaglb.TabIndex = 103
        Me.VitDiaglb.Text = "Diagnóstico"
        '
        'VitBuscartb
        '
        Me.VitBuscartb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitBuscartb.Location = New System.Drawing.Point(538, 377)
        Me.VitBuscartb.Name = "VitBuscartb"
        Me.VitBuscartb.Size = New System.Drawing.Size(100, 22)
        Me.VitBuscartb.TabIndex = 111
        '
        'VitBuscarbt
        '
        Me.VitBuscarbt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.VitBuscarbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitBuscarbt.Location = New System.Drawing.Point(695, 369)
        Me.VitBuscarbt.Name = "VitBuscarbt"
        Me.VitBuscarbt.Size = New System.Drawing.Size(130, 33)
        Me.VitBuscarbt.TabIndex = 110
        Me.VitBuscarbt.Text = "Buscar"
        Me.VitBuscarbt.UseVisualStyleBackColor = False
        '
        'VitBuscarlb
        '
        Me.VitBuscarlb.AutoSize = True
        Me.VitBuscarlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitBuscarlb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.VitBuscarlb.Location = New System.Drawing.Point(339, 377)
        Me.VitBuscarlb.Name = "VitBuscarlb"
        Me.VitBuscarlb.Size = New System.Drawing.Size(164, 20)
        Me.VitBuscarlb.TabIndex = 109
        Me.VitBuscarlb.Text = "Buscar Por Nombre"
        '
        'VitCitacb
        '
        Me.VitCitacb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VitalesTBL3BindingSource, "Vit_Cita", True))
        Me.VitCitacb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitCitacb.FormattingEnabled = True
        Me.VitCitacb.Location = New System.Drawing.Point(615, 100)
        Me.VitCitacb.Name = "VitCitacb"
        Me.VitCitacb.Size = New System.Drawing.Size(183, 23)
        Me.VitCitacb.TabIndex = 90
        Me.VitCitacb.Text = "Elegir"
        '
        'VitalesTBL3TableAdapter
        '
        Me.VitalesTBL3TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTBL1TableAdapter = Nothing
        Me.TableAdapterManager.MedicoTBL4TableAdapter = Nothing
        Me.TableAdapterManager.PacientesTBL2TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Tarea_2._2_Diseño.ConsultorioDBVBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VitalesTBL3TableAdapter = Me.VitalesTBL3TableAdapter
        '
        'Vitales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(898, 578)
        Me.Controls.Add(Me.VitBuscartb)
        Me.Controls.Add(Me.VitBuscarbt)
        Me.Controls.Add(Me.VitBuscarlb)
        Me.Controls.Add(Me.VitRecomtb)
        Me.Controls.Add(Me.VitRecomlb)
        Me.Controls.Add(Me.VitDiagtb)
        Me.Controls.Add(Me.VitDiaglb)
        Me.Controls.Add(Me.VitPulsotb)
        Me.Controls.Add(Me.VitPulsolb)
        Me.Controls.Add(Me.VitListaVitalesdgv)
        Me.Controls.Add(Me.VitSintomtb)
        Me.Controls.Add(Me.VitSintomlb)
        Me.Controls.Add(Me.VitAlturatb)
        Me.Controls.Add(Me.VitAlturalb)
        Me.Controls.Add(Me.VitPesotb)
        Me.Controls.Add(Me.VitPesolb)
        Me.Controls.Add(Me.VitPresiontb)
        Me.Controls.Add(Me.VitPresionlb)
        Me.Controls.Add(Me.VitCitacb)
        Me.Controls.Add(Me.VitCitalb)
        Me.Controls.Add(Me.VitPacientecb)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.VitTemptb)
        Me.Controls.Add(Me.VitBorrarbt)
        Me.Controls.Add(Me.VitGuardarbt)
        Me.Controls.Add(Me.VitEditarbt)
        Me.Controls.Add(Me.VitTemplb)
        Me.Controls.Add(Me.VitPacientelb)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Vitales"
        Me.Text = "Vitales"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VitalesTBL3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultorioDBVBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.VitListaVitalesdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents VitTemptb As TextBox
    Friend WithEvents VitBorrarbt As Button
    Friend WithEvents VitGuardarbt As Button
    Friend WithEvents VitEditarbt As Button
    Friend WithEvents VitTemplb As Label
    Friend WithEvents VitPacientelb As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents VitTitulolb As Label
    Friend WithEvents VitPacientecb As ComboBox
    Friend WithEvents VitCitalb As Label
    Friend WithEvents VitPresiontb As TextBox
    Friend WithEvents VitPresionlb As Label
    Friend WithEvents VitPesotb As TextBox
    Friend WithEvents VitPesolb As Label
    Friend WithEvents VitSintomtb As TextBox
    Friend WithEvents VitSintomlb As Label
    Friend WithEvents VitAlturatb As TextBox
    Friend WithEvents VitAlturalb As Label
    Friend WithEvents VitListaVitalesdgv As DataGridView
    Friend WithEvents VitPulsolb As Label
    Friend WithEvents VitPulsotb As TextBox
    Friend WithEvents VitRecomtb As TextBox
    Friend WithEvents VitRecomlb As Label
    Friend WithEvents VitDiagtb As TextBox
    Friend WithEvents VitDiaglb As Label
    Friend WithEvents VitBuscartb As TextBox
    Friend WithEvents VitBuscarbt As Button
    Friend WithEvents VitBuscarlb As Label
    Friend WithEvents VitCitacb As ComboBox
    Friend WithEvents ConsultorioDBVBDataSet1 As ConsultorioDBVBDataSet1
    Friend WithEvents VitalesTBL3BindingSource As BindingSource
    Friend WithEvents VitalesTBL3TableAdapter As ConsultorioDBVBDataSet1TableAdapters.VitalesTBL3TableAdapter
    Friend WithEvents TableAdapterManager As ConsultorioDBVBDataSet1TableAdapters.TableAdapterManager
End Class
