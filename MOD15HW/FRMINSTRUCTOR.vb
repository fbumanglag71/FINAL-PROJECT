'POINT TO CLASS INHERIT FORM
Imports MOD15HW.ClassInherit

Public Class FRMINSTRUCTOR

    'DECLAR INSTANTIATION CODE OBJECT
    Dim Inst As New Instructors

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'CLEAR ANY DATA IN LIST BOX
        ListBox1.Items.Clear()

        'POINT INSTRUCTOR CLASS TO INPUT TEXT BOXES
        Inst.FirstName = instFirst.Text
        Inst.LastName = instLast.Text
        Inst.Email = InsEmail.Text
        Inst.OfficeNumber = InstOffice.Text



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'DISPLAY INSTRUCTOR DATA INTO LISTBOX 
        ListBox1.Items.Add("Instructor Name: " + Inst.FirstName + " " + Inst.LastName)
        ListBox1.Items.Add("Email: " + Inst.Email)
        ListBox1.Items.Add("Office Number: " + Inst.OfficeNumber)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'DECLARE EXPORT VARIABLE TO EXPORT INSTRUCTOR DATA TO CSV FILE TYPE
        Dim export As IO.StreamWriter = IO.File.CreateText("C:\Users\Francisco Bumanglag\Desktop\CE_INSTRUCTOR.csv")

        'CREATE FILE HEADERS -- COMMMA DELIMITED
        export.WriteLine("FIRST NAME" & "," & "LAST NAME" & "," & "EMAIL" & "," & "OFFICE NUMBER")

        'INSERT DATA INTO FILE -- COMMA DELIMITED
        export.WriteLine(Inst.FirstName & "," & Inst.LastName & "," & Inst.Email & "," & Inst.OfficeNumber)

        export.Close()   'IF THIS LINE IS OMMITED THE FILE WILL BE EMPTY

        'MESSAGE FOR USER -- EXPORT WAS SUCCESSFUL
        MessageBox.Show("YOUR INSTRUCTOR INFORMATION WAS SAVE AND EXPORTED TO A CSV FILE.  PLEASE CHECK YOUR DESKTOP AND LOCATE FILE THE CE_INSTRUCTOR FILE")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()
        MAIN.Show()

    End Sub

    Private Sub frmInstructor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

    End Sub
End Class