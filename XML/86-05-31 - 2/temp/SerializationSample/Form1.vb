Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim p As Phone
    Dim s As Xml.Serialization.XmlSerializer
    Dim m As IO.MemoryStream

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
    Friend WithEvents btnS As System.Windows.Forms.Button
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnS = New System.Windows.Forms.Button
        Me.txtX = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnS
        '
        Me.btnS.Location = New System.Drawing.Point(24, 16)
        Me.btnS.Name = "btnS"
        Me.btnS.TabIndex = 0
        Me.btnS.Text = "Serialization"
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(16, 56)
        Me.txtX.Multiline = True
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(264, 200)
        Me.txtX.TabIndex = 1
        Me.txtX.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(192, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Deserialize"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.btnS)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnS.Click
        p = New Phone
        p.Family = "ramezani"
        p.Name = "shahram"
        p.Phone = "0912"

        s = New Xml.Serialization.XmlSerializer(p.GetType)
        m = New IO.MemoryStream
        s.Serialize(m, p)
        txtX.Text = System.Text.Encoding.UTF8.GetString(m.ToArray)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim xmlstring As String = System.Text.Encoding.UTF8.GetString(m.ToArray)
        Dim md As New IO.MemoryStream(System.Text.Encoding.UTF8.GetBytes(xmlstring))
        Dim pn As Phone = s.Deserialize(md)
        MsgBox(pn.Family & vbCrLf & pn.Name & vbCrLf & pn.Phone)
    End Sub
End Class
