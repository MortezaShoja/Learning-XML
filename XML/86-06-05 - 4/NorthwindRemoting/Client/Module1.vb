Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Http
Imports System.Data.SqlClient
Imports System.Data
Imports MyGeneral

Module Module1

    Sub Main()
        Dim c As New HttpChannel
        ChannelServices.RegisterChannel(c)
        While True
            Dim ig As IGetMyEmployees = Activator.GetObject((New MyEmployees).GetType, "http://192.168.1.3:1234/Employees.SOAP")
            Dim e As MyEmployees = ig.GetEmployee(Console.ReadLine)
            Console.WriteLine(e.GetInfo)
        End While
    End Sub

End Module
