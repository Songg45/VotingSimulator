Module VoterBuildModule

    Public Sub RegisterVoters(ByVal CurrentDistrict As Integer, ByRef CurrentRow As Integer)

        Dim VoterCountTable As DataTable = MainForm.SQLServerData.Tables(1),
            VoterListTable As DataTable = MainForm.SQLServerData.Tables(0)

        Dim BlueCounter As Integer = 0,
            RedCounter As Integer = 0,
            GreenCounter As Integer = 0,
            PurpleCounter As Integer = 0,
            YellowCounter As Integer = 0,
            TotalCounter As Integer = 0

        Dim BlueVotersNeeded As Integer = 0,
            RedVotersNeeded As Integer = 0,
            GreenVotersNeeded As Integer = 0,
            PurpleVotersNeeded As Integer = 0,
            YellowVotersNeeded As Integer = 0,
            TotalVotersNeeded As Integer = 0

        Dim Seed As Integer,
            VoterAgeString As String,
            VoterAge As Integer,
            VoterParty As Integer,
            Success As Int16,
            VoterAdded As Boolean = False,
            DistrictNumber As Integer = CurrentDistrict + 1

        'Initialize variables and get voter counts for given district

        BlueVotersNeeded = VoterCountTable.Rows(CurrentDistrict).Item(1)
        RedVotersNeeded = VoterCountTable.Rows(CurrentDistrict).Item(2)
        GreenVotersNeeded = VoterCountTable.Rows(CurrentDistrict).Item(3)
        PurpleVotersNeeded = VoterCountTable.Rows(CurrentDistrict).Item(4)
        YellowVotersNeeded = VoterCountTable.Rows(CurrentDistrict).Item(5)
        TotalVotersNeeded = VoterCountTable.Rows(CurrentDistrict).Item(6)

        Do Until TotalCounter = TotalVotersNeeded

            Seed = DetermineSeed(Success)

            VoterAdded = False
            Success = 0

            ' Add voter to party

            VoterParty = SeedManipulation(Seed, VoterParty)

            Do Until VoterAdded = True

                Select Case VoterParty
                    Case 1 'Blue Party
                        If BlueCounter = BlueVotersNeeded Then
                            VoterParty += 1

                        Else

                            BlueCounter += 1
                            VoterListTable.Rows(CurrentRow).Item(3) = "Blue"
                            VoterAdded = True

                        End If

                    Case 2 'Red Party
                        If RedCounter = RedVotersNeeded Then
                            VoterParty += 1

                        Else

                            RedCounter += 1
                            VoterListTable.Rows(CurrentRow).Item(3) = "Red"
                            VoterAdded = True

                        End If

                    Case 3 'Green Party
                        If GreenCounter = GreenVotersNeeded Then
                            VoterParty += 1

                        Else

                            GreenCounter += 1
                            VoterListTable.Rows(CurrentRow).Item(3) = "Green"
                            VoterAdded = True

                        End If

                    Case 4 'Purple Party
                        If PurpleCounter = PurpleVotersNeeded Then
                            VoterParty += 1

                        Else

                            PurpleCounter += 1
                            VoterListTable.Rows(CurrentRow).Item(3) = "Purple"
                            VoterAdded = True

                        End If

                    Case 5 'Yellow Party
                        If YellowCounter = YellowVotersNeeded Then
                            VoterParty = 1

                        Else

                            YellowCounter += 1
                            VoterListTable.Rows(CurrentRow).Item(3) = "Yellow"
                            VoterAdded = True

                        End If

                    Case Else

                        Seed = DetermineSeed(Success)
                        Seed = Math.Abs(Seed)
                        SeedManipulation(Seed, VoterParty)

                End Select

            Loop

            VoterAgeString = Seed.ToString()
            VoterAgeString = VoterAgeString.Substring(0, 2)
            VoterAge = Convert.ToInt16(VoterAgeString)

            If VoterAge < 18 Then

                VoterAge += 18

            End If

            VoterListTable.Rows(CurrentRow).Item(2) = DistrictNumber
            VoterListTable.Rows(CurrentRow).Item(1) = VoterAge

            CurrentRow += 1
            TotalCounter += 1

        Loop

    End Sub

End Module