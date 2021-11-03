Imports System.Data.SqlClient
Imports System.IO
Imports SQLfuncs
Imports System.Windows.Forms
Imports System.IO.Ports
Public Class formAppMenu

#Region "VARIAVEIS"

    Dim connection As New SqlConnection("data source =.\sqlexpress; initial catalog = db_Arduino_Casa; integrated security = true;")
    Dim admin As String
    Dim log As New formLogIn
    Dim connArd As New formConnArd
    Dim sql As New SQLfuncs.SQLfuncs

#End Region

#Region "LOAD MENU"
    Private Sub formAppMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As New SQLfuncs.SQLfuncs

        Me.LabelBoasVindas.Visible = False
        Me.LabelBoasVindasAdmin.Visible = False
        Me.ConnectionToolStripMenuItem.Enabled = False
        Me.UsersToolStripMenuItem.Enabled = False
        Me.SairToolStripMenuItem.Enabled = False
        Me.RESETSYSTEMToolStripMenuItem.Visible = False
        Me.logInForm()

        If sql.selectSystem() = False Then
            MessageBox.Show("SYSTEM WEB IS DOWN !! ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.RESETSYSTEMToolStripMenuItem.Visible = True
        End If

    End Sub
#End Region

#Region "LOG IN / REGISTER"
    Public Sub logInForm()

        log.MdiParent = Me
        log.Show()
        log.AutoSizeMode = AutoSizeMode.GrowAndShrink
        log.Top = 40
        log.Left = 400
        log.MaximizeBox = False
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If log.Enabled = False Then
            admin = sql.selectAdmin()
            Me.LabelBoasVindasAdmin.Text = admin
            LogInToolStripMenuItem.Enabled = False
            Me.LabelBoasVindas.Visible = True
            Me.LabelBoasVindasAdmin.Visible = True
            Me.ConnectionToolStripMenuItem.Enabled = True
            Me.SairToolStripMenuItem.Enabled = True
            Timer1.Enabled = False
        End If

    End Sub
#End Region

#Region "CONNECTION/PLANTA"
    'CONEXÂO ARDD / PLANTA
    Private Sub ConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionToolStripMenuItem.Click

        For Each f As Form In Application.OpenForms
            If TypeOf f Is formConnArd Then
                If f.WindowState = FormWindowState.Minimized Then
                    f.WindowState = FormWindowState.Normal
                End If
                f.Activate()
                Return
            End If
        Next

        connArd.MdiParent = Me
        connArd.Show()
        connArd.AutoSizeMode = AutoSizeMode.GrowAndShrink
        connArd.Top = 40
        connArd.Left = 450
        connArd.MaximizeBox = False
        Timer2.Enabled = True

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If connArd.PanelLigacao.Visible = False Then
            Me.UsersToolStripMenuItem.Enabled = True
            Me.ConnectionToolStripMenuItem.Text = "Planta"
            connArd.Top = 0
            connArd.Left = 0
            Me.Height = 470
            Me.Width = 1020
            Me.usersOn()
            Timer2.Enabled = False
        End If
    End Sub

#End Region

#Region "USERS"

    'AGENDAMENTOS
    Private Sub AgendamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendamentosToolStripMenuItem.Click

        For Each f As Form In Application.OpenForms
            If TypeOf f Is formAgendamentos Then
                If f.WindowState = FormWindowState.Minimized Then
                    f.WindowState = FormWindowState.Normal
                End If
                f.Activate()
                Return
            End If
        Next

        Dim ag As New formAgendamentos

        ag.MdiParent = Me
        ag.Show()
        ag.AutoSizeMode = AutoSizeMode.GrowAndShrink
        ag.Top = 0
        ag.Left = 0
        ag.MaximizeBox = False
        Me.Height = 467
        Me.Width = 1090

    End Sub
    'USERS ONLINE
    Public Sub usersOn()
        Dim u As New formUsersOnline

        u.MdiParent = Me
        u.Show()
        u.AutoSizeMode = AutoSizeMode.GrowAndShrink
        u.Top = 30
        u.Left = 0
        u.MaximizeBox = False
    End Sub
    Private Sub OnlineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlineToolStripMenuItem.Click

        For Each f As Form In Application.OpenForms
            If TypeOf f Is formUsersOnline Then
                If f.WindowState = FormWindowState.Minimized Then
                    f.WindowState = FormWindowState.Normal
                End If
                f.Activate()
                Return
            End If
        Next

        Me.usersOn()


    End Sub

#End Region

#Region "LOG OUT"
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click

        If MessageBox.Show("Are you sure you want to leave?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If sql.updateStatusAdmin(admin, "no") = False Then
                MessageBox.Show("Good Bye!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Application.[Exit]()
            End If
        End If

    End Sub


#End Region

    Private Sub RESETSYSTEMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESETSYSTEMToolStripMenuItem.Click

        If MessageBox.Show("Is the system already in operation? !! ", "ASKING", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql.systemDown("no")
        End If

    End Sub

End Class