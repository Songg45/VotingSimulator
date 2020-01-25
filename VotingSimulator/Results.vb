Imports System.Data.SqlClient
Imports System.IO
Imports VotingSimulator.My.Resources

Public Class ResultsForm

    Dim District1Row As Integer = 0,
        District2Row As Integer = 0,
        District3Row As Integer = 0,
        District4Row As Integer = 0,
        District5Row As Integer = 0,
        District6Row As Integer = 0,
        District7Row As Integer = 0,
        District8Row As Integer = 0,
        District9Row As Integer = 0,
        District10Row As Integer = 0,
        District11Row As Integer = 0,
        District12Row As Integer = 0,
        LockForUpdating As Object = New Object

    Dim District1Completed As Boolean = False,
        District2Completed As Boolean = False,
        District3Completed As Boolean = False,
        District4Completed As Boolean = False,
        District5Completed As Boolean = False,
        District6Completed As Boolean = False,
        District7Completed As Boolean = False,
        District8Completed As Boolean = False,
        District9Completed As Boolean = False,
        District10Completed As Boolean = False,
        District11Completed As Boolean = False,
        District12Completed As Boolean = False

    Dim District910TimerInterval As Integer = 50,
        District1611TimerInterval As Integer = 50,
        District1272TimerInterval As Integer = 50,
        District3TimerInterval As Integer = 50,
        District8TimerInterval As Integer = 50,
        District5TimerInterval As Integer = 50,
        District4TimerInterval As Integer = 50

    Dim District910TimerSuccess As Integer = 0,
        District1611TimerSuccess As Integer = 0,
        District1272TimerSuccess As Integer = 0,
        District3TimerSuccess As Integer = 0,
        District8TimerSuccess As Integer = 0,
        District5TimerSuccess As Integer = 0,
        District4TimerSuccess As Integer = 0,
        DistrictTimersCompleted As Integer = 0

    Dim UniqueIdentifier As String = MainForm.UniqueIdentifier

    Private Sub ResultsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckSQLConnection()

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

        Me.Close()

    End Sub

    Private Sub CheckSQLConnection()

        'Check for connection between program and SQL Server

        Dim SQLServerConnection As SqlConnection,
            SQLServerCommand As SqlCommand,
            SQLServerDataAdapter As SqlDataAdapter,
            ActualVotesTable As DataTable = ResultsTally.Tables(2)

        Try

            SQLServerConnection = New SqlConnection(MainResources.VoterBuildConnectionString)
            SQLServerCommand = SQLServerConnection.CreateCommand

            For DistrictNumber = 1 To 12

                SQLServerCommand.CommandText = MainResources.ResultsFormSelectByDistrict1 & UniqueIdentifier &
                                               MainResources.ResultsFormSelectByDistrict2 & DistrictNumber

                'SQLServerCommand.CommandText = "SELECT * FROM dbo.Names WHERE DISTRICT = " & DistrictNumber
                SQLServerDataAdapter = New SqlDataAdapter(SQLServerCommand.CommandText, SQLServerConnection)

                DistrictNumber -= 1

                SQLServerDataAdapter.Fill(VotersByDistrict.Tables(DistrictNumber))
                SQLServerDataAdapter.Dispose()

                DistrictNumber += 1

            Next

            SQLServerCommand.CommandText = MainResources.VoterBuildGetVoterTally
            SQLServerDataAdapter = New SqlDataAdapter(SQLServerCommand.CommandText, SQLServerConnection)
            SQLServerDataAdapter.Fill(ResultsTally.Tables(1))
            SQLServerDataAdapter.Fill(ResultsTally.Tables(2))
            SQLServerDataAdapter.Dispose()

            SQLServerConnection.Close()
            SQLServerConnection.Dispose()

            For CurrentRows As Integer = 0 To ActualVotesTable.Rows.Count - 1

                ActualVotesTable.Rows(CurrentRows).Item(1) = 0
                ActualVotesTable.Rows(CurrentRows).Item(2) = 0
                ActualVotesTable.Rows(CurrentRows).Item(3) = 0
                ActualVotesTable.Rows(CurrentRows).Item(4) = 0
                ActualVotesTable.Rows(CurrentRows).Item(5) = 0
                ActualVotesTable.Rows(CurrentRows).Item(6) = 0

            Next

            LogText.AppendText(MainResources.ResultsFormStarted & DateTime.Now & Environment.NewLine)

        Catch SQLError As SqlException

            MessageBox.Show(MainResources.ResultsFormNoSQLConnection)
            BeginButton.Visible = False
            ElectionFraudButton.Visible = False

            LogText.AppendText(MainResources.ResultsFormFailed & DateTime.Now & Environment.NewLine)

        End Try

    End Sub

    Private Sub BeginButton_Click(sender As Object, e As EventArgs) Handles BeginButton.Click

        LogText.AppendText("UniqueIdentifier is: " & UniqueIdentifier)
        LogText.AppendText(MainResources.ResultsFormBeginButton & DateTime.Now & Environment.NewLine)

        District910Timer.Start()
        District1611Timer.Start()
        District1272Timer.Start()
        District3Timer.Start()
        District8Timer.Start()
        District5Timer.Start()
        District4Timer.Start()

    End Sub

    '---------------------------------------------------------------------------------------------------------------------------'
    '
    '               SUBROUTINES FOR EACH OF THE DISTRICT TIMERS
    '              
    '---------------------------------------------------------------------------------------------------------------------------'

    Private Sub District910Timer_Elasped(sender As Object, e As EventArgs) Handles District910Timer.Tick

        Dim PreviousInterval As Integer = District910TimerInterval

        Try

            If District9Row <> VotersByDistrict.Tables(8).Rows.Count Then

                DistrictVoter9.RunWorkerAsync()

            ElseIf District9Completed = False Then

                LogText.AppendText(MainResources.ResultsFormDistrict9Complete & DateTime.Now & Environment.NewLine)
                District9Completed = True
                District9.Image = MainResources.Completed9

            End If

            If District10Row <> VotersByDistrict.Tables(9).Rows.Count Then

                DistrictVoter10.RunWorkerAsync()

            ElseIf District10Completed = False Then

                LogText.AppendText(MainResources.ResultsFormDistrict10Complete & DateTime.Now & Environment.NewLine)
                District10Completed = True
                District10.Image = MainResources.Completed10

            End If

            If District9Completed = True AndAlso District10Completed = True Then

                District910Timer.Stop()
                ResetTimerIntervals()
                DistrictTimersCompleted += 1

            End If

            District910TimerSuccess += 1

            If District910TimerSuccess = 50 Then

                District910TimerInterval -= 100

                If District910TimerInterval < 1 Then

                    District910TimerInterval = 1

                End If

                District910TimerSuccess = 0
                District910Timer.Interval = District910TimerInterval
                LogText.AppendText("DEBUG: District 9, 10 Interval decreased from " & PreviousInterval & " to " & District910TimerInterval & Environment.NewLine)

            End If

        Catch ThreadTooFast As System.InvalidOperationException

            District910TimerInterval += 25
            District910TimerSuccess = 0
            District910Timer.Interval = District910TimerInterval
            LogText.AppendText("DEBUG: District 9, 10 Interval increased from " & PreviousInterval & " to " & District910TimerInterval & Environment.NewLine)

        End Try

    End Sub

    Private Sub District1611Timer_Tick(sender As Object, e As EventArgs) Handles District1611Timer.Tick

        Dim PreviousInterval As Integer = District1611TimerInterval

        Try

            If District1Row <> VotersByDistrict.Tables(0).Rows.Count Then

                DistrictVoter1.RunWorkerAsync()

            ElseIf District1Completed = False Then

                LogText.AppendText(MainResources.ResultsFormDistrict1Complete & DateTime.Now & Environment.NewLine)
                District1Completed = True
                District1.Image = MainResources.Completed1

            End If

            If District6Row <> VotersByDistrict.Tables(5).Rows.Count Then

                DistrictVoter6.RunWorkerAsync()

            ElseIf District6Completed = False Then

                LogText.AppendText(MainResources.ResultsFormDistrict6Complete & DateTime.Now & Environment.NewLine)
                District6Completed = True
                District6.Image = MainResources.Completed6

            End If

            If District11Row <> VotersByDistrict.Tables(10).Rows.Count Then

                DistrictVoter11.RunWorkerAsync()

            ElseIf District11Completed = False Then

                LogText.AppendText(MainResources.ResultsFormDistrict11Complete & DateTime.Now & Environment.NewLine)
                District11Completed = True
                District11.Image = MainResources.Completed11

            End If

            If District11Completed = True AndAlso District6Completed = True AndAlso District1Completed = True Then

                District1611Timer.Stop()
                ResetTimerIntervals()
                DistrictTimersCompleted += 1

            End If

            District1611TimerSuccess += 1

            If District1611TimerSuccess = 50 Then

                District1611TimerInterval -= 100

                If District1611TimerInterval < 1 Then

                    District1611TimerInterval = 1

                End If

                District1611TimerSuccess = 0
                District1611Timer.Interval = District1611TimerInterval
                LogText.AppendText("DEBUG: District 1, 6, 11 Interval decreased from " & PreviousInterval & " to " & District1611TimerInterval & Environment.NewLine)

            End If

        Catch ThreadTooFast As System.InvalidOperationException

            District1611TimerInterval += 25
            District1611TimerSuccess = 0
            District1611Timer.Interval = District1611TimerInterval
            LogText.AppendText("DEBUG: District 1, 6, 11 Interval increased from " & PreviousInterval & " to " & District1611TimerInterval & Environment.NewLine)

        End Try

    End Sub

    Private Sub District1272Timer_Tick(sender As Object, e As EventArgs) Handles District1272Timer.Tick

        Dim PreviousInterval As Integer = District1272TimerInterval

        Try

            If District12Row <> VotersByDistrict.Tables(11).Rows.Count Then

                DistrictVoter12.RunWorkerAsync()

            ElseIf District12Completed = False Then

                LogText.AppendText(MainResources.ResultsFormDistrict12Complete & DateTime.Now & Environment.NewLine)
                District12Completed = True
                District12.Image = MainResources.Completed12

            End If

            If District7Row <> VotersByDistrict.Tables(6).Rows.Count Then

                DistrictVoter7.RunWorkerAsync()

            ElseIf District7Completed = False Then

                LogText.AppendText(MainResources.ResultsFormDistrict7Complete & DateTime.Now & Environment.NewLine)
                District7Completed = True
                District7.Image = MainResources.Completed7

            End If

            If District2Row <> VotersByDistrict.Tables(1).Rows.Count Then

                DistrictVoter2.RunWorkerAsync()

            ElseIf District2Completed = False Then

                LogText.AppendText(MainResources.ResultsFormDistrict2Complete & DateTime.Now & Environment.NewLine)
                District2Completed = True
                District2.Image = MainResources.Completed2

            End If

            If District12Completed = True AndAlso District7Completed = True AndAlso District2Completed = True Then

                District1272Timer.Stop()
                ResetTimerIntervals()
                DistrictTimersCompleted += 1

            End If

            District1272TimerSuccess += 1

            If District1272TimerSuccess = 50 Then

                District1272TimerInterval -= 100

                If District1272TimerInterval < 1 Then

                    District1272TimerInterval = 1

                End If

                District1272TimerSuccess = 0
                District1272Timer.Interval = District1272TimerInterval
                LogText.AppendText("DEBUG: District 12, 7, 2 Interval decreased from " & PreviousInterval & " to " & District1272TimerInterval & Environment.NewLine)

            End If

        Catch ThreadTooFast As System.InvalidOperationException

            District1272TimerInterval += 25
            District1272TimerSuccess = 0
            District1272Timer.Interval = District1272TimerInterval
            LogText.AppendText("DEBUG: District 12, 7, 2 Interval increased from " & PreviousInterval & " to " & District1272TimerInterval & Environment.NewLine)

        End Try

    End Sub

    Private Sub District3Timer_Tick(sender As Object, e As EventArgs) Handles District3Timer.Tick

        Dim PreviousInterval As Integer = District3TimerInterval

        Try

            If District3Row <> VotersByDistrict.Tables(2).Rows.Count Then

                DistrictVoter3.RunWorkerAsync()

            ElseIf District3Completed = False Then

                LogText.AppendText(MainResources.ResultsFormDistrict3Complete & DateTime.Now & Environment.NewLine)
                District3Completed = True
                District3.Image = MainResources.Completed3

                District3Timer.Stop()
                ResetTimerIntervals()
                DistrictTimersCompleted += 1

            End If

            If District1Completed = True AndAlso District3Completed = True Then

                District1.Image = MainResources.Completed1_3

            ElseIf District3Completed = True Then

                District1.Image = MainResources.Completed3ButNot1

            End If

            District3TimerSuccess += 1

            If District3TimerSuccess = 50 Then

                District3TimerInterval -= 100

                If District3TimerInterval < 1 Then

                    District3TimerInterval = 1

                End If

                District3TimerSuccess = 0
                District3Timer.Interval = District3TimerInterval
                LogText.AppendText("DEBUG: District 3 Interval decreased from " & PreviousInterval & " to " & District3TimerInterval & Environment.NewLine)

            End If

        Catch ThreadTooFast As System.InvalidOperationException

            District3TimerInterval += 25
            District3TimerSuccess = 0
            District3Timer.Interval = District3TimerInterval
            LogText.AppendText("DEBUG: District 3 Interval increased from " & PreviousInterval & " to " & District3TimerInterval & Environment.NewLine)

        End Try

    End Sub

    Private Sub District8Timer_Tick(sender As Object, e As EventArgs) Handles District8Timer.Tick

        Dim PreviousInterval As Integer = District8TimerInterval

        Try

            If District8Row <> VotersByDistrict.Tables(7).Rows.Count Then

                DistrictVoter8.RunWorkerAsync()

            ElseIf District8Completed = False Then

                LogText.AppendText(MainResources.ResultsFormDistrict8Complete & DateTime.Now & Environment.NewLine)
                District8Completed = True
                District8.Image = MainResources.Completed8

                District8Timer.Stop()
                ResetTimerIntervals()
                DistrictTimersCompleted += 1

            End If

            District8TimerSuccess += 1

            If District8TimerSuccess = 50 Then

                District8TimerInterval -= 100

                If District8TimerInterval < 1 Then

                    District8TimerInterval = 1

                End If

                District8TimerSuccess = 0
                District8Timer.Interval = District8TimerInterval
                LogText.AppendText("DEBUG: District 8 Interval decreased from " & PreviousInterval & " to " & District8TimerInterval & Environment.NewLine)

            End If

        Catch ThreadTooFast As System.InvalidOperationException

            District8TimerInterval += 25
            District8TimerSuccess = 0
            District8Timer.Interval = District8TimerInterval
            LogText.AppendText("DEBUG: District 8 Interval increased from " & PreviousInterval & " to " & District8TimerInterval & Environment.NewLine)

        End Try

    End Sub

    Private Sub District5Timer_Tick(sender As Object, e As EventArgs) Handles District5Timer.Tick

        Dim PreviousInterval As Integer = District5TimerInterval

        Try

            If District5Row <> VotersByDistrict.Tables(4).Rows.Count Then

                DistrictVoter5.RunWorkerAsync()

            ElseIf District5Completed = False Then

                LogText.AppendText(MainResources.ResultsFormDistrict5Complete & DateTime.Now & Environment.NewLine)
                District5Completed = True
                District5.Image = MainResources.Completed5

                District5Timer.Stop()
                ResetTimerIntervals()
                DistrictTimersCompleted += 1

            End If

            If District2Completed = True AndAlso District5Completed = True Then

                District2.Image = MainResources.Completed2_5

            ElseIf District5Completed = True Then

                District2.Image = MainResources.Completed5ButNot2

            End If

            District5TimerSuccess += 1

            If District5TimerSuccess = 50 Then

                District5TimerInterval -= 100

                If District5TimerInterval < 1 Then

                    District5TimerInterval = 1

                End If

                District5TimerSuccess = 0
                District5Timer.Interval = District5TimerInterval
                LogText.AppendText("DEBUG: District 5 Interval decreased from " & PreviousInterval & " to " & District5TimerInterval & Environment.NewLine)

            End If

        Catch ThreadTooFast As System.InvalidOperationException

            District5TimerInterval += 25
            District5TimerSuccess = 0
            District5Timer.Interval = District5TimerInterval
            LogText.AppendText("DEBUG: District 5 Interval increased from " & PreviousInterval & " to " & District5TimerInterval & Environment.NewLine)

        End Try

    End Sub

    Private Sub District4Timer_Tick(sender As Object, e As EventArgs) Handles District4Timer.Tick

        Dim PreviousInterval As Integer = District4TimerInterval

        Try

            If District4Row <> VotersByDistrict.Tables(3).Rows.Count Then

                DistrictVoter4.RunWorkerAsync()

            ElseIf District4Completed = False Then

                LogText.AppendText(MainResources.ResultsFormDistrict4Complete & DateTime.Now & Environment.NewLine)
                District4Completed = True
                District4.Image = MainResources.Completed4

                District4Timer.Stop()
                ResetTimerIntervals()
                DistrictTimersCompleted += 1

            End If

            District4TimerSuccess += 1

            If District4TimerSuccess = 50 Then

                District4TimerInterval -= 100

                If District4TimerInterval < 1 Then

                    District4TimerInterval = 1

                End If

                District4TimerSuccess = 0
                District4Timer.Interval = District4TimerInterval
                LogText.AppendText("DEBUG: District 4 Interval decreased from " & PreviousInterval & " to " & District4TimerInterval & Environment.NewLine)

            End If

        Catch ThreadTooFast As System.InvalidOperationException

            District4TimerInterval += 25
            District4TimerSuccess = 0
            District4Timer.Interval = District4TimerInterval
            LogText.AppendText("DEBUG: District 4 Interval increased from " & PreviousInterval & " to " & District4TimerInterval & Environment.NewLine)

        End Try

    End Sub

    Private Sub ResetTimerIntervals()

        If District910Timer.Enabled = True Then
            District910TimerInterval = 1
            District910Timer.Interval = District910TimerInterval

        End If

        If District1611Timer.Enabled = True Then
            District1611TimerInterval = 1
            District1611Timer.Interval = District1611TimerInterval

        End If

        If District1272Timer.Enabled = True Then
            District1272TimerInterval = 1
            District1272Timer.Interval = District1272TimerInterval

        End If

        If District3Timer.Enabled = True Then
            District3TimerInterval = 1
            District3Timer.Interval = District3TimerInterval

        End If

        If District8Timer.Enabled = True Then
            District8TimerInterval = 1
            District8Timer.Interval = District8TimerInterval

        End If

        If District5Timer.Enabled = True Then
            District5TimerInterval = 1
            District5Timer.Interval = District5TimerInterval

        End If

        If District4Timer.Enabled = True Then
            District4TimerInterval = 1
            District4Timer.Interval = District4TimerInterval

        End If

        If DistrictTimersCompleted = 7 Then

            Dim BlueVotes As Integer = ResultsTally.Tables(2).Rows(12).Item(1),
                RedVotes As Integer = ResultsTally.Tables(2).Rows(12).Item(2),
                GreenVotes As Integer = ResultsTally.Tables(2).Rows(12).Item(3),
                PurpleVotes As Integer = ResultsTally.Tables(2).Rows(12).Item(4),
                YellowVotes As Integer = ResultsTally.Tables(2).Rows(12).Item(5)

            LogText.AppendText(MainResources.ResultsFormAllDistrictsReporting1 & Date.Now &
                               MainResources.ResultsFormAllDistrictsReporting2 & Environment.NewLine)
            LogText.AppendText("BLUE: " & BlueVotes & Environment.NewLine)
            LogText.AppendText("RED: " & RedVotes & Environment.NewLine)
            LogText.AppendText("GREEN: " & GreenVotes & Environment.NewLine)
            LogText.AppendText("PURPLE: " & PurpleVotes & Environment.NewLine)
            LogText.AppendText("YELLOW: " & YellowVotes & Environment.NewLine)

            WriteLog()
            RestartVoting()

            BeginButton.PerformClick()

        End If

    End Sub

    Private Sub RestartVoting()

        District910Timer.Interval = 50
        District1611Timer.Interval = 50
        District1272Timer.Interval = 50
        District3Timer.Interval = 50
        District8Timer.Interval = 50
        District5Timer.Interval = 50
        District4Timer.Interval = 50

        District1Row = 0
        District2Row = 0
        District3Row = 0
        District4Row = 0
        District5Row = 0
        District6Row = 0
        District7Row = 0
        District8Row = 0
        District9Row = 0
        District10Row = 0
        District11Row = 0
        District12Row = 0

        District1Completed = False
        District2Completed = False
        District3Completed = False
        District4Completed = False
        District5Completed = False
        District6Completed = False
        District7Completed = False
        District8Completed = False
        District9Completed = False
        District10Completed = False
        District11Completed = False
        District12Completed = False

        MainForm.UniqueIdentifier = MainForm.UniqueIdentifier & Date.Now.Hour & Date.Now.Minute

        ResultsTally.Reset()
        CheckSQLConnection()

    End Sub

    Private Sub WriteLog()

        Dim BlueVotes As Integer = ResultsTally.Tables(2).Rows(12).Item(1),
                RedVotes As Integer = ResultsTally.Tables(2).Rows(12).Item(2),
                GreenVotes As Integer = ResultsTally.Tables(2).Rows(12).Item(3),
                PurpleVotes As Integer = ResultsTally.Tables(2).Rows(12).Item(4),
                YellowVotes As Integer = ResultsTally.Tables(2).Rows(12).Item(5)

        Dim ResultsFileLocation As String = "C:\Users\NetWorkShare\Desktop\Districts\Logfile.txt",
               DebugFileLocation As String = "",
               Logfile As StreamWriter = New StreamWriter(ResultsFileLocation, True),
               RunNumber As Integer = 0

        Logfile.WriteLine(MainResources.ResultsFormAllDistrictsReporting1 & Date.Now &
                              MainResources.ResultsFormAllDistrictsReporting2 & Environment.NewLine)

        Logfile.WriteLine("BLUE: " & BlueVotes & Environment.NewLine)
        Logfile.WriteLine("RED: " & RedVotes & Environment.NewLine)
        Logfile.WriteLine("GREEN: " & GreenVotes & Environment.NewLine)
        Logfile.WriteLine("PURPLE: " & PurpleVotes & Environment.NewLine)
        Logfile.WriteLine("YELLOW: " & YellowVotes & Environment.NewLine)

        Try

            Logfile.Flush()
            Logfile.Close()
            Logfile.Dispose()

        Catch Exception As Exception

            Logfile.Flush()
            Logfile.Close()

        End Try

        RunNumber += 1

        DebugFileLocation = "C:\Users\NetWorkShare\Desktop\Districts\DebugFile" & RunNumber & ".txt"

        LogText.SaveFile(DebugFileLocation)

        LogText.Text = ""

    End Sub

    '---------------------------------------------------------------------------------------------------------------------------'
    '
    '               SUBROUTINES FOR EACH OF THE 12 BACKGROUNDWORKERS FOR ITS RESPECTIVE DISTRICT VOTERS
    '              
    '---------------------------------------------------------------------------------------------------------------------------'

    Private Sub DistrictVoter1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DistrictVoter1.DoWork

        Dim VoterName As String,
            PartyVoted As String = "",
            ProvisionalBallot As Integer,
            DistrictNumber As Integer = 1,
            District1Table As DataTable = VotersByDistrict.Tables(0)

        Dim Success As Short = 0,
            ReadWriteMode As Integer = 4

        DistrictNumber -= 1

        VoterName = District1Table.Rows(District1Row).Item(0)
        ProvisionalBallot = "0"

        DetermineParty(Success, PartyVoted)
        SQLInteraction.SQLInteraction(Success, ReadWriteMode, UniqueIdentifier, VoterName, ProvisionalBallot, PartyVoted)

        District1Row += 1

        DistrictTallyUpdate(PartyVoted, DistrictNumber)
        UpdateUIFromBackGroundWorker(VoterName, PartyVoted)

    End Sub

    Private Sub DistrictVoter2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DistrictVoter2.DoWork

        Dim VoterName As String,
            PartyVoted As String = "",
            ProvisionalBallot As Integer,
            DistrictNumber As Integer = 2,
            District2Table As DataTable = VotersByDistrict.Tables(1)

        Dim Success As Short = 0,
            ReadWriteMode As Integer = 4

        DistrictNumber -= 1

        VoterName = District2Table.Rows(District2Row).Item(0)
        ProvisionalBallot = "0"

        DetermineParty(Success, PartyVoted)
        SQLInteraction.SQLInteraction(Success, ReadWriteMode, UniqueIdentifier, VoterName, ProvisionalBallot, PartyVoted)

        District2Row += 1

        DistrictTallyUpdate(PartyVoted, DistrictNumber)
        UpdateUIFromBackGroundWorker(VoterName, PartyVoted)

    End Sub

    Private Sub DistrictVoter3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DistrictVoter3.DoWork

        Dim VoterName As String,
            PartyVoted As String = "" = "",
            ProvisionalBallot As Integer,
            DistrictNumber As Integer = 3,
            District3Table As DataTable = VotersByDistrict.Tables(2)

        Dim Success As Short = 0,
            ReadWriteMode As Integer = 4

        DistrictNumber -= 1

        VoterName = District3Table.Rows(District3Row).Item(0)
        ProvisionalBallot = "0"

        DetermineParty(Success, PartyVoted)
        SQLInteraction.SQLInteraction(Success, ReadWriteMode, UniqueIdentifier, VoterName, ProvisionalBallot, PartyVoted)

        District3Row += 1

        DistrictTallyUpdate(PartyVoted, DistrictNumber)
        UpdateUIFromBackGroundWorker(VoterName, PartyVoted)

    End Sub

    Private Sub DistrictVoter4_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DistrictVoter4.DoWork

        Dim VoterName As String,
            PartyVoted As String = "",
            ProvisionalBallot As Integer,
            DistrictNumber As Integer = 4,
            District4Table As DataTable = VotersByDistrict.Tables(3)

        Dim Success As Short = 0,
            ReadWriteMode As Integer = 4

        DistrictNumber -= 1

        VoterName = District4Table.Rows(District4Row).Item(0)
        ProvisionalBallot = "0"

        DetermineParty(Success, PartyVoted)
        SQLInteraction.SQLInteraction(Success, ReadWriteMode, UniqueIdentifier, VoterName, ProvisionalBallot, PartyVoted)

        District4Row += 1

        DistrictTallyUpdate(PartyVoted, DistrictNumber)
        UpdateUIFromBackGroundWorker(VoterName, PartyVoted)

    End Sub

    Private Sub DistrictVoter5_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DistrictVoter5.DoWork

        Dim VoterName As String,
            PartyVoted As String = "",
            ProvisionalBallot As Integer,
            DistrictNumber As Integer = 5,
            District5Table As DataTable = VotersByDistrict.Tables(4)

        Dim Success As Short = 0,
            ReadWriteMode As Integer = 4

        DistrictNumber -= 1

        VoterName = District5Table.Rows(District5Row).Item(0)
        ProvisionalBallot = "0"

        DetermineParty(Success, PartyVoted)
        SQLInteraction.SQLInteraction(Success, ReadWriteMode, UniqueIdentifier, VoterName, ProvisionalBallot, PartyVoted)

        District5Row += 1

        DistrictTallyUpdate(PartyVoted, DistrictNumber)
        UpdateUIFromBackGroundWorker(VoterName, PartyVoted)

    End Sub

    Private Sub DistrictVoter6_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DistrictVoter6.DoWork

        Dim VoterName As String,
            PartyVoted As String = "",
            ProvisionalBallot As Integer,
            DistrictNumber As Integer = 6,
            District6Table As DataTable = VotersByDistrict.Tables(5)

        Dim Success As Short = 0,
            ReadWriteMode As Integer = 4

        DistrictNumber -= 1

        VoterName = District6Table.Rows(District6Row).Item(0)
        ProvisionalBallot = "0"

        DetermineParty(Success, PartyVoted)
        SQLInteraction.SQLInteraction(Success, ReadWriteMode, UniqueIdentifier, VoterName, ProvisionalBallot, PartyVoted)

        District6Row += 1

        DistrictTallyUpdate(PartyVoted, DistrictNumber)
        UpdateUIFromBackGroundWorker(VoterName, PartyVoted)

    End Sub

    Private Sub DistrictVoter7_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DistrictVoter7.DoWork

        Dim VoterName As String,
            PartyVoted As String = "",
            ProvisionalBallot As Integer,
            DistrictNumber As Integer = 7,
            District7Table As DataTable = VotersByDistrict.Tables(6)

        Dim Success As Short = 0,
            ReadWriteMode As Integer = 4

        DistrictNumber -= 1

        VoterName = District7Table.Rows(District7Row).Item(0)
        ProvisionalBallot = "0"

        DetermineParty(Success, PartyVoted)
        SQLInteraction.SQLInteraction(Success, ReadWriteMode, UniqueIdentifier, VoterName, ProvisionalBallot, PartyVoted)

        District7Row += 1

        DistrictTallyUpdate(PartyVoted, DistrictNumber)
        UpdateUIFromBackGroundWorker(VoterName, PartyVoted)

    End Sub

    Private Sub DistrictVoter8_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DistrictVoter8.DoWork

        Dim VoterName As String,
            PartyVoted As String = "",
            ProvisionalBallot As Integer,
            DistrictNumber As Integer = 8,
            District8Table As DataTable = VotersByDistrict.Tables(7)

        Dim Success As Short = 0,
            ReadWriteMode As Integer = 4

        DistrictNumber -= 1

        VoterName = District8Table.Rows(District8Row).Item(0)
        ProvisionalBallot = "0"

        DetermineParty(Success, PartyVoted)
        SQLInteraction.SQLInteraction(Success, ReadWriteMode, UniqueIdentifier, VoterName, ProvisionalBallot, PartyVoted)

        District8Row += 1

        DistrictTallyUpdate(PartyVoted, DistrictNumber)
        UpdateUIFromBackGroundWorker(VoterName, PartyVoted)

    End Sub

    Private Sub DistrictVoter9_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DistrictVoter9.DoWork

        Dim VoterName As String,
            PartyVoted As String = "",
            ProvisionalBallot As Integer,
            DistrictNumber As Integer = 9,
            District9Table As DataTable = VotersByDistrict.Tables(8)

        Dim Success As Short = 0,
            ReadWriteMode As Integer = 4

        DistrictNumber -= 1

        VoterName = District9Table.Rows(District9Row).Item(0)
        ProvisionalBallot = "0"

        DetermineParty(Success, PartyVoted)
        SQLInteraction.SQLInteraction(Success, ReadWriteMode, UniqueIdentifier, VoterName, ProvisionalBallot, PartyVoted)

        District9Row += 1

        DistrictTallyUpdate(PartyVoted, DistrictNumber)
        UpdateUIFromBackGroundWorker(VoterName, PartyVoted)

    End Sub

    Private Sub DistrictVoter10_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DistrictVoter10.DoWork

        Dim VoterName As String,
            PartyVoted As String = "",
            ProvisionalBallot As Integer,
            DistrictNumber As Integer = 10,
            District10Table As DataTable = VotersByDistrict.Tables(9)

        Dim Success As Short = 0,
            ReadWriteMode As Integer = 4

        DistrictNumber -= 1

        VoterName = District10Table.Rows(District10Row).Item(0)
        ProvisionalBallot = "0"

        DetermineParty(Success, PartyVoted)
        SQLInteraction.SQLInteraction(Success, ReadWriteMode, UniqueIdentifier, VoterName, ProvisionalBallot, PartyVoted)

        District10Row += 1

        DistrictTallyUpdate(PartyVoted, DistrictNumber)
        UpdateUIFromBackGroundWorker(VoterName, PartyVoted)

    End Sub

    Private Sub DistrictVoter11_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DistrictVoter11.DoWork

        Dim VoterName As String,
            PartyVoted As String = "",
            ProvisionalBallot As Integer,
            DistrictNumber As Integer = 11,
            District11Table As DataTable = VotersByDistrict.Tables(10)

        Dim Success As Short = 0,
            ReadWriteMode As Integer = 4

        DistrictNumber -= 1

        VoterName = District11Table.Rows(District11Row).Item(0)

        ProvisionalBallot = "0"
        PartyVoted = "Blue"

        DetermineParty(Success, PartyVoted)
        SQLInteraction.SQLInteraction(Success, ReadWriteMode, UniqueIdentifier, VoterName, ProvisionalBallot, PartyVoted)

        District11Row += 1

        DistrictTallyUpdate(PartyVoted, DistrictNumber)
        UpdateUIFromBackGroundWorker(VoterName, PartyVoted)

    End Sub

    Private Sub DistrictVoter12_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DistrictVoter12.DoWork

        Dim VoterName As String,
            PartyVoted As String = "",
            ProvisionalBallot As Integer,
            DistrictNumber As Integer = 12,
            District12Table As DataTable = VotersByDistrict.Tables(11)

        Dim Success As Short = 0,
            ReadWriteMode As Integer = 4

        DistrictNumber -= 1

        VoterName = District12Table.Rows(District12Row).Item(0)
        ProvisionalBallot = "0"

        DetermineParty(Success, PartyVoted)
        SQLInteraction.SQLInteraction(Success, ReadWriteMode, UniqueIdentifier, VoterName, ProvisionalBallot, PartyVoted)

        District12Row += 1

        DistrictTallyUpdate(PartyVoted, DistrictNumber)
        UpdateUIFromBackGroundWorker(VoterName, PartyVoted)

    End Sub

    Private Sub DistrictTallyUpdate(PartyVoted As String, DistrictNumber As Integer)

        SyncLock LockForUpdating

            Select Case PartyVoted
                Case "Blue"
                    ResultsTally.Tables(2).Rows(DistrictNumber).Item(1) = ResultsTally.Tables(2).Rows(DistrictNumber).Item(1) + 1
                    ResultsTally.Tables(2).Rows(12).Item(1) = ResultsTally.Tables(2).Rows(12).Item(1) + 1

                Case "Red"
                    ResultsTally.Tables(2).Rows(DistrictNumber).Item(2) = ResultsTally.Tables(2).Rows(DistrictNumber).Item(2) + 1
                    ResultsTally.Tables(2).Rows(12).Item(2) = ResultsTally.Tables(2).Rows(12).Item(2) + 1

                Case "Green"
                    ResultsTally.Tables(2).Rows(DistrictNumber).Item(3) = ResultsTally.Tables(2).Rows(DistrictNumber).Item(3) + 1
                    ResultsTally.Tables(2).Rows(12).Item(3) = ResultsTally.Tables(2).Rows(12).Item(3) + 1

                Case "Purple"
                    ResultsTally.Tables(2).Rows(DistrictNumber).Item(4) = ResultsTally.Tables(2).Rows(DistrictNumber).Item(4) + 1
                    ResultsTally.Tables(2).Rows(12).Item(4) = ResultsTally.Tables(2).Rows(12).Item(4) + 1

                Case "Yellow"
                    ResultsTally.Tables(2).Rows(DistrictNumber).Item(5) = ResultsTally.Tables(2).Rows(DistrictNumber).Item(5) + 1
                    ResultsTally.Tables(2).Rows(12).Item(5) = ResultsTally.Tables(2).Rows(12).Item(5) + 1

            End Select

            ResultsTally.Tables(2).Rows(DistrictNumber).Item(6) = ResultsTally.Tables(2).Rows(DistrictNumber).Item(6) + 1
            ResultsTally.Tables(2).Rows(12).Item(6) = ResultsTally.Tables(2).Rows(12).Item(6) + 1

        End SyncLock

    End Sub

    Private Sub UpdateUIFromBackGroundWorker(ByVal VoterName As String, PartyVoted As String)

        Dim NewTotalVote As Integer,
            TotalVotesByParty As Integer

        Select Case PartyVoted

            Case "Blue"

                Me.Invoke(Sub() LogText.AppendText(VoterName & MainResources.ResultsFormBallotBlueCast & DateTime.Now & Environment.NewLine))

                TotalVotesByParty = ResultsTally.Tables(2).Rows(12).Item(1)
                Me.Invoke(Sub() BlueVotesBox.Text = TotalVotesByParty)

            Case "Red"
                Me.Invoke(Sub() LogText.AppendText(VoterName & MainResources.ResultsFormBallotRedCast & DateTime.Now & Environment.NewLine))

                TotalVotesByParty = ResultsTally.Tables(2).Rows(12).Item(2)
                Me.Invoke(Sub() RedVotesBox.Text = TotalVotesByParty)

            Case "Green"

                Me.Invoke(Sub() LogText.AppendText(VoterName & MainResources.ResultsFormBallotGreenCast & DateTime.Now & Environment.NewLine))

                TotalVotesByParty = ResultsTally.Tables(2).Rows(12).Item(3)
                Me.Invoke(Sub() GreenVotesBox.Text = TotalVotesByParty)

            Case "Purple"
                Me.Invoke(Sub() LogText.AppendText(VoterName & MainResources.ResultsFormBallotPurpleCast & DateTime.Now & Environment.NewLine))

                TotalVotesByParty = ResultsTally.Tables(2).Rows(12).Item(4)
                Me.Invoke(Sub() PurpleVotesBox.Text = TotalVotesByParty)

            Case "Yellow"
                Me.Invoke(Sub() LogText.AppendText(VoterName & MainResources.ResultsFormBallotYellowCast & DateTime.Now & Environment.NewLine))

                TotalVotesByParty = ResultsTally.Tables(2).Rows(12).Item(5)
                Me.Invoke(Sub() YellowVotesBox.Text = TotalVotesByParty)

        End Select

        NewTotalVote = ResultsTally.Tables(2).Rows(12).Item(6)
        Me.Invoke(Sub() VoteTotalsBox.Text = NewTotalVote)

    End Sub

    '---------------------------------------------------------------------------------------------------------------------------'
    '
    '
    '                                       
    '
    '
    '
    '
    '
    '                                       BELOW THIS LINE
    '                                       CONTROLS THE MOUSE TOOLTIPS 
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '---------------------------------------------------------------------------------------------------------------------------'

    Private Sub BuildToolTip(ByRef ToolTipText As String, ByVal DistrictNumber As Integer)

        Dim WorkingTable As DataTable = ResultsTally.Tables(2)

        DistrictNumber -= 1

        ToolTipText = "BLUE: " & WorkingTable.Rows(DistrictNumber).Item(1) & Environment.NewLine &
              "RED: " & WorkingTable.Rows(DistrictNumber).Item(2) & Environment.NewLine &
              "GREEN: " & WorkingTable.Rows(DistrictNumber).Item(3) & Environment.NewLine &
              "PURPLE: " & WorkingTable.Rows(DistrictNumber).Item(4) & Environment.NewLine &
              "YELLOW: " & WorkingTable.Rows(DistrictNumber).Item(5) & Environment.NewLine &
              "TOTAL: " & WorkingTable.Rows(DistrictNumber).Item(6)

    End Sub

    Private Sub District1_MouseEnter(sender As Object, e As System.EventArgs) Handles District1.MouseEnter

        Dim TooltipText As String = "",
            DistrictNumber As Integer = 1

        BuildToolTip(TooltipText, DistrictNumber)

        DistrictTally.Show(TooltipText, District1)

    End Sub

    Private Sub District2_MouseEnter(sender As Object, e As System.EventArgs) Handles District2.MouseEnter

        Dim TooltipText As String = "",
            DistrictNumber As Integer = 2

        BuildToolTip(TooltipText, DistrictNumber)

        DistrictTally.Show(TooltipText, District2)

    End Sub

    Private Sub District3_MouseEnter(sender As Object, e As System.EventArgs) Handles District3.MouseEnter

        Dim TooltipText As String = "",
            DistrictNumber As Integer = 3

        BuildToolTip(TooltipText, DistrictNumber)

        DistrictTally.Show(TooltipText, District3)

    End Sub

    Private Sub District4_MouseEnter(sender As Object, e As System.EventArgs) Handles District4.MouseEnter

        Dim TooltipText As String = "",
            DistrictNumber As Integer = 4

        BuildToolTip(TooltipText, DistrictNumber)

        DistrictTally.Show(TooltipText, District4)

    End Sub

    Private Sub District5_MouseEnter(sender As Object, e As System.EventArgs) Handles District5.MouseEnter

        Dim TooltipText As String = "",
            DistrictNumber As Integer = 5

        BuildToolTip(TooltipText, DistrictNumber)

        DistrictTally.Show(TooltipText, District5)

    End Sub

    Private Sub District6_MouseEnter(sender As Object, e As System.EventArgs) Handles District6.MouseEnter

        Dim TooltipText As String = "",
            DistrictNumber As Integer = 6

        BuildToolTip(TooltipText, DistrictNumber)

        DistrictTally.Show(TooltipText, District6)

    End Sub

    Private Sub District7_MouseEnter(sender As Object, e As System.EventArgs) Handles District7.MouseEnter

        Dim TooltipText As String = "",
            DistrictNumber As Integer = 7

        BuildToolTip(TooltipText, DistrictNumber)

        DistrictTally.Show(TooltipText, District7)

    End Sub

    Private Sub District8_MouseEnter(sender As Object, e As System.EventArgs) Handles District8.MouseEnter

        Dim TooltipText As String = "",
            DistrictNumber As Integer = 8

        BuildToolTip(TooltipText, DistrictNumber)

        DistrictTally.Show(TooltipText, District8)

    End Sub

    Private Sub District9_MouseEnter(sender As Object, e As System.EventArgs) Handles District9.MouseEnter

        Dim TooltipText As String = "",
            DistrictNumber As Integer = 9

        BuildToolTip(TooltipText, DistrictNumber)

        DistrictTally.Show(TooltipText, District9)

    End Sub

    Private Sub District10_MouseEnter(sender As Object, e As System.EventArgs) Handles District10.MouseEnter

        Dim TooltipText As String = "",
            DistrictNumber As Integer = 10

        BuildToolTip(TooltipText, DistrictNumber)

        DistrictTally.Show(TooltipText, District10)

    End Sub

    Private Sub District11_MouseEnter(sender As Object, e As System.EventArgs) Handles District11.MouseEnter

        Dim TooltipText As String = "",
            DistrictNumber As Integer = 11

        BuildToolTip(TooltipText, DistrictNumber)

        DistrictTally.Show(TooltipText, District11)

    End Sub

    Private Sub District12_MouseEnter(sender As Object, e As System.EventArgs) Handles District12.MouseEnter

        Dim TooltipText As String = "",
            DistrictNumber As Integer = 12

        BuildToolTip(TooltipText, DistrictNumber)

        DistrictTally.Show(TooltipText, District12)

    End Sub

    Private Sub District1_MouseExit(sender As Object, e As System.EventArgs) Handles District1.MouseLeave

        DistrictTally.Hide(District1)

    End Sub

    Private Sub District2_MouseExit(sender As Object, e As System.EventArgs) Handles District2.MouseLeave

        DistrictTally.Hide(District2)

    End Sub

    Private Sub District3_MouseExit(sender As Object, e As System.EventArgs) Handles District3.MouseLeave

        DistrictTally.Hide(District3)

    End Sub

    Private Sub District4_MouseExit(sender As Object, e As System.EventArgs) Handles District4.MouseLeave

        DistrictTally.Hide(District4)

    End Sub

    Private Sub District5_MouseExit(sender As Object, e As System.EventArgs) Handles District5.MouseLeave

        DistrictTally.Hide(District5)

    End Sub

    Private Sub District6_MouseExit(sender As Object, e As System.EventArgs) Handles District6.MouseLeave

        DistrictTally.Hide(District6)

    End Sub

    Private Sub District7_MouseExit(sender As Object, e As System.EventArgs) Handles District7.MouseLeave

        DistrictTally.Hide(District7)

    End Sub

    Private Sub District8_MouseExit(sender As Object, e As System.EventArgs) Handles District8.MouseLeave

        DistrictTally.Hide(District8)

    End Sub

    Private Sub District9_MouseExit(sender As Object, e As System.EventArgs) Handles District9.MouseLeave

        DistrictTally.Hide(District9)

    End Sub

    Private Sub District10_MouseExit(sender As Object, e As System.EventArgs) Handles District10.MouseLeave

        DistrictTally.Hide(District10)

    End Sub

    Private Sub District11_MouseExit(sender As Object, e As System.EventArgs) Handles District11.MouseLeave

        DistrictTally.Hide(District11)

    End Sub

    Private Sub District12_MouseExit(sender As Object, e As System.EventArgs) Handles District12.MouseLeave

        DistrictTally.Hide(District12)

    End Sub

End Class