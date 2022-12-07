<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMSTUDENT
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.stuNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.studEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.stuLast = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.stuFirst = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(411, 308)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 23)
        Me.Button4.TabIndex = 135
        Me.Button4.Text = "3. EXPORT TO CSV"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(553, 308)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 23)
        Me.Button3.TabIndex = 134
        Me.Button3.Text = "4. EXIT FORM"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(213, 308)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 23)
        Me.Button2.TabIndex = 133
        Me.Button2.Text = "2. DISPLAY INFORMATION"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 23)
        Me.Button1.TabIndex = 132
        Me.Button1.Text = "1. SAVE INFORMATION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'stuNumber
        '
        Me.stuNumber.Location = New System.Drawing.Point(186, 228)
        Me.stuNumber.Name = "stuNumber"
        Me.stuNumber.Size = New System.Drawing.Size(166, 23)
        Me.stuNumber.TabIndex = 129
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 15)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Student Number"
        '
        'studEmail
        '
        Me.studEmail.Location = New System.Drawing.Point(186, 181)
        Me.studEmail.Name = "studEmail"
        Me.studEmail.Size = New System.Drawing.Size(166, 23)
        Me.studEmail.TabIndex = 127
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Student Email"
        '
        'stuLast
        '
        Me.stuLast.Location = New System.Drawing.Point(186, 133)
        Me.stuLast.Name = "stuLast"
        Me.stuLast.Size = New System.Drawing.Size(166, 23)
        Me.stuLast.TabIndex = 125
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 15)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Student Last Name"
        '
        'stuFirst
        '
        Me.stuFirst.Location = New System.Drawing.Point(186, 88)
        Me.stuFirst.Name = "stuFirst"
        Me.stuFirst.Size = New System.Drawing.Size(166, 23)
        Me.stuFirst.TabIndex = 123
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 15)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Student First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(184, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 37)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "STUDENT INPUT SCREEN"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(436, 88)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(214, 169)
        Me.ListBox1.TabIndex = 137
        '
        'FRMSTUDENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 373)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.stuNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.studEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.stuLast)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.stuFirst)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FRMSTUDENT"
        Me.Text = "FRMSTUDENT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents stuNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents studEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents stuLast As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents stuFirst As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
