Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim fullname As String
        'Read the input from the user
        fullname = txtFullName.Text

        Dim fullnameTrimmed As String
        fullnameTrimmed = fullname.Trim()

        'Trim the input so as to remove leading spaces


        'Find the Index of first name
        Dim idxSpace As Integer
        idxSpace = fullname.IndexOf(" ")

        'Extract the first name
        Dim firstName As String
        firstName = fullname.Substring(0, idxSpace)

        'Display the result to the user
        txtFirstName.Text = firstName







    End Sub

    Private Sub txtFullName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFullName.TextChanged

    End Sub
End Class
