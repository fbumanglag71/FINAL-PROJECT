<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MAIN
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnInstructor = New System.Windows.Forms.Button()
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnCourse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(56, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 37)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "COURSE ENROLLMENT"
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.Control
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnQuit.Location = New System.Drawing.Point(109, 291)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(194, 23)
        Me.btnQuit.TabIndex = 20
        Me.btnQuit.Text = "QUIT"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnInstructor
        '
        Me.btnInstructor.BackColor = System.Drawing.SystemColors.Control
        Me.btnInstructor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnInstructor.Location = New System.Drawing.Point(109, 186)
        Me.btnInstructor.Name = "btnInstructor"
        Me.btnInstructor.Size = New System.Drawing.Size(194, 23)
        Me.btnInstructor.TabIndex = 19
        Me.btnInstructor.Text = "INSTRUCTOR SCREEN"
        Me.btnInstructor.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.SystemColors.Control
        Me.btnStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnStudent.Location = New System.Drawing.Point(109, 140)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(194, 23)
        Me.btnStudent.TabIndex = 18
        Me.btnStudent.Text = "STUDENT SCREEN"
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'btnCourse
        '
        Me.btnCourse.BackColor = System.Drawing.SystemColors.Control
        Me.btnCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCourse.Location = New System.Drawing.Point(109, 94)
        Me.btnCourse.Name = "btnCourse"
        Me.btnCourse.Size = New System.Drawing.Size(194, 23)
        Me.btnCourse.TabIndex = 17
        Me.btnCourse.Text = "COURSE SCREEN"
        Me.btnCourse.UseVisualStyleBackColor = False
        '
        'MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 344)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnInstructor)
        Me.Controls.Add(Me.btnStudent)
        Me.Controls.Add(Me.btnCourse)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "MAIN"
        Me.Text = "MAIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnInstructor As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnCourse As Button
End Class
