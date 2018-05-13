<Serializable()> Public Class student
    <Xml.Serialization.XmlAttribute()> Public Family As String
    Private cN As String
    <Xml.Serialization.XmlAttribute()> Public Property Name() As String
        Get
            Return cN
        End Get
        Set(ByVal Value As String)
            cN = Value
        End Set
    End Property
End Class
