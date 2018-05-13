Imports System.Runtime.Remoting, System.Runtime.Remoting.Channels, System.Runtime.Remoting.Channels.Http



<Serializable()> Public Class employee
    Inherits MarshalByRefObject
    Public employeeid As String
    Public lastname As String
    Public firstname As String

    Public Function GetInfo() As String
        Return employeeid & "," & lastname & "," & firstname
    End Function
End Class

Public Interface IGetEmployee
    Function GetEmployee(ByVal employeeid As String) As employee
End Interface