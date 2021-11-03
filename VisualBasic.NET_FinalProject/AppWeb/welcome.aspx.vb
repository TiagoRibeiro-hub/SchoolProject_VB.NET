Imports System.Windows.Forms
Imports System.Web.Security
Imports System.Data
Imports System.Data.SqlClient
Imports SQLfuncs
Public Class welcome
    Inherits System.Web.UI.Page
    Dim connection As New SqlConnection("data source =.\sqlexpress; initial catalog = db_Arduino_Casa; integrated security = true;")
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Dim sql As New SQLfuncs.SQLfuncs

        'If sql.selectSystem() = False Then
        '    MessageBox.Show("SYSTEM DOWN !! CALL THE ADMINISTRATOR !!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Response.Redirect("welcome.aspx")
        '    Session.RemoveAll()
        'End If


    End Sub

End Class