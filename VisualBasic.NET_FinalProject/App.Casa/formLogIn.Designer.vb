<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogIn
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
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbAdministrator = New System.Windows.Forms.TextBox()
        Me.lbPass = New System.Windows.Forms.Label()
        Me.lbAdmin = New System.Windows.Forms.Label()
        Me.lbRepeatPassword = New System.Windows.Forms.Label()
        Me.tbRepeatPassword = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.LabelLogOut = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(177, 196)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(75, 30)
        Me.btnLogIn.TabIndex = 5
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = True
        Me.btnLogIn.Visible = False
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(177, 93)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(200, 22)
        Me.tbPassword.TabIndex = 2
        '
        'tbAdministrator
        '
        Me.tbAdministrator.Location = New System.Drawing.Point(177, 34)
        Me.tbAdministrator.Name = "tbAdministrator"
        Me.tbAdministrator.Size = New System.Drawing.Size(200, 22)
        Me.tbAdministrator.TabIndex = 1
        '
        'lbPass
        '
        Me.lbPass.AutoSize = True
        Me.lbPass.Location = New System.Drawing.Point(62, 96)
        Me.lbPass.Name = "lbPass"
        Me.lbPass.Size = New System.Drawing.Size(69, 17)
        Me.lbPass.TabIndex = 7
        Me.lbPass.Text = "Password"
        '
        'lbAdmin
        '
        Me.lbAdmin.AutoSize = True
        Me.lbAdmin.Location = New System.Drawing.Point(40, 34)
        Me.lbAdmin.Name = "lbAdmin"
        Me.lbAdmin.Size = New System.Drawing.Size(91, 17)
        Me.lbAdmin.TabIndex = 6
        Me.lbAdmin.Text = "Administrator"
        '
        'lbRepeatPassword
        '
        Me.lbRepeatPassword.AutoSize = True
        Me.lbRepeatPassword.Location = New System.Drawing.Point(12, 158)
        Me.lbRepeatPassword.Name = "lbRepeatPassword"
        Me.lbRepeatPassword.Size = New System.Drawing.Size(119, 17)
        Me.lbRepeatPassword.TabIndex = 8
        Me.lbRepeatPassword.Text = "Repeat Password"
        '
        'tbRepeatPassword
        '
        Me.tbRepeatPassword.Location = New System.Drawing.Point(177, 152)
        Me.tbRepeatPassword.Name = "tbRepeatPassword"
        Me.tbRepeatPassword.Size = New System.Drawing.Size(200, 22)
        Me.tbRepeatPassword.TabIndex = 3
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(177, 196)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 30)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'LabelLogOut
        '
        Me.LabelLogOut.AutoSize = True
        Me.LabelLogOut.Location = New System.Drawing.Point(369, 227)
        Me.LabelLogOut.Name = "LabelLogOut"
        Me.LabelLogOut.Size = New System.Drawing.Size(56, 17)
        Me.LabelLogOut.TabIndex = 9
        Me.LabelLogOut.Text = "Log out"
        '
        'formLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 253)
        Me.Controls.Add(Me.LabelLogOut)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.tbRepeatPassword)
        Me.Controls.Add(Me.lbRepeatPassword)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbAdministrator)
        Me.Controls.Add(Me.lbPass)
        Me.Controls.Add(Me.lbAdmin)
        Me.Name = "formLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "formLogIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogIn As Button
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbAdministrator As TextBox
    Friend WithEvents lbPass As Label
    Friend WithEvents lbAdmin As Label
    Friend WithEvents lbRepeatPassword As Label
    Friend WithEvents tbRepeatPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents LabelLogOut As Label
End Class
