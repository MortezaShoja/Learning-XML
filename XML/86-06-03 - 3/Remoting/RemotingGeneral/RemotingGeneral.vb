<Serializable()> Public Class Employee
    Inherits MarshalByRefObject

    Public family As String

    Public Function getinfo() As String
        Return family
    End Function
End Class

Public Class ManageEmployee
    Inherits MarshalByRefObject

    Implements IGetEmployee

    Public Function GeE() As Employee Implements IGetEmployee.GeE
        Dim e As New Employee
        e.family = "morteza shoja is OK"
        Return e
    End Function
End Class

Public Interface IGetEmployee
    Function GeE() As Employee
End Interface