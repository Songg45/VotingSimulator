Imports Microsoft.Office.Interop.Excel
Imports VotingSimulator.My.Resources

Public Class VoterBuild

    Private Sub VoterBuild_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ExceldbAdapater As OleDb.OleDbDataAdapter,
            ExcelDbConnection As OleDb.OleDbConnection,
            ExcelPath As String = "C:\Users\NetWorkShare\Desktop\Final Data.xlsx"

        ExcelDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ExcelPath + ";Extended Properties=Excel 12.0;")

        ExcelDbConnection.Open()
        ExceldbAdapater = New OleDb.OleDbDataAdapter("Select * from [Master Voter List$]", ExcelDbConnection)

        ExceldbAdapater.Fill(ExcelData.Tables(0))

        ExceldbAdapater.Dispose()
        ExcelDbConnection.Dispose()

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click

        Me.Close()

    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click



    End Sub

End Class