Imports System.Windows.Forms

Public Class MainForm
    Inherits Form

    Private WithEvents myButton As New Button()

    Public Sub New()
        ' Set up the form
        Me.Text = "Simple VB.NET App"
        Me.Size = New System.Drawing.Size(300, 200)

        ' Set up the button
        myButton.Text = "Click Me!"
        myButton.Size = New System.Drawing.Size(80, 30)
        myButton.Location = New System.Drawing.Point(110, 70)

        ' Add the button to the form
        Me.Controls.Add(myButton)
    End Sub

    Private Sub MyButton_Click(sender As Object, e As EventArgs) Handles myButton.Click
        ' Display a message box when the button is clicked
        MessageBox.Show("Hello, VB.NET World!", "Greetings")
    End Sub

    Public Shared Sub Main()
        ' Run the application
        Application.Run(New MainForm())
    End Sub
End Class
