Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lst As System.Windows.Forms.ListBox
    Friend WithEvents btnStop As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lst = New System.Windows.Forms.ListBox
        Me.btnStop = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lst
        '
        Me.lst.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lst.Location = New System.Drawing.Point(0, 0)
        Me.lst.Name = "lst"
        Me.lst.Size = New System.Drawing.Size(292, 264)
        Me.lst.TabIndex = 0
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(312, 16)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(400, 266)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.lst)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sc As New ServiceProcess.ServiceController
        Dim services() As ServiceProcess.ServiceController = sc.GetServices()
        For i As Integer = 0 To services.Length - 1
            lst.Items.Add(services(i).ServiceName)
        Next
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Dim s As New ServiceProcess.ServiceController(lst.SelectedItem)
        If s.CanStop Then
            s.Stop()
        Else
            MsgBox("Impossible!")
        End If
    End Sub
End Class
