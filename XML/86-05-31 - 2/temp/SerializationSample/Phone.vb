<Serializable()> Public Class Phone
    <Xml.Serialization.XmlElement()> Public Family As String
    <Xml.Serialization.XmlElement()> Public Name As String
    Private cP As String
    '<Xml.Serialization.XmlAttribute()> Public Property Phone() As String
    <Xml.Serialization.XmlElement()> Public Property Phone() As String
        Get
            Return cP
        End Get
        Set(ByVal Value As String)
            cP = Value
        End Set
    End Property
End Class
