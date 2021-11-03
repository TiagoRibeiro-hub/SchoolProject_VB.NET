<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAppMenu
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.LogInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelBoasVindas = New System.Windows.Forms.Label()
        Me.LabelBoasVindasAdmin = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPortMenu = New System.IO.Ports.SerialPort(Me.components)
        Me.RESETSYSTEMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogInToolStripMenuItem, Me.ConnectionToolStripMenuItem, Me.UsersToolStripMenuItem, Me.SairToolStripMenuItem, Me.RESETSYSTEMToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1482, 28)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip"
        '
        'LogInToolStripMenuItem
        '
        Me.LogInToolStripMenuItem.Name = "LogInToolStripMenuItem"
        Me.LogInToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.LogInToolStripMenuItem.Text = "Log In"
        '
        'ConnectionToolStripMenuItem
        '
        Me.ConnectionToolStripMenuItem.Name = "ConnectionToolStripMenuItem"
        Me.ConnectionToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.ConnectionToolStripMenuItem.Text = "Connect ARD1"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgendamentosToolStripMenuItem, Me.OnlineToolStripMenuItem})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'AgendamentosToolStripMenuItem
        '
        Me.AgendamentosToolStripMenuItem.Name = "AgendamentosToolStripMenuItem"
        Me.AgendamentosToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.AgendamentosToolStripMenuItem.Text = "Agendamentos"
        '
        'OnlineToolStripMenuItem
        '
        Me.OnlineToolStripMenuItem.Name = "OnlineToolStripMenuItem"
        Me.OnlineToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.OnlineToolStripMenuItem.Text = "Online"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.SairToolStripMenuItem.Text = "Log Out"
        '
        'LabelBoasVindas
        '
        Me.LabelBoasVindas.AutoSize = True
        Me.LabelBoasVindas.BackColor = System.Drawing.Color.White
        Me.LabelBoasVindas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBoasVindas.Location = New System.Drawing.Point(631, -1)
        Me.LabelBoasVindas.Name = "LabelBoasVindas"
        Me.LabelBoasVindas.Size = New System.Drawing.Size(147, 29)
        Me.LabelBoasVindas.TabIndex = 4
        Me.LabelBoasVindas.Text = "Bem Vindo "
        '
        'LabelBoasVindasAdmin
        '
        Me.LabelBoasVindasAdmin.AutoSize = True
        Me.LabelBoasVindasAdmin.BackColor = System.Drawing.Color.White
        Me.LabelBoasVindasAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.LabelBoasVindasAdmin.Location = New System.Drawing.Point(784, -1)
        Me.LabelBoasVindasAdmin.Name = "LabelBoasVindasAdmin"
        Me.LabelBoasVindasAdmin.Size = New System.Drawing.Size(168, 29)
        Me.LabelBoasVindasAdmin.TabIndex = 6
        Me.LabelBoasVindasAdmin.Text = "Adminstrador"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'RESETSYSTEMToolStripMenuItem
        '
        Me.RESETSYSTEMToolStripMenuItem.Name = "RESETSYSTEMToolStripMenuItem"
        Me.RESETSYSTEMToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.RESETSYSTEMToolStripMenuItem.Text = "RESET SYSTEM"
        '
        'formAppMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1482, 503)
        Me.Controls.Add(Me.LabelBoasVindasAdmin)
        Me.Controls.Add(Me.LabelBoasVindas)
        Me.Controls.Add(Me.MenuStrip)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "formAppMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents LogInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelBoasVindas As Label
    Friend WithEvents OnlineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelBoasVindasAdmin As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents SerialPortMenu As IO.Ports.SerialPort
    Friend WithEvents RESETSYSTEMToolStripMenuItem As ToolStripMenuItem
End Class
