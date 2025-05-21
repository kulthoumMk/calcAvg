Public Class Form1
    Dim r

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        r = MsgBox("Would You Like to Continue?", 4 Or 32, "Start Application")
        If r = 7 Then
            MessageBox.Show("Application closed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        Else
            txtFirstName.Focus()
        End If

        ' Set FullName and Average fields as read-only
        txtFullName.ReadOnly = True
        txtAverage.ReadOnly = True
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        ' Check for empty name fields
        If String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse String.IsNullOrWhiteSpace(txtMidName.Text) OrElse String.IsNullOrWhiteSpace(txtLastName.Text) Then
            MessageBox.Show("Please fill in all name fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Check if any of the name fields contain invalid characters
        If Not IsValidName(txtFirstName.Text) OrElse Not IsValidName(txtMidName.Text) OrElse Not IsValidName(txtLastName.Text) Then
            MessageBox.Show("Please fill in all name fields with valid alphabetical characters only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Concatenate full name and display it
        txtFullName.Text = $"{txtFirstName.Text} {txtMidName.Text} {txtLastName.Text}"

        ' Initialize array for marks and variables for total and average
        Dim marks(4) As Double
        Dim total As Double = 0

        ' Input marks using input boxes and calculate total
        For i As Integer = 0 To 4
            Dim validInput As Boolean = False
            Dim input As String

            Do
                input = InputBox($"Enter mark {i + 1} (0-100):", "Input Marks")

                ' Check if the user clicked "Cancel" or closed the InputBox
                If String.IsNullOrWhiteSpace(input) Then
                    MessageBox.Show("Please enter a valid mark between 0 and 100.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ' Validate mark input
                ElseIf Double.TryParse(input, marks(i)) AndAlso marks(i) >= 0 AndAlso marks(i) <= 100 Then
                validInput = True ' Mark input as valid if it's numeric and within range
                Else
                    MessageBox.Show("Please enter a valid mark between 0 and 100.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Loop Until validInput ' Repeat until valid input is entered

            total += marks(i)
        Next

        ' Calculate average
        Dim avg As Double = total / marks.Length
        txtAverage.Text = avg.ToString("F2")

        ' Show student information in a message box
        MessageBox.Show($"Full Name: {txtFullName.Text}{Environment.NewLine}Marks: {String.Join(", ", marks)}{Environment.NewLine}Average: {avg:F2}", "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ' Prompt to continue or end the program
        Dim result As DialogResult = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Me.Close()
        Else
            clearAll()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear all text boxes
        clearAll()
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        ' Confirm before exiting
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    ' Function to validate name input (no leading spaces, only alphabets, max length 30)
    Private Function IsValidName(name As String) As Boolean
        If String.IsNullOrWhiteSpace(name) OrElse Not name.All(Function(c) Char.IsLetter(c)) OrElse name.Length > 30 Then
            Return False
        End If
        Return True
    End Function

    ' Update full name automatically as the user types in name fields
    Private Sub UpdateFullName()
        If IsValidName(txtFirstName.Text) AndAlso IsValidName(txtMidName.Text) AndAlso IsValidName(txtLastName.Text) Then
            txtFullName.Text = $"{txtFirstName.Text} {txtMidName.Text} {txtLastName.Text}"
        Else
            txtFullName.Clear()
        End If
    End Sub

    ' Event handlers for text change to validate length and capitalize first letter
    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        CapitalizeFirstLetter(txtFirstName)
        If txtFirstName.Text.Length > 15 Then
            MessageBox.Show("First name cannot exceed 15 characters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFirstName.Text = txtFirstName.Text.Substring(0, 15) ' Trim the text to 15 characters
        End If

        ' Check for spaces
        If txtFirstName.Text.Contains(" ") Then
            MessageBox.Show("First name cannot contain spaces.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFirstName.Text = txtFirstName.Text.Replace(" ", "") ' Remove spaces
        End If

        UpdateFullName()
    End Sub

    Private Sub txtMidName_TextChanged(sender As Object, e As EventArgs) Handles txtMidName.TextChanged
        CapitalizeFirstLetter(txtMidName)
        If txtMidName.Text.Length > 15 Then
            MessageBox.Show("Middle name cannot exceed 15 characters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMidName.Text = txtMidName.Text.Substring(0, 15) ' Trim the text to 15 characters
        End If

        ' Check for spaces
        If txtMidName.Text.Contains(" ") Then
            MessageBox.Show("Middle name cannot contain spaces.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMidName.Text = txtMidName.Text.Replace(" ", "") ' Remove spaces
        End If

        UpdateFullName()
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        CapitalizeFirstLetter(txtLastName)
        If txtLastName.Text.Length > 15 Then
            MessageBox.Show("Last name cannot exceed 15 characters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLastName.Text = txtLastName.Text.Substring(0, 15) ' Trim the text to 15 characters
        End If

        ' Check for spaces
        If txtLastName.Text.Contains(" ") Then
            MessageBox.Show("Last name cannot contain spaces.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLastName.Text = txtLastName.Text.Replace(" ", "") ' Remove spaces
        End If

        UpdateFullName()
    End Sub

    ' Capitalize the first letter of the given TextBox
    Private Sub CapitalizeFirstLetter(textBox As TextBox)
        If textBox.Text.Length > 0 Then
            Dim firstLetter As String = textBox.Text.Substring(0, 1).ToUpper()
            Dim restOfString As String = textBox.Text.Substring(1).ToLower()
            textBox.Text = firstLetter & restOfString
            textBox.SelectionStart = textBox.Text.Length ' Set the cursor to the end of the text
        End If
    End Sub

    ' Update individual name fields automatically if FullName is changed
    Private Sub txtFullName_TextChanged(sender As Object, e As EventArgs) Handles txtFullName.TextChanged
        Dim parts = txtFullName.Text.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        If parts.Length > 0 Then txtFirstName.Text = parts(0)
        If parts.Length > 1 Then txtMidName.Text = parts(1)
        If parts.Length > 2 Then txtLastName.Text = parts(2)
        ' Clear remaining fields if more than 3 parts are present
        If parts.Length > 3 Then
            txtMidName.Text = String.Empty
            txtLastName.Text = String.Empty
        End If
    End Sub

    Private Sub txtAverage_TextChanged(sender As Object, e As EventArgs) Handles txtAverage.TextChanged
    End Sub
    Private Sub clearAll()
        txtFirstName.Clear()
        txtMidName.Clear()
        txtLastName.Clear()
        txtFullName.Clear()
        txtAverage.Clear()
        txtFirstName.Focus()
    End Sub
End Class
