Imports System.Runtime.Remoting, System.Runtime.Remoting.Channels, System.Runtime.Remoting.Channels.Http

Module Module1

    Sub Main()
        Console.WriteLine("Server Started ...")
        Dim c As New System.Runtime.Remoting.Channels.Http.HttpChannel(1234)
        ChannelServices.RegisterChannel(c)
        RemotingConfiguration.RegisterWellKnownServiceType(GetType(RemotingGeneral.ManageEmployee), "SOAP", WellKnownObjectMode.Singleton)

        Console.ReadLine()
    End Sub

End Module
