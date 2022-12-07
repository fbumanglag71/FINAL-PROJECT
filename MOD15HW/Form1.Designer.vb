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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(264, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 32)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "COURSE ENROLLMENT"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(330, 326)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(144, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "QUIT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(330, 239)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "INSTRUCTOR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(330, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "STUDENT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(330, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "COURSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
