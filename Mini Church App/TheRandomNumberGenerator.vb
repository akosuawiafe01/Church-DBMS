Module TheRandomNumberGenerator
    'Generates Random Numbers
    Public Function randomNumber(ByVal rLength As Integer) As String
        Dim randomNum As New Random()
        Dim allowedChars() As Char = "0123456789".ToCharArray()
        Dim str As String = ""

        For i As Integer = 0 To rLength - 1
            str += allowedChars(randomNum.Next(0, allowedChars.Length))
        Next
        Return str
    End Function
End Module
