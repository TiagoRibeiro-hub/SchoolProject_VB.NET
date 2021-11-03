<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUsersOnline
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
        Me.lbUsersOnline = New System.Windows.Forms.Label()
        Me.ListBoxUsersOnline = New System.Windows.Forms.ListBox()
        Me.TimerUsersOn = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lbUsersOnline
        '
        Me.lbUsersOnline.AutoSize = True
        Me.lbUsersOnline.BackColor = System.Drawing.Color.Transparent
        Me.lbUsersOnline.Font = New System.Drawing.Font("MS UI Gothic", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsersOnline.ForeColor = System.Drawing.Color.Green
        Me.lbUsersOnline.Location = New System.Drawing.Point(48, 27)
        Me.lbUsersOnline.Name = "lbUsersOnline"
        Me.lbUsersOnline.Size = New System.Drawing.Size(149, 24)
        Me.lbUsersOnline.TabIndex = 0
        Me.lbUsersOnline.Text = "Users Online"
        '
        'ListBoxUsersOnline
        '
        Me.ListBoxUsersOnline.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ListBoxUsersOnline.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxUsersOnline.ForeColor = System.Drawing.Color.Green
        Me.ListBoxUsersOnline.FormattingEnabled = True
        Me.ListBoxUsersOnline.ItemHeight = 17
        Me.ListBoxUsersOnline.Location = New System.Drawing.Point(12, 84)
        Me.ListBoxUsersOnline.Name = "ListBoxUsersOnline"
        Me.ListBoxUsersOnline.Size = New System.Drawing.Size(237, 276)
        Me.ListBoxUsersOnline.TabIndex = 1
        '
        'TimerUsersOn
        '
        Me.TimerUsersOn.Interval = 10000
        '
        'formUsersOnline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(261, 373)
        Me.Controls.Add(Me.ListBoxUsersOnline)
        Me.Controls.Add(Me.lbUsersOnline)
        Me.Name = "formUsersOnline"
        Me.Text = "UsersOnline"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbUsersOnline As Label
    Friend WithEvents ListBoxUsersOnline As ListBox
    Friend WithEvents TimerUsersOn As Timer
End Class
