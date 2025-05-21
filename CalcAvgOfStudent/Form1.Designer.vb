<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnProcess = New Button()
        btnClear = New Button()
        btnEnd = New Button()
        txtFirstName = New TextBox()
        txtMidName = New TextBox()
        txtLastName = New TextBox()
        txtFullName = New TextBox()
        txtAverage = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' btnProcess
        ' 
        btnProcess.BackColor = SystemColors.HotTrack
        btnProcess.FlatStyle = FlatStyle.Flat
        btnProcess.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnProcess.ForeColor = SystemColors.ButtonHighlight
        btnProcess.Location = New Point(68, 384)
        btnProcess.Name = "btnProcess"
        btnProcess.Size = New Size(112, 46)
        btnProcess.TabIndex = 0
        btnProcess.Text = "Process"
        btnProcess.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.HotTrack
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnClear.ForeColor = SystemColors.ButtonHighlight
        btnClear.Location = New Point(201, 384)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 46)
        btnClear.TabIndex = 1
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnEnd
        ' 
        btnEnd.BackColor = SystemColors.HotTrack
        btnEnd.FlatStyle = FlatStyle.Flat
        btnEnd.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnEnd.ForeColor = SystemColors.ButtonHighlight
        btnEnd.Location = New Point(338, 384)
        btnEnd.Name = "btnEnd"
        btnEnd.Size = New Size(127, 46)
        btnEnd.TabIndex = 2
        btnEnd.Text = "End"
        btnEnd.UseVisualStyleBackColor = False
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Times New Roman", 10F, FontStyle.Bold Or FontStyle.Italic)
        txtFirstName.Location = New Point(178, 69)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(297, 30)
        txtFirstName.TabIndex = 0
        ' 
        ' txtMidName
        ' 
        txtMidName.Font = New Font("Times New Roman", 10F, FontStyle.Bold Or FontStyle.Italic)
        txtMidName.Location = New Point(178, 129)
        txtMidName.Name = "txtMidName"
        txtMidName.Size = New Size(297, 30)
        txtMidName.TabIndex = 4
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Times New Roman", 10F, FontStyle.Bold Or FontStyle.Italic)
        txtLastName.Location = New Point(178, 184)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(297, 30)
        txtLastName.TabIndex = 5
        ' 
        ' txtFullName
        ' 
        txtFullName.Font = New Font("Times New Roman", 10F, FontStyle.Bold Or FontStyle.Italic)
        txtFullName.Location = New Point(179, 247)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(297, 30)
        txtFullName.TabIndex = 6
        ' 
        ' txtAverage
        ' 
        txtAverage.Font = New Font("Times New Roman", 10F, FontStyle.Bold Or FontStyle.Italic)
        txtAverage.Location = New Point(178, 303)
        txtAverage.Name = "txtAverage"
        txtAverage.Size = New Size(297, 30)
        txtAverage.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bell MT", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(18, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 29)
        Label1.TabIndex = 8
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bell MT", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(19, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 29)
        Label2.TabIndex = 9
        Label2.Text = "Mide name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bell MT", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(18, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 29)
        Label3.TabIndex = 10
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Bell MT", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(19, 247)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 29)
        Label4.TabIndex = 11
        Label4.Text = "Full Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bell MT", 12F, FontStyle.Bold Or FontStyle.Italic)
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(19, 303)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 29)
        Label5.TabIndex = 12
        Label5.Text = "Average"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 26F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(720, 468)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtAverage)
        Controls.Add(txtFullName)
        Controls.Add(txtLastName)
        Controls.Add(txtMidName)
        Controls.Add(txtFirstName)
        Controls.Add(btnEnd)
        Controls.Add(btnClear)
        Controls.Add(btnProcess)
        Font = New Font("Andalus", 8F)
        ForeColor = Color.Brown
        Name = "Form1"
        Text = "Calculate_Avg_Student"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnProcess As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMidName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
