Public Class Person
    Public Property Identifier() As Integer
    Public Property FirstName() As String
    Public Property LastName() As String

    Public Overrides Function ToString() As String
        Return $"{Identifier} {LastName} {FirstName}"
    End Function
End Class
