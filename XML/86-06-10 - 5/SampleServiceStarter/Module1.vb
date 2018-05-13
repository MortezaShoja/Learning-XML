Module Module1

    Sub Main()
        Dim sc As New ServiceProcess.ServiceController("SampleServiceInstaller")
        While True
            Dim command As String = Console.ReadLine()
            If command = "stop" Then
                sc.Stop()
            ElseIf command = "start" Then
                sc.Start()
            ElseIf command = "pause" Then
                sc.Pause()
            ElseIf command = "continue" Then
                sc.Continue()
            Else
                Exit While
            End If
        End While
    End Sub

End Module
