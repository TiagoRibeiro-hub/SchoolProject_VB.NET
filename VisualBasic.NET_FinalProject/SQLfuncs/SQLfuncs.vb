Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms
Imports System.Data

Public Class SQLfuncs

    Dim connection As New SqlConnection("data source =.\sqlexpress; initial catalog = db_Arduino_Casa; integrated security = true;")
    Dim admin As String

    'CONEXOES
#Region "CONEXOES"
    'OPEN CONNECTION
    Public Sub open()
        connection.Open()
    End Sub
    'CLOSE CONNECTION
    Public Sub close()
        connection.Close()
    End Sub
#End Region
    'ADMIN APP
#Region "ADMIN APP"
    'REGISTER ADMIN
    Public Sub registerAdmin(ByVal userName As String, ByVal password As String)

        Dim command As New SqlCommand

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_registerAdmin"
        command.Parameters.AddWithValue("@username", userName)
        command.Parameters.AddWithValue("@password", password)
        Try

            open()

            If command.ExecuteNonQuery() > -1 Then
                MessageBox.Show("Successful operation!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                close()
            Else
                MessageBox.Show("System error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                close()
            End If



        Catch ex As Exception
            MessageBox.Show("Please try again!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Sub

    'CONFIRM ADMIN
    Public Function confirmAdmin() As Boolean

        Dim command As New SqlCommand
        Dim reader As SqlDataReader

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_confirmAdmin"

        Try
            open()

            reader = command.ExecuteReader()

            While reader.Read()
                If reader(0).Contains("yes") Then
                    Return True
                Else
                    Return False
                End If
            End While

            close()

        Catch ex As Exception
            MessageBox.Show("Confirm Admin Erro!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

    'LOG IN
    Public Function logInAdmin(ByVal userName As String, ByVal password As String) As Boolean

        Dim command As New SqlCommand
        Dim reader As SqlDataReader

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_logInApp"
        command.Parameters.AddWithValue("@username", userName)

        Try
            open()

            reader = command.ExecuteReader()

            While reader.Read()
                If reader(0).Contains(password) Then
                    Return True
                Else
                    Return False
                End If
            End While

            close()

        Catch ex As Exception
            MessageBox.Show("Please try again,!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function
    'UPDATE STATUS ADMIN
    Public Function updateStatusAdmin(ByVal userName As String, ByVal online As String) As Boolean

        Dim command As New SqlCommand

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_adminStatus"
        command.Parameters.AddWithValue("@online", online)
        command.Parameters.AddWithValue("@username", userName)
        Try
            open()

            command.ExecuteNonQuery()
            If online.Contains("yes") Then
                Return True
            ElseIf online.Contains("no") Then
                Return False
            End If

            close()

        Catch ex As Exception
            MessageBox.Show("Please try again, Update Status!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

    'SELECT ADMIN
    Public Function selectAdmin() As String

        Dim command As New SqlCommand
        Dim reader As SqlDataReader

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_selectAdmin"

        open()

        reader = command.ExecuteReader()
        While reader.Read()
            admin = reader.GetValue(0)
        End While

        close()

        Return admin

    End Function
#End Region

    'SISTEMA DOWN 
#Region "SYSTEM DOWN"

    'SELECT
    Public Function selectSystem() As Boolean

        Dim command As New SqlCommand
        Dim reader As SqlDataReader

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_systemStatus"

        Try
            open()

            reader = command.ExecuteReader()

            While reader.Read()
                If reader(0).Contains("no") Then
                    Return True
                Else
                    Return False
                End If
            End While

            close()

        Catch ex As Exception
            MessageBox.Show("Select System funcs!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False

        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

    'UPDATE
    Public Sub systemDown(ByVal estado As String)

        Dim command As New SqlCommand

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_systemDown"
        command.Parameters.AddWithValue("@estado", estado)

        Try
            open()

            command.ExecuteNonQuery()

            close()

        Catch ex As Exception
            MessageBox.Show("System down funcs!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try


    End Sub

#End Region

    'DIVISOES PEDIDOS E RESPOSTAS
#Region "DIVISOES PEDIDOS E RESPOSTAS"

    'SELECT DATA RECIEVE
    Public Function selectDataRecieve(ByVal username As String) As String

        Dim command As New SqlCommand
        Dim reader As SqlDataReader
        Dim res As String

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_ArdAppRequest"
        command.Parameters.AddWithValue("@username", username)

        Try
            open()

            reader = command.ExecuteReader()

            While reader.Read()
                If reader(0).Contains("no") Then
                    res = "no"
                ElseIf reader(0).Contains("sal") Then
                    res = "l"
                ElseIf reader(0).Contains("cor") Then
                    res = "h"
                ElseIf reader(0).Contains("coz") Then
                    res = "k"
                ElseIf reader(0).Contains("co1") Then
                    res = "q"
                ElseIf reader(0).Contains("co2") Then
                    res = "r"
                ElseIf reader(0).Contains("co3") Then
                    res = "s"
                ElseIf reader(0).Contains("cb1") Then
                    res = "c"
                ElseIf reader(0).Contains("cb2") Then
                    res = "b"
                End If
            End While

            close()

            Return res

        Catch ex As Exception
            MessageBox.Show("Please try again, Data Recieve!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return res = ""

        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

    'SELECT DATA ANSWER
    Public Function selectDataAnswer(ByVal username As String) As String

        Dim command As New SqlCommand
        Dim reader As SqlDataReader
        Dim res As String

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_selectArdAppAnswer"
        command.Parameters.AddWithValue("@username", username)

        Try
            open()

            reader = command.ExecuteReader()

            While reader.Read()
                If reader(0).Contains("no") Then
                    res = "no"
                End If
                'sala
                If reader(0).Contains("sal1") Then
                    res = "sal1"
                ElseIf reader(0).Contains("sal0") Then
                    res = "sal0"
                End If
                'corredor
                If reader(0).Contains("cor1") Then
                    res = "cor1"
                ElseIf reader(0).Contains("cor0") Then
                    res = "cor0"
                End If
                'cozinha
                If reader(0).Contains("coz1") Then
                    res = "coz1"
                ElseIf reader(0).Contains("coz0") Then
                    res = "coz0"
                End If
                'quarto1
                If reader(0).Contains("co11") Then
                    res = "co11"
                ElseIf reader(0).Contains("co10") Then
                    res = "co10"
                End If
                'quarto2
                If reader(0).Contains("co21") Then
                    res = "co21"
                ElseIf reader(0).Contains("co20") Then
                    res = "co20"
                End If
                'quarto3
                If reader(0).Contains("co31") Then
                    res = "co31"
                ElseIf reader(0).Contains("co30") Then
                    res = "co30"
                End If
                'casa de banho1
                If reader(0).Contains("cb11") Then
                    res = "cb11"
                ElseIf reader(0).Contains("cb10") Then
                    res = "cb10"
                End If
                'casa de banho2
                If reader(0).Contains("cb21") Then
                    res = "cb21"
                ElseIf reader(0).Contains("cb20") Then
                    res = "cb20"
                End If
            End While

            Return res
            close()


        Catch ex As Exception
            MessageBox.Show("Please try again, Data Answer!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return res = ""

        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

    'UPDATE DATA RECIEVE
    Public Function updateDataRecieve(ByVal estado As String, ByVal username As String) As Boolean

        Dim command As New SqlCommand

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_UpdateArdAppRequest"
        command.Parameters.AddWithValue("@estado", estado)
        command.Parameters.AddWithValue("@username", username)

        Try
            open()

            If command.ExecuteNonQuery() > -1 Then
                Return True
            Else
                Return False
            End If

            close()

        Catch ex As Exception
            MessageBox.Show("Please try again Update Data Recieve!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

    'UPDATE DATA ANSWER
    Public Function databaseUpdateStatusAnswer(ByVal estado As String, ByVal username As String) As Boolean

        Dim command As New SqlCommand

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_UpdateArdAppAnswer"
        command.Parameters.AddWithValue("@estado", estado)
        command.Parameters.AddWithValue("@username", username)

        Try
            open()

            If command.ExecuteNonQuery() > -1 Then
                Return True
            Else
                Return False
            End If

            close()

        Catch ex As Exception
            MessageBox.Show("Please try again Update Data Answer!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

    'UPDATE STATUS RESPOSTA/PEDIDOS
    Public Function databaseUpdateStatus(ByVal estado As String, ByVal username As String) As Boolean

        Dim command As New SqlCommand

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_ArdAppAnswer"
        command.Parameters.AddWithValue("@estado", estado)
        command.Parameters.AddWithValue("@username", username)

        Try
            open()

            If command.ExecuteNonQuery() > -1 Then
                Return True
            Else
                Return False
            End If

            close()

        Catch ex As Exception
            MessageBox.Show("Please try again Update Answer!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

#End Region

    'ESTADO ARDUINO
#Region "ESTADO ARDUINO"
    'SELECT ESTADO ARDUINO
    Public Function selectEstadoArduino() As DataTable

        Dim command As New SqlCommand
        Dim reader As SqlDataReader
        Dim table As New DataTable

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_estadoARD"

        Try
            open()

            reader = command.ExecuteReader()

            table.Load(reader)

            close()

            Return table

        Catch ex As Exception
            MessageBox.Show("Please try again, ARDstatus Recieve!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

    'UPDATE STATUS ARDUINO
    Public Sub databaseUpdateStatusArduino(ByVal sala_resposta As String, ByVal estado As String)

        Dim command As New SqlCommand

        command.Connection = connection
        command.CommandText = "UPDATE estadoArduino SET " & sala_resposta & " = '" & estado & "'"

        Try
            open()
            command.ExecuteNonQuery()
            close()

        Catch ex As Exception
            MessageBox.Show("Please try again Update Answer!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Sub
#End Region

    'AGENDAMENTOS
#Region "AGENDAMENTOS"

    'AGENDAMENTOS
    Public Function agendamentosInfo() As DataTable

        Dim command As New SqlCommand
        Dim reader As SqlDataReader
        Dim table As New DataTable

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_agendamentos"

        Try

            open()

            reader = command.ExecuteReader()

            table.Load(reader)

            close()

            Return table

        Catch ex As Exception
            MessageBox.Show("Schedules not possible to see!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

    'UPDATE AGENDAMENTOS PEDIDOS
    Public Sub databaseUpdateAgendamentosPedidos(ByVal sala_resposta As String, ByVal estado As String, ByVal user As String)

        Dim command As New SqlCommand
        command.Connection = connection

        If estado.Contains("null") Then
            command.CommandText = "UPDATE utilizadoresCasa SET " & sala_resposta & " = null WHERE utilizador ='" & user & "'"
        Else
            command.CommandText = "UPDATE utilizadoresCasa SET " & sala_resposta & " = '" & estado & "' WHERE utilizador ='" & user & "'"
        End If

        Try
            open()
            command.ExecuteNonQuery()
            close()

        Catch ex As Exception
            MessageBox.Show("Please try again Update Agendamentos Pedidos!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Sub

    'AGENDAMENTOS UPDATE
    Public Sub agendamentosUpdate(ByVal username As String, ByVal data As String, ByVal sala As String, ByVal corredor As String,
                                  ByVal cozinha As String, ByVal quarto1 As String, ByVal quarto2 As String, ByVal quarto3 As String,
                                  ByVal casaDeBanho1 As String, ByVal casaDeBanho2 As String)

        Dim command As New SqlCommand

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_agendamentosUpdate"
        command.Parameters.AddWithValue("@utilizador", username)
        command.Parameters.AddWithValue("@agend", data)
        command.Parameters.AddWithValue("@sala", sala)
        command.Parameters.AddWithValue("@corredor", corredor)
        command.Parameters.AddWithValue("@cozinha", cozinha)
        command.Parameters.AddWithValue("@quarto1", quarto1)
        command.Parameters.AddWithValue("@quarto2", quarto2)
        command.Parameters.AddWithValue("@quarto3", quarto3)
        command.Parameters.AddWithValue("@casaDeBanho1", casaDeBanho1)
        command.Parameters.AddWithValue("@casaDeBanho2", casaDeBanho2)

        Try
            open()
            If command.ExecuteNonQuery() > -1 Then
                MessageBox.Show("Agendamento Concluido!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            close()

        Catch ex As Exception
            MessageBox.Show("Please try again Update Agendamento!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Sub

    'VISUALIZAR AGENDAMENTOS INDIVIDUAIS
    Public Function agendamentosIndividuais(ByVal utilizador As String) As DataTable

        Dim command As New SqlCommand
        Dim reader As SqlDataReader
        Dim table As New DataTable

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_agendamentosIndividuais"
        command.Parameters.AddWithValue("@utilizador", utilizador)

        Try

            open()

            reader = command.ExecuteReader()

            table.Load(reader)

            close()

            Return table

        Catch ex As Exception
            MessageBox.Show("AGENDAMENTOS INDIVIDUAIS!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

#End Region

    'UTILIZADORES CASA
#Region "UTILIZADORES CASA"
    'USERS ONLINE
    Public Function usersOnline() As DataTable

        Dim command As New SqlCommand
        Dim reader As SqlDataReader
        Dim table As New DataTable

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_usersOnline"

        Try

            open()

            reader = command.ExecuteReader()

            table.Load(reader)

            close()

            Return table

        Catch ex As Exception
            MessageBox.Show("Users Online not possible to see!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

    'REGISTER USERS
    Public Function registerUsers(ByVal userName As String, ByVal password As String, ByVal admin As String) As Boolean

        Dim command As New SqlCommand

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_registerUsers"
        command.Parameters.AddWithValue("@username", userName)
        command.Parameters.AddWithValue("@password", password)
        command.Parameters.AddWithValue("@admin", admin)
        Try

            open()

            If command.ExecuteNonQuery() > -1 Then
                MessageBox.Show("Successful operation!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                MessageBox.Show("System error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            close()
        Catch ex As Exception
            MessageBox.Show("Please try again!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

    'ALTERAR INFO USERS
    Public Function changeInfo(ByVal userName As String, ByVal password As String) As Boolean

        Dim command As New SqlCommand

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_changeInfo"
        command.Parameters.AddWithValue("@username", userName)
        command.Parameters.AddWithValue("@password", password)
        Try

            open()

            If command.ExecuteNonQuery() > -1 Then
                MessageBox.Show("Successful operation!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                MessageBox.Show("System error!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            close()
        Catch ex As Exception
            MessageBox.Show("Please try again!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

    'LOG IN WEB
    Public Function logInWeb(ByVal userName As String, ByVal password As String) As Boolean

        Dim command As New SqlCommand
        Dim reader As SqlDataReader

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_logInWeb"
        command.Parameters.AddWithValue("@username", userName)

        Try
            open()

            reader = command.ExecuteReader()

            While reader.Read()
                If reader(0).Contains(password) Then
                    Return True
                    Exit While
                Else
                    Return False
                End If
            End While

            close()

        Catch ex As Exception
            MessageBox.Show("Please try again,!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

    'UPDATE STATUS WEB
    Public Function updateStatusWeb(ByVal userName As String, ByVal online As String) As Boolean

        Dim command As New SqlCommand

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_userStatus"
        command.Parameters.AddWithValue("@online", online)
        command.Parameters.AddWithValue("@username", userName)
        Try
            open()

            command.ExecuteNonQuery()
            If online.Contains("yes") Then
                Return True
            ElseIf online.Contains("no") Then
                Return False
            End If

            close()

        Catch ex As Exception
            MessageBox.Show("Please try again, Update Status Web!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

#End Region

    'AUTORIZAÇÔES
#Region "AUTORIZACOES"

    'USERS AUTORIZACOES
    Public Function usersAutorizacoes() As DataTable

        Dim command As New SqlCommand
        Dim reader As SqlDataReader
        Dim table As New DataTable

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_usersAutorizacao"

        Try

            open()

            reader = command.ExecuteReader()

            table.Load(reader)

            close()

            Return table

        Catch ex As Exception
            MessageBox.Show("Users Autorizacoes not possible to see!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try

    End Function

    'USERS AUTORIZACOES UPDATEusp_usersAutorizacaoUpdate
    Public Sub usersAutorizacaoUpdate(ByVal username As String, ByVal sala As String, ByVal corredor As String,
                                  ByVal cozinha As String, ByVal quarto1 As String, ByVal quarto2 As String, ByVal quarto3 As String,
                                  ByVal casaDeBanho1 As String, ByVal casaDeBanho2 As String, ByVal adminAutori As String)

        Dim command As New SqlCommand

        command.Connection = connection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "usp_usersAutorizacaoUpdate"
        command.Parameters.AddWithValue("@sala", sala)
        command.Parameters.AddWithValue("@corredor", corredor)
        command.Parameters.AddWithValue("@cozinha", cozinha)
        command.Parameters.AddWithValue("@quarto1", quarto1)
        command.Parameters.AddWithValue("@quarto2", quarto2)
        command.Parameters.AddWithValue("@quarto3", quarto3)
        command.Parameters.AddWithValue("@casaDeBanho1", casaDeBanho1)
        command.Parameters.AddWithValue("@casaDeBanho2", casaDeBanho2)
        command.Parameters.AddWithValue("@admin", adminAutori)
        command.Parameters.AddWithValue("@utilizador", username)

        Try
            open()

            If command.ExecuteNonQuery() > -1 Then
                MessageBox.Show("Permissoes Efectuadas!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            close()

        Catch ex As Exception
            MessageBox.Show("Update Autorizacoes Falhou!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Finally
            If connection.State = ConnectionState.Open Then
                close()
            End If
        End Try
    End Sub

#End Region
End Class


