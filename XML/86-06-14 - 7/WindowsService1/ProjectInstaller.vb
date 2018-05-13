Imports System.ComponentModel
Imports System.Configuration.Install

<RunInstaller(True)> Public Class ProjectInstaller
    Inherits System.Configuration.Install.Installer

#Region " Component Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Installer overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents PerformanceCounterInstaller1 As System.Diagnostics.PerformanceCounterInstaller
    Friend WithEvents ServiceProcessInstaller1 As System.ServiceProcess.ServiceProcessInstaller
    Friend WithEvents ServiceInstaller1 As System.ServiceProcess.ServiceInstaller
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PerformanceCounterInstaller1 = New System.Diagnostics.PerformanceCounterInstaller
        Me.ServiceProcessInstaller1 = New System.ServiceProcess.ServiceProcessInstaller
        Me.ServiceInstaller1 = New System.ServiceProcess.ServiceInstaller
        '
        'PerformanceCounterInstaller1
        '
        Me.PerformanceCounterInstaller1.CategoryHelp = "None"
        Me.PerformanceCounterInstaller1.CategoryName = "C"
        Me.PerformanceCounterInstaller1.Counters.AddRange(New System.Diagnostics.CounterCreationData() {New System.Diagnostics.CounterCreationData("C", "None", System.Diagnostics.PerformanceCounterType.NumberOfItems32)})
        '
        'ServiceProcessInstaller1
        '
        Me.ServiceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalService
        Me.ServiceProcessInstaller1.Password = Nothing
        Me.ServiceProcessInstaller1.Username = Nothing
        '
        'ServiceInstaller1
        '
        Me.ServiceInstaller1.ServiceName = "Service1"
        '
        'ProjectInstaller
        '
        Me.Installers.AddRange(New System.Configuration.Install.Installer() {Me.PerformanceCounterInstaller1, Me.ServiceProcessInstaller1, Me.ServiceInstaller1})

    End Sub

#End Region

End Class
