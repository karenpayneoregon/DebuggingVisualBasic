Imports ConcreteClasses

Public Class Form1
    Private Sub GetPersonButton_Click(sender As Object, e As EventArgs) Handles GetPersonButton.Click

        Dim person As New Person With {.Identifier = 1, .FirstName = "Karen", .LastName = "Payne"}
        MessageBox.Show(person.ToString())

    End Sub
End Class
