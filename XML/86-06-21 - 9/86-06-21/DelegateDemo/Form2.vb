Public Class Form2
    Inherits System.Windows.Forms.Form

    Public Delegate Function IntDouble(ByVal k As Integer) As Double

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
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Name = "Form2"
        Me.Text = "Form2"

    End Sub

#End Region

    Public Function f1(ByVal i As Integer) As Double
        If i = 0 Then
            Return 1
        Else
            Return f1(i - 1) * i
        End If
    End Function

    Public Function f2(ByVal j As Integer) As Double
        Return j / 2
    End Function

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim d As New IntDouble(AddressOf f1)
        MsgBox(d(7))
        d = New IntDouble(AddressOf f2)
        MsgBox(d(3))
    End Sub
End Class
