Imports System.Windows.Forms
Imports System.Web.Security
Imports System.Data
Imports System.Data.SqlClient
Imports SQLfuncs
Public Class index
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim sql As New SQLfuncs.SQLfuncs

        If sql.selectSystem() = False Then
            MessageBox.Show("SYSTEM DOWN !! CALL THE ADMINISTRATOR !!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Session.RemoveAll()
            LinkButtonLogIn.Visible = False

        ElseIf Not Session("userName") = "" Then
            LinkButtonPlanta.Visible = True
            LinkButtonChange.Visible = True
            LinkButtonLogIn.Text = "Log Out"
        End If


    End Sub
    Protected Sub LinkButtonLogIn_Click(sender As Object, e As EventArgs) Handles LinkButtonLogIn.Click

        If LinkButtonLogIn.Text = "Log In" Then
            Response.Redirect("LogIn.aspx")
        ElseIf LinkButtonLogIn.Text = "Log Out" Then
            Dim sql As New SQLfuncs.SQLfuncs
            sql.updateStatusWeb(Session("userName"), "no")
            Session.RemoveAll()
            Response.Redirect("welcome.aspx")
        End If

    End Sub
    Protected Sub LinkButtonPlanta_Click(sender As Object, e As EventArgs) Handles LinkButtonPlanta.Click

        Response.Redirect("Plant.aspx")

    End Sub

    Protected Sub LinkButtonChange_Click(sender As Object, e As EventArgs) Handles LinkButtonChange.Click

        Response.Redirect("Register.aspx")

    End Sub

End Class