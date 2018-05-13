Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Http
Imports System.Data.SqlClient
Imports System.Data
Imports MyGeneral

Public Class Form1
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnV As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnV = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(96, 16)
        Me.txtID.Name = "txtID"
        Me.txtID.TabIndex = 0
        Me.txtID.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EmployeeID"
        '
        'btnV
        '
        Me.btnV.Location = New System.Drawing.Point(216, 16)
        Me.btnV.Name = "btnV"
        Me.btnV.TabIndex = 2
        Me.btnV.Text = "View"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 48)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(312, 216)
        Me.DataGrid1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(312, 262)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.btnV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c = New HttpChannel
        ChannelServices.RegisterChannel(c)
    End Sub

    Private Sub btnV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnV.Click
        Dim ig As IGetMyEmployees = Activator.GetObject((New MyEmployees).GetType, "http://192.168.1.3:1234/Employees.SOAP")
        Dim emp As MyEmployees = ig.GetEmployee(Integer.Parse(txtID.Text))
        Dim tbl As New DataTable("Employees")
        tbl.Columns.Add("EmployeeID")
        tbl.Columns.Add("Lastname")
        tbl.Columns.Add("Firstname")
        Dim r As DataRow = tbl.NewRow
        r.Item("employeeid") = emp.EmployeeID
        r.Item("lastname") = emp.LastName
        r.Item("firstname") = emp.FirstName
        tbl.Rows.Add(r)
        DataGrid1.DataSource = tbl
    End Sub
End Class
