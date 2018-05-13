Imports System.Data.SqlClient

Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim s As student
    Dim SerializerObject As Xml.Serialization.XmlSerializer
    Dim SerializerStream As IO.MemoryStream

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
    Friend WithEvents txtF As System.Windows.Forms.TextBox
    Friend WithEvents txtN As System.Windows.Forms.TextBox
    Friend WithEvents btnM As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnS As System.Windows.Forms.Button
    Friend WithEvents txtXML As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnR As System.Windows.Forms.Button
    Friend WithEvents sdaR As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsR1 As SerializationDemo.dsR
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtF = New System.Windows.Forms.TextBox
        Me.txtN = New System.Windows.Forms.TextBox
        Me.btnM = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnS = New System.Windows.Forms.Button
        Me.txtXML = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnR = New System.Windows.Forms.Button
        Me.sdaR = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.DsR1 = New SerializationDemo.dsR
        CType(Me.DsR1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtF
        '
        Me.txtF.Location = New System.Drawing.Point(120, 16)
        Me.txtF.Name = "txtF"
        Me.txtF.TabIndex = 0
        Me.txtF.Text = ""
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(120, 48)
        Me.txtN.Name = "txtN"
        Me.txtN.TabIndex = 1
        Me.txtN.Text = ""
        '
        'btnM
        '
        Me.btnM.Location = New System.Drawing.Point(120, 80)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(104, 23)
        Me.btnM.TabIndex = 2
        Me.btnM.Text = "Make"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(56, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Family"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(56, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        '
        'btnS
        '
        Me.btnS.Location = New System.Drawing.Point(120, 120)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(104, 23)
        Me.btnS.TabIndex = 5
        Me.btnS.Text = "Serialize"
        '
        'txtXML
        '
        Me.txtXML.Location = New System.Drawing.Point(256, 16)
        Me.txtXML.Multiline = True
        Me.txtXML.Name = "txtXML"
        Me.txtXML.Size = New System.Drawing.Size(344, 240)
        Me.txtXML.TabIndex = 6
        Me.txtXML.Text = ""
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(120, 160)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        '
        'btnR
        '
        Me.btnR.Location = New System.Drawing.Point(120, 200)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(104, 23)
        Me.btnR.TabIndex = 8
        Me.btnR.Text = "Restore"
        '
        'sdaR
        '
        Me.sdaR.DeleteCommand = Me.SqlDeleteCommand1
        Me.sdaR.InsertCommand = Me.SqlInsertCommand1
        Me.sdaR.SelectCommand = Me.SqlSelectCommand1
        Me.sdaR.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "XRows", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Row", "Row"), New System.Data.Common.DataColumnMapping("XData", "XData")})})
        Me.sdaR.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Row, XData FROM XRows"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO XRows(XData) VALUES (@XData); SELECT Row, XData FROM XRows WHERE (Row" & _
        " = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@XData", System.Data.SqlDbType.NVarChar, 4000, "XData"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE XRows SET XData = @XData WHERE (Row = @Original_Row) AND (XData = @Origina" & _
        "l_XData OR @Original_XData IS NULL AND XData IS NULL); SELECT Row, XData FROM XR" & _
        "ows WHERE (Row = @Row)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@XData", System.Data.SqlDbType.NVarChar, 4000, "XData"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Row", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Row", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_XData", System.Data.SqlDbType.NVarChar, 4000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "XData", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Row", System.Data.SqlDbType.Int, 4, "Row"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM XRows WHERE (Row = @Original_Row) AND (XData = @Original_XData OR @Or" & _
        "iginal_XData IS NULL AND XData IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Row", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Row", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_XData", System.Data.SqlDbType.NVarChar, 4000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "XData", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=COM3;packet size=4096;integrated security=SSPI;data source=""."";per" & _
        "sist security info=False;initial catalog=Northwind"
        '
        'DsR1
        '
        Me.DsR1.DataSetName = "dsR"
        Me.DsR1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(616, 310)
        Me.Controls.Add(Me.btnR)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtXML)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnM)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.txtF)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DsR1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM.Click
        s = New student
        s.Family = txtF.Text
        s.Name = txtN.Text
    End Sub

    Private Sub btnS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnS.Click
        SerializerObject = New Xml.Serialization.XmlSerializer(s.GetType)
        SerializerStream = New IO.MemoryStream
        SerializerObject.Serialize(SerializerStream, s)
        txtXML.Text = System.Text.Encoding.UTF8.GetString(SerializerStream.ToArray)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sqlcon As New SqlConnection("server=local;integrated security=sspi;data source=.;database=northwind")
        Dim cmd As New SqlCommand("INSERT INTO XRows(XData)VALUES('" & txtXML.Text & "')", sqlcon)
        sqlcon.Open()
        cmd.ExecuteNonQuery()
        sqlcon.Close()
    End Sub

    Private Sub btnR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnR.Click
        sdaR.Fill(DsR1)
        Dim s1 As New student
        For i As Integer = 0 To DsR1.Tables(0).Rows.Count - 1
            Dim xmlstring As String = DsR1.Tables(0).Rows(i).Item(1)
            Dim sr As New Xml.Serialization.XmlSerializer(s1.GetType)
            Dim md As New IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(xmlstring))
            Dim sn As student = sr.Deserialize(md)
            MsgBox(sn.Family & vbCrLf & sn.Name)
        Next
    End Sub
End Class
