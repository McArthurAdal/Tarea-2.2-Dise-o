<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Médico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Médico))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MedTitulolb = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MedBorrarbt = New System.Windows.Forms.Button()
        Me.MedGuardarbt = New System.Windows.Forms.Button()
        Me.MedEditarbt = New System.Windows.Forms.Button()
        Me.MedApellidotb = New System.Windows.Forms.TextBox()
        Me.MedicoTBL4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultorioDBVBDataSet1 = New Tarea_2._2_Diseño.ConsultorioDBVBDataSet1()
        Me.MedEspeclb = New System.Windows.Forms.Label()
        Me.MedApellidolb = New System.Windows.Forms.Label()
        Me.MedNombretb = New System.Windows.Forms.TextBox()
        Me.MedNombrelb = New System.Windows.Forms.Label()
        Me.MedEspectb = New System.Windows.Forms.TextBox()
        Me.MedLicensiatb = New System.Windows.Forms.TextBox()
        Me.MedLicensialb = New System.Windows.Forms.Label()
        Me.MedListaMedicodgv = New System.Windows.Forms.DataGridView()
        Me.MedBuscartb = New System.Windows.Forms.TextBox()
        Me.MedBuscarbt = New System.Windows.Forms.Button()
        Me.MedBuscarlb = New System.Windows.Forms.Label()
        Me.MedicoTBL4TableAdapter = New Tarea_2._2_Diseño.ConsultorioDBVBDataSet1TableAdapters.MedicoTBL4TableAdapter()
        Me.TableAdapterManager = New Tarea_2._2_Diseño.ConsultorioDBVBDataSet1TableAdapters.TableAdapterManager()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.MedicoTBL4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultorioDBVBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedListaMedicodgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MedTitulolb)
        Me.Panel2.Location = New System.Drawing.Point(268, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(626, 38)
        Me.Panel2.TabIndex = 41
        '
        'MedTitulolb
        '
        Me.MedTitulolb.AutoSize = True
        Me.MedTitulolb.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedTitulolb.Location = New System.Drawing.Point(264, 5)
        Me.MedTitulolb.Name = "MedTitulolb"
        Me.MedTitulolb.Size = New System.Drawing.Size(99, 29)
        Me.MedTitulolb.TabIndex = 0
        Me.MedTitulolb.Text = "Médico"
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
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 162)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label17.Location = New System.Drawing.Point(97, 172)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 29)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Pacientes"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(3, 237)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(3, 315)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label18.Location = New System.Drawing.Point(97, 246)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 29)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Citas"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label20.Location = New System.Drawing.Point(100, 324)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 29)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Vitales"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(52, 543)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 13
        Me.PictureBox7.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label22.Location = New System.Drawing.Point(125, 556)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(67, 29)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 578)
        Me.Panel1.TabIndex = 40
        '
        'MedBorrarbt
        '
        Me.MedBorrarbt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.MedBorrarbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedBorrarbt.Location = New System.Drawing.Point(712, 557)
        Me.MedBorrarbt.Name = "MedBorrarbt"
        Me.MedBorrarbt.Size = New System.Drawing.Size(169, 51)
        Me.MedBorrarbt.TabIndex = 68
        Me.MedBorrarbt.Text = "Borrar"
        Me.MedBorrarbt.UseVisualStyleBackColor = False
        '
        'MedGuardarbt
        '
        Me.MedGuardarbt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.MedGuardarbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedGuardarbt.Location = New System.Drawing.Point(304, 557)
        Me.MedGuardarbt.Name = "MedGuardarbt"
        Me.MedGuardarbt.Size = New System.Drawing.Size(169, 51)
        Me.MedGuardarbt.TabIndex = 67
        Me.MedGuardarbt.Text = "Guardar"
        Me.MedGuardarbt.UseVisualStyleBackColor = False
        '
        'MedEditarbt
        '
        Me.MedEditarbt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.MedEditarbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedEditarbt.Location = New System.Drawing.Point(508, 557)
        Me.MedEditarbt.Name = "MedEditarbt"
        Me.MedEditarbt.Size = New System.Drawing.Size(169, 51)
        Me.MedEditarbt.TabIndex = 66
        Me.MedEditarbt.Text = "Editar"
        Me.MedEditarbt.UseVisualStyleBackColor = False
        '
        'MedApellidotb
        '
        Me.MedApellidotb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicoTBL4BindingSource, "Med_Apellido", True))
        Me.MedApellidotb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedApellidotb.Location = New System.Drawing.Point(617, 105)
        Me.MedApellidotb.Name = "MedApellidotb"
        Me.MedApellidotb.Size = New System.Drawing.Size(213, 22)
        Me.MedApellidotb.TabIndex = 63
        '
        'MedicoTBL4BindingSource
        '
        Me.MedicoTBL4BindingSource.DataMember = "MedicoTBL4"
        Me.MedicoTBL4BindingSource.DataSource = Me.ConsultorioDBVBDataSet1
        '
        'ConsultorioDBVBDataSet1
        '
        Me.ConsultorioDBVBDataSet1.DataSetName = "ConsultorioDBVBDataSet1"
        Me.ConsultorioDBVBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedEspeclb
        '
        Me.MedEspeclb.AutoSize = True
        Me.MedEspeclb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedEspeclb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.MedEspeclb.Location = New System.Drawing.Point(382, 162)
        Me.MedEspeclb.Name = "MedEspeclb"
        Me.MedEspeclb.Size = New System.Drawing.Size(111, 20)
        Me.MedEspeclb.TabIndex = 61
        Me.MedEspeclb.Text = "Especialidad"
        '
        'MedApellidolb
        '
        Me.MedApellidolb.AutoSize = True
        Me.MedApellidolb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedApellidolb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.MedApellidolb.Location = New System.Drawing.Point(688, 59)
        Me.MedApellidolb.Name = "MedApellidolb"
        Me.MedApellidolb.Size = New System.Drawing.Size(73, 20)
        Me.MedApellidolb.TabIndex = 44
        Me.MedApellidolb.Text = "Apellido"
        '
        'MedNombretb
        '
        Me.MedNombretb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicoTBL4BindingSource, "Med_Nombre", True))
        Me.MedNombretb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedNombretb.Location = New System.Drawing.Point(352, 105)
        Me.MedNombretb.Name = "MedNombretb"
        Me.MedNombretb.Size = New System.Drawing.Size(188, 22)
        Me.MedNombretb.TabIndex = 43
        '
        'MedNombrelb
        '
        Me.MedNombrelb.AutoSize = True
        Me.MedNombrelb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedNombrelb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.MedNombrelb.Location = New System.Drawing.Point(412, 59)
        Me.MedNombrelb.Name = "MedNombrelb"
        Me.MedNombrelb.Size = New System.Drawing.Size(71, 20)
        Me.MedNombrelb.TabIndex = 42
        Me.MedNombrelb.Text = "Nombre"
        '
        'MedEspectb
        '
        Me.MedEspectb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicoTBL4BindingSource, "Med_Especialidad", True))
        Me.MedEspectb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedEspectb.Location = New System.Drawing.Point(352, 203)
        Me.MedEspectb.Name = "MedEspectb"
        Me.MedEspectb.Size = New System.Drawing.Size(188, 22)
        Me.MedEspectb.TabIndex = 73
        '
        'MedLicensiatb
        '
        Me.MedLicensiatb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicoTBL4BindingSource, "Med_Licensia", True))
        Me.MedLicensiatb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedLicensiatb.Location = New System.Drawing.Point(617, 203)
        Me.MedLicensiatb.Name = "MedLicensiatb"
        Me.MedLicensiatb.Size = New System.Drawing.Size(213, 22)
        Me.MedLicensiatb.TabIndex = 75
        '
        'MedLicensialb
        '
        Me.MedLicensialb.AutoSize = True
        Me.MedLicensialb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedLicensialb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.MedLicensialb.Location = New System.Drawing.Point(658, 162)
        Me.MedLicensialb.Name = "MedLicensialb"
        Me.MedLicensialb.Size = New System.Drawing.Size(167, 20)
        Me.MedLicensialb.TabIndex = 74
        Me.MedLicensialb.Text = "Numero de Licensia"
        '
        'MedListaMedicodgv
        '
        Me.MedListaMedicodgv.AllowUserToAddRows = False
        Me.MedListaMedicodgv.AllowUserToDeleteRows = False
        Me.MedListaMedicodgv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.MedListaMedicodgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MedListaMedicodgv.Location = New System.Drawing.Point(304, 342)
        Me.MedListaMedicodgv.Name = "MedListaMedicodgv"
        Me.MedListaMedicodgv.ReadOnly = True
        Me.MedListaMedicodgv.RowHeadersWidth = 102
        Me.MedListaMedicodgv.Size = New System.Drawing.Size(551, 150)
        Me.MedListaMedicodgv.TabIndex = 77
        '
        'MedBuscartb
        '
        Me.MedBuscartb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedBuscartb.Location = New System.Drawing.Point(530, 300)
        Me.MedBuscartb.Name = "MedBuscartb"
        Me.MedBuscartb.Size = New System.Drawing.Size(100, 22)
        Me.MedBuscartb.TabIndex = 82
        '
        'MedBuscarbt
        '
        Me.MedBuscarbt.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.MedBuscarbt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedBuscarbt.Location = New System.Drawing.Point(687, 292)
        Me.MedBuscarbt.Name = "MedBuscarbt"
        Me.MedBuscarbt.Size = New System.Drawing.Size(130, 33)
        Me.MedBuscarbt.TabIndex = 81
        Me.MedBuscarbt.Text = "Buscar"
        Me.MedBuscarbt.UseVisualStyleBackColor = False
        '
        'MedBuscarlb
        '
        Me.MedBuscarlb.AutoSize = True
        Me.MedBuscarlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedBuscarlb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.MedBuscarlb.Location = New System.Drawing.Point(331, 300)
        Me.MedBuscarlb.Name = "MedBuscarlb"
        Me.MedBuscarlb.Size = New System.Drawing.Size(164, 20)
        Me.MedBuscarlb.TabIndex = 80
        Me.MedBuscarlb.Text = "Buscar Por Nombre"
        '
        'MedicoTBL4TableAdapter
        '
        Me.MedicoTBL4TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CitasTBL1TableAdapter = Nothing
        Me.TableAdapterManager.MedicoTBL4TableAdapter = Me.MedicoTBL4TableAdapter
        Me.TableAdapterManager.PacientesTBL2TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Tarea_2._2_Diseño.ConsultorioDBVBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VitalesTBL3TableAdapter = Nothing
        '
        'Médico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(897, 578)
        Me.Controls.Add(Me.MedBuscartb)
        Me.Controls.Add(Me.MedBuscarbt)
        Me.Controls.Add(Me.MedBuscarlb)
        Me.Controls.Add(Me.MedListaMedicodgv)
        Me.Controls.Add(Me.MedLicensiatb)
        Me.Controls.Add(Me.MedLicensialb)
        Me.Controls.Add(Me.MedEspectb)
        Me.Controls.Add(Me.MedBorrarbt)
        Me.Controls.Add(Me.MedGuardarbt)
        Me.Controls.Add(Me.MedEditarbt)
        Me.Controls.Add(Me.MedApellidotb)
        Me.Controls.Add(Me.MedEspeclb)
        Me.Controls.Add(Me.MedApellidolb)
        Me.Controls.Add(Me.MedNombretb)
        Me.Controls.Add(Me.MedNombrelb)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Médico"
        Me.Text = "Médico"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MedicoTBL4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultorioDBVBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedListaMedicodgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents MedTitulolb As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MedBorrarbt As Button
    Friend WithEvents MedGuardarbt As Button
    Friend WithEvents MedEditarbt As Button
    Friend WithEvents MedApellidotb As TextBox
    Friend WithEvents MedEspeclb As Label
    Friend WithEvents MedApellidolb As Label
    Friend WithEvents MedNombretb As TextBox
    Friend WithEvents MedNombrelb As Label
    Friend WithEvents MedEspectb As TextBox
    Friend WithEvents MedLicensiatb As TextBox
    Friend WithEvents MedLicensialb As Label
    Friend WithEvents MedListaMedicodgv As DataGridView
    Friend WithEvents MedBuscartb As TextBox
    Friend WithEvents MedBuscarbt As Button
    Friend WithEvents MedBuscarlb As Label
    Friend WithEvents ConsultorioDBVBDataSet1 As ConsultorioDBVBDataSet1
    Friend WithEvents MedicoTBL4BindingSource As BindingSource
    Friend WithEvents MedicoTBL4TableAdapter As ConsultorioDBVBDataSet1TableAdapters.MedicoTBL4TableAdapter
    Friend WithEvents TableAdapterManager As ConsultorioDBVBDataSet1TableAdapters.TableAdapterManager
End Class
