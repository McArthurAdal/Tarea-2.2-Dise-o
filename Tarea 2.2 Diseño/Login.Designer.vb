<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.accederbt = New System.Windows.Forms.Button()
        Me.Contrasenalb = New System.Windows.Forms.Label()
        Me.Contrasenatb = New System.Windows.Forms.TextBox()
        Me.Nombreusuariolb = New System.Windows.Forms.Label()
        Me.Nombreusuariotb = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Paginainiciallb = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'accederbt
        '
        Me.accederbt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.accederbt.Location = New System.Drawing.Point(447, 346)
        Me.accederbt.Name = "accederbt"
        Me.accederbt.Size = New System.Drawing.Size(257, 82)
        Me.accederbt.TabIndex = 0
        Me.accederbt.Text = "Acceder"
        Me.accederbt.UseVisualStyleBackColor = False
        '
        'Contrasenalb
        '
        Me.Contrasenalb.AutoSize = True
        Me.Contrasenalb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contrasenalb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Contrasenalb.Location = New System.Drawing.Point(330, 247)
        Me.Contrasenalb.Name = "Contrasenalb"
        Me.Contrasenalb.Size = New System.Drawing.Size(123, 25)
        Me.Contrasenalb.TabIndex = 3
        Me.Contrasenalb.Text = "Contraseña"
        '
        'Contrasenatb
        '
        Me.Contrasenatb.BackColor = System.Drawing.SystemColors.Control
        Me.Contrasenatb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contrasenatb.Location = New System.Drawing.Point(512, 247)
        Me.Contrasenatb.Name = "Contrasenatb"
        Me.Contrasenatb.Size = New System.Drawing.Size(127, 29)
        Me.Contrasenatb.TabIndex = 4
        '
        'Nombreusuariolb
        '
        Me.Nombreusuariolb.AutoSize = True
        Me.Nombreusuariolb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombreusuariolb.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Nombreusuariolb.Location = New System.Drawing.Point(330, 151)
        Me.Nombreusuariolb.Name = "Nombreusuariolb"
        Me.Nombreusuariolb.Size = New System.Drawing.Size(164, 25)
        Me.Nombreusuariolb.TabIndex = 5
        Me.Nombreusuariolb.Text = "Nombre usuario"
        '
        'Nombreusuariotb
        '
        Me.Nombreusuariotb.BackColor = System.Drawing.SystemColors.Control
        Me.Nombreusuariotb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombreusuariotb.Location = New System.Drawing.Point(512, 151)
        Me.Nombreusuariotb.Name = "Nombreusuariotb"
        Me.Nombreusuariotb.Size = New System.Drawing.Size(127, 29)
        Me.Nombreusuariotb.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Paginainiciallb)
        Me.Panel2.Location = New System.Drawing.Point(275, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(619, 38)
        Me.Panel2.TabIndex = 40
        '
        'Paginainiciallb
        '
        Me.Paginainiciallb.AutoSize = True
        Me.Paginainiciallb.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paginainiciallb.Location = New System.Drawing.Point(206, 9)
        Me.Paginainiciallb.Name = "Paginainiciallb"
        Me.Paginainiciallb.Size = New System.Drawing.Size(191, 28)
        Me.Paginainiciallb.TabIndex = 1
        Me.Paginainiciallb.Text = "Pagina Inicial "
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Font = New System.Drawing.Font("Berlin Sans FB", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(269, 625)
        Me.Panel3.TabIndex = 41
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
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
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label14.Location = New System.Drawing.Point(70, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(199, 28)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Oficina Médica"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(921, 625)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Nombreusuariotb)
        Me.Controls.Add(Me.Nombreusuariolb)
        Me.Controls.Add(Me.Contrasenatb)
        Me.Controls.Add(Me.Contrasenalb)
        Me.Controls.Add(Me.accederbt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Página Inicial"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents accederbt As Button
    Friend WithEvents Contrasenalb As Label
    Friend WithEvents Contrasenatb As TextBox
    Friend WithEvents Nombreusuariolb As Label
    Friend WithEvents Nombreusuariotb As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Paginainiciallb As Label
End Class
