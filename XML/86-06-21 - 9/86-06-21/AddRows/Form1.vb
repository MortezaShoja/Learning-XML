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
    Friend WithEvents txtT As System.Windows.Forms.TextBox
    Friend WithEvents btnA As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sqlcon As System.Data.SqlClient.SqlConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtT = New System.Windows.Forms.TextBox
        Me.btnA = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.sqlcon = New System.Data.SqlClient.SqlConnection
        Me.SuspendLayout()
        '
        'txtT
        '
        Me.txtT.Location = New System.Drawing.Point(128, 40)
        Me.txtT.Name = "txtT"
        Me.txtT.Size = New System.Drawing.Size(144, 20)
        Me.txtT.TabIndex = 0
        Me.txtT.Text = ""
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(128, 80)
        Me.btnA.Name = "btnA"
        Me.btnA.TabIndex = 1
        Me.btnA.Text = "Add"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Title"
        '
        'sqlcon
        '
        Me.sqlcon.ConnectionString = "server=local;data source=192.168.1.4;user id=sa;pwd=;database=mu"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.txtT)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click
        Dim cmd As New SqlClient.SqlCommand("EXEC INS_T '" & txtT.Text & "'", sqlcon)
        sqlcon.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Done")
        sqlcon.Close()
    End Sub
End Class
