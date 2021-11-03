Imports System.Data.SqlClient
Imports System.IO
Imports SQLfuncs
Imports System.Windows.Forms
Imports System.IO.Ports
Public Class formLogIn
    Dim connection As New SqlConnection("data source =.\sqlexpress; initial catalog = db_Arduino_Casa; integrated security = true;")
    Dim sql As New SQLfuncs.SQLfuncs
    Dim out As Boolean = False

#Region "FORM LOAD/CLOSE"

    Private Sub formLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.tbPassword.UseSystemPasswordChar = True
        Me.tbRepeatPassword.UseSystemPasswordChar = True

        Dim res As Boolean
        res = sql.confirmAdmin()
        If res = True Then
            Me.btnRegister.Visible = False
            Me.btnLogIn.Visible = True
        End If

    End Sub

    Private Sub formLogIn_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If out = False Then
            e.Cancel = True
        End If

    End Sub

    Private Sub LabelLogOut_Click(sender As Object, e As EventArgs) Handles LabelLogOut.Click
        out = True
        Application.[Exit]()
    End Sub

#End Region

#Region "Register"
    Private Sub tbRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If tbAdministrator.Text = "" Or tbPassword.Text = "" Or tbRepeatPassword.Text = "" Then
            MessageBox.Show("Full fill all spaces!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Me.tbPassword.Text = Me.tbRepeatPassword.Text Then
                sql.registerAdmin(Me.tbAdministrator.Text, Me.tbPassword.Text)
                Me.btnRegister.Visible = False
                Me.btnLogIn.Visible = True
                Me.tbPassword.Text = ""
                Me.tbRepeatPassword.Text = ""
            Else
                MessageBox.Show("Password don't match!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

#End Region

#Region "Log In"
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        If Me.tbPassword.Text = Me.tbRepeatPassword.Text Then
            If sql.logInAdmin(Me.tbAdministrator.Text, Me.tbPassword.Text) = True Then
                If sql.updateStatusAdmin(Me.tbAdministrator.Text, "yes") = True Then
                    out = True
                    Me.Visible = False
                    Me.Enabled = False
                Else
                    Me.cleanTextBox()
                End If
            Else
                Me.cleanTextBox()
            End If
        Else
            MessageBox.Show("Password don't match!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cleanPassworText()
        End If

    End Sub
    Public Sub cleanTextBox()
        MessageBox.Show("Please try again!!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cleanPassworText()
        Me.tbAdministrator.Text = ""
        Me.tbAdministrator.Focus()
    End Sub
    Public Sub cleanPassworText()
        Me.tbPassword.Text = ""
        Me.tbPassword.Focus()
        Me.tbRepeatPassword.Text = ""
    End Sub

#End Region
End Class