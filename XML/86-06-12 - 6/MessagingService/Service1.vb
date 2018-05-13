Imports System.ServiceProcess

Public Class MessagingService
    Inherits System.ServiceProcess.ServiceBase

#Region " Component Designer generated code "

    Public Sub New()
        MyBase.New()

        ' This call is required by the Component Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call

    End Sub

    'UserService overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' The main entry point for the process
    <MTAThread()> _
    Shared Sub Main()
        Dim ServicesToRun() As System.ServiceProcess.ServiceBase

        ' More than one NT Service may run within the same process. To add
        ' another service to this process, change the following line to
        ' create a second service object. For example,
        '
        '   ServicesToRun = New System.ServiceProcess.ServiceBase () {New Service1, New MySecondUserService}
        '
        ServicesToRun = New System.ServiceProcess.ServiceBase() {New MessagingService}

        System.ServiceProcess.ServiceBase.Run(ServicesToRun)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Component Designer
    ' It can be modified using the Component Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'MessagingService
        '
        Me.CanHandlePowerEvent = True
        Me.CanPauseAndContinue = True
        Me.CanShutdown = True
        Me.ServiceName = "MessagingService"

    End Sub

#End Region

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
    End Sub

    Protected Overrides Sub OnCustomCommand(ByVal command As Integer)
        Dim sw As New IO.StreamWriter("C:\Messages.txt", True)
        Dim text As String
        Select Case command
            Case Is = 129
                text = "Hello"
            Case Is = 130
                text = "Bye"
            Case Is = 131
                text = ":-)"
            Case Is = 132
                text = ":-("
            Case Is = 133
                text = ":-*"
        End Select
        sw.WriteLine(text)
        sw.Close()
    End Sub
End Class
