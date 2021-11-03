Imports System.Data.SqlClient
Imports System.IO
Imports SQLfuncs
Imports System.Windows.Forms
Imports System.IO.Ports

Public Class formConnArd

#Region "VARIAVEIS"
    Dim connection As New SqlConnection("data source =.\sqlexpress; initial catalog = db_Arduino_Casa; integrated security = true;")
    Dim admin, resDataRecieve, resPedido As String
    Dim out As Boolean = False
    Dim statusARD, utilizadorInfo, table As New DataTable
    Dim dateTimeReal As New DateTime

    Dim salaVF As Boolean = False
    Dim CorredorVF As Boolean = False
    Dim CozinhaVF As Boolean = False
    Dim Quarto1VF As Boolean = False
    Dim Quarto2VF As Boolean = False
    Dim Quarto3VF As Boolean = False
    Dim CasaDeBanho1VF As Boolean = False
    Dim CasaDeBanho2VF As Boolean = False
    Dim cont As Integer = 0

#End Region

    'FORM LOAD / CLOSE
#Region "FORM LOAD/CLOSE"
    Private Sub formConnArd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.PanelPlanta.Visible = False
        Me.Height = 250
        Me.Width = 210

    End Sub

    Private Sub formConnArd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If out = False Then
            e.Cancel = True
            If MessageBox.Show("The application will close !!! Are you sure you want to close the app? ", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                e.Cancel = False
                Application.[Exit]()
            End If
        End If

    End Sub

#End Region

    'LIGAÇÂO ARDUINO
#Region "Ligacao Arduino"
    Private Sub btnShowPorts_Click(sender As Object, e As EventArgs) Handles btnShowPorts.Click

        For Each comports In My.Computer.Ports.SerialPortNames

            If Not Me.cbPorts.Items.Contains(comports) Then

                Me.cbPorts.Items.Add(comports)
                Me.cbPorts.Enabled = True

            End If

        Next
        Me.btnShowPorts.Enabled = False
        Me.btnShowPorts.Visible = False
        Me.btnStart.Visible = True
        Me.btnStart.ForeColor = Color.FromArgb(0, 0, 255)
        Me.lbInfoPort.Visible = True


    End Sub

    Private Sub cbPorts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPorts.SelectedIndexChanged

        Try

            SerialPort.PortName = Me.cbPorts.Text
            Me.btnStart.Enabled = True
            Me.btnStart.PerformClick()


        Catch ex As Exception

            MessageBox.Show("Impossivel selecionar a porta!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try


    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim sql As New SQLfuncs.SQLfuncs
        Try
            SerialPort.Open()
            If MessageBox.Show("Ligação Feita", "ConnectionARD1", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then

                Me.PanelLigacao.Visible = False
                Me.PanelPlanta.Visible = True
                Me.Height = 400
                Me.Width = 1000

                admin = sql.selectAdmin()
                TimerDateTime.Enabled = True
                TimerAccao.Enabled = True

            End If

        Catch ex As Exception

            MessageBox.Show("Não foi possivel abrir a porta!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.lbInfoPort.ForeColor = Color.FromArgb(255, 0, 0)

        End Try

    End Sub
#End Region

    'ARD - BASE DE DADOS
#Region "ARD - BASE DE DADOS"
    Private Sub TimerAccao_Tick(sender As Object, e As EventArgs) Handles TimerAccao.Tick
        Dim sql As New SQLfuncs.SQLfuncs

        resDataRecieve = sql.selectDataRecieve(admin)

        If Not resDataRecieve = "no" Then

            Me.btnDataSend.Visible = True

            Me.tbDataSend.Text = resDataRecieve

            Me.btnDataSend.PerformClick()
        End If

    End Sub

    Private Sub btnDataSend_Click(sender As Object, e As EventArgs) Handles btnDataSend.Click
        Try
            SerialPort.Write(Me.tbDataSend.Text)
            TimerAccao.Enabled = False
            TimerUpdate.Enabled = True
            Me.btnDataSend.Visible = False
        Catch ex As Exception
            MsgBox("Data Send Error")
        End Try
    End Sub


    Private Sub TimerUpdate_Tick(sender As Object, e As EventArgs) Handles TimerUpdate.Tick

        Dim sql As New SQLfuncs.SQLfuncs
        Dim res As Boolean

        Try

            If SerialPort.ReadBufferSize > 0 Then

                Me.tbDataReceive.Text = SerialPort.ReadExisting

            End If

            Me.tbDataReceive.Text = Me.tbDataReceive.Text.Trim()

            'sala
            If Me.tbDataReceive.Text.Contains("sal1") Then
                Me.pbSalaOff.Visible = False
                Me.pbSalaOn.Visible = True
                res = sql.databaseUpdateStatus(Me.tbDataReceive.Text, admin)
                If res = True Then
                    sql.databaseUpdateStatusArduino("sala_resposta", Me.tbDataReceive.Text)
                    TimerAccao.Enabled = True
                    TimerUpdate.Enabled = False
                End If
            End If
            If Me.tbDataReceive.Text.Contains("sal0") Then
                Me.pbSalaOn.Visible = False
                Me.pbSalaOff.Visible = True
                res = sql.databaseUpdateStatus(Me.tbDataReceive.Text, admin)
                If res = True Then
                    sql.databaseUpdateStatusArduino("sala_resposta", Me.tbDataReceive.Text)
                    TimerAccao.Enabled = True
                    TimerUpdate.Enabled = False
                End If
            End If
            'corredor
            If Me.tbDataReceive.Text.Contains("cor1") Then
                Me.pbCorredorOff.Visible = False
                Me.pbCorredorOn.Visible = True
                res = sql.databaseUpdateStatus(Me.tbDataReceive.Text, admin)
                If res = True Then
                    sql.databaseUpdateStatusArduino("corredor_resposta", Me.tbDataReceive.Text)
                    TimerAccao.Enabled = True
                    TimerUpdate.Enabled = False
                End If
            End If
            If Me.tbDataReceive.Text.Contains("cor0") Then
                Me.pbCorredorOn.Visible = False
                Me.pbCorredorOff.Visible = True
                res = sql.databaseUpdateStatus(Me.tbDataReceive.Text, admin)
                If res = True Then
                    sql.databaseUpdateStatusArduino("corredor_resposta", Me.tbDataReceive.Text)
                    TimerAccao.Enabled = True
                    TimerUpdate.Enabled = False
                End If
            End If
            'cozinha
            If Me.tbDataReceive.Text.Contains("coz1") Then
                Me.pbCozinhaOff.Visible = False
                Me.pbCozinhaOn.Visible = True
                res = sql.databaseUpdateStatus(Me.tbDataReceive.Text, admin)
                If res = True Then
                    sql.databaseUpdateStatusArduino("cozinha_resposta", Me.tbDataReceive.Text)
                    TimerAccao.Enabled = True
                    TimerUpdate.Enabled = False
                End If
            End If
            If Me.tbDataReceive.Text.Contains("coz0") Then
                Me.pbCozinhaOn.Visible = False
                Me.pbCozinhaOff.Visible = True
                res = sql.databaseUpdateStatus(Me.tbDataReceive.Text, admin)
                If res = True Then
                    sql.databaseUpdateStatusArduino("cozinha_resposta", Me.tbDataReceive.Text)
                    TimerAccao.Enabled = True
                    TimerUpdate.Enabled = False
                End If
            End If
            'quarto 1
            If Me.tbDataReceive.Text.Contains("co11") Then
                Me.pbQuarto1Off.Visible = False
                Me.pbQuarto1On.Visible = True
                res = sql.databaseUpdateStatus(Me.tbDataReceive.Text, admin)
                If res = True Then
                    sql.databaseUpdateStatusArduino("quarto_1_resposta", Me.tbDataReceive.Text)
                    TimerAccao.Enabled = True
                    TimerUpdate.Enabled = False
                End If
            End If
            If Me.tbDataReceive.Text.Contains("co10") Then
                Me.pbQuarto1On.Visible = False
                Me.pbQuarto1Off.Visible = True
                res = sql.databaseUpdateStatus(Me.tbDataReceive.Text, admin)
                If res = True Then
                    sql.databaseUpdateStatusArduino("quarto_1_resposta", Me.tbDataReceive.Text)
                    TimerAccao.Enabled = True
                    TimerUpdate.Enabled = False
                End If
            End If
            'quarto 2
            If Me.tbDataReceive.Text.Contains("co21") Then
                Me.pbQuarto2Off.Visible = False
                Me.pbQuarto2On.Visible = True
                res = sql.databaseUpdateStatus(Me.tbDataReceive.Text, admin)
                If res = True Then
                    sql.databaseUpdateStatusArduino("quarto_2_resposta", Me.tbDataReceive.Text)
                    TimerAccao.Enabled = True
                    TimerUpdate.Enabled = False
                End If
            End If
            If Me.tbDataReceive.Text.Contains("co20") Then
                Me.pbQuarto2On.Visible = False
                Me.pbQuarto2Off.Visible = True
                res = sql.databaseUpdateStatus(Me.tbDataReceive.Text, admin)
                If res = True Then
                    sql.databaseUpdateStatusArduino("quarto_2_resposta", Me.tbDataReceive.Text)
                    TimerAccao.Enabled = True
                    TimerUpdate.Enabled = False
                End If
            End If
            'quarto 3
            If Me.tbDataReceive.Text.Contains("co31") Then
                Me.pbQuarto3Off.Visible = False
                Me.pbQuarto3On.Visible = True
                res = sql.databaseUpdateStatus(Me.tbDataReceive.Text, admin)
                If res = True Then
                    sql.databaseUpdateStatusArduino("quarto_3_resposta", Me.tbDataReceive.Text)
                    TimerAccao.Enabled = True
                    TimerUpdate.Enabled = False
                End If
            End If
            If Me.tbDataReceive.Text.Contains("co30") Then
                Me.pbQuarto3On.Visible = False
                Me.pbQuarto3Off.Visible = True
                res = sql.databaseUpdateStatus(Me.tbDataReceive.Text, admin)
                If res = True Then
                    sql.databaseUpdateStatusArduino("quarto_3_resposta", Me.tbDataReceive.Text)
                    TimerAccao.Enabled = True
                    TimerUpdate.Enabled = False
                End If
            End If
            'casa de banho 1
            If Me.tbDataReceive.Text.Contains("cb11") Then
                Me.pbCasaDeBanho1Off.Visible = False
                Me.pbCasaDeBanho1On.Visible = True
                res = sql.databaseUpdateStatus(Me.tbDataReceive.Text, admin)
                If res = True Then
                    sql.databaseUpdateStatusArduino("casa_de_banho_1_resposta", Me.tbDataReceive.Text)
                    TimerAccao.Enabled = True
                    TimerUpdate.Enabled = False
                End If
            End If
            If Me.tbDataReceive.Text.Contains("cb10") Then
                Me.pbCasaDeBanho1On.Visible = False
                Me.pbCasaDeBanho1Off.Visible = True
                res = sql.databaseUpdateStatus(Me.tbDataReceive.Text, admin)
                If res = True Then
                    sql.databaseUpdateStatusArduino("casa_de_banho_1_resposta", Me.tbDataReceive.Text)
                    TimerAccao.Enabled = True
                    TimerUpdate.Enabled = False
                End If
            End If
            'casa de banho 2
            If Me.tbDataReceive.Text.Contains("cb21") Then
                Me.pbCasaDeBanho2Off.Visible = False
                Me.pbCasaDeBanho2On.Visible = True
                res = sql.databaseUpdateStatus(Me.tbDataReceive.Text, admin)
                If res = True Then
                    sql.databaseUpdateStatusArduino("casa_de_banho_2_resposta", Me.tbDataReceive.Text)
                    TimerAccao.Enabled = True
                    TimerUpdate.Enabled = False
                End If
            End If
            If Me.tbDataReceive.Text.Contains("cb20") Then
                Me.pbCasaDeBanho2On.Visible = False
                Me.pbCasaDeBanho2Off.Visible = True
                res = sql.databaseUpdateStatus(Me.tbDataReceive.Text, admin)
                If res = True Then
                    sql.databaseUpdateStatusArduino("casa_de_banho_2_resposta", Me.tbDataReceive.Text)
                    TimerAccao.Enabled = True
                    TimerUpdate.Enabled = False
                End If
            End If

            If cont = 8 Then
                reporFalse()
                TimerDateTime.Enabled = True
            Else
                TimerEnviarPedidos.Enabled = True
            End If


        Catch ex As Exception
            MsgBox("Timer Update Pendurou!")
        End Try
    End Sub


#End Region

    'AGENDAMENTOS
#Region "AGENDAMENTOS"
    Private Sub TimerDateTime_Tick_1(sender As Object, e As EventArgs) Handles TimerDateTime.Tick

        dateTimeReal = System.DateTime.Now
        Dim sql As New SQLfuncs.SQLfuncs
        table = sql.agendamentosInfo()
        conferirDateTime(table)

    End Sub
    Public Sub conferirDateTime(ByVal table As DataTable)

        Dim sql As New SQLfuncs.SQLfuncs
        Dim comparar As Integer
        statusARD = sql.selectEstadoArduino()

        If table.Select.Length = 0 Then
            Exit Sub
        End If
        For i = 0 To table.Rows.Count() - 1
            If table.Rows(i).Item(1).ToString() = "" Then
                Continue For
            End If
            utilizadorInfo = table.Rows(i).Table
            comparar = DateTime.Compare(dateTimeReal, table.Rows(i).Item(1))
            If comparar >= 0 Then
                TimerDateTime.Enabled = False
                TimerEnviarPedidos.Enabled = True
                sql.databaseUpdateAgendamentosPedidos("agendamento", "null", utilizadorInfo.Rows(0).Item(0).ToString())
                Exit For
            End If
        Next
        Exit Sub
    End Sub
    Private Sub TimerEnviarPedidos_Tick_1(sender As Object, e As EventArgs) Handles TimerEnviarPedidos.Tick

        Dim Sql As New SQLfuncs.SQLfuncs
        resPedido = Sql.selectDataRecieve(admin)
        verResPedido(resPedido)

    End Sub
    Public Sub verResPedido(ByVal resPedido As String)

        If resPedido.Contains("no") Then
            TimerEnviarPedidos.Enabled = False
            compararPedidos()
        End If

    End Sub
    Public Sub compararPedidos()
        Dim Sql As New SQLfuncs.SQLfuncs


        If utilizadorInfo.Select.Length = 0 Or statusARD.Select.Length = 0 Then
            Exit Sub
        End If

        'Sala
        If salaVF = False Then

            If (utilizadorInfo.Rows(0).Item(2).Contains("sal1") And statusARD.Rows(0).Item(0).ToString().Contains("sal1")) Or (utilizadorInfo.Rows(0).Item(2).Contains("sal0") And statusARD.Rows(0).Item(0).Contains("sal0")) Then
                Sql.databaseUpdateAgendamentosPedidos("sala_pedido", "wait", utilizadorInfo.Rows(0).Item(0).ToString())
                salaVF = True
                cont += 1
            Else
                Sql.updateDataRecieve("sal", admin)
                Sql.databaseUpdateAgendamentosPedidos("sala_pedido", "wait", utilizadorInfo.Rows(0).Item(0).ToString())
                salaVF = True
                cont += 1
                Exit Sub
            End If

        End If


        'Corredor
        If CorredorVF = False Then

            If (utilizadorInfo.Rows(0).Item(3).Contains("cor1") And statusARD.Rows(0).Item(1).Contains("cor1")) Or (utilizadorInfo.Rows(0).Item(3).Contains("cor0") And statusARD.Rows(0).Item(1).Contains("cor0")) Then
                Sql.databaseUpdateAgendamentosPedidos("corredor_pedido", "wait", utilizadorInfo.Rows(0).Item(0).ToString())
                CorredorVF = True
                cont += 1
            Else
                Sql.updateDataRecieve("cor", admin)
                Sql.databaseUpdateAgendamentosPedidos("corredor_pedido", "wait", utilizadorInfo.Rows(0).Item(0).ToString())
                CorredorVF = True
                cont += 1
                Exit Sub
            End If

        End If



        'Cozinha
        If CozinhaVF = False Then

            If (utilizadorInfo.Rows(0).Item(4).Contains("coz1") And statusARD.Rows(0).Item(2).Contains("coz1")) Or (utilizadorInfo.Rows(0).Item(4).Contains("coz0") And statusARD.Rows(0).Item(2).Contains("coz0")) Then
                Sql.databaseUpdateAgendamentosPedidos("cozinha_pedido", "wait", utilizadorInfo.Rows(0).Item(0).ToString())
                CozinhaVF = True
                cont += 1
            Else
                Sql.updateDataRecieve("coz", admin)
                Sql.databaseUpdateAgendamentosPedidos("cozinha_pedido", "wait", utilizadorInfo.Rows(0).Item(0).ToString())
                CozinhaVF = True
                cont += 1
                Exit Sub
            End If

        End If



        'quarto 1
        If Quarto1VF = False Then

            If (utilizadorInfo.Rows(0).Item(5).Contains("co11") And statusARD.Rows(0).Item(3).ToString().Contains("co11")) Or (utilizadorInfo.Rows(0).Item(5).Contains("co10") And statusARD.Rows(0).Item(3).Contains("co10")) Then
                Sql.databaseUpdateAgendamentosPedidos("quarto_1_pedido", "wait", utilizadorInfo.Rows(0).Item(0).ToString())
                Quarto1VF = True
                cont += 1
            Else
                Sql.updateDataRecieve("co1", admin)
                Sql.databaseUpdateAgendamentosPedidos("quarto_1_pedido", "wait", utilizadorInfo.Rows(0).Item(0).ToString())
                Quarto1VF = True
                cont += 1
                Exit Sub
            End If

        End If



        'quarto 2
        If Quarto2VF = False Then

            If (utilizadorInfo.Rows(0).Item(6).Contains("co21") And statusARD.Rows(0).Item(4).Contains("co21")) Or (utilizadorInfo.Rows(0).Item(6).Contains("co20") And statusARD.Rows(0).Item(4).Contains("co20")) Then
                Sql.databaseUpdateAgendamentosPedidos("quarto_2_pedido", "wait", utilizadorInfo.Rows(0).Item(0).ToString())
                Quarto2VF = True
                cont += 1
            Else
                Sql.updateDataRecieve("co2", admin)
                Sql.databaseUpdateAgendamentosPedidos("quarto_2_pedido", "wait", utilizadorInfo.Rows(0).Item(0).ToString())
                Quarto2VF = True
                cont += 1
                Exit Sub
            End If

        End If



        'quarto 3
        If Quarto3VF = False Then

            If (utilizadorInfo.Rows(0).Item(7).Contains("co31") And statusARD.Rows(0).Item(5).Contains("co31")) Or (utilizadorInfo.Rows(0).Item(7).Contains("co30") And statusARD.Rows(0).Item(5).Contains("co30")) Then
                Sql.databaseUpdateAgendamentosPedidos("quarto_3_pedido", "wait", utilizadorInfo.Rows(0).Item(0).ToString())
                Quarto3VF = True
                cont += 1
            Else
                Sql.updateDataRecieve("co3", admin)
                Sql.databaseUpdateAgendamentosPedidos("quarto_3_pedido", "wait", utilizadorInfo.Rows(0).Item(0).ToString())
                Quarto3VF = True
                cont += 1
                Exit Sub
            End If

        End If



        'casa de banho 1
        If CasaDeBanho1VF = False Then

            If (utilizadorInfo.Rows(0).Item(8).Contains("cb11") And statusARD.Rows(0).Item(6).Contains("cb11")) Or (utilizadorInfo.Rows(0).Item(8).Contains("cb10") And statusARD.Rows(0).Item(6).Contains("cb10")) Then
                Sql.databaseUpdateAgendamentosPedidos("casa_de_banho_1_pedido", "wait", utilizadorInfo.Rows(0).Item(0).ToString())
                CasaDeBanho1VF = True
                cont += 1
            Else
                Sql.updateDataRecieve("cb1", admin)
                Sql.databaseUpdateAgendamentosPedidos("casa_de_banho_1_pedido", "wait", utilizadorInfo.Rows(0).Item(0).ToString())
                CasaDeBanho1VF = True
                cont += 1
                Exit Sub
            End If

        End If


        'casa de banho 2
        If CasaDeBanho2VF = False Then

            If (utilizadorInfo.Columns(9).ToString().Contains("cb21") And statusARD.Columns(7).ToString().Contains("cb21")) Or (utilizadorInfo.Columns(9).ToString().Contains("cb20") And statusARD.Columns(7).ToString().Contains("cb20")) Then
                Sql.databaseUpdateAgendamentosPedidos("casa_de_banho_2_pedido", "wait", utilizadorInfo.Rows(0).Item(0).ToString())
                CasaDeBanho2VF = True
                cont += 1
            Else
                Sql.updateDataRecieve("cb2", admin)
                Sql.databaseUpdateAgendamentosPedidos("casa_de_banho_2_pedido", "wait", utilizadorInfo.Rows(0).Item(0).ToString())
                CasaDeBanho2VF = True
                cont += 1
                Exit Sub
            End If

        End If

    End Sub
    Public Sub reporFalse()
        salaVF = False
        CorredorVF = False
        CozinhaVF = False
        Quarto1VF = False
        Quarto2VF = False
        Quarto3VF = False
        CasaDeBanho1VF = False
        CasaDeBanho2VF = False
    End Sub
#End Region
End Class