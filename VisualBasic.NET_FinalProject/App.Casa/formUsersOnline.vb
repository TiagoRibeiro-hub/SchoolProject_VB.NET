Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports SQLfuncs
Imports System.Windows.Forms
Imports System.IO.Ports
Public Class formUsersOnline
    Dim connection As New SqlConnection("data source =.\sqlexpress; initial catalog = db_Arduino_Casa; integrated security = true;")
    Dim sql As New SQLfuncs.SQLfuncs

    Private Sub formUsersOnline_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.usersOn()
        TimerUsersOn.Enabled = True

    End Sub

    Private Sub TimerUsersOn_Tick(sender As Object, e As EventArgs) Handles TimerUsersOn.Tick

        Me.usersOn()

    End Sub

    Public Sub usersOn()
        Dim table As New DataTable

        table = sql.usersOnline()
        ListBoxUsersOnline.DataSource = table

        For i = 0 To table.Rows.Count() - 1
            If table.Rows(i).Item(1).Contains("yes") Then
                ListBoxUsersOnline.DisplayMember = "utilizador"
            End If
        Next

    End Sub

End Class