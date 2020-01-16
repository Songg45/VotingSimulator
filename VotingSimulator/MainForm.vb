Imports VotingSimulator.My.Resources

Public Class MainForm

    Private Sub VoterBuildButton_Click(sender As Object, e As EventArgs) Handles VoterBuildButton.Click

        VoterBuild.Show()

        VoterGridView.DataSource = VoterBuild.ExcelData.Tables(0)
        VoterGridView.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        VoterGridView.Update()
        VoterGridView.Refresh()

    End Sub

    Private Sub ResultsButton_Click(sender As Object, e As EventArgs) Handles ResultsButton.Click

        ResultsForm.Show()

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

        Dim CloseVotingSimulator = MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "Close Voting Simulator?")

        If CloseVotingSimulator = MsgBoxResult.Yes Then

            MessageBox.Show(MainResources.ClosingMessage) ' Closing Voting Simulator

            Application.Exit()

        End If

    End Sub

End Class
