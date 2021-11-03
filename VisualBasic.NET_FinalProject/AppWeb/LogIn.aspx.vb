Imports System.Windows.Forms
Imports System.Web.Security
Imports System.Data
Imports System.Data.SqlClient
Imports SQLfuncs
Imports AppWeb.index
Public Class LogIn
    Inherits System.Web.UI.Page


    Protected Sub LinkButtonRegister_Click(sender As Object, e As EventArgs) Handles LinkButtonRegister.Click
        Response.Redirect("Register.aspx")
    End Sub

    Protected Sub ButtonLogIn_Click(sender As Object, e As EventArgs) Handles ButtonLogIn.Click
        Dim sql As New SQLfuncs.SQLfuncs

        If Me.TextBoxUserName.Text = "" Or Me.TextBoxPassword.Text = "" Then
            MessageBox.Show("Full fill all spaces!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If sql.logInWeb(Me.TextBoxUserName.Text, Me.TextBoxPassword.Text) = True Then
                If sql.updateStatusWeb(Me.TextBoxUserName.Text, "yes") = True Then
                    MessageBox.Show("Successful Logged!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Session("userName") = Me.TextBoxUserName.Text
                    Response.Redirect("Plant.aspx")
                Else
                    cleanTextBox()
                End If
            Else
                cleanTextBox()
            End If
        End If

    End Sub
    Public Sub cleanTextBox()
        MessageBox.Show("Please try again!!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.TextBoxUserName.Text = ""
        Me.TextBoxPassword.Text = ""
        Me.TextBoxUserName.Focus()
    End Sub
End Class