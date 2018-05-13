Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Http
Imports System.Data.SqlClient
Imports System.Data
Imports MyGeneral

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Name = "Form1"
        Me.Text = "Form1"

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dbg As New DataGrid
        Dim tbl As New DataTable("Employees")
        tbl.Columns.Add("EmployeeID")
        tbl.Columns.Add("Lastname")
        tbl.Columns.Add("Firstname")
        Dim c As New HttpChannel
        ChannelServices.RegisterChannel(c)
        Dim i As Integer
        Dim ig As IGetMyEmployees = Activator.GetObject((New MyEmployees).GetType, "http://192.168.1.3:1234/Employees.SOAP")
        i = ig.GetCount
        While i > 0
            Dim emp As MyEmployees = ig.GetEmployee(i)
            Dim r As DataRow = tbl.NewRow
            r.Item("employeeid") = emp.EmployeeID
            r.Item("lastname") = emp.LastName
            r.Item("firstname") = emp.FirstName
            tbl.Rows.Add(r)
            i -= 1
        End While
        Dim dvw As New DataView(tbl)
        dvw.Sort = "Employeeid"
        'dbg.DataSource = tbl
        dbg.DataSource = dvw
        dbg.Dock = DockStyle.Fill
        Me.Controls.Add(dbg)
    End Sub
End Class
