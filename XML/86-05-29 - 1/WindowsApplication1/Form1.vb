Imports System.Data.SqlClient, System.Data

Public Class Form1
    Inherits System.Windows.Forms.Form

    Public Shared ds As DataSet

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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(408, 342)
        Me.Name = "Form1"
        Me.Text = "Form1"

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sdaE As New SqlDataAdapter("SELECT * FROM employees", New SqlConnection("server=local;integrated security=sspi;data source=.;database=northwind"))
        ds = New DataSet("Employees")
        sdaE.FillSchema(ds, SchemaType.Source)
        sdaE.Fill(ds)
        Dim dbg As New DataGrid
        dbg.Dock = DockStyle.Fill
        Me.Controls.Add(dbg)
        dbg.DataSource = ds
        dbg.DataMember = ds.Tables(0).TableName
        'MsgBox(ds.Tables(0).TableName)
        ds.WriteXmlSchema("..\Schema.xsd")
        ds.WriteXml("..\Data.XML")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim frm As New Form2
        frm.Show()
        Dim frm1 As New Form3
        frm1.Show()
        Timer1.Enabled = False
    End Sub
End Class
