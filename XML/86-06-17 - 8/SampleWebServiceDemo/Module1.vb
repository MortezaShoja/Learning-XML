Module Module1

    Sub Main()
        Dim s As New SampleWebServiceDemo.localhost.WebSCOM
        Console.WriteLine(s.HelloWorld)
        Dim s1 As New localhost1.GetSum

        Console.WriteLine(s1.GetSum(1))
        Console.ReadLine()
    End Sub

End Module
