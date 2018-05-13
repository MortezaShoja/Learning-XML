Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Http

Module Module1

    Sub Main()
        Console.WriteLine("Server Started...")
        Dim chn As New HttpChannel(8080)
        ChannelServices.RegisterChannel(chn)
        RemotingConfiguration.RegisterWellKnownServiceType((New employee.employee).GetType, "GetEmployee.SOAP", WellKnownObjectMode.Singleton)
        Console.ReadLine()
    End Sub

End Module
