Imports System.Runtime.Remoting, System.Runtime.Remoting.Channels, System.Runtime.Remoting.Channels.Http, employee

Module Module1

    Sub Main()
        Dim c As New HttpChannel
        ChannelServices.RegisterChannel(c)
        Dim ig As IGetEmployee = Activator.GetObject((New employee.employee).GetType, "http://localhost:1234/SOAP")
        Dim e As employee.employee = ig.GetE
        Console.WriteLine(e.GetInfo)
        Console.ReadLine()
    End Sub

End Module
