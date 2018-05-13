﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.573
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class dsT
    Inherits DataSet
    
    Private tableTitle As TitleDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Title")) Is Nothing) Then
                Me.Tables.Add(New TitleDataTable(ds.Tables("Title")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Title As TitleDataTable
        Get
            Return Me.tableTitle
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As dsT = CType(MyBase.Clone,dsT)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Title")) Is Nothing) Then
            Me.Tables.Add(New TitleDataTable(ds.Tables("Title")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableTitle = CType(Me.Tables("Title"),TitleDataTable)
        If (Not (Me.tableTitle) Is Nothing) Then
            Me.tableTitle.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "dsT"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/dsT.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableTitle = New TitleDataTable
        Me.Tables.Add(Me.tableTitle)
    End Sub
    
    Private Function ShouldSerializeTitle() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub TitleRowChangeEventHandler(ByVal sender As Object, ByVal e As TitleRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TitleDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnID As DataColumn
        
        Private columnTitle As DataColumn
        
        Friend Sub New()
            MyBase.New("Title")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property IDColumn As DataColumn
            Get
                Return Me.columnID
            End Get
        End Property
        
        Friend ReadOnly Property TitleColumn As DataColumn
            Get
                Return Me.columnTitle
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As TitleRow
            Get
                Return CType(Me.Rows(index),TitleRow)
            End Get
        End Property
        
        Public Event TitleRowChanged As TitleRowChangeEventHandler
        
        Public Event TitleRowChanging As TitleRowChangeEventHandler
        
        Public Event TitleRowDeleted As TitleRowChangeEventHandler
        
        Public Event TitleRowDeleting As TitleRowChangeEventHandler
        
        Public Overloads Sub AddTitleRow(ByVal row As TitleRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddTitleRow(ByVal ID As Integer, ByVal Title As String) As TitleRow
            Dim rowTitleRow As TitleRow = CType(Me.NewRow,TitleRow)
            rowTitleRow.ItemArray = New Object() {ID, Title}
            Me.Rows.Add(rowTitleRow)
            Return rowTitleRow
        End Function
        
        Public Function FindByID(ByVal ID As Integer) As TitleRow
            Return CType(Me.Rows.Find(New Object() {ID}),TitleRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As TitleDataTable = CType(MyBase.Clone,TitleDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New TitleDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnID = Me.Columns("ID")
            Me.columnTitle = Me.Columns("Title")
        End Sub
        
        Private Sub InitClass()
            Me.columnID = New DataColumn("ID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnID)
            Me.columnTitle = New DataColumn("Title", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTitle)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnID}, true))
            Me.columnID.AllowDBNull = false
            Me.columnID.Unique = true
        End Sub
        
        Public Function NewTitleRow() As TitleRow
            Return CType(Me.NewRow,TitleRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New TitleRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(TitleRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.TitleRowChangedEvent) Is Nothing) Then
                RaiseEvent TitleRowChanged(Me, New TitleRowChangeEvent(CType(e.Row,TitleRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.TitleRowChangingEvent) Is Nothing) Then
                RaiseEvent TitleRowChanging(Me, New TitleRowChangeEvent(CType(e.Row,TitleRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.TitleRowDeletedEvent) Is Nothing) Then
                RaiseEvent TitleRowDeleted(Me, New TitleRowChangeEvent(CType(e.Row,TitleRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.TitleRowDeletingEvent) Is Nothing) Then
                RaiseEvent TitleRowDeleting(Me, New TitleRowChangeEvent(CType(e.Row,TitleRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveTitleRow(ByVal row As TitleRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TitleRow
        Inherits DataRow
        
        Private tableTitle As TitleDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableTitle = CType(Me.Table,TitleDataTable)
        End Sub
        
        Public Property ID As Integer
            Get
                Return CType(Me(Me.tableTitle.IDColumn),Integer)
            End Get
            Set
                Me(Me.tableTitle.IDColumn) = value
            End Set
        End Property
        
        Public Property Title As String
            Get
                Try 
                    Return CType(Me(Me.tableTitle.TitleColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableTitle.TitleColumn) = value
            End Set
        End Property
        
        Public Function IsTitleNull() As Boolean
            Return Me.IsNull(Me.tableTitle.TitleColumn)
        End Function
        
        Public Sub SetTitleNull()
            Me(Me.tableTitle.TitleColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TitleRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As TitleRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As TitleRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As TitleRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
