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
    Friend WithEvents sdaE As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Ds1 As GetChangesDemo.ds
    Friend WithEvents dbgA As System.Windows.Forms.DataGrid
    Friend WithEvents dbgB As System.Windows.Forms.DataGrid
    Friend WithEvents btnG As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.sdaE = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Ds1 = New GetChangesDemo.ds
        Me.dbgA = New System.Windows.Forms.DataGrid
        Me.dbgB = New System.Windows.Forms.DataGrid
        Me.btnG = New System.Windows.Forms.Button
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbgA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbgB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sdaE
        '
        Me.sdaE.DeleteCommand = Me.SqlDeleteCommand1
        Me.sdaE.InsertCommand = Me.SqlInsertCommand1
        Me.sdaE.SelectCommand = Me.SqlSelectCommand1
        Me.sdaE.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "MyEmployees", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employeeid", "employeeid"), New System.Data.Common.DataColumnMapping("lastname", "lastname"), New System.Data.Common.DataColumnMapping("firstname", "firstname")})})
        Me.sdaE.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM MyEmployees WHERE (employeeid = @Original_employeeid) AND (firstname " & _
        "= @Original_firstname) AND (lastname = @Original_lastname)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employeeid", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employeeid", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_firstname", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "firstname", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_lastname", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lastname", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=COM3;packet size=4096;integrated security=SSPI;data source=""."";per" & _
        "sist security info=False;initial catalog=my_db"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO MyEmployees(lastname, firstname) VALUES (@lastname, @firstname); SELE" & _
        "CT employeeid, lastname, firstname FROM MyEmployees WHERE (employeeid = @@IDENTI" & _
        "TY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@lastname", System.Data.SqlDbType.NVarChar, 20, "lastname"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firstname", System.Data.SqlDbType.NVarChar, 10, "firstname"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT employeeid, lastname, firstname FROM MyEmployees"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE MyEmployees SET lastname = @lastname, firstname = @firstname WHERE (employ" & _
        "eeid = @Original_employeeid) AND (firstname = @Original_firstname) AND (lastname" & _
        " = @Original_lastname); SELECT employeeid, lastname, firstname FROM MyEmployees " & _
        "WHERE (employeeid = @employeeid)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@lastname", System.Data.SqlDbType.NVarChar, 20, "lastname"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@firstname", System.Data.SqlDbType.NVarChar, 10, "firstname"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employeeid", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employeeid", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_firstname", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "firstname", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_lastname", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lastname", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employeeid", System.Data.SqlDbType.Int, 4, "employeeid"))
        '
        'Ds1
        '
        Me.Ds1.DataSetName = "ds"
        Me.Ds1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'dbgA
        '
        Me.dbgA.DataMember = ""
        Me.dbgA.DataSource = Me.Ds1.MyEmployees
        Me.dbgA.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgA.Location = New System.Drawing.Point(0, 0)
        Me.dbgA.Name = "dbgA"
        Me.dbgA.Size = New System.Drawing.Size(296, 264)
        Me.dbgA.TabIndex = 0
        '
        'dbgB
        '
        Me.dbgB.DataMember = ""
        Me.dbgB.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgB.Location = New System.Drawing.Point(304, 0)
        Me.dbgB.Name = "dbgB"
        Me.dbgB.Size = New System.Drawing.Size(288, 264)
        Me.dbgB.TabIndex = 1
        '
        'btnG
        '
        Me.btnG.Location = New System.Drawing.Point(8, 272)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(576, 23)
        Me.btnG.TabIndex = 2
        Me.btnG.Text = "GetChanges"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 310)
        Me.Controls.Add(Me.btnG)
        Me.Controls.Add(Me.dbgB)
        Me.Controls.Add(Me.dbgA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbgA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbgB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sdaE.Fill(Ds1)
    End Sub

    Private Sub btnG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnG.Click
        Dim ds2 As DataSet = Ds1.GetChanges
        dbgB.DataSource = ds2.Tables(0)
    End Sub
End Class
