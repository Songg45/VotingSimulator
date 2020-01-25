Module SelectParty

    Public Sub DetermineParty(ByRef Success As Short, ByRef PartyVoted As String)

        Dim Seed As Integer = 0,
            VoterParty As Integer = 0,
            Voted As Boolean = False

        Seed = DetermineSeed(Success)

        Do Until Voted = True

            Select Case SeedManipulation(Seed, VoterParty)

                Case 1
                    PartyVoted = "Blue"
                    Voted = True

                Case 2
                    PartyVoted = "Red"
                    Voted = True

                Case 3
                    PartyVoted = "Green"
                    Voted = True

                Case 4
                    PartyVoted = "Purple"
                    Voted = True

                Case 5
                    PartyVoted = "Yellow"
                    Voted = True

                Case Else
                    Seed = DetermineSeed(Success)

            End Select

        Loop

    End Sub

End Module
