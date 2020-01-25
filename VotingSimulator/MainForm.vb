Imports System.Text.RegularExpressions
Imports VotingSimulator.My.Resources

Public Class MainForm

    Dim CurrentDistrict As Integer = 0

    Public UniqueIdentifier As String

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        VoterGridView.Visible = False
        ResultsButton.Visible = False

    End Sub

    Private Sub ResultsButton_Click(sender As Object, e As EventArgs) Handles ResultsButton.Click

        ResultsForm.Show()

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

        Dim CloseVotingSimulator = MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "Close Voting Simulator?")

        If CloseVotingSimulator = MsgBoxResult.Yes Then

            MessageBox.Show(MainResources.MainFormClosingMessage) ' Closing Voting Simulator

            Application.Exit()

        End If

    End Sub
    Private Sub SubmitNameButton_Click(sender As Object, e As EventArgs) Handles SubmitNameButton.Click

        Dim Name As String = NameText.Text,
            RegexReplace As Regex = New Regex("[^a-zA-Z0-9]")

        Try

            If Name = "" Then

                Throw New ArgumentNullException

            End If

            UniqueIdentifier = RegexReplace.Replace(Name, "")
            NameLabel.Visible = False
            SubmitNameButton.Visible = False

            UniqueIdentifier = NameText.Text & Date.Now.Year & Date.Now.Month & Date.Now.Day &
                                              Date.Now.Hour & Date.Now.Minute & Date.Now.Second & Date.Now.Millisecond

            VoterBuild.RunWorkerAsync()

        Catch RegexException As ArgumentNullException

            MessageBox.Show(MainResources.MainFormNameWrong)

        End Try

    End Sub

    Private Sub VoterBuild_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles VoterBuild.DoWork

        Dim Success As Short = 0,
            ReadWriteMode As Integer = 1,
            CurrentRow = 0,
            SQLServerData As DataSet = Me.SQLServerData

        VoterBuild.ReportProgress(1)
        SQLInteraction.SQLInteraction(Success, ReadWriteMode)

        For CurrentDistrict = 0 To 11

            VoterBuild.ReportProgress(2)
            RegisterVoters(CurrentDistrict, CurrentRow)

        Next

        ReadWriteMode = 2

        VoterBuild.ReportProgress(3)
        SQLInteraction.SQLInteraction(Success, ReadWriteMode, UniqueIdentifier)

    End Sub

    Private Sub VoterBuild_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles VoterBuild.RunWorkerCompleted

        If e.Cancelled = False AndAlso e.Error Is Nothing Then

            Dim ReadWriteMode As Integer = 3,
                Success As Short = 0

            SQLInteraction.SQLInteraction(Success, ReadWriteMode, UniqueIdentifier)

            VoterGridView.DataSource = SQLServerData.Tables(0)
            VoterGridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            VoterGridView.Update()
            VoterGridView.Refresh()

            VoterGridView.Visible = True

            NameText.Text = MainResources.VoterBuildResultsFormReady

            ResultsButton.Visible = True

        End If

    End Sub

    Private Sub VoterBuild_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles VoterBuild.ProgressChanged

        Dim DistrictNumber As Integer = CurrentDistrict + 1

        Select Case e.ProgressPercentage
            Case 1
                NameText.Invoke(Sub() NameText.Text = MainResources.VoterBuildStarting)

            Case 2
                NameText.Invoke(Sub() NameText.Text = MainResources.VoterBuildProcess & DistrictNumber)

            Case 3
                NameText.Invoke(Sub() NameText.Text = MainResources.VoterBuildWriteToSQL)

        End Select

    End Sub

End Class
