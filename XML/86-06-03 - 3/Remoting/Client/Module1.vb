Imports System.Runtime.Remoting, System.Runtime.Remoting.Channels, System.Runtime.Remoting.Channels.Http

Module Module1

    Sub Main()
        Dim c As New HttpChannel
        ChannelServices.RegisterChannel(c)

        Dim i As RemotingGeneral.IGetEmployee = Activator.GetObject(GetType(RemotingGeneral.Employee), "http://localhost:1234/SOAP")
        Dim e As RemotingGeneral.Employee = i.GeE
        Console.WriteLine(e.getinfo)
        'Console.WriteLine(CType(Activator.GetObject(GetType(RemotingGeneral.ManageEmployee), "http://localhost:1234/SOAP"), RemotingGeneral.ManageEmployee).GeE.getinfo)
        Console.ReadLine()
    End Sub

End Module
