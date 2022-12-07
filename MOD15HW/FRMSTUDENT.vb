Imports MOD15HW.ClassInherit

Public Class FRMSTUDENT

    'DECLARE INSTANTIATION CODE OBJECT

    Dim Stu As New Students

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'POINT STUDENT CLASSES TO INPUT TEXT BOXES
        Stu.FirstName = stuFirst.Text
        Stu.LastName = stuLast.Text
        Stu.Email = studEmail.Text
        Stu.StudentNumber = stuNumber.Text


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        'DISPLAY STUDENT DATA INTO LISTBOX
        ListBox1.Items.Add("Student Name: " + Stu.FirstName + " " & Stu.LastName)
        ListBox1.Items.Add("Email: " + Stu.Email)
        ListBox1.Items.Add("Student Number: " + Stu.StudentNumber)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'DECLARE EXPORT VARIABLE TO SAVE STUDENT DATA AS CSV FILE TYPE
        Dim export As IO.StreamWriter = IO.File.CreateText("C:\Users\Francisco Bumanglag\Desktop\CE_STUDENT.csv")

        'CREATE FILE HEADERS -- COMMMA DELIMITED
        export.WriteLine("FIRST NAME" & "," & "LAST NAME" & "," & "EMAIL" & "," & "STUDENT NUMBER")

        'INSERT DATA INTO FILE -- COMMA DELIMITED
        export.WriteLine(Stu.FirstName & "," & Stu.LastName & "," & Stu.Email & "," & Stu.StudentNumber)

        export.Close()   'IF THIS LINE IS OMMITED THE FILE WILL BE EMPTY

        'MESSAGE TO USER -- FILE EXPORTED SUCCESSFULLY
        MessageBox.Show("YOUR STUDENT INFORMATION WAS SAVE AND EXPORTED TO A CSV FILE.  PLEASE CHECK YOUR DESKTOP AND LOCATE FILE THE CE_STUDENT FILE")


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()      'CLOSE STUDENT FORM
        MAIN.Show()     'UNHIDE / SHOW MAIN FORM

    End Sub

    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ON LOAD CENTER STUDENT FORM
        Me.CenterToScreen()

    End Sub

End Class