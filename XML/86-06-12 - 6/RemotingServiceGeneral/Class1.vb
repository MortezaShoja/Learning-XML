Imports System.Data.SqlClient

<Serializable()> Public Class employee
    Inherits MarshalByRefObject

    Public EmployeeID As Integer
    Public LastName As String
    Public FirstName As String

End Class

Public Interface IGetEmployee
    Function GetEmployee(ByVal EmployeeID As Integer) As employee
End Interface

<Serializable()> Public Class EmployeeManager
    Inherits MarshalByRefObject
    Implements IGetEmployee

    Public Function GetEmployee(ByVal EmployeeID As Integer) As employee Implements IGetEmployee.GetEmployee
        Dim sqlcon As New SqlConnection("server=local;user id=sa;pwd=;data source=.;database=northwind")
        Dim cmd As New SqlCommand("SELECT employeeid,lastname,firstname FROM employees WHERE employeeid=" & EmployeeID, sqlcon)
        sqlcon.Open()
        Dim e As New employee
        Dim sdr As SqlDataReader = cmd.ExecuteReader
        If sdr.HasRows Then
            sdr.Read()
            e.EmployeeID = sdr.Item("employeeid")
            e.LastName = sdr.Item("Lastname")
            e.FirstName = sdr.Item("firstname")
        End If

        sqlcon.Close()
        Return e
    End Function
End Class
