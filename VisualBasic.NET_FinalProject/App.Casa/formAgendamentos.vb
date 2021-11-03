Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports SQLfuncs
Imports System.Windows.Forms
Imports System.IO.Ports
Public Class formAgendamentos

    Dim connection As New SqlConnection("data source =.\sqlexpress; initial catalog = db_Arduino_Casa; integrated security = true;")

#Region "FORM LOAD"
    Private Sub formAgendamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As New SQLfuncs.SQLfuncs
        Dim admin As String
        admin = sql.selectAdmin()
        Me.agendamentoGridUpdate()


    End Sub
#End Region

#Region "GRID AGENDAMENTOS"
    Private Sub TimerAgendamento_Tick(sender As Object, e As EventArgs) Handles TimerAgendamento.Tick

        Me.agendamentoGridUpdate()

    End Sub

    Public Sub agendamentoGridUpdate()
        Dim sql As New SQLfuncs.SQLfuncs
        Dim table As New DataTable

        table = sql.agendamentosInfo()

        gridAgendamentos.DataSource = table

    End Sub

#End Region



End Class