Imports System.Security.Cryptography

Module SeedInteraction

    Public Function SeedManipulation(ByRef Seed As Integer, ByRef VoterParty As Integer)

        'Part 0: Convert number to absolute (positive) number
        Seed = Math.Abs(Seed)

        'Part 1: Divide Seed by 5 different numbers

        Dim DivideSeedBy33 As Double,
        DivideSeedBy66 As Double,
        DivideSeedBy99 As Double,
        DivideSeedBy1212 As Double,
        DivideSeedBy1515 As Double

        DivideSeedBy33 = Seed / 33
        DivideSeedBy66 = Seed / 66
        DivideSeedBy99 = Seed / 99
        DivideSeedBy1212 = Seed / 1212
        DivideSeedBy1515 = Seed / 1515

        'Part 2: Capture whole number from division

        Dim SeedWhole1 As Double,
        SeedWhole2 As Double,
        SeedWhole3 As Double,
        SeedWhole4 As Double,
        SeedWhole5 As Double

        SeedWhole1 = Math.Truncate(DivideSeedBy33)
        SeedWhole2 = Math.Truncate(DivideSeedBy66)
        SeedWhole3 = Math.Truncate(DivideSeedBy99)
        SeedWhole4 = Math.Truncate(DivideSeedBy1212)
        SeedWhole5 = Math.Truncate(DivideSeedBy1515)

        'Part 3: Capture decimal number from division

        Dim SeedDecimal1 As Double,
        SeedDecimal2 As Double,
        SeedDecimal3 As Double,
        SeedDecimal4 As Double,
        SeedDecimal5 As Double

        SeedDecimal1 = DivideSeedBy33 - SeedWhole1
        SeedDecimal2 = DivideSeedBy66 - SeedWhole2
        SeedDecimal3 = DivideSeedBy99 - SeedWhole3
        SeedDecimal4 = DivideSeedBy1212 - SeedWhole4
        SeedDecimal5 = DivideSeedBy1515 - SeedWhole5

        'Part 4: Round up

        Dim SeedFinal1 As Double,
        SeedFinal2 As Double,
        SeedFinal3 As Double,
        SeedFinal4 As Double,
        SeedFinal5 As Double

        SeedFinal1 = Math.Round(SeedDecimal1, 0)
        SeedFinal2 = Math.Round(SeedDecimal2, 0)
        SeedFinal3 = Math.Round(SeedDecimal3, 0)
        SeedFinal4 = Math.Round(SeedDecimal4, 0)
        SeedFinal5 = Math.Round(SeedDecimal5, 0)

        'Part 5: Add SeedFinals up to get party voter will go to
        '1 = Blue 4 = Purple
        '2 = Red 5 = Yellow
        '3 = Green

        VoterParty = SeedFinal1 + SeedFinal2 + SeedFinal3 + SeedFinal4 + SeedFinal5

        Return VoterParty

    End Function

    Public Function DetermineSeed(ByRef Success As Int16)

        Dim ByteCount As Byte() = New Byte(6) {},
            SeedNumber As New RNGCryptoServiceProvider()

        Try

            SeedNumber.GetBytes(ByteCount)
            SeedNumber.Dispose()

            Success += 2
            Return BitConverter.ToInt32(ByteCount, 0)

        Catch SeedTooManyLoops As System.OverflowException

            SeedNumber.Dispose()
            Success = 0
            Return BitConverter.ToInt32(ByteCount, 0)

        Catch SeedException As Exception

            Throw New NotImplementedException
            SeedNumber.Dispose()
            Return Success

        End Try

    End Function

End Module
