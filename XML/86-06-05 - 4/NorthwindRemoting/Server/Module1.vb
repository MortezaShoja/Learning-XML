Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Http
Imports System.Data.SqlClient
Imports System.Data
Imports MyGeneral

Module Module1

    Sub Main()
        Dim c As New HttpChannel(1234)
        ChannelServices.RegisterChannel(c)
        RemotingConfiguration.RegisterWellKnownServiceType((New EmployeeManager).GetType, "Employees.SOAP", WellKnownObjectMode.Singleton)
        Console.WriteLine("Console Started...")
        Console.ReadLine()
    End Sub

End Module
