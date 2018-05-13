Imports System.ServiceProcess
Imports System.Diagnostics

Public Class NewSource
    Inherits System.ServiceProcess.ServiceBase

    Private ev As New EventLog

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
        ServicesToRun = New System.ServiceProcess.ServiceBase() {New NewSource}

        System.ServiceProcess.ServiceBase.Run(ServicesToRun)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Component Designer
    ' It can be modified using the Component Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'NewSource
        '
        Me.CanHandlePowerEvent = True
        Me.CanPauseAndContinue = True
        Me.CanShutdown = True
        Me.ServiceName = "NewSource"

    End Sub

#End Region

    Protected Overrides Sub OnStart(ByVal args() As String)
        If Not ev.SourceExists("MyService") Then
            ev.CreateEventSource("MyService", "MyServiceLog")
        End If
        ev.WriteEntry("NewSource Started...")
        EventLog.WriteEntry("test")
    End Sub

    Protected Overrides Sub OnStop()
        ev.WriteEntry("NewSource Stoped...")
    End Sub

End Class
