Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim sc As ServiceProcess.ServiceController

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
    Friend WithEvents txtCMD As System.Windows.Forms.TextBox
    Friend WithEvents btnE As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtCMD = New System.Windows.Forms.TextBox
        Me.btnE = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtCMD
        '
        Me.txtCMD.Location = New System.Drawing.Point(32, 40)
        Me.txtCMD.Name = "txtCMD"
        Me.txtCMD.TabIndex = 0
        Me.txtCMD.Text = ""
        '
        'btnE
        '
        Me.btnE.Location = New System.Drawing.Point(32, 96)
        Me.btnE.Name = "btnE"
        Me.btnE.TabIndex = 1
        Me.btnE.Text = "!"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.txtCMD)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnE.Click
        sc.ExecuteCommand(Integer.Parse(txtCMD.Text))
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sc = New ServiceProcess.ServiceController("CustomService", "192.168.1.3")
    End Sub
End Class
