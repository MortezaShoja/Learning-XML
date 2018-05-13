Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Http
Imports System.Data.SqlClient
Imports System.Data

<Serializable()> Public Class MyEmployees
    Inherits MarshalByRefObject

    Public EmployeeID As Integer
    Public LastName As String
    Public FirstName As String

    Public Function GetInfo() As String
        Return EmployeeID.ToString & "," & FirstName & "," & LastName
    End Function
End Class

Public Interface IGetMyEmployees
    Function GetEmployee(ByVal ID As Integer) As MyEmployees
    Function GetCount() As Integer
End Interface

<Serializable()> Public Class EmployeeManager
    Inherits MarshalByRefObject
    Implements IGetMyEmployees


    Public Function GetEmployee(ByVal ID As Integer) As MyEmployees Implements IGetMyEmployees.GetEmployee
        Dim e As New MyEmployees

        Dim sqlcon As New SqlConnection("server=local;integrated security=sspi;data source=.;database=northwind")
        Dim cmd As New SqlCommand("SELECT * FROM dbo.GetInfo(" & ID.ToString & ")", sqlcon)
        sqlcon.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader
        If sdr.HasRows Then
            While sdr.Read
                e.EmployeeID = sdr.Item(0)
                e.LastName = sdr.Item(1)
                e.FirstName = sdr.Item(2)
            End While
            sdr.Close()
        End If
        sqlcon.Close()
        Return e
    End Function

    Public Function GetCount() As Integer Implements IGetMyEmployees.GetCount
        Dim sqlcon As New SqlConnection("server=local;integrated security=sspi;data source=.;database=northwind")
        Dim cmd As New SqlCommand("SELECT dbo.GetCount()", sqlcon)
        sqlcon.Open()
        Dim i As Integer = CType(cmd.ExecuteScalar, Integer)
        sqlcon.Close()
        Return i
    End Function
End Class
