Imports System.Windows.Forms
Imports System.Web.Security
Imports System.Data
Imports System.Data.SqlClient
Imports SQLfuncs

Public Class Register
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Session("userName") = "" Then
            Me.ButtonRegister.Visible = True
            Dim sql As New SQLfuncs.SQLfuncs
            Dim table As New DataTable

            table = sql.usersOnline()

            If table.Select.Length = 0 Then
                Me.CheckBoxAdmin.Visible = True
                'Me.CheckBoxAdmin.Checked = True
            ElseIf table.Rows(0).Item(2).contains("yes") Then
                Me.CheckBoxAdmin.Visible = False
            ElseIf table.Rows(0).Item(2).contains("no") Then
                Me.CheckBoxAdmin.Visible = True
                'Me.CheckBoxAdmin.Checked = True
            End If
        Else
            Me.ButtonAlterar.Visible = True
            Me.CheckBoxAdmin.Visible = False
        End If

    End Sub
    Public Sub cleanTextBox()
        Me.TextBoxUserName.Text = ""
        Me.TextBoxPassword.Text = ""
        Me.TextBoxRepeatPassword.Text = ""
        Me.TextBoxUserName.Focus()
    End Sub

    Protected Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click


        If TextBoxUserName.Text = "" Or TextBoxPassword.Text = "" Or TextBoxRepeatPassword.Text = "" Then
            MessageBox.Show("Full fill all spaces!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cleanTextBox()
        Else
            If TextBoxPassword.Text = TextBoxRepeatPassword.Text Then

                Dim sql As New SQLfuncs.SQLfuncs
                Dim admin As String = "no"

                If Me.CheckBoxAdmin.Checked = True Then
                    admin = "yes"
                End If

                If sql.registerUsers(TextBoxUserName.Text, TextBoxPassword.Text, admin) = True Then
                    Response.Redirect("LogIn.aspx")
                Else
                    cleanTextBox()
                End If
            Else
                MessageBox.Show("Password don't match!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cleanTextBox()
            End If
        End If

    End Sub

    Protected Sub ButtonAlterar_Click(sender As Object, e As EventArgs) Handles ButtonAlterar.Click

        If TextBoxUserName.Text = "" Or TextBoxPassword.Text = "" Or TextBoxRepeatPassword.Text = "" Then
            MessageBox.Show("Full fill all spaces!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cleanTextBox()
        Else
            If TextBoxPassword.Text = TextBoxRepeatPassword.Text Then
                Dim sql As New SQLfuncs.SQLfuncs
                If sql.changeInfo(TextBoxUserName.Text, TextBoxPassword.Text) = True Then
                    Response.Redirect("Plant.aspx")
                Else
                    cleanTextBox()
                End If
            Else
                MessageBox.Show("Password don't match!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cleanTextBox()
            End If
        End If
    End Sub
End Class