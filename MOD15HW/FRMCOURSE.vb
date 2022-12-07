'POINT TO CLASS INHERIT
Imports MOD15HW.ClassInherit

Public Class FRMCOURSE

    'DECLARE INSTANTIATING CODE OBJECTS
    Dim Cour As New Courses

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'CLEAR ANY DATA IN LIST BOX
        ListBox1.Items.Clear()

        'POINT CLASS COURSE TO INPUT TEXT BOXES
        Cour.CourseNumber = courNum.Text
        Cour.CourseName = courName.Text
        Cour.CourseUnits = courUnits.Text
        Cour.RoomNumber = courRoom.Text


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        'DISPLAY SAVED COURSE DATA INTO LISTBOX
        ListBox1.Items.Add("Course#: " + Cour.CourseNumber)
        ListBox1.Items.Add("Course Name: " + Cour.CourseName)
        ListBox1.Items.Add("Units: " + Cour.CourseUnits)
        ListBox1.Items.Add("Room#: " + Cour.RoomNumber)





    End Sub

        Private Sub frmCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ON FORM LOAD CENTER THE FORM
        Me.CenterToScreen()

    End Sub

        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'DECLAR EXPORT VARIABLE TO SAVE COURSE DATA AS CSV FILE TYPE 
        Dim export As IO.StreamWriter = IO.File.CreateText("C:\Users\Francisco Bumanglag\Desktop\CE_COURSE.csv")

        'CREATE FILE HEADERS -- COMMMA DELIMITED
        export.WriteLine("COURSE NUMBER" & "," & "COURSE NAME" & "," & "COURSE UNITS" & "," & "COURSE NUMBER")

        'INSERT DATA INTO FILE -- COMMA DELIMITED
        export.WriteLine(Cour.CourseNumber & "," & Cour.CourseName & "," & Cour.CourseUnits & "," & Cour.RoomNumber)

        export.Close()   'IF THIS LINE IS OMMITED THE FILE WILL BE EMPTY

        'MESSAGE FOR USER -- FILE EXPORTED SUCESSFULLY
        MessageBox.Show("YOUR COURSE INFORMATION WAS SAVE AND EXPORTED TO A CSV FILE.  PLEASE CHECK YOUR DESKTOP AND LOCATE FILE THE CE_COURSE FILE")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()      'CLOSE THE COURSE FORM
        MAIN.Show()     'UNHIDE / SHOW THE MAIN FORM

    End Sub


End Class