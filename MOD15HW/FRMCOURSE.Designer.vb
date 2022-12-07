<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMCOURSE
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.courUnits = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.courRoom = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.courName = New System.Windows.Forms.TextBox()
        Me.courNum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(395, 325)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 23)
        Me.Button4.TabIndex = 135
        Me.Button4.Text = "3. EXPORT TO CSV"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(537, 325)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 23)
        Me.Button3.TabIndex = 134
        Me.Button3.Text = "4. EXIT FORM"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(202, 325)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 23)
        Me.Button2.TabIndex = 133
        Me.Button2.Text = "2. DISPLAY INFORMATION"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 23)
        Me.Button1.TabIndex = 132
        Me.Button1.Text = "1. SAVE INFORMATION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(54, 200)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 15)
        Me.Label16.TabIndex = 129
        Me.Label16.Text = "Course Units"
        '
        'courUnits
        '
        Me.courUnits.Location = New System.Drawing.Point(144, 192)
        Me.courUnits.Name = "courUnits"
        Me.courUnits.Size = New System.Drawing.Size(145, 23)
        Me.courUnits.TabIndex = 124
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(61, 251)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 15)
        Me.Label15.TabIndex = 128
        Me.Label15.Text = "Course Room"
        '
        'courRoom
        '
        Me.courRoom.Location = New System.Drawing.Point(144, 243)
        Me.courRoom.Name = "courRoom"
        Me.courRoom.Size = New System.Drawing.Size(145, 23)
        Me.courRoom.TabIndex = 125
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 15)
        Me.Label9.TabIndex = 127
        Me.Label9.Text = "Course Name"
        '
        'courName
        '
        Me.courName.Location = New System.Drawing.Point(144, 148)
        Me.courName.Name = "courName"
        Me.courName.Size = New System.Drawing.Size(145, 23)
        Me.courName.TabIndex = 123
        '
        'courNum
        '
        Me.courNum.Location = New System.Drawing.Point(144, 102)
        Me.courNum.Name = "courNum"
        Me.courNum.Size = New System.Drawing.Size(145, 23)
        Me.courNum.TabIndex = 122
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(76, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 15)
        Me.Label8.TabIndex = 126
        Me.Label8.Text = "Course#"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(381, 102)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(251, 169)
        Me.ListBox1.TabIndex = 136
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(186, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 37)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "COURSE INPUT SCREEN"
        '
        'FRMCOURSE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 386)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.courUnits)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.courRoom)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.courName)
        Me.Controls.Add(Me.courNum)
        Me.Controls.Add(Me.Label8)
        Me.Name = "FRMCOURSE"
        Me.Text = "FRMCOURSE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents courUnits As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents courRoom As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents courName As TextBox
    Friend WithEvents courNum As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
End Class
