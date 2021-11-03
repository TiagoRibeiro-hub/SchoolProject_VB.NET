<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAgendamentos
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
        Me.gridAgendamentos = New System.Windows.Forms.DataGridView()
        Me.TimerAgendamento = New System.Windows.Forms.Timer(Me.components)
        CType(Me.gridAgendamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridAgendamentos
        '
        Me.gridAgendamentos.AllowUserToAddRows = False
        Me.gridAgendamentos.AllowUserToResizeColumns = False
        Me.gridAgendamentos.AllowUserToResizeRows = False
        Me.gridAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAgendamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridAgendamentos.Location = New System.Drawing.Point(0, 0)
        Me.gridAgendamentos.MultiSelect = False
        Me.gridAgendamentos.Name = "gridAgendamentos"
        Me.gridAgendamentos.ReadOnly = True
        Me.gridAgendamentos.RowHeadersWidth = 51
        Me.gridAgendamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gridAgendamentos.RowTemplate.Height = 24
        Me.gridAgendamentos.Size = New System.Drawing.Size(1405, 420)
        Me.gridAgendamentos.TabIndex = 0
        '
        'TimerAgendamento
        '
        Me.TimerAgendamento.Enabled = True
        Me.TimerAgendamento.Interval = 10000
        '
        'formAgendamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1405, 420)
        Me.Controls.Add(Me.gridAgendamentos)
        Me.Name = "formAgendamentos"
        Me.Text = "formAgendamentos"
        CType(Me.gridAgendamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gridAgendamentos As DataGridView
    Friend WithEvents TimerAgendamento As Timer
End Class
