<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro_de_Paciente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_de_Paciente))
        Me.PacTitulolb = New System.Windows.Forms.Label()
        Me.PacNombrelb = New System.Windows.Forms.Label()
        Me.PacNombretb = New System.Windows.Forms.TextBox()
        Me.PacientesTBL2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultorioDBVBDataSet1 = New Tarea_2._2_Diseño.ConsultorioDBVBDataSet1()
        Me.PacApellidolb = New System.Windows.Forms.Label()
        Me.PacEdadlb = New System.Windows.Forms.Label()
        Me.PacEdadtb = New System.Windows.Forms.TextBox()
        Me.PacSexolb = New System.Windows.Forms.Label()
        Me.PacSexocb = New System.Windows.Forms.ComboBox()
        Me.PacTeleflb = New System.Windows.Forms.Label()
        Me.PacTeleftb = New System.Windows.Forms.TextBox()
        Me.PacDirecclb = New System.Windows.Forms.Label()
        Me.PacDirectb = New System.Windows.Forms.TextBox()
        Me.PacFechalb = New System.Windows.Forms.Label()
        Me.PacEmaillb = New System.Windows.Forms.Label()
        Me.PacEmailtb = New System.Windows.Forms.TextBox()
        Me.PacApellidotb = New System.Windows.Forms.TextBox()
        Me.PacFechaNacdp = New System.Windows.Forms.DateTimePicker()
        Me.PacEditarbt = New System.Windows.Forms.Button()
        Me.PacGuardarbt = New System.Windows.Forms.Button()
        Me.PacBorrarbt = New System.Windows.Forms.Button()
        Me.PacSegurotb = New System.Windows.Forms.TextBox()
        Me.PacSegurolb = New System.Windows.Forms.Label()
        Me.PacListadgv = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Logout = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.VitalesIconlb = New System.Windows.Forms.Label()
        Me.MedicoIconlb = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.CitasIconlb = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PacBusquedatb = New System.Windows.Forms.TextBox()
        Me.PacBusquedabt = New System.Windows.Forms.Button()
        Me.PacBusquedalb = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PacientesTBL2TableAdapter = New Tarea_2._2_Diseño.ConsultorioDBVBDataSet1TableAdapters.PacientesTBL2TableAdapter()
        Me.TableAdapterManager = New Tarea_2._2_Diseño.ConsultorioDBVBDataSet1TableAdapters.TableAdapterManager()
        Me.IdPacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatEdadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatFechaNacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatDireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatCiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatCodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatEstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatPaisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatSexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatTelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatSeguroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PacientesTBL2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultorioDBVBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacListadgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PacTitulolb
        '
        Me.PacTitulolb.AutoSize = True
        Me.PacTitulolb.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacTitulolb.Location = New System.Drawing.Point(178, 6)
        Me.PacTitulolb.Name = "PacTitulolb"
        Me.PacTitulolb.Size = New System.Drawing.Size(258, 29)
        Me.PacTitulolb.TabIndex = 0
        Me.PacTitulolb.Text = "Registro de Paciente"
        '
        'PacNombrelb
        '
        Me.PacNombrelb.AutoSize = True
        Me.PacNombrelb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacNombrelb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PacNombrelb.Location = New System.Drawing.Point(368, 77)
        Me.PacNombrelb.Name = "PacNombrelb"
        Me.PacNombrelb.Size = New System.Drawing.Size(71, 20)
        Me.PacNombrelb.TabIndex = 1
        Me.PacNombrelb.Text = "Nombre"
        '
        'PacNombretb
        '
        Me.PacNombretb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesTBL2BindingSource, "Pat_Name", True))
        Me.PacNombretb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacNombretb.Location = New System.Drawing.Point(345, 123)
        Me.PacNombretb.Name = "PacNombretb"
        Me.PacNombretb.Size = New System.Drawing.Size(131, 22)
        Me.PacNombretb.TabIndex = 2
        '
        'PacientesTBL2BindingSource
        '
        Me.PacientesTBL2BindingSource.DataMember = "PacientesTBL2"
        Me.PacientesTBL2BindingSource.DataSource = Me.ConsultorioDBVBDataSet1
        '
        'ConsultorioDBVBDataSet1
        '
        Me.ConsultorioDBVBDataSet1.DataSetName = "ConsultorioDBVBDataSet1"
        Me.ConsultorioDBVBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PacApellidolb
        '
        Me.PacApellidolb.AutoSize = True
        Me.PacApellidolb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacApellidolb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PacApellidolb.Location = New System.Drawing.Point(534, 77)
        Me.PacApellidolb.Name = "PacApellidolb"
        Me.PacApellidolb.Size = New System.Drawing.Size(73, 20)
        Me.PacApellidolb.TabIndex = 3
        Me.PacApellidolb.Text = "Apellido"
        '
        'PacEdadlb
        '
        Me.PacEdadlb.AutoSize = True
        Me.PacEdadlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacEdadlb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PacEdadlb.Location = New System.Drawing.Point(684, 77)
        Me.PacEdadlb.Name = "PacEdadlb"
        Me.PacEdadlb.Size = New System.Drawing.Size(51, 20)
        Me.PacEdadlb.TabIndex = 5
        Me.PacEdadlb.Text = "Edad"
        '
        'PacEdadtb
        '
        Me.PacEdadtb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesTBL2BindingSource, "Pat_Edad", True))
        Me.PacEdadtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacEdadtb.Location = New System.Drawing.Point(679, 123)
        Me.PacEdadtb.MaxLength = 3
        Me.PacEdadtb.Name = "PacEdadtb"
        Me.PacEdadtb.Size = New System.Drawing.Size(56, 22)
        Me.PacEdadtb.TabIndex = 6
        '
        'PacSexolb
        '
        Me.PacSexolb.AutoSize = True
        Me.PacSexolb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacSexolb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PacSexolb.Location = New System.Drawing.Point(358, 164)
        Me.PacSexolb.Name = "PacSexolb"
        Me.PacSexolb.Size = New System.Drawing.Size(49, 20)
        Me.PacSexolb.TabIndex = 7
        Me.PacSexolb.Text = "Sexo"
        '
        'PacSexocb
        '
        Me.PacSexocb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesTBL2BindingSource, "Pat_Sexo", True))
        Me.PacSexocb.FormattingEnabled = True
        Me.PacSexocb.Items.AddRange(New Object() {"Male ", "Female"})
        Me.PacSexocb.Location = New System.Drawing.Point(351, 210)
        Me.PacSexocb.Name = "PacSexocb"
        Me.PacSexocb.Size = New System.Drawing.Size(85, 21)
        Me.PacSexocb.TabIndex = 8
        '
        'PacTeleflb
        '
        Me.PacTeleflb.AutoSize = True
        Me.PacTeleflb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacTeleflb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PacTeleflb.Location = New System.Drawing.Point(360, 254)
        Me.PacTeleflb.Name = "PacTeleflb"
        Me.PacTeleflb.Size = New System.Drawing.Size(79, 20)
        Me.PacTeleflb.TabIndex = 9
        Me.PacTeleflb.Text = "Teléfono"
        '
        'PacTeleftb
        '
        Me.PacTeleftb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesTBL2BindingSource, "Pat_Telefono", True))
        Me.PacTeleftb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacTeleftb.Location = New System.Drawing.Point(351, 300)
        Me.PacTeleftb.MaxLength = 10
        Me.PacTeleftb.Name = "PacTeleftb"
        Me.PacTeleftb.Size = New System.Drawing.Size(100, 22)
        Me.PacTeleftb.TabIndex = 10
        '
        'PacDirecclb
        '
        Me.PacDirecclb.AutoSize = True
        Me.PacDirecclb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacDirecclb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PacDirecclb.Location = New System.Drawing.Point(661, 172)
        Me.PacDirecclb.Name = "PacDirecclb"
        Me.PacDirecclb.Size = New System.Drawing.Size(84, 20)
        Me.PacDirecclb.TabIndex = 11
        Me.PacDirecclb.Text = "Dirección"
        '
        'PacDirectb
        '
        Me.PacDirectb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesTBL2BindingSource, "Pat_Direccion", True))
        Me.PacDirectb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacDirectb.Location = New System.Drawing.Point(489, 210)
        Me.PacDirectb.Name = "PacDirectb"
        Me.PacDirectb.Size = New System.Drawing.Size(441, 22)
        Me.PacDirectb.TabIndex = 12
        '
        'PacFechalb
        '
        Me.PacFechalb.AutoSize = True
        Me.PacFechalb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacFechalb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PacFechalb.Location = New System.Drawing.Point(756, 77)
        Me.PacFechalb.Name = "PacFechalb"
        Me.PacFechalb.Size = New System.Drawing.Size(176, 20)
        Me.PacFechalb.TabIndex = 21
        Me.PacFechalb.Text = "Fecha de nacimiento"
        '
        'PacEmaillb
        '
        Me.PacEmaillb.AutoSize = True
        Me.PacEmaillb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacEmaillb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PacEmaillb.Location = New System.Drawing.Point(607, 258)
        Me.PacEmaillb.Name = "PacEmaillb"
        Me.PacEmaillb.Size = New System.Drawing.Size(53, 20)
        Me.PacEmaillb.TabIndex = 23
        Me.PacEmaillb.Text = "Email"
        '
        'PacEmailtb
        '
        Me.PacEmailtb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesTBL2BindingSource, "Pat_Email", True))
        Me.PacEmailtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacEmailtb.Location = New System.Drawing.Point(520, 300)
        Me.PacEmailtb.Name = "PacEmailtb"
        Me.PacEmailtb.Size = New System.Drawing.Size(216, 22)
        Me.PacEmailtb.TabIndex = 24
        '
        'PacApellidotb
        '
        Me.PacApellidotb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesTBL2BindingSource, "Pat_Apellido", True))
        Me.PacApellidotb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacApellidotb.Location = New System.Drawing.Point(495, 123)
        Me.PacApellidotb.Name = "PacApellidotb"
        Me.PacApellidotb.Size = New System.Drawing.Size(165, 22)
        Me.PacApellidotb.TabIndex = 27
        '
        'PacFechaNacdp
        '
        Me.PacFechaNacdp.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PacientesTBL2BindingSource, "Pat_Fecha_Nac", True))
        Me.PacFechaNacdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacFechaNacdp.Location = New System.Drawing.Point(750, 123)
        Me.PacFechaNacdp.Name = "PacFechaNacdp"
        Me.PacFechaNacdp.Size = New System.Drawing.Size(178, 22)
        Me.PacFechaNacdp.TabIndex = 29
        '
        'PacEditarbt
        '
        Me.PacEditarbt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PacEditarbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacEditarbt.Location = New System.Drawing.Point(571, 581)
        Me.PacEditarbt.Name = "PacEditarbt"
        Me.PacEditarbt.Size = New System.Drawing.Size(169, 51)
        Me.PacEditarbt.TabIndex = 30
        Me.PacEditarbt.Text = "Editar"
        Me.PacEditarbt.UseVisualStyleBackColor = False
        '
        'PacGuardarbt
        '
        Me.PacGuardarbt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PacGuardarbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacGuardarbt.Location = New System.Drawing.Point(367, 581)
        Me.PacGuardarbt.Name = "PacGuardarbt"
        Me.PacGuardarbt.Size = New System.Drawing.Size(169, 51)
        Me.PacGuardarbt.TabIndex = 31
        Me.PacGuardarbt.Text = "Guardar"
        Me.PacGuardarbt.UseVisualStyleBackColor = False
        '
        'PacBorrarbt
        '
        Me.PacBorrarbt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PacBorrarbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacBorrarbt.Location = New System.Drawing.Point(775, 581)
        Me.PacBorrarbt.Name = "PacBorrarbt"
        Me.PacBorrarbt.Size = New System.Drawing.Size(169, 51)
        Me.PacBorrarbt.TabIndex = 32
        Me.PacBorrarbt.Text = "Borrar"
        Me.PacBorrarbt.UseVisualStyleBackColor = False
        '
        'PacSegurotb
        '
        Me.PacSegurotb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesTBL2BindingSource, "Pat_Seguro", True))
        Me.PacSegurotb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacSegurotb.Location = New System.Drawing.Point(805, 300)
        Me.PacSegurotb.MaxLength = 15
        Me.PacSegurotb.Name = "PacSegurotb"
        Me.PacSegurotb.Size = New System.Drawing.Size(127, 22)
        Me.PacSegurotb.TabIndex = 33
        '
        'PacSegurolb
        '
        Me.PacSegurolb.AutoSize = True
        Me.PacSegurolb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacSegurolb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PacSegurolb.Location = New System.Drawing.Point(801, 258)
        Me.PacSegurolb.Name = "PacSegurolb"
        Me.PacSegurolb.Size = New System.Drawing.Size(129, 20)
        Me.PacSegurolb.TabIndex = 34
        Me.PacSegurolb.Text = "Seguro médico"
        '
        'PacListadgv
        '
        Me.PacListadgv.AllowUserToAddRows = False
        Me.PacListadgv.AllowUserToDeleteRows = False
        Me.PacListadgv.AllowUserToResizeColumns = False
        Me.PacListadgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Empty
        DataGridViewCellStyle1.NullValue = "No Records Yet"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PacListadgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PacListadgv.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PacListadgv.AutoGenerateColumns = False
        Me.PacListadgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.PacListadgv.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PacListadgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PacListadgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PacListadgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPacienteDataGridViewTextBoxColumn, Me.PatNameDataGridViewTextBoxColumn, Me.PatApellidoDataGridViewTextBoxColumn, Me.PatEdadDataGridViewTextBoxColumn, Me.PatFechaNacDataGridViewTextBoxColumn, Me.PatDireccionDataGridViewTextBoxColumn, Me.PatCiudadDataGridViewTextBoxColumn, Me.PatCodigoDataGridViewTextBoxColumn, Me.PatEstadoDataGridViewTextBoxColumn, Me.PatPaisDataGridViewTextBoxColumn, Me.PatSexoDataGridViewTextBoxColumn, Me.PatTelefonoDataGridViewTextBoxColumn, Me.PatEmailDataGridViewTextBoxColumn, Me.PatSeguroDataGridViewTextBoxColumn})
        Me.PacListadgv.DataSource = Me.PacientesTBL2BindingSource
        Me.PacListadgv.Location = New System.Drawing.Point(275, 403)
        Me.PacListadgv.Name = "PacListadgv"
        Me.PacListadgv.ReadOnly = True
        Me.PacListadgv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PacListadgv.RowHeadersWidth = 102
        Me.PacListadgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PacListadgv.Size = New System.Drawing.Size(763, 150)
        Me.PacListadgv.TabIndex = 36
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Logout)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.VitalesIconlb)
        Me.Panel1.Controls.Add(Me.MedicoIconlb)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.CitasIconlb)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 656)
        Me.Panel1.TabIndex = 38
        '
        'Logout
        '
        Me.Logout.AutoSize = True
        Me.Logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Logout.Location = New System.Drawing.Point(131, 549)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(67, 29)
        Me.Logout.TabIndex = 14
        Me.Logout.Text = "Salir"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(58, 536)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 13
        Me.PictureBox7.TabStop = False
        '
        'VitalesIconlb
        '
        Me.VitalesIconlb.AutoSize = True
        Me.VitalesIconlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VitalesIconlb.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.VitalesIconlb.Location = New System.Drawing.Point(101, 304)
        Me.VitalesIconlb.Name = "VitalesIconlb"
        Me.VitalesIconlb.Size = New System.Drawing.Size(92, 29)
        Me.VitalesIconlb.TabIndex = 10
        Me.VitalesIconlb.Text = "Vitales"
        '
        'MedicoIconlb
        '
        Me.MedicoIconlb.AutoSize = True
        Me.MedicoIconlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicoIconlb.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.MedicoIconlb.Location = New System.Drawing.Point(95, 232)
        Me.MedicoIconlb.Name = "MedicoIconlb"
        Me.MedicoIconlb.Size = New System.Drawing.Size(99, 29)
        Me.MedicoIconlb.TabIndex = 9
        Me.MedicoIconlb.Text = "Médico"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1, 222)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'CitasIconlb
        '
        Me.CitasIconlb.AutoSize = True
        Me.CitasIconlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitasIconlb.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.CitasIconlb.Location = New System.Drawing.Point(98, 155)
        Me.CitasIconlb.Name = "CitasIconlb"
        Me.CitasIconlb.Size = New System.Drawing.Size(72, 29)
        Me.CitasIconlb.TabIndex = 7
        Me.CitasIconlb.Text = "Citas"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(4, 295)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(4, 146)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PacTitulolb)
        Me.Panel2.Location = New System.Drawing.Point(268, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(770, 38)
        Me.Panel2.TabIndex = 39
        '
        'PacBusquedatb
        '
        Me.PacBusquedatb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacBusquedatb.Location = New System.Drawing.Point(597, 368)
        Me.PacBusquedatb.Name = "PacBusquedatb"
        Me.PacBusquedatb.Size = New System.Drawing.Size(100, 22)
        Me.PacBusquedatb.TabIndex = 82
        '
        'PacBusquedabt
        '
        Me.PacBusquedabt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PacBusquedabt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacBusquedabt.Location = New System.Drawing.Point(754, 360)
        Me.PacBusquedabt.Name = "PacBusquedabt"
        Me.PacBusquedabt.Size = New System.Drawing.Size(130, 33)
        Me.PacBusquedabt.TabIndex = 81
        Me.PacBusquedabt.Text = "Buscar"
        Me.PacBusquedabt.UseVisualStyleBackColor = False
        '
        'PacBusquedalb
        '
        Me.PacBusquedalb.AutoSize = True
        Me.PacBusquedalb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PacBusquedalb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.PacBusquedalb.Location = New System.Drawing.Point(398, 368)
        Me.PacBusquedalb.Name = "PacBusquedalb"
        Me.PacBusquedalb.Size = New System.Drawing.Size(164, 20)
        Me.PacBusquedalb.TabIndex = 80
        Me.PacBusquedalb.Text = "Buscar Por Nombre"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label22.Location = New System.Drawing.Point(131, 549)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 28)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Salir"
        '
        'PacientesTBL2TableAdapter
        '
        Me.PacientesTBL2TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = True
        Me.TableAdapterManager.CitasTBL1TableAdapter = Nothing
        Me.TableAdapterManager.MedicoTBL4TableAdapter = Nothing
        Me.TableAdapterManager.PacientesTBL2TableAdapter = Me.PacientesTBL2TableAdapter
        Me.TableAdapterManager.UpdateOrder = Tarea_2._2_Diseño.ConsultorioDBVBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VitalesTBL3TableAdapter = Nothing
        '
        'IdPacienteDataGridViewTextBoxColumn
        '
        Me.IdPacienteDataGridViewTextBoxColumn.DataPropertyName = "IdPaciente"
        Me.IdPacienteDataGridViewTextBoxColumn.HeaderText = "Paciente ID"
        Me.IdPacienteDataGridViewTextBoxColumn.Name = "IdPacienteDataGridViewTextBoxColumn"
        Me.IdPacienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPacienteDataGridViewTextBoxColumn.Width = 88
        '
        'PatNameDataGridViewTextBoxColumn
        '
        Me.PatNameDataGridViewTextBoxColumn.DataPropertyName = "Pat_Name"
        Me.PatNameDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.PatNameDataGridViewTextBoxColumn.Name = "PatNameDataGridViewTextBoxColumn"
        Me.PatNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatNameDataGridViewTextBoxColumn.Width = 69
        '
        'PatApellidoDataGridViewTextBoxColumn
        '
        Me.PatApellidoDataGridViewTextBoxColumn.DataPropertyName = "Pat_Apellido"
        Me.PatApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.PatApellidoDataGridViewTextBoxColumn.Name = "PatApellidoDataGridViewTextBoxColumn"
        Me.PatApellidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatApellidoDataGridViewTextBoxColumn.Width = 69
        '
        'PatEdadDataGridViewTextBoxColumn
        '
        Me.PatEdadDataGridViewTextBoxColumn.DataPropertyName = "Pat_Edad"
        Me.PatEdadDataGridViewTextBoxColumn.HeaderText = "Edad"
        Me.PatEdadDataGridViewTextBoxColumn.Name = "PatEdadDataGridViewTextBoxColumn"
        Me.PatEdadDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatEdadDataGridViewTextBoxColumn.Width = 57
        '
        'PatFechaNacDataGridViewTextBoxColumn
        '
        Me.PatFechaNacDataGridViewTextBoxColumn.DataPropertyName = "Pat_Fecha_Nac"
        Me.PatFechaNacDataGridViewTextBoxColumn.HeaderText = "Fecha Nac"
        Me.PatFechaNacDataGridViewTextBoxColumn.Name = "PatFechaNacDataGridViewTextBoxColumn"
        Me.PatFechaNacDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatFechaNacDataGridViewTextBoxColumn.Width = 85
        '
        'PatDireccionDataGridViewTextBoxColumn
        '
        Me.PatDireccionDataGridViewTextBoxColumn.DataPropertyName = "Pat_Direccion"
        Me.PatDireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.PatDireccionDataGridViewTextBoxColumn.Name = "PatDireccionDataGridViewTextBoxColumn"
        Me.PatDireccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatDireccionDataGridViewTextBoxColumn.Width = 77
        '
        'PatCiudadDataGridViewTextBoxColumn
        '
        Me.PatCiudadDataGridViewTextBoxColumn.DataPropertyName = "Pat_Ciudad"
        Me.PatCiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
        Me.PatCiudadDataGridViewTextBoxColumn.Name = "PatCiudadDataGridViewTextBoxColumn"
        Me.PatCiudadDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatCiudadDataGridViewTextBoxColumn.Width = 65
        '
        'PatCodigoDataGridViewTextBoxColumn
        '
        Me.PatCodigoDataGridViewTextBoxColumn.DataPropertyName = "Pat_Codigo"
        Me.PatCodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.PatCodigoDataGridViewTextBoxColumn.Name = "PatCodigoDataGridViewTextBoxColumn"
        Me.PatCodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatCodigoDataGridViewTextBoxColumn.Width = 65
        '
        'PatEstadoDataGridViewTextBoxColumn
        '
        Me.PatEstadoDataGridViewTextBoxColumn.DataPropertyName = "Pat_Estado"
        Me.PatEstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.PatEstadoDataGridViewTextBoxColumn.Name = "PatEstadoDataGridViewTextBoxColumn"
        Me.PatEstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatEstadoDataGridViewTextBoxColumn.Width = 65
        '
        'PatPaisDataGridViewTextBoxColumn
        '
        Me.PatPaisDataGridViewTextBoxColumn.DataPropertyName = "Pat_Pais"
        Me.PatPaisDataGridViewTextBoxColumn.HeaderText = "Pais"
        Me.PatPaisDataGridViewTextBoxColumn.Name = "PatPaisDataGridViewTextBoxColumn"
        Me.PatPaisDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatPaisDataGridViewTextBoxColumn.Width = 52
        '
        'PatSexoDataGridViewTextBoxColumn
        '
        Me.PatSexoDataGridViewTextBoxColumn.DataPropertyName = "Pat_Sexo"
        Me.PatSexoDataGridViewTextBoxColumn.HeaderText = "Sexo"
        Me.PatSexoDataGridViewTextBoxColumn.Name = "PatSexoDataGridViewTextBoxColumn"
        Me.PatSexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatSexoDataGridViewTextBoxColumn.Width = 56
        '
        'PatTelefonoDataGridViewTextBoxColumn
        '
        Me.PatTelefonoDataGridViewTextBoxColumn.DataPropertyName = "Pat_Telefono"
        Me.PatTelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.PatTelefonoDataGridViewTextBoxColumn.Name = "PatTelefonoDataGridViewTextBoxColumn"
        Me.PatTelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatTelefonoDataGridViewTextBoxColumn.Width = 74
        '
        'PatEmailDataGridViewTextBoxColumn
        '
        Me.PatEmailDataGridViewTextBoxColumn.DataPropertyName = "Pat_Email"
        Me.PatEmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.PatEmailDataGridViewTextBoxColumn.Name = "PatEmailDataGridViewTextBoxColumn"
        Me.PatEmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatEmailDataGridViewTextBoxColumn.Width = 57
        '
        'PatSeguroDataGridViewTextBoxColumn
        '
        Me.PatSeguroDataGridViewTextBoxColumn.DataPropertyName = "Pat_Seguro"
        Me.PatSeguroDataGridViewTextBoxColumn.HeaderText = "Seguro"
        Me.PatSeguroDataGridViewTextBoxColumn.Name = "PatSeguroDataGridViewTextBoxColumn"
        Me.PatSeguroDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatSeguroDataGridViewTextBoxColumn.Width = 66
        '
        'Registro_de_Paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1058, 656)
        Me.Controls.Add(Me.PacBusquedatb)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PacBusquedabt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PacBusquedalb)
        Me.Controls.Add(Me.PacListadgv)
        Me.Controls.Add(Me.PacSegurolb)
        Me.Controls.Add(Me.PacSegurotb)
        Me.Controls.Add(Me.PacBorrarbt)
        Me.Controls.Add(Me.PacGuardarbt)
        Me.Controls.Add(Me.PacEditarbt)
        Me.Controls.Add(Me.PacFechaNacdp)
        Me.Controls.Add(Me.PacApellidotb)
        Me.Controls.Add(Me.PacEmailtb)
        Me.Controls.Add(Me.PacEmaillb)
        Me.Controls.Add(Me.PacFechalb)
        Me.Controls.Add(Me.PacDirectb)
        Me.Controls.Add(Me.PacDirecclb)
        Me.Controls.Add(Me.PacTeleftb)
        Me.Controls.Add(Me.PacTeleflb)
        Me.Controls.Add(Me.PacSexocb)
        Me.Controls.Add(Me.PacSexolb)
        Me.Controls.Add(Me.PacEdadtb)
        Me.Controls.Add(Me.PacEdadlb)
        Me.Controls.Add(Me.PacApellidolb)
        Me.Controls.Add(Me.PacNombretb)
        Me.Controls.Add(Me.PacNombrelb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registro_de_Paciente"
        Me.Text = " "
        CType(Me.PacientesTBL2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultorioDBVBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacListadgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PacTitulolb As Label
    Friend WithEvents PacNombrelb As Label
    Friend WithEvents PacNombretb As TextBox
    Friend WithEvents PacApellidolb As Label
    Friend WithEvents PacEdadlb As Label
    Friend WithEvents PacEdadtb As TextBox
    Friend WithEvents PacSexolb As Label
    Friend WithEvents PacSexocb As ComboBox
    Friend WithEvents PacTeleflb As Label
    Friend WithEvents PacTeleftb As TextBox
    Friend WithEvents PacDirecclb As Label
    Friend WithEvents PacDirectb As TextBox
    Friend WithEvents PacFechalb As Label
    Friend WithEvents PacEmaillb As Label
    Friend WithEvents PacEmailtb As TextBox
    Friend WithEvents PacApellidotb As TextBox
    Friend WithEvents PacFechaNacdp As DateTimePicker
    Friend WithEvents PacEditarbt As Button
    Friend WithEvents PacGuardarbt As Button
    Friend WithEvents PacBorrarbt As Button
    Friend WithEvents PacSegurotb As TextBox
    Friend WithEvents PacSegurolb As Label
    Friend WithEvents PacListadgv As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VitalesIconlb As Label
    Friend WithEvents MedicoIconlb As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents CitasIconlb As Label
    Friend WithEvents Logout As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PacBusquedatb As TextBox
    Friend WithEvents PacBusquedabt As Button
    Friend WithEvents PacBusquedalb As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents ConsultorioDBVBDataSet1 As ConsultorioDBVBDataSet1
    Friend WithEvents PacientesTBL2BindingSource As BindingSource
    Friend WithEvents PacientesTBL2TableAdapter As ConsultorioDBVBDataSet1TableAdapters.PacientesTBL2TableAdapter
    Friend WithEvents TableAdapterManager As ConsultorioDBVBDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents IdPacienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatEdadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatFechaNacDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatDireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatCiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatCodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatEstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatPaisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatSexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatTelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatSeguroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
