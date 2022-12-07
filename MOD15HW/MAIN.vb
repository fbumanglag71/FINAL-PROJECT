Public Class MAIN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCourse.Click

        Me.Hide()               'HIDE MAIN FORM
        FRMCOURSE.Show()        'OPEN COURSE FORM

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnStudent.Click

        Me.Hide()               'HIDE MAIN FORM
        FRMSTUDENT.Show()       'OPEN STUDENT FORM

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnInstructor.Click

        Me.Hide()               'HIDE MAIN FORM
        FRMINSTRUCTOR.Show()    'OPEN INSTRUCUTOR FORM

    End Sub

    Private Sub MAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()     'ON FORM LOAD CENTER THE FORM

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Me.Close()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 

    End Sub
End Class           'MAIN FORM