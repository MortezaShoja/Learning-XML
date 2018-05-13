<Serializable()> Public Class employee
    Inherits MarshalByRefObject
    Public employeeid As String
    Public family As String
    Public name As String

    Public Function GetInfo() As String
        Return employeeid & "," & family & "," & name
    End Function
End Class

Public Interface IGetEmployee
    Function GetE() As employee
End Interface

<Serializable()> Public Class EmployeeManager
    Inherits MarshalByRefObject
    Implements IGetEmployee

    Public Function GetE() As employee Implements IGetEmployee.GetE
        Dim e As New employee
        e.employeeid = "7"
        e.family = "king"
        e.name = "robert"
        Return e
    End Function
End Class
