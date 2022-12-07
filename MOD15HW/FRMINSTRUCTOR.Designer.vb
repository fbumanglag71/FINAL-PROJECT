<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMINSTRUCTOR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.InstOffice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InsEmail = New System.Windows.Forms.TextBox()
        Me.instEmail = New System.Windows.Forms.Label()
        Me.instLast = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.instFirst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(403, 315)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(134, 23)
        Me.Button4.TabIndex = 135
        Me.Button4.Text = "3. EXPORT TO CSV"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(557, 315)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 23)
        Me.Button3.TabIndex = 134
        Me.Button3.Text = "4. EXIT FORM"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(211, 315)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 23)
        Me.Button2.TabIndex = 133
        Me.Button2.Text = "2. DISPLAY INFORMATION"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 23)
        Me.Button1.TabIndex = 132
        Me.Button1.Text = "1. SAVE INFORMATION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InstOffice
        '
        Me.InstOffice.Location = New System.Drawing.Point(211, 223)
        Me.InstOffice.Name = "InstOffice"
        Me.InstOffice.Size = New System.Drawing.Size(166, 23)
        Me.InstOffice.TabIndex = 129
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 15)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Instructor Office#"
        '
        'InsEmail
        '
        Me.InsEmail.Location = New System.Drawing.Point(211, 179)
        Me.InsEmail.Name = "InsEmail"
        Me.InsEmail.Size = New System.Drawing.Size(166, 23)
        Me.InsEmail.TabIndex = 127
        '
        'instEmail
        '
        Me.instEmail.AutoSize = True
        Me.instEmail.Location = New System.Drawing.Point(76, 187)
        Me.instEmail.Name = "instEmail"
        Me.instEmail.Size = New System.Drawing.Size(90, 15)
        Me.instEmail.TabIndex = 126
        Me.instEmail.Text = "Instructor Email"
        '
        'instLast
        '
        Me.instLast.Location = New System.Drawing.Point(211, 132)
        Me.instLast.Name = "instLast"
        Me.instLast.Size = New System.Drawing.Size(166, 23)
        Me.instLast.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 15)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Instructor Last Name"
        '
        'instFirst
        '
        Me.instFirst.Location = New System.Drawing.Point(211, 86)
        Me.instFirst.Name = "instFirst"
        Me.instFirst.Size = New System.Drawing.Size(166, 23)
        Me.instFirst.TabIndex = 123
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 15)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Instructor First Name"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(447, 86)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(244, 169)
        Me.ListBox1.TabIndex = 136
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(182, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(382, 37)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "INSTRUCTOR INPUT SCREEN"
        '
        'FRMINSTRUCTOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 386)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.InstOffice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.InsEmail)
        Me.Controls.Add(Me.instEmail)
        Me.Controls.Add(Me.instLast)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.instFirst)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRMINSTRUCTOR"
        Me.Text = "FRMINSTRUCTOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents InstOffice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents InsEmail As TextBox
    Friend WithEvents instEmail As Label
    Friend WithEvents instLast As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents instFirst As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
End Class
