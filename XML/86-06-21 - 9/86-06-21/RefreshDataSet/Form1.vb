Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim t As Threading.Thread

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
    Friend WithEvents dbg As System.Windows.Forms.DataGrid
    Friend WithEvents sdaT As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents sqlcon As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsT1 As RefreshDataSet.dsT
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dbg = New System.Windows.Forms.DataGrid
        Me.sdaT = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlcon = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DsT1 = New RefreshDataSet.dsT
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsT1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbg
        '
        Me.dbg.DataMember = ""
        Me.dbg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dbg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbg.Location = New System.Drawing.Point(0, 0)
        Me.dbg.Name = "dbg"
        Me.dbg.Size = New System.Drawing.Size(292, 266)
        Me.dbg.TabIndex = 0
        '
        'sdaT
        '
        Me.sdaT.DeleteCommand = Me.SqlDeleteCommand1
        Me.sdaT.InsertCommand = Me.SqlInsertCommand1
        Me.sdaT.SelectCommand = Me.SqlSelectCommand1
        Me.sdaT.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Title", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Title", "Title")})})
        Me.sdaT.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Title WHERE (ID = @Original_ID) AND (Title = @Original_Title OR @Orig" & _
        "inal_Title IS NULL AND Title IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.sqlcon
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Title", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Title", System.Data.DataRowVersion.Original, Nothing))
        '
        'sqlcon
        '
        Me.sqlcon.ConnectionString = "server=local;data source=192.168.1.4;user id=sa;pwd=;database=mu"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Title(ID, Title) VALUES (@ID, @Title); SELECT ID, Title FROM Title WH" & _
        "ERE (ID = @ID)"
        Me.SqlInsertCommand1.Connection = Me.sqlcon
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 50, "Title"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT ID, Title FROM Title"
        Me.SqlSelectCommand1.Connection = Me.sqlcon
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Title SET ID = @ID, Title = @Title WHERE (ID = @Original_ID) AND (Title = " & _
        "@Original_Title OR @Original_Title IS NULL AND Title IS NULL); SELECT ID, Title " & _
        "FROM Title WHERE (ID = @ID)"
        Me.SqlUpdateCommand1.Connection = Me.sqlcon
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, "ID"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 50, "Title"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Title", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Title", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsT1
        '
        Me.DsT1.DataSetName = "dsT"
        Me.DsT1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.dbg)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsT1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sdaT.Fill(DsT1)
        dbg.SetDataBinding(DsT1, "Title")
        t = New Threading.Thread(AddressOf Supply)
        t.Start()
    End Sub

    Public Sub Supply()
        While True
            Dim mid As Integer = CType(DsT1.Tables(0).Rows(DsT1.Tables(0).Rows.Count - 1).Item(0), Integer)
            Dim sqlconT As New SqlClient.SqlConnection
            sqlconT.ConnectionString = sqlcon.ConnectionString
            Dim cmd As New SqlClient.SqlCommand("SELECT dbo.GetChanges(" & mid.ToString & ")", sqlconT)
            sqlconT.Open()
            If CType(cmd.ExecuteScalar, Integer) = 1 Then
                cmd.CommandText = "SELECT * FROM dbo.GetRows(" & mid.ToString & ")"
                Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
                While sdr.Read
                    Dim r As DataRow = DsT1.Tables(0).NewRow
                    r.Item(0) = sdr(0)
                    r.Item(1) = sdr.Item(1)
                    DsT1.Tables(0).Rows.Add(r)
                End While
                sdr.Close()
            End If
            sqlconT.Close()
            t.Sleep(5000)
        End While
    End Sub
End Class
