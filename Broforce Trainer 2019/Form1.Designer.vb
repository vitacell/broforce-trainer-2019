<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblLifes = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLifesSwitch = New System.Windows.Forms.Label()
        Me.lblGrenadesSwitch = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblLifes
        '
        Me.lblLifes.AutoSize = True
        Me.lblLifes.BackColor = System.Drawing.SystemColors.HotTrack
        Me.lblLifes.ForeColor = System.Drawing.Color.Lime
        Me.lblLifes.Location = New System.Drawing.Point(12, 9)
        Me.lblLifes.Name = "lblLifes"
        Me.lblLifes.Size = New System.Drawing.Size(129, 18)
        Me.lblLifes.TabIndex = 1
        Me.lblLifes.Text = "Infinite lifes: F1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Infinite grenades: F2"
        '
        'lblLifesSwitch
        '
        Me.lblLifesSwitch.AutoSize = True
        Me.lblLifesSwitch.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblLifesSwitch.Location = New System.Drawing.Point(187, 9)
        Me.lblLifesSwitch.Name = "lblLifesSwitch"
        Me.lblLifesSwitch.Size = New System.Drawing.Size(38, 18)
        Me.lblLifesSwitch.TabIndex = 3
        Me.lblLifesSwitch.Text = "OFF"
        '
        'lblGrenadesSwitch
        '
        Me.lblGrenadesSwitch.AutoSize = True
        Me.lblGrenadesSwitch.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblGrenadesSwitch.Location = New System.Drawing.Point(187, 74)
        Me.lblGrenadesSwitch.Name = "lblGrenadesSwitch"
        Me.lblGrenadesSwitch.Size = New System.Drawing.Size(38, 18)
        Me.lblGrenadesSwitch.TabIndex = 4
        Me.lblGrenadesSwitch.Text = "OFF"
        '
        'Timer2
        '
        Me.Timer2.Interval = 300
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 95)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 26)
        Me.TextBox2.TabIndex = 6
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(237, 233)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblGrenadesSwitch)
        Me.Controls.Add(Me.lblLifesSwitch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLifes)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Broforce Trainer by LabRat v1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLifes As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLifesSwitch As Label
    Friend WithEvents lblGrenadesSwitch As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
