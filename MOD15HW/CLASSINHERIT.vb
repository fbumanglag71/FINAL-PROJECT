Public Class ClassInherit
    MustInherit Class Person

        Public Property FirstName As String
        Public Property LastName As String
        Public Property Email As String
        MustOverride Function Choice() As String

    End Class    'PERSON

    Class Students

        Inherits Person

        Public Property StudentNumber As String

        Overrides Function Choice() As String
            Return ""
        End Function


    End Class    'STUDENT

    Class Instructors

        Inherits Person
        Public Property OfficeNumber As String
        Overrides Function Choice() As String
            Return ""
        End Function

    End Class    'INSTRUCTOR

    Class Courses

        Public Property CourseNumber As String
        Public Property CourseName As String
        Public Property CourseUnits As String
        Public Property RoomNumber As String


    End Class    'COURSE

End Class       'CLASS INHERIT








