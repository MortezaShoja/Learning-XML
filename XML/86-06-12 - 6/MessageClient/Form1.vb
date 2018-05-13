Imports System.ServiceProcess

Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim sc As ServiceController
    Dim tbl As DataTable


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
    Friend WithEvents cboMsg As System.Windows.Forms.ComboBox
    Friend WithEvents btnS As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboMsg = New System.Windows.Forms.ComboBox
        Me.btnS = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cboMsg
        '
        Me.cboMsg.Location = New System.Drawing.Point(64, 40)
        Me.cboMsg.Name = "cboMsg"
        Me.cboMsg.Size = New System.Drawing.Size(160, 21)
        Me.cboMsg.TabIndex = 0
        '
        'btnS
        '
        Me.btnS.Location = New System.Drawing.Point(64, 104)
        Me.btnS.Name = "btnS"
        Me.btnS.TabIndex = 1
        Me.btnS.Text = "Send"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.cboMsg)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sc = New ServiceController("MessagingService", "192.168.1.3")
        tbl = New DataTable("Messages")
        tbl.Columns.Add("ID")
        tbl.Columns.Add("Text")
        Dim r1 As DataRow = tbl.NewRow
        r1(0) = 129
        r1(1) = "Hello"
        tbl.Rows.Add(r1)
        Dim r2 As DataRow = tbl.NewRow
        r2(0) = 130
        r2(1) = "Bye"
        tbl.Rows.Add(r2)
        Dim r3 As DataRow = tbl.NewRow
        r3(0) = 131
        r3(1) = ":-)"
        tbl.Rows.Add(r3)
        Dim r4 As DataRow = tbl.NewRow
        r4(0) = 132
        r4(1) = ":-("
        tbl.Rows.Add(r4)
        Dim r5 As DataRow = tbl.NewRow
        r5(0) = 133
        r5(1) = ":-*"
        tbl.Rows.Add(r5)
        Dim ds As New DataSet("ds")
        ds.Tables.Add(tbl)
        cboMsg.DataSource = ds.Tables(0)
        cboMsg.DisplayMember = ds.Tables(0).Columns(1).ColumnName
        cboMsg.ValueMember = ds.Tables(0).Columns(0).ColumnName
    End Sub

    Private Sub btnS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnS.Click
        sc.ExecuteCommand(cboMsg.SelectedValue)
    End Sub
End Class
