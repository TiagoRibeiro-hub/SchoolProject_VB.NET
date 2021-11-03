Imports System.Windows.Forms
Imports System.Web.Security
Imports System.Data
Imports System.Data.SqlClient
Imports SQLfuncs
Imports System.Text
Imports System.Configuration

Public Class Plant
    Inherits System.Web.UI.Page
    Dim connection As New SqlConnection("data source =.\sqlexpress; initial catalog = db_Arduino_Casa; integrated security = true;")
    Dim admin, userAutorizacao As String
    Dim tableAutorizacoes As New DataTable
    Dim dateTimeReal, escolherData As New DateTime

    'FORM LOAD
#Region "FORM LOAD"

    'FORM LOAD
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim sql As New SQLfuncs.SQLfuncs
        Dim table As New DataTable
        Dim utilizadores As New DataTable

        admin = sql.selectAdmin()

        Me.gridAgendIndividuais()

        table = sql.selectEstadoArduino()
        luzes(table)
        autorizacoesLuzes()
        dropDownDias()

        utilizadores = sql.usersOnline()
        For i = 0 To utilizadores.Rows.Count() - 1
            If utilizadores.Rows(i).Item(2).Contains("yes") Or utilizadores.Rows(i).Item(2).Contains("yes.sub") Then
                If Session("userName") = utilizadores.Rows(i).Item(0) Then
                    Me.PanelAutorizacaoAdmin.Visible = True
                    Me.tableAutorizacoesVer()
                    PlaceHolderTableAutorizaçoes.Visible = True
                    Me.dropDownListUsers()
                End If
            End If
        Next


    End Sub

    'LUZES ESTADO ARDUINO
    Public Sub luzes(ByVal table As DataTable)
        Dim sql As New SQLfuncs.SQLfuncs

        'sala
        If table.Rows(0).Item(0).Contains("sal1") Then
            Me.luzesSalaOn()
        ElseIf table.Rows(0).Item(0).ToString().Contains("sal0") Then
            Me.luzesSalaOff()
        End If

        'corredor
        If table.Rows(0).Item(1).ToString().Contains("cor1") Then
            Me.luzesCorredorOn()
        ElseIf table.Rows(0).Item(1).ToString().Contains("cor0") Then
            Me.luzesCorredorOff()
        End If

        'cozinha
        If table.Rows(0).Item(2).ToString().Contains("coz1") Then
            Me.luzesCozinhaOn()
        ElseIf table.Rows(0).Item(2).ToString().Contains("coz0") Then
            Me.luzesCozinhaOff()
        End If

        'quarto1
        If table.Rows(0).Item(3).ToString().Contains("co11") Then
            Me.luzesQuarto1On()
        ElseIf table.Rows(0).Item(3).ToString().Contains("co10") Then
            Me.luzesQuarto1Off()
        End If

        'quarto2
        If table.Rows(0).Item(4).ToString().Contains("co21") Then
            Me.luzesQuarto2On()
        ElseIf table.Rows(0).Item(4).ToString().Contains("co20") Then
            Me.luzesQuarto2Off()
        End If

        'quarto3
        If table.Rows(0).Item(5).ToString().Contains("co31") Then
            Me.luzesQuarto3On()
        ElseIf table.Rows(0).Item(5).ToString().Contains("co30") Then
            Me.luzesQuarto3Off()
        End If

        'casa de banho1
        If table.Rows(0).Item(6).ToString().Contains("cb11") Then
            Me.luzesCasaDeBanho1On()
        ElseIf table.Rows(0).Item(6).ToString().Contains("cb10") Then
            Me.luzesCasaDeBanho1Off()
        End If

        'casa de banho2
        If table.Rows(0).Item(7).ToString().Contains("cb21") Then
            Me.luzesCasaDeBanho2On()
        ElseIf table.Rows(0).Item(7).ToString().Contains("cb20") Then
            Me.luzesCasaDeBanho2Off()
        End If


    End Sub

    'AUTORIZACOES DE LUZES
    Public Sub autorizacoesLuzes()
        Dim sql As New SQLfuncs.SQLfuncs
        Dim table As New DataTable

        table = sql.usersAutorizacoes()

        For i = 1 To table.Rows.Count() - 1
            If table.Rows(i).Item(0) = Session("userName") Then

                'sala
                If table.Rows(i).Item(1).Contains("no") Then
                    Me.ButtonLuzSala.Enabled = False
                    Me.ButtonLuzSala.Text = "X"
                    Me.ImageButtonLuzSalaOn.Enabled = False
                    Me.ImageButtonLuzSalaOff.Enabled = False
                End If

                'corredor
                If table.Rows(i).Item(2).ToString().Contains("no") Then
                    Me.ButtonLuzCorredor.Enabled = False
                    Me.ButtonLuzCorredor.Text = "X"
                    Me.ImageButtonLuzCorredorOn.Enabled = False
                    Me.ImageButtonLuzCorredorOff.Enabled = False
                End If

                'cozinha
                If table.Rows(i).Item(3).ToString().Contains("no") Then
                    Me.ButtonLuzCozinha.Enabled = False
                    Me.ButtonLuzCozinha.Text = "X"
                    Me.ImageButtonLuzCozinhaOn.Enabled = False
                    Me.ImageButtonLuzCozinhaOff.Enabled = False
                End If

                'quarto1
                If table.Rows(i).Item(4).ToString().Contains("no") Then
                    Me.ButtonLuzQuarto1.Enabled = False
                    Me.ButtonLuzQuarto1.Text = "X"
                    Me.ImageButtonLuzQuarto1On.Enabled = False
                    Me.ImageButtonLuzQuarto1Off.Enabled = False
                End If

                'quarto2
                If table.Rows(i).Item(5).ToString().Contains("no") Then
                    Me.ButtonLuzQuarto2.Enabled = False
                    Me.ButtonLuzQuarto2.Text = "X"
                    Me.ImageButtonLuzQuarto2On.Enabled = False
                    Me.ImageButtonLuzQuarto2Off.Enabled = False
                End If

                'quarto3
                If table.Rows(i).Item(6).ToString().Contains("no") Then
                    Me.ButtonLuzQuarto3.Enabled = False
                    Me.ButtonLuzQuarto3.Text = "X"
                    Me.ImageButtonLuzQuarto3On.Enabled = False
                    Me.ImageButtonLuzQuarto3Off.Enabled = False
                End If

                'casa de banho1
                If table.Rows(i).Item(7).ToString().Contains("no") Then
                    Me.ButtonLuzCasaDeBanho1.Enabled = False
                    Me.ButtonLuzCasaDeBanho1.Text = "X"
                    Me.ImageButtonLuzCasaDeBanho1On.Enabled = False
                    Me.ImageButtonLuzCasaDeBanho1Off.Enabled = False
                End If

                'casa de banho2
                If table.Rows(i).Item(8).ToString().Contains("no") Then
                    Me.ButtonLuzCasaDeBanho2.Enabled = False
                    Me.ButtonLuzCasaDeBanho2.Text = "X"
                    Me.ImageButtonCasaDeBanho2On.Enabled = False
                    Me.ImageButtonLuzCasaDeBanho2Off.Enabled = False
                End If

            End If
        Next

    End Sub

    'GRID VIEW
#Region "GRID VIEW"
    'GRID AGENDAMENTOS INDIVIDUAIS
    Public Sub gridAgendIndividuais()
        Dim sql As New SQLfuncs.SQLfuncs
        Dim tableAgendIndividuais As New DataTable

        tableAgendIndividuais = sql.agendamentosIndividuais(Session("userName"))

        Me.GridViewAgendIndividual.DataSource = tableAgendIndividuais
        Me.GridViewAgendIndividual.DataBind()

    End Sub

    'GRID VIEW INFO "TRADUZIR" ON / OFF 
    Private Sub GridViewAgendIndividual_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles GridViewAgendIndividual.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then

            If e.Row.Cells(0).Text.Trim().ToLower().Contains("") Then
                e.Row.Cells(0).Text = "wait"
            End If

            If e.Row.Cells(1).Text.Trim().ToLower().Contains("sal1") Then
                e.Row.Cells(1).Text = "ON"
            ElseIf e.Row.Cells(1).Text.Trim().ToLower().Contains("sal0") Then
                e.Row.Cells(1).Text = "OFF"
            End If

            If e.Row.Cells(2).Text.Trim().ToLower().Contains("cor1") Then
                e.Row.Cells(2).Text = "ON"
            ElseIf e.Row.Cells(2).Text.Trim().ToLower().Contains("cor0") Then
                e.Row.Cells(2).Text = "OFF"
            End If

            If e.Row.Cells(3).Text.Trim().ToLower().Contains("coz1") Then
                e.Row.Cells(3).Text = "ON"
            ElseIf e.Row.Cells(3).Text.Trim().ToLower().Contains("coz0") Then
                e.Row.Cells(3).Text = "OFF"
            End If

            If e.Row.Cells(4).Text.Trim().ToLower().Contains("co11") Then
                e.Row.Cells(4).Text = "ON"
            ElseIf e.Row.Cells(4).Text.Trim().ToLower().Contains("co10") Then
                e.Row.Cells(4).Text = "OFF"
            End If

            If e.Row.Cells(5).Text.Trim().ToLower().Contains("co21") Then
                e.Row.Cells(5).Text = "ON"
            ElseIf e.Row.Cells(5).Text.Trim().ToLower().Contains("co20") Then
                e.Row.Cells(5).Text = "OFF"
            End If

            If e.Row.Cells(6).Text.Trim().ToLower().Contains("co31") Then
                e.Row.Cells(6).Text = "ON"
            ElseIf e.Row.Cells(6).Text.Trim().ToLower().Contains("co30") Then
                e.Row.Cells(6).Text = "OFF"
            End If

            If e.Row.Cells(7).Text.Trim().ToLower().Contains("cb11") Then
                e.Row.Cells(7).Text = "ON"
            ElseIf e.Row.Cells(7).Text.Trim().ToLower().Contains("cb10") Then
                e.Row.Cells(7).Text = "OFF"
            End If

            If e.Row.Cells(8).Text.Trim().ToLower().Contains("cb21") Then
                e.Row.Cells(8).Text = "ON"
            ElseIf e.Row.Cells(8).Text.Trim().ToLower().Contains("cb20") Then
                e.Row.Cells(8).Text = "OFF"
            End If

        End If

    End Sub

#End Region

#End Region

    'LUZES
#Region "LUZES"

    'SALA
#Region "LUZES SALA"
    'SALA LUZ BUTTONS
    Protected Sub ButtonLuzSala_Click(sender As Object, e As EventArgs) Handles ButtonLuzSala.Click
        Me.clickSala()
    End Sub
    Protected Sub ImageButtonLuzSalaOff_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonLuzSalaOff.Click
        Me.clickSala()
    End Sub
    Protected Sub ImageButtonLuzSalaOn_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonLuzSalaOn.Click
        Me.clickSala()
    End Sub

    'SALA LUZ FUNCS
    Public Sub clickSala()
        Dim sql As New SQLfuncs.SQLfuncs
        Dim res As String = "no"
        Dim contador As Integer = 15000

        If pedSala() = True Then
            Exit Sub
        End If

        sql.databaseUpdateStatusAnswer("sal", admin)

        While res = "no"
            res = sql.selectDataAnswer(admin)
            contador -= 1
            If contador = 0 Then
                Exit While
            End If
        End While

        If res = "no" Then
            MessageBox.Show("System Error, contact the administrator!!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeWebbApp()
        Else
            Me.resSala(res)
        End If

    End Sub

    'CONFIRMAR PEDIDO COM ARDUINO 
    Public Function pedSala() As Boolean
        Dim sql As New SQLfuncs.SQLfuncs
        Dim table As New DataTable

        table = sql.selectEstadoArduino()

        If (Me.ButtonLuzSala.Text = "Off" Or ImageButtonLuzSalaOff.Visible = False) And (table.Rows(0).Item(0).Contains("sal1")) Then
            Return False
        ElseIf (Me.ButtonLuzSala.Text = "Off" Or ImageButtonLuzSalaOff.Visible = False) And (table.Rows(0).Item(0).Contains("sal0")) Then
            Me.resSala("sal0")
            Return True
        ElseIf (Me.ButtonLuzSala.Text = "On" Or ImageButtonLuzSalaOn.Visible = False) And (table.Rows(0).Item(0).ToString().Contains("sal0")) Then
            Return False
        ElseIf (Me.ButtonLuzSala.Text = "On" Or ImageButtonLuzSalaOn.Visible = False) And (table.Rows(0).Item(0).ToString().Contains("sal1")) Then
            Me.resSala("sal1")
            Return True
        End If

    End Function
    Public Sub resSala(ByVal res As String)
        Dim sql As New SQLfuncs.SQLfuncs

        If res = "sal1" Then
            Me.luzesSalaOn()
        ElseIf res = "sal0" Then
            Me.luzesSalaOff()
        End If

    End Sub
    Public Sub luzesSalaOn()
        Me.ImageButtonLuzSalaOff.Visible = False
        Me.ImageButtonLuzSalaOn.Visible = True
        Me.ButtonLuzSala.Text = "Off"
        Me.ButtonLuzSala.ForeColor = System.Drawing.Color.Red
        Me.LabelLuzSala.Text = "Luz da Sala Acessa"
        Me.LabelLuzSala.ForeColor = System.Drawing.Color.Red
    End Sub
    Public Sub luzesSalaOff()
        Me.ImageButtonLuzSalaOff.Visible = True
        Me.ImageButtonLuzSalaOn.Visible = False
        Me.ButtonLuzSala.Text = "On"
        Me.ButtonLuzSala.ForeColor = System.Drawing.Color.Black
        Me.LabelLuzSala.Text = "Luz da Sala Apagada"
        Me.LabelLuzSala.ForeColor = System.Drawing.Color.Black
    End Sub

#End Region

    'CORREDOR
#Region "CORREDOR"
    'CORREDOR LUZ BUTTONS
    Protected Sub ButtonLuzCorredor_Click(sender As Object, e As EventArgs) Handles ButtonLuzCorredor.Click
        Me.clickCorredor()
    End Sub
    Protected Sub ImageButtonLuzCorredorOff_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonLuzCorredorOff.Click
        Me.clickCorredor()
    End Sub
    Protected Sub ImageButtonLuzCorredorOn_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonLuzCorredorOn.Click
        Me.clickCorredor()
    End Sub

    'CORREDOR LUZ FUNCS
    Public Sub clickCorredor()
        Dim sql As New SQLfuncs.SQLfuncs
        Dim res As String = "no"
        Dim contador As Integer = 15000

        If pedCorredor() = True Then
            Exit Sub
        End If

        sql.databaseUpdateStatusAnswer("cor", admin)

        While res = "no"
            res = sql.selectDataAnswer(admin)
            contador -= 1
            If contador = 0 Then
                Exit While
            End If
        End While

        If res = "no" Then
            MessageBox.Show("System Error, contact the administrator!!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeWebbApp()
        Else
            Me.resCorredor(res)
        End If

    End Sub

    'CONFIRMAR PEDIDO COM ARDUINO 
    Public Function pedCorredor() As Boolean
        Dim sql As New SQLfuncs.SQLfuncs
        Dim table As New DataTable

        table = sql.selectEstadoArduino()

        If (Me.ButtonLuzCorredor.Text = "Off" Or ImageButtonLuzCorredorOff.Visible = False) And (table.Rows(0).Item(1).Contains("cor1")) Then
            Return False
        ElseIf (Me.ButtonLuzCorredor.Text = "Off" Or ImageButtonLuzCorredorOff.Visible = False) And (table.Rows(0).Item(1).Contains("cor0")) Then
            Me.resSala("cor0")
            Return True
        ElseIf (Me.ButtonLuzCorredor.Text = "On" Or ImageButtonLuzCorredorOn.Visible = False) And (table.Rows(0).Item(1).ToString().Contains("cor0")) Then
            Return False
        ElseIf (Me.ButtonLuzCorredor.Text = "On" Or ImageButtonLuzCorredorOn.Visible = False) And (table.Rows(0).Item(1).ToString().Contains("cor1")) Then
            Me.resSala("cor1")
            Return True
        End If

    End Function

    Public Sub resCorredor(ByVal res As String)
        Dim sql As New SQLfuncs.SQLfuncs

        If res = "cor1" Then
            Me.luzesCorredorOn()
        ElseIf res = "cor0" Then
            Me.luzesCorredorOff()
        End If

    End Sub
    Public Sub luzesCorredorOn()
        Me.ImageButtonLuzCorredorOff.Visible = False
        Me.ImageButtonLuzCorredorOn.Visible = True
        Me.ButtonLuzCorredor.Text = "Off"
        Me.ButtonLuzCorredor.ForeColor = System.Drawing.Color.Red
        Me.LabelLuzCorredor.Text = "Luz do Corredor Acessa"
        Me.LabelLuzCorredor.ForeColor = System.Drawing.Color.Red
    End Sub
    Public Sub luzesCorredorOff()
        Me.ImageButtonLuzCorredorOff.Visible = True
        Me.ImageButtonLuzCorredorOn.Visible = False
        Me.ButtonLuzCorredor.Text = "On"
        Me.ButtonLuzCorredor.ForeColor = System.Drawing.Color.Black
        Me.LabelLuzCorredor.Text = "Luz do Corredor Apagada"
        Me.LabelLuzCorredor.ForeColor = System.Drawing.Color.Black
    End Sub

#End Region

    'COZINHA
#Region "Cozinha"
    'COZINHA LUZ BUTTONS
    Protected Sub ButtonLuzCozinha_Click(sender As Object, e As EventArgs) Handles ButtonLuzCozinha.Click
        Me.clickCozinha()
    End Sub
    Protected Sub ImageButtonLuzCozinhaOff_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonLuzCozinhaOff.Click
        Me.clickCozinha()
    End Sub
    Protected Sub ImageButtonLuzCozinhaOn_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonLuzCozinhaOn.Click
        Me.clickCozinha()
    End Sub

    'COZINHA LUZ FUNCS
    Public Sub clickCozinha()
        Dim sql As New SQLfuncs.SQLfuncs
        Dim res As String = "no"
        Dim contador As Integer = 15000

        If pedCozinha() = True Then
            Exit Sub
        End If

        sql.databaseUpdateStatusAnswer("coz", admin)

        While res = "no"
            res = sql.selectDataAnswer(admin)
            contador -= 1
            If contador = 0 Then
                Exit While
            End If
        End While

        If res = "no" Then
            MessageBox.Show("System Error, contact the administrator!!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeWebbApp()
        Else
            Me.resCozinha(res)
        End If

    End Sub

    'CONFIRMAR PEDIDO COM ARDUINO 
    Public Function pedCozinha() As Boolean
        Dim sql As New SQLfuncs.SQLfuncs
        Dim table As New DataTable

        table = sql.selectEstadoArduino()

        If (Me.ButtonLuzCozinha.Text = "Off" Or ImageButtonLuzCozinhaOff.Visible = False) And (table.Rows(0).Item(2).Contains("coz1")) Then
            Return False
        ElseIf (Me.ButtonLuzCorredor.Text = "Off" Or ImageButtonLuzCozinhaOff.Visible = False) And (table.Rows(0).Item(2).Contains("coz0")) Then
            Me.resSala("coz0")
            Return True
        ElseIf (Me.ButtonLuzCozinha.Text = "On" Or ImageButtonLuzCozinhaOn.Visible = False) And (table.Rows(0).Item(2).ToString().Contains("coz0")) Then
            Return False
        ElseIf (Me.ButtonLuzCozinha.Text = "On" Or ImageButtonLuzCozinhaOn.Visible = False) And (table.Rows(0).Item(2).ToString().Contains("coz1")) Then
            Me.resSala("coz1")
            Return True
        End If

    End Function
    Public Sub resCozinha(ByVal res As String)
        Dim sql As New SQLfuncs.SQLfuncs

        If res = "coz1" Then
            Me.luzesCozinhaOn()
        ElseIf res = "coz0" Then
            Me.luzesCozinhaOff()
        End If

    End Sub
    Public Sub luzesCozinhaOn()
        Me.ImageButtonLuzCozinhaOff.Visible = False
        Me.ImageButtonLuzCozinhaOn.Visible = True
        Me.ButtonLuzCozinha.Text = "Off"
        Me.ButtonLuzCozinha.ForeColor = System.Drawing.Color.Red
        Me.LabelLuzCozinha.Text = "Luz da Cozinha Acessa"
        Me.LabelLuzCozinha.ForeColor = System.Drawing.Color.Red
    End Sub
    Public Sub luzesCozinhaOff()
        Me.ImageButtonLuzCozinhaOff.Visible = True
        Me.ImageButtonLuzCozinhaOn.Visible = False
        Me.ButtonLuzCozinha.Text = "On"
        Me.ButtonLuzCozinha.ForeColor = System.Drawing.Color.Black
        Me.LabelLuzCozinha.Text = "Luz da Cozinha Apagada"
        Me.LabelLuzCozinha.ForeColor = System.Drawing.Color.Black
    End Sub

#End Region

    'QUARTO1
#Region "QUARTO1"
    'QUARTO1 LUZ BUTTONS
    Protected Sub ButtonLuzQuarto1_Click(sender As Object, e As EventArgs) Handles ButtonLuzQuarto1.Click
        Me.clickQuarto1()
    End Sub
    Protected Sub ImageButtonLuzQuarto1Off_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonLuzQuarto1Off.Click
        Me.clickQuarto1()
    End Sub
    Protected Sub ImageButtonLuzQuarto1On_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonLuzQuarto1On.Click
        Me.clickQuarto1()
    End Sub

    'QUARTO1 LUZ FUNC
    Public Sub clickQuarto1()
        Dim sql As New SQLfuncs.SQLfuncs
        Dim res As String = "no"
        Dim contador As Integer = 15000

        If pedQuarto1() = True Then
            Exit Sub
        End If

        sql.databaseUpdateStatusAnswer("co1", admin)

        While res = "no"
            res = sql.selectDataAnswer(admin)
            contador -= 1
            If contador = 0 Then
                Exit While
            End If
        End While

        If res = "no" Then
            MessageBox.Show("System Error, contact the administrator!!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeWebbApp()
        Else
            Me.resQuarto1(res)
        End If

    End Sub

    'CONFIRMAR PEDIDO COM ARDUINO 
    Public Function pedQuarto1() As Boolean
        Dim sql As New SQLfuncs.SQLfuncs
        Dim table As New DataTable

        table = sql.selectEstadoArduino()

        If (Me.ButtonLuzQuarto1.Text = "Off" Or ImageButtonLuzQuarto1Off.Visible = False) And (table.Rows(0).Item(3).Contains("co11")) Then
            Return False
        ElseIf (Me.ButtonLuzQuarto1.Text = "Off" Or ImageButtonLuzQuarto1Off.Visible = False) And (table.Rows(0).Item(3).Contains("co10")) Then
            Me.resSala("co10")
            Return True
        ElseIf (Me.ButtonLuzQuarto1.Text = "On" Or ImageButtonLuzQuarto1On.Visible = False) And (table.Rows(0).Item(3).ToString().Contains("co10")) Then
            Return False
        ElseIf (Me.ButtonLuzQuarto1.Text = "On" Or ImageButtonLuzQuarto1On.Visible = False) And (table.Rows(0).Item(3).ToString().Contains("co11")) Then
            Me.resSala("co11")
            Return True
        End If

    End Function
    Public Sub resQuarto1(ByVal res As String)
        Dim sql As New SQLfuncs.SQLfuncs

        If res = "co11" Then
            Me.luzesQuarto1On()
        ElseIf res = "co10" Then
            Me.luzesQuarto1Off()
        End If

    End Sub
    Public Sub luzesQuarto1On()
        Me.ImageButtonLuzQuarto1Off.Visible = False
        Me.ImageButtonLuzQuarto1On.Visible = True
        Me.ButtonLuzQuarto1.Text = "Off"
        Me.ButtonLuzQuarto1.ForeColor = System.Drawing.Color.Red
        Me.LabelLuzQuarto1.Text = "Luz do Quarto 1 Acessa"
        Me.LabelLuzQuarto1.ForeColor = System.Drawing.Color.Red
    End Sub
    Public Sub luzesQuarto1Off()
        Me.ImageButtonLuzQuarto1Off.Visible = True
        Me.ImageButtonLuzQuarto1On.Visible = False
        Me.ButtonLuzQuarto1.Text = "On"
        Me.ButtonLuzQuarto1.ForeColor = System.Drawing.Color.Black
        Me.LabelLuzQuarto1.Text = "Luz do Quarto 1 Apagada"
        Me.LabelLuzQuarto1.ForeColor = System.Drawing.Color.Black
    End Sub

#End Region

    'QUARTO2
#Region "QUARTO2"
    'QUARTO2 LUZ BUTTONS
    Protected Sub ButtonLuzQuarto2_Click(sender As Object, e As EventArgs) Handles ButtonLuzQuarto2.Click
        Me.clickQuarto2()
    End Sub
    Protected Sub ImageButtonLuzQuarto2Off_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonLuzQuarto2Off.Click
        Me.clickQuarto2()
    End Sub
    Protected Sub ImageButtonLuzQuarto2On_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonLuzQuarto2On.Click
        Me.clickQuarto2()
    End Sub

    'QUARTO2 LUZ FUNC
    Public Sub clickQuarto2()
        Dim sql As New SQLfuncs.SQLfuncs
        Dim res As String = "no"
        Dim contador As Integer = 15000

        If pedQuarto2() = True Then
            Exit Sub
        End If

        sql.databaseUpdateStatusAnswer("co2", admin)

        While res = "no"
            res = sql.selectDataAnswer(admin)
            contador -= 1
            If contador = 0 Then
                Exit While
            End If
        End While

        If res = "no" Then
            MessageBox.Show("System Error, contact the administrator!!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeWebbApp()
        Else
            Me.resQuarto2(res)
        End If
    End Sub

    'CONFIRMAR PEDIDO COM ARDUINO 
    Public Function pedQuarto2() As Boolean
        Dim sql As New SQLfuncs.SQLfuncs
        Dim table As New DataTable

        table = sql.selectEstadoArduino()

        If (Me.ButtonLuzQuarto2.Text = "Off" Or ImageButtonLuzQuarto2Off.Visible = False) And (table.Rows(0).Item(4).Contains("co21")) Then
            Return False
        ElseIf (Me.ButtonLuzQuarto2.Text = "Off" Or ImageButtonLuzQuarto2Off.Visible = False) And (table.Rows(0).Item(4).Contains("co20")) Then
            Me.resSala("co20")
            Return True
        ElseIf (Me.ButtonLuzQuarto2.Text = "On" Or ImageButtonLuzQuarto2On.Visible = False) And (table.Rows(0).Item(4).ToString().Contains("co20")) Then
            Return False
        ElseIf (Me.ButtonLuzQuarto2.Text = "On" Or ImageButtonLuzQuarto2On.Visible = False) And (table.Rows(0).Item(4).ToString().Contains("co21")) Then
            Me.resSala("co21")
            Return True
        End If

    End Function

    Public Sub resQuarto2(ByVal res As String)
        Dim sql As New SQLfuncs.SQLfuncs

        If res = "co21" Then
            Me.luzesQuarto2On()
        ElseIf res = "co20" Then
            Me.luzesQuarto2Off()
        End If

    End Sub
    Public Sub luzesQuarto2On()
        Me.ImageButtonLuzQuarto2Off.Visible = False
        Me.ImageButtonLuzQuarto2On.Visible = True
        Me.ButtonLuzQuarto2.Text = "Off"
        Me.ButtonLuzQuarto2.ForeColor = System.Drawing.Color.Red
        Me.LabelLuzQuarto2.Text = "Luz do Quarto 2 Acessa"
        Me.LabelLuzQuarto2.ForeColor = System.Drawing.Color.Red
    End Sub
    Public Sub luzesQuarto2Off()
        Me.ImageButtonLuzQuarto2Off.Visible = True
        Me.ImageButtonLuzQuarto2On.Visible = False
        Me.ButtonLuzQuarto2.Text = "On"
        Me.ButtonLuzQuarto2.ForeColor = System.Drawing.Color.Black
        Me.LabelLuzQuarto2.Text = "Luz do Quarto 2 Apagada"
        Me.LabelLuzQuarto2.ForeColor = System.Drawing.Color.Black
    End Sub

#End Region

    'QUARTO3
#Region "QUARTO3"
    'QUARTO3 LUZ BUTTONS
    Protected Sub ButtonLuzQuarto3_Click(sender As Object, e As EventArgs) Handles ButtonLuzQuarto3.Click
        Me.clickQuarto3()
    End Sub
    Protected Sub ImageButtonLuzQuarto3Off_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonLuzQuarto3Off.Click
        Me.clickQuarto3()
    End Sub
    Protected Sub ImageButtonLuzQuarto3On_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonLuzQuarto3On.Click
        Me.clickQuarto3()
    End Sub

    'QUARTO3 LUZ FUNC
    Public Sub clickQuarto3()
        Dim sql As New SQLfuncs.SQLfuncs
        Dim res As String = "no"
        Dim contador As Integer = 15000

        If pedQuarto3() = True Then
            Exit Sub
        End If

        sql.databaseUpdateStatusAnswer("co3", admin)

        While res = "no"
            res = sql.selectDataAnswer(admin)
            contador -= 1
            If contador = 0 Then
                Exit While
            End If
        End While

        If res = "no" Then
            MessageBox.Show("System Error, contact the administrator!!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeWebbApp()
        Else
            Me.resQuarto3(res)
        End If
    End Sub


    'CONFIRMAR PEDIDO COM ARDUINO 
    Public Function pedQuarto3() As Boolean
        Dim sql As New SQLfuncs.SQLfuncs
        Dim table As New DataTable

        table = sql.selectEstadoArduino()

        If (Me.ButtonLuzQuarto3.Text = "Off" Or ImageButtonLuzQuarto3Off.Visible = False) And (table.Rows(0).Item(5).Contains("co31")) Then
            Return False
        ElseIf (Me.ButtonLuzQuarto3.Text = "Off" Or ImageButtonLuzQuarto3Off.Visible = False) And (table.Rows(0).Item(5).Contains("co30")) Then
            Me.resSala("co30")
            Return True
        ElseIf (Me.ButtonLuzQuarto3.Text = "On" Or ImageButtonLuzQuarto3On.Visible = False) And (table.Rows(0).Item(5).ToString().Contains("co30")) Then
            Return False
        ElseIf (Me.ButtonLuzQuarto3.Text = "On" Or ImageButtonLuzQuarto3On.Visible = False) And (table.Rows(0).Item(5).ToString().Contains("co31")) Then
            Me.resSala("co31")
            Return True
        End If

    End Function
    Public Sub resQuarto3(ByVal res As String)
        Dim sql As New SQLfuncs.SQLfuncs

        If res = "co31" Then
            Me.luzesQuarto3On()
        ElseIf res = "co30" Then
            Me.luzesQuarto3Off()
        End If

    End Sub
    Public Sub luzesQuarto3On()
        Me.ImageButtonLuzQuarto3Off.Visible = False
        Me.ImageButtonLuzQuarto3On.Visible = True
        Me.ButtonLuzQuarto3.Text = "Off"
        Me.ButtonLuzQuarto3.ForeColor = System.Drawing.Color.Red
        Me.LabelLuzQuarto3.Text = "Luz do Quarto 3 Acessa"
        Me.LabelLuzQuarto3.ForeColor = System.Drawing.Color.Red
    End Sub
    Public Sub luzesQuarto3Off()
        Me.ImageButtonLuzQuarto3Off.Visible = True
        Me.ImageButtonLuzQuarto3On.Visible = False
        Me.ButtonLuzQuarto3.Text = "On"
        Me.ButtonLuzQuarto3.ForeColor = System.Drawing.Color.Black
        Me.LabelLuzQuarto3.Text = "Luz do Quarto 3 Apagada"
        Me.LabelLuzQuarto3.ForeColor = System.Drawing.Color.Black
    End Sub

#End Region

    'CASA DE BANHO1
#Region "CASA DE BANHO1"
    'CASA DE BANHO1 LUZ BUTTONS
    Protected Sub ButtonLuzCasaDeBanho1_Click(sender As Object, e As EventArgs) Handles ButtonLuzCasaDeBanho1.Click
        Me.clickCasaDeBanho1()
    End Sub
    Protected Sub ImageButtonLuzCasaDeBanho1Off_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonLuzCasaDeBanho1Off.Click
        Me.clickCasaDeBanho1()
    End Sub
    Protected Sub ImageButtonLuzCasaDeBanho1On_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonLuzCasaDeBanho1On.Click
        Me.clickCasaDeBanho1()
    End Sub

    'CASA DE BANHO1 LUZ FUNCS
    Public Sub clickCasaDeBanho1()
        Dim sql As New SQLfuncs.SQLfuncs
        Dim res As String = "no"
        Dim contador As Integer = 15000

        If pedCasaDeBanho1() = True Then
            Exit Sub
        End If

        sql.databaseUpdateStatusAnswer("cb1", admin)

        While res = "no"
            res = sql.selectDataAnswer(admin)
            contador -= 1
            If contador = 0 Then
                Exit While
            End If
        End While

        If res = "no" Then
            MessageBox.Show("System Error, contact the administrator!!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeWebbApp()
        Else
            Me.resCasaDeBanho1(res)
        End If

    End Sub

    'CONFIRMAR PEDIDO COM ARDUINO 
    Public Function pedCasaDeBanho1() As Boolean
        Dim sql As New SQLfuncs.SQLfuncs
        Dim table As New DataTable

        table = sql.selectEstadoArduino()

        If (Me.ButtonLuzCasaDeBanho1.Text = "Off" Or ImageButtonLuzCasaDeBanho1Off.Visible = False) And (table.Rows(0).Item(6).Contains("cb11")) Then
            Return False
        ElseIf (Me.ButtonLuzCasaDeBanho1.Text = "Off" Or ImageButtonLuzCasaDeBanho1Off.Visible = False) And (table.Rows(0).Item(6).Contains("cb10")) Then
            Me.resSala("cb10")
            Return True
        ElseIf (Me.ButtonLuzCasaDeBanho1.Text = "On" Or ImageButtonLuzCasaDeBanho1On.Visible = False) And (table.Rows(0).Item(6).ToString().Contains("cb10")) Then
            Return False
        ElseIf (Me.ButtonLuzCasaDeBanho1.Text = "On" Or ImageButtonLuzCasaDeBanho1On.Visible = False) And (table.Rows(0).Item(6).ToString().Contains("cb11")) Then
            Me.resSala("cb11")
            Return True
        End If

    End Function
    Public Sub resCasaDeBanho1(ByVal res As String)
        Dim sql As New SQLfuncs.SQLfuncs

        If res = "cb11" Then
            Me.luzesCasaDeBanho1On()
        ElseIf res = "cb10" Then
            Me.luzesCasaDeBanho1Off()
        End If

    End Sub
    Public Sub luzesCasaDeBanho1On()
        Me.ImageButtonLuzCasaDeBanho1Off.Visible = False
        Me.ImageButtonLuzCasaDeBanho1On.Visible = True
        Me.ButtonLuzCasaDeBanho1.Text = "Off"
        Me.ButtonLuzCasaDeBanho1.ForeColor = System.Drawing.Color.Red
        Me.LabelLuzCasaDeBanho1.Text = "Luz da Casa de Banho 1 Acessa"
        Me.LabelLuzCasaDeBanho1.ForeColor = System.Drawing.Color.Red
    End Sub
    Public Sub luzesCasaDeBanho1Off()
        Me.ImageButtonLuzCasaDeBanho1Off.Visible = True
        Me.ImageButtonLuzCasaDeBanho1On.Visible = False
        Me.ButtonLuzCasaDeBanho1.Text = "On"
        Me.ButtonLuzCasaDeBanho1.ForeColor = System.Drawing.Color.Black
        Me.LabelLuzCasaDeBanho1.Text = "Luz da Casa de Banho 1 Apagada"
        Me.LabelLuzCasaDeBanho1.ForeColor = System.Drawing.Color.Black
    End Sub

#End Region

    'CASA DE BANHO2
#Region "CASA DE BANHO2"
    'CASA DE BANHO2 LUZ BUTTONS
    Protected Sub ButtonLuzCasaDeBanho2_Click(sender As Object, e As EventArgs) Handles ButtonLuzCasaDeBanho2.Click
        Me.clickCasaDeBanho2()
    End Sub
    Protected Sub ImageButtonLuzCasaDeBanho2Off_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonLuzCasaDeBanho2Off.Click
        Me.clickCasaDeBanho2()
    End Sub
    Protected Sub ImageButtonCasaDeBanho2On_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonCasaDeBanho2On.Click
        Me.clickCasaDeBanho2()
    End Sub

    'CASA DE BANHO2 LUZ FUNCS
    Public Sub clickCasaDeBanho2()
        Dim sql As New SQLfuncs.SQLfuncs
        Dim res As String = "no"
        Dim contador As Integer = 15000

        If pedCasaDeBanho2() = True Then
            Exit Sub
        End If

        sql.databaseUpdateStatusAnswer("cb2", admin)

        While res = "no"
            res = sql.selectDataAnswer(admin)
            contador -= 1
            If contador = 0 Then
                Exit While
            End If
        End While

        If res = "no" Then
            MessageBox.Show("System Error, contact the administrator!!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            closeWebbApp()
        Else
            Me.resCasaDeBanho2(res)
        End If
    End Sub

    'CONFIRMAR PEDIDO COM ARDUINO 
    Public Function pedCasaDeBanho2() As Boolean
        Dim sql As New SQLfuncs.SQLfuncs
        Dim table As New DataTable

        table = sql.selectEstadoArduino()

        If (Me.ButtonLuzCasaDeBanho2.Text = "Off" Or ImageButtonLuzCasaDeBanho2Off.Visible = False) And (table.Rows(0).Item(6).Contains("cb21")) Then
            Return False
        ElseIf (Me.ButtonLuzCasaDeBanho2.Text = "Off" Or ImageButtonLuzCasaDeBanho2Off.Visible = False) And (table.Rows(0).Item(6).Contains("cb20")) Then
            Me.resSala("cb20")
            Return True
        ElseIf (Me.ButtonLuzCasaDeBanho2.Text = "On" Or ImageButtonCasaDeBanho2On.Visible = False) And (table.Rows(0).Item(6).ToString().Contains("cb20")) Then
            Return False
        ElseIf (Me.ButtonLuzCasaDeBanho2.Text = "On" Or ImageButtonCasaDeBanho2On.Visible = False) And (table.Rows(0).Item(6).ToString().Contains("cb21")) Then
            Me.resSala("cb21")
            Return True
        End If

    End Function
    Public Sub resCasaDeBanho2(ByVal res As String)
        Dim sql As New SQLfuncs.SQLfuncs

        If res = "cb21" Then
            Me.luzesCasaDeBanho2On()
        ElseIf res = "cb20" Then
            Me.luzesCasaDeBanho2Off()
        End If

    End Sub
    Public Sub luzesCasaDeBanho2On()
        Me.ImageButtonLuzCasaDeBanho2Off.Visible = False
        Me.ImageButtonCasaDeBanho2On.Visible = True
        Me.ButtonLuzCasaDeBanho2.Text = "Off"
        Me.ButtonLuzCasaDeBanho2.ForeColor = System.Drawing.Color.Red
        Me.LabelLuzCasaDeBanho2.Text = "Luz da Casa de Banho 2 Acessa"
        Me.LabelLuzCasaDeBanho2.ForeColor = System.Drawing.Color.Red
    End Sub
    Public Sub luzesCasaDeBanho2Off()
        Me.ImageButtonLuzCasaDeBanho2Off.Visible = True
        Me.ImageButtonCasaDeBanho2On.Visible = False
        Me.ButtonLuzCasaDeBanho2.Text = "On"
        Me.ButtonLuzCasaDeBanho2.ForeColor = System.Drawing.Color.Black
        Me.LabelLuzCasaDeBanho2.Text = "Luz da Casa de Banho 2 Apagada"
        Me.LabelLuzCasaDeBanho2.ForeColor = System.Drawing.Color.Black
    End Sub

#End Region

    'CLOSE WEB APP
    Public Sub closeWebbApp()
        Dim sql As New SQLfuncs.SQLfuncs

        sql.systemDown("yes")
        Session.Remove("userName")
        MessageBox.Show("SYSTEM DOWN !! CALL THE ADMINISTRATOR !!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Response.Redirect("welcome.aspx")
        Session.RemoveAll()

    End Sub

#End Region

    'AGENDAMENTO
#Region "AGENDAMENTO"

    'MOSTRAR DATAS
#Region "MOSTRAR DATAS"
    Public Sub dropDownDias()
        escolherData = System.DateTime.Now.ToString()
        Dim anoBissexto As Integer = escolherData.Year
        Dim dia As Integer = escolherData.Day
        Me.LabelAnoRes.Text = escolherData.Year
        Me.LabelMesRes.Text = escolherData.ToString("MMMM")

        If ((anoBissexto Mod 400 = 0) Or (anoBissexto Mod 4 = 0 And anoBissexto Mod 100 <> 0)) Then
            If Me.LabelMesRes.Text.ToLower.Contains("abril") Or Me.LabelMesRes.Text.ToLower.Contains("junho") Or Me.LabelMesRes.Text.ToLower.Contains("setembro") Or Me.LabelMesRes.Text.ToLower.Contains("novembro") Then
                dias30(dia)
            ElseIf Me.LabelMesRes.Text.ToLower.Contains("fevereiro") Then
                For dias = dia To 29
                    Me.DropDownListDias.Items.Add(dias)
                Next
            Else
                dias31(dia)
            End If
        Else
            If Me.LabelMesRes.Text.ToLower.Contains("abril") Or Me.LabelMesRes.Text.ToLower.Contains("junho") Or Me.LabelMesRes.Text.ToLower.Contains("setembro") Or Me.LabelMesRes.Text.ToLower.Contains("novembro") Then
                dias30(dia)
            ElseIf Me.LabelMesRes.Text.ToLower.Contains("fevereiro") Then
                For dias = dia To 28
                    Me.DropDownListDias.Items.Add(dias)
                Next
            Else
                dias31(dia)
            End If
        End If

    End Sub
    Public Sub dias30(ByVal dia As Integer)
        For dias = dia To 30
            Me.DropDownListDias.Items.Add(dias)
        Next
    End Sub
    Public Sub dias31(ByVal dia As Integer)
        For dias = dia To 31
            Me.DropDownListDias.Items.Add(dias)
        Next
    End Sub


#End Region

    'ESCOLHER E MARCAR AGENDAMENTO
#Region "Escolher e Marcar Agendamento"
    'BUTTON FAZER UPDATE BASE DADOS
    Protected Sub ButtonFazerAgendamento_Click(sender As Object, e As EventArgs) Handles ButtonFazerAgendamento.Click
        Me.marcarAgendamento()
        Me.gridAgendIndividuais()
        CheckBoxSalaOff.Checked = False
        CheckBoxSalaOn.Checked = False
        CheckBoxCorredorOFF.Checked = False
        CheckBoxCorredorON.Checked = False
        CheckBoxluzesCozinhaAgenOFF.Checked = False
        CheckBoxluzesCozinhaAgenON.Checked = False
        CheckBoxluzesQuarto1AgenOFF.Checked = False
        CheckBoxluzesQuarto1AgenON.Checked = False
        CheckBoxluzesQuarto2AgenOFF.Checked = False
        CheckBoxluzesQuarto2AgenON.Checked = False
        CheckBoxluzesQuarto3AgenOFF.Checked = False
        CheckBoxluzesQuarto3AgenON.Checked = False
        CheckBoxLuzesCasaDeBanho1AgendOFF.Checked = False
        CheckBoxLuzesCasaDeBanho1AgendON.Checked = False
        CheckBoxLuzesCasaDeBanho2AgendOFF.Checked = False
        CheckBoxLuzesCasaDeBanho2AgendON.Checked = False
    End Sub

    'MARCAR AGENDAMENTO
    Public Sub marcarAgendamento()
        Dim sql As New SQLfuncs.SQLfuncs
        Dim dataAgendada As String

        dataAgendada = Me.escolherData.Year.ToString() & "/" & Me.escolherData.Month.ToString() & "/" & Me.DropDownListDias.SelectedValue.ToString() & " " & Me.DropDownListHH.SelectedValue.ToString() & ":" & Me.DropDownListMM.SelectedValue.ToString() & ":" & Me.DropDownListSS.SelectedValue.ToString()


        Dim sala, corredor, cozinha, quarto1, quarto2, quarto3, casaDeBanho1, casaDeBanho2 As String

        'sala
        If CheckBoxSalaOn.Checked = True Then
            sala = "sal1"
        ElseIf CheckBoxSalaOff.Checked = True Or CheckBoxSalaOn.Checked = False Or (CheckBoxSalaOff.Checked = True And CheckBoxSalaOn.Checked = True) Or (CheckBoxSalaOff.Checked = False And CheckBoxSalaOn.Checked = False) Then
            sala = "sal0"
        End If
        'corredor
        If CheckBoxCorredorON.Checked = True Then
            corredor = "cor1"
        ElseIf CheckBoxCorredorOFF.Checked = True Or CheckBoxCorredorON.Checked = False Or (CheckBoxCorredorOFF.Checked = True And CheckBoxCorredorON.Checked = True) Or (CheckBoxCorredorOFF.Checked = False And CheckBoxCorredorON.Checked = False) Then
            corredor = "cor0"
        End If
        'cozinha
        If CheckBoxluzesCozinhaAgenON.Checked = True Then
            cozinha = "coz1"
        ElseIf CheckBoxluzesCozinhaAgenOFF.Checked = True Or CheckBoxluzesCozinhaAgenON.Checked = False Or (CheckBoxluzesCozinhaAgenOFF.Checked = True And CheckBoxluzesCozinhaAgenON.Checked = True) Or (CheckBoxluzesCozinhaAgenOFF.Checked = False And CheckBoxluzesCozinhaAgenON.Checked = False) Then
            cozinha = "coz0"
        End If
        'quarto1
        If CheckBoxluzesQuarto1AgenON.Checked = True Then
            quarto1 = "co11"
        ElseIf CheckBoxluzesQuarto1AgenOFF.Checked = True Or CheckBoxluzesQuarto1AgenON.Checked = False Or (CheckBoxluzesQuarto1AgenOFF.Checked = True And CheckBoxluzesQuarto1AgenON.Checked = True) Or (CheckBoxluzesQuarto1AgenOFF.Checked = False And CheckBoxluzesQuarto1AgenON.Checked = False) Then
            quarto1 = "co10"
        End If
        'quarto2
        If CheckBoxluzesQuarto2AgenON.Checked = True Then
            quarto2 = "co21"
        ElseIf CheckBoxluzesQuarto2AgenOFF.Checked = True Or CheckBoxluzesQuarto2AgenON.Checked = False Or (CheckBoxluzesQuarto2AgenOFF.Checked = True And CheckBoxluzesQuarto2AgenON.Checked = True) Or (CheckBoxluzesQuarto2AgenOFF.Checked = False And CheckBoxluzesQuarto2AgenON.Checked = False) Then
            quarto2 = "co20"
        End If
        'quarto3
        If CheckBoxluzesQuarto3AgenON.Checked = True Then
            quarto3 = "co31"
        ElseIf CheckBoxluzesQuarto3AgenOFF.Checked = True Or CheckBoxluzesQuarto3AgenON.Checked = False Or (CheckBoxluzesQuarto3AgenOFF.Checked = True And CheckBoxluzesQuarto3AgenON.Checked = True) Or (CheckBoxluzesQuarto3AgenOFF.Checked = False And CheckBoxluzesQuarto3AgenON.Checked = False) Then
            quarto3 = "co30"
        End If
        'casa de banho1
        If CheckBoxLuzesCasaDeBanho1AgendON.Checked = True Then
            casaDeBanho1 = "cb11"
        ElseIf CheckBoxLuzesCasaDeBanho1AgendOFF.Checked = True Or CheckBoxLuzesCasaDeBanho1AgendON.Checked = False Or (CheckBoxLuzesCasaDeBanho1AgendOFF.Checked = True And CheckBoxLuzesCasaDeBanho1AgendON.Checked = True) Or (CheckBoxLuzesCasaDeBanho1AgendOFF.Checked = False And CheckBoxLuzesCasaDeBanho1AgendON.Checked = False) Then
            casaDeBanho1 = "cb10"
        End If
        'casa de banho2
        If CheckBoxLuzesCasaDeBanho2AgendON.Checked = True Then
            casaDeBanho2 = "cb21"
        ElseIf CheckBoxLuzesCasaDeBanho2AgendOFF.Checked = True Or CheckBoxLuzesCasaDeBanho2AgendON.Checked = False Or (CheckBoxLuzesCasaDeBanho2AgendOFF.Checked = True And CheckBoxLuzesCasaDeBanho2AgendON.Checked = True) Or (CheckBoxLuzesCasaDeBanho2AgendOFF.Checked = False And CheckBoxLuzesCasaDeBanho2AgendON.Checked = False) Then
            casaDeBanho2 = "cb30"
        End If

        sql.agendamentosUpdate(Session("userName"), dataAgendada, sala, corredor, cozinha, quarto1, quarto2, quarto3, casaDeBanho1, casaDeBanho2)

    End Sub

#End Region

    'REFRESH AGENDAMENTO
#Region "Refresh Agendamento"
    Protected Sub TimerRefresh_Tick(sender As Object, e As EventArgs) Handles TimerRefresh.Tick

        Dim sql As New SQLfuncs.SQLfuncs
        Dim table, statusARD As New DataTable

        dateTimeReal = System.DateTime.Now

        table = sql.agendamentosInfo()
        statusARD = sql.selectEstadoArduino()
        refreshAgendamentos(table, statusARD)

    End Sub

    Public Sub refreshAgendamentos(ByVal table As DataTable, ByVal statusARD As DataTable)

        Dim comparar As Integer

        If table.Select.Length = 0 Then
            Exit Sub
        End If
        For i = 0 To table.Rows.Count() - 1
            If table.Rows(i).Item(1).ToString() = "" Then
                Continue For
            End If
            comparar = DateTime.Compare(dateTimeReal, table.Rows(i).Item(1))
            If comparar >= 0 Then
                luzes(statusARD)
            End If
        Next
        Exit Sub

    End Sub

#End Region

#End Region

    'AUTORIZAÇÔES SÒ ADMIN
#Region "Autorizações"

    'DROP DOWN LIST USERS
    Public Sub dropDownListUsers()

        For i = 0 To tableAutorizacoes.Rows.Count() - 1
            Me.DropDownListUsersAutori.Items.Add(tableAutorizacoes.Rows(i).Item(0))
        Next
    End Sub

    'AUTORIZACOES USERS
    Public Sub usersAutorizacoesDropDown(ByVal user As String)

        DropDownListUsersAutori.Items.Clear()

        For i = 0 To tableAutorizacoes.Rows.Count() - 1
            If Me.tableAutorizacoes.Rows(i).Item(0).Contains(user) Then

                If tableAutorizacoes.Rows(i).Item(9).contains("yes") Or tableAutorizacoes.Rows(i).Item(9).contains("yes.sub") Then
                    Me.CheckBoxAdminAutori.Checked = True
                ElseIf tableAutorizacoes.Rows(i).Item(9).contains("no") Then
                    Me.CheckBoxAdminAutori.Checked = False
                End If

                If tableAutorizacoes.Rows(i).Item(1).contains("yes") Then
                    Me.CheckBoxSalaAutori.Checked = True
                ElseIf tableAutorizacoes.Rows(i).Item(1).contains("no") Then
                    Me.CheckBoxSalaAutori.Checked = False
                End If

                If tableAutorizacoes.Rows(i).Item(2).contains("yes") Then
                    Me.CheckBoxCorredorAutori.Checked = True
                ElseIf tableAutorizacoes.Rows(i).Item(2).contains("no") Then
                    Me.CheckBoxCorredorAutori.Checked = False
                End If

                If tableAutorizacoes.Rows(i).Item(3).contains("yes") Then
                    Me.CheckBoxCozinhaAutori.Checked = True
                ElseIf tableAutorizacoes.Rows(i).Item(3).contains("no") Then
                    Me.CheckBoxCozinhaAutori.Checked = False
                End If

                If tableAutorizacoes.Rows(i).Item(4).contains("yes") Then
                    Me.CheckBoxQuarto1Autori.Checked = True
                ElseIf tableAutorizacoes.Rows(i).Item(4).contains("no") Then
                    Me.CheckBoxQuarto1Autori.Checked = False
                End If

                If tableAutorizacoes.Rows(i).Item(5).contains("yes") Then
                    Me.CheckBoxQuarto2Autori.Checked = True
                ElseIf tableAutorizacoes.Rows(i).Item(5).contains("no") Then
                    Me.CheckBoxQuarto2Autori.Checked = False
                End If

                If tableAutorizacoes.Rows(i).Item(6).contains("yes") Then
                    Me.CheckBoxQuarto3Autori.Checked = True
                ElseIf tableAutorizacoes.Rows(i).Item(6).contains("no") Then
                    Me.CheckBoxQuarto3Autori.Checked = False
                End If

                If tableAutorizacoes.Rows(i).Item(7).contains("yes") Then
                    Me.CheckBoxCasaDeBanho1Autori.Checked = True
                ElseIf tableAutorizacoes.Rows(i).Item(7).contains("no") Then
                    Me.CheckBoxCasaDeBanho1Autori.Checked = False
                End If

                If tableAutorizacoes.Rows(i).Item(8).contains("yes") Then
                    Me.CheckBoxCasaDeBanho2Autori.Checked = True
                ElseIf tableAutorizacoes.Rows(i).Item(8).contains("no") Then
                    Me.CheckBoxCasaDeBanho2Autori.Checked = False
                End If
            End If
        Next
        Me.dropDownListUsers()

    End Sub

    'BUTTON ESCOLHER USER
    Protected Sub ButtonRefreshAutori_Click(sender As Object, e As EventArgs) Handles ButtonRefreshAutori.Click

        userAutorizacao = DropDownListUsersAutori.SelectedValue.ToString()
        Me.LabelUsersEscolhidos.Text = userAutorizacao
        Me.usersAutorizacoesDropDown(userAutorizacao)

    End Sub

    'BUTTON GRAVAR PERMISSOES
    Protected Sub ButtonGravarAutori_Click(sender As Object, e As EventArgs) Handles ButtonGravarAutori.Click
        Dim sql As New SQLfuncs.SQLfuncs
        Dim sala, corredor, cozinha, quarto1, quarto2, quarto3, casaDeBanho1, casaDeBanho2, adminAuto As String

        'sala
        If CheckBoxSalaAutori.Checked = False Then
            sala = "no"
        ElseIf CheckBoxSalaAutori.Checked = True Then
            sala = "yes"
        End If
        'corredor
        If CheckBoxCorredorAutori.Checked = False Then
            corredor = "no"
        ElseIf CheckBoxCorredorAutori.Checked = True Then
            corredor = "yes"
        End If
        'cozinha
        If CheckBoxCozinhaAutori.Checked = False Then
            cozinha = "no"
        ElseIf CheckBoxCozinhaAutori.Checked = True Then
            cozinha = "yes"
        End If
        'quarto1
        If CheckBoxQuarto1Autori.Checked = False Then
            quarto1 = "no"
        ElseIf CheckBoxQuarto1Autori.Checked = True Then
            quarto1 = "yes"
        End If
        'quarto2
        If CheckBoxQuarto2Autori.Checked = False Then
            quarto2 = "no"
        ElseIf CheckBoxQuarto2Autori.Checked = True Then
            quarto2 = "yes"
        End If
        'quarto3
        If CheckBoxQuarto3Autori.Checked = False Then
            quarto3 = "no"
        ElseIf CheckBoxQuarto3Autori.Checked = True Then
            quarto3 = "yes"
        End If
        'casa de banho1
        If CheckBoxCasaDeBanho1Autori.Checked = False Then
            casaDeBanho1 = "no"
        ElseIf CheckBoxCasaDeBanho1Autori.Checked = True Then
            casaDeBanho1 = "yes"
        End If
        'casa de banho2
        If CheckBoxCasaDeBanho2Autori.Checked = False Then
            casaDeBanho2 = "no"
        ElseIf CheckBoxCasaDeBanho2Autori.Checked = True Then
            casaDeBanho2 = "yes"
        End If
        'admin
        If CheckBoxAdminAutori.Checked = True Then
            adminAuto = "yes.sub"
        ElseIf CheckBoxAdminAutori.Checked = False Then
            adminAuto = "no"
        End If

        sql.usersAutorizacaoUpdate(Me.LabelUsersEscolhidos.Text, sala, corredor, cozinha, quarto1, quarto2, quarto3, casaDeBanho1, casaDeBanho2, adminAuto)
        Me.LabelUsersEscolhidos.Text = "Escolher user"
        DropDownListUsersAutori.Items.Clear()
        Me.dropDownListUsers()
        PlaceHolderTableAutorizaçoes.Controls.Clear()
        Me.tableAutorizacoesVer()
    End Sub

    'VER TABELA DE AUTORIZACOES
    Public Sub tableAutorizacoesVer()
        Dim sql As New SQLfuncs.SQLfuncs
        Dim html As New StringBuilder()

        tableAutorizacoes = sql.usersAutorizacoes()

        html.Append("<table border = '1'")
        html.Append("<tr>")
        For Each column As DataColumn In tableAutorizacoes.Columns
            html.Append("<th>")
            html.Append(column.ColumnName)
            html.Append("</th>")
        Next
        html.Append("</tr>")

        For Each row As DataRow In tableAutorizacoes.Rows
            html.Append("<tr>")
            For Each column As DataColumn In tableAutorizacoes.Columns
                html.Append("<td>")
                html.Append(row(column.ColumnName))
                html.Append("</td>")
            Next
            html.Append("<tr>")
        Next

        html.Append("</table")

        PlaceHolderTableAutorizaçoes.Controls.Add(New Literal() With {.Text = html.ToString()})

    End Sub




#End Region

End Class