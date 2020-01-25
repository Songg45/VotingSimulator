Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports VotingSimulator.My.Resources

Module SQLInteraction

    Public Sub SQLInteraction(ByRef Success As Short, ByVal ReadWriteMode As Short, Optional ByVal UniqueIdentifier As String = "",
                              Optional ByVal VoterName As String = "", Optional ByVal ProvisionalBallot As Integer = 0,
                              Optional ByVal PartyVoted As String = "")

        Dim SQLServerConnection As SqlConnection,
            SQLServerCommand As SqlCommand,
            SQLServerDataAdapter As SqlDataAdapter,
            SqlExport As SqlBulkCopy,
            SQLServerData As DataSet = MainForm.SQLServerData

        Static Dim LockForUpdating As New Object

#Disable Warning CA2000 ' Dispose objects before losing scope
#Disable Warning IDE0067 ' Dispose objects before losing scope
#Disable Warning CA2100 ' Review SQL queries for security vulnerabilities

        Select Case ReadWriteMode
            Case 1
                Try

                    'Creates an SQL connection to the SQL Server to automatically import data to Dataset

                    SQLServerConnection = New SqlConnection(MainResources.VoterBuildConnectionString)
                    SQLServerCommand = SQLServerConnection.CreateCommand

                    SQLServerCommand.CommandText = MainResources.VoterBuildGetVoterTable

                    SQLServerDataAdapter = New SqlDataAdapter(SQLServerCommand.CommandText, SQLServerConnection)

                    SQLServerDataAdapter.Fill(SQLServerData.Tables(0))
                    SQLServerDataAdapter.Dispose()

                    SQLServerCommand.CommandText = MainResources.VoterBuildGetVoterTally
                    SQLServerDataAdapter = New SqlDataAdapter(SQLServerCommand.CommandText, SQLServerConnection)
                    SQLServerDataAdapter.Fill(SQLServerData.Tables(1))
                    SQLServerDataAdapter.Dispose()

                    SQLServerConnection.Close()
                    SQLServerConnection.Dispose()

                    Success += 1

                Catch OleDbException As SqlException

                    MessageBox.Show(MainResources.VoterBuildSQLFailed)

                End Try

            Case 2
                Try

                    'Every new instance of this program will get its own table to interact with

                    SQLServerConnection = New SqlConnection(MainResources.VoterBuildConnectionString)
                    SQLServerCommand = SQLServerConnection.CreateCommand

                    SQLServerCommand.CommandText = MainResources.VoterBuildCreateTable & UniqueIdentifier & MainResources.VoterBuildCreateTable2

                    SQLServerConnection.Open()
                    SQLServerCommand.ExecuteNonQuery()

                    SqlExport = New SqlBulkCopy(MainResources.VoterBuildConnectionString) With {.DestinationTableName = "VoterSim.VoterList" & UniqueIdentifier}
                    SqlExport.WriteToServer(SQLServerData.Tables(0))

                    SQLServerConnection.Close()
                    SQLServerConnection.Dispose()

                    Success += 1

                Catch OleDbException As SqlException

                    MessageBox.Show(MainResources.VoterBuildSQLFailed)

                End Try

            Case 3
                Try

                    'Repopulate datatable from SQL Server

                    SQLServerConnection = New SqlConnection(MainResources.VoterBuildConnectionString)
                    SQLServerCommand = SQLServerConnection.CreateCommand

                    SQLServerCommand.CommandText = MainResources.VoterBuildFinalizeVoterTable & UniqueIdentifier

                    SQLServerDataAdapter = New SqlDataAdapter(SQLServerCommand.CommandText, SQLServerConnection)

                    SQLServerDataAdapter.Fill(SQLServerData.Tables(0))
                    SQLServerDataAdapter.Dispose()

                    SQLServerConnection.Close()
                    SQLServerConnection.Dispose()

                    Success += 1

                Catch OleDbException As SqlException

                    MessageBox.Show(MainResources.VoterBuildSQLFailed)

                End Try

            Case 4
                Try

                    SyncLock LockForUpdating

                        'Upload data to SQL Server

                        SQLServerConnection = New SqlConnection(MainResources.VoterBuildConnectionString)
                        SQLServerCommand = SQLServerConnection.CreateCommand

                        SQLServerCommand.CommandText = MainResources.ResultsFormUpdateSQLTable1 & UniqueIdentifier & MainResources.ResultsFormUpdateSQLTable2 &
                                                       ProvisionalBallot & MainResources.ResultsFormUpdateSQLTable3 & PartyVoted & MainResources.ResultsFormUpdateSQLTable4 &
                                                       VoterName & MainResources.ResultsFormUpdateSQLTable5

                        SQLServerConnection.Open()
                        SQLServerCommand.ExecuteNonQuery()

                        SQLServerConnection.Close()
                        SQLServerConnection.Dispose()

                    End SyncLock

                    Success += 1

                Catch OleDbException As SqlException

                    'MessageBox.Show(MainResources.VoterBuildSQLFailed)

                End Try

            Case Else
                MessageBox.Show(MainResources.VoterBuildWriteFailed)

        End Select

#Enable Warning IDE0067 ' Dispose objects before losing scope
#Enable Warning CA2000 ' Dispose objects before losing scope
#Enable Warning CA2100 ' Review SQL queries for security vulnerabilities

    End Sub

End Module
