Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Http
Imports RemotingServiceGeneral
Imports System.ServiceProcess

Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim counter As Integer
    Dim sc As ServiceController
    Dim c As HttpChannel

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
    Friend WithEvents lblS As System.Windows.Forms.Label
    Friend WithEvents tmrS As System.Windows.Forms.Timer
    Friend WithEvents tmrR As System.Windows.Forms.Timer
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnG As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dbg As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lblS = New System.Windows.Forms.Label
        Me.tmrS = New System.Windows.Forms.Timer(Me.components)
        Me.tmrR = New System.Windows.Forms.Timer(Me.components)
        Me.txtID = New System.Windows.Forms.TextBox
        Me.btnG = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.dbg = New System.Windows.Forms.DataGrid
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblS
        '
        Me.lblS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.Location = New System.Drawing.Point(16, 16)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(320, 40)
        Me.lblS.TabIndex = 0
        '
        'tmrS
        '
        Me.tmrS.Interval = 300
        '
        'tmrR
        '
        Me.tmrR.Interval = 300
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(112, 80)
        Me.txtID.Name = "txtID"
        Me.txtID.TabIndex = 1
        Me.txtID.Text = ""
        '
        'btnG
        '
        Me.btnG.Location = New System.Drawing.Point(112, 112)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(96, 23)
        Me.btnG.TabIndex = 2
        Me.btnG.Text = "Get"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "employee id"
        '
        'dbg
        '
        Me.dbg.DataMember = ""
        Me.dbg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbg.Location = New System.Drawing.Point(0, 144)
        Me.dbg.Name = "dbg"
        Me.dbg.Size = New System.Drawing.Size(344, 120)
        Me.dbg.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(344, 266)
        Me.Controls.Add(Me.dbg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnG)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblS)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sc = New ServiceController("EmployeesService", "192.168.1.3")
        lblS.Text = sc.Status.ToString
        If sc.Status = ServiceControllerStatus.Stopped Then
            tmrS.Enabled = True
            Application.DoEvents()
        End If
    End Sub

    Private Sub tmrS_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrS.Tick
        If counter < 5 Then
            lblS.Text &= "."
            counter += 1
        Else
            If sc.Status <> ServiceControllerStatus.Running Then
                sc.Start()
            End If
            tmrS.Enabled = False
            tmrR.Enabled = True
        End If
    End Sub

    Private Sub tmrR_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrR.Tick
        Application.DoEvents()
        sc.Refresh()
        If sc.Status = ServiceControllerStatus.Running Then
            lblS.Text = "Started"
            tmrR.Enabled = False
        End If
    End Sub

    Private Sub btnG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnG.Click
        If c Is Nothing Then
            c = New HttpChannel
        End If
        Dim ig As IGetEmployee = Activator.GetObject(GetType(employee), "http://192.168.1.3:1234/SOAP")
        Dim emp As employee = ig.GetEmployee(txtID.Text)
        Dim tbl As New DataTable("Employees")
        tbl.Columns.Add("EmployeeID")
        tbl.Columns.Add("LastName")
        tbl.Columns.Add("FirstName")
        Dim r As DataRow = tbl.NewRow
        r.Item("Employeeid") = emp.EmployeeID
        r.Item("lastname") = emp.LastName
        r.Item("firstname") = emp.FirstName
        tbl.Rows.Add(r)
        dbg.DataSource = tbl
    End Sub
End Class
