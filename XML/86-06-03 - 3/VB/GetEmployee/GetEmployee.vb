Public Class GetEmployee
    Inherits MarshalByRefObject
    Implements employee.IGetEmployee


    Public Function GetEmployee(ByVal employeeid As String) As employee.employee Implements employee.IGetEmployee.GetEmployee
        Dim e1 As New employee.employee
        e1.employeeid = "7"
        e1.firstname = "shahram"
        e1.lastname = "ramezani"
        Return e1
    End Function
End Class
