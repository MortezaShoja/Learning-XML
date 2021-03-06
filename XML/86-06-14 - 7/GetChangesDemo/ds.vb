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
Public Class ds
    Inherits DataSet
    
    Private tableMyEmployees As MyEmployeesDataTable
    
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
            If (Not (ds.Tables("MyEmployees")) Is Nothing) Then
                Me.Tables.Add(New MyEmployeesDataTable(ds.Tables("MyEmployees")))
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
    Public ReadOnly Property MyEmployees As MyEmployeesDataTable
        Get
            Return Me.tableMyEmployees
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ds = CType(MyBase.Clone,ds)
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
        If (Not (ds.Tables("MyEmployees")) Is Nothing) Then
            Me.Tables.Add(New MyEmployeesDataTable(ds.Tables("MyEmployees")))
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
        Me.tableMyEmployees = CType(Me.Tables("MyEmployees"),MyEmployeesDataTable)
        If (Not (Me.tableMyEmployees) Is Nothing) Then
            Me.tableMyEmployees.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ds"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/ds.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableMyEmployees = New MyEmployeesDataTable
        Me.Tables.Add(Me.tableMyEmployees)
    End Sub
    
    Private Function ShouldSerializeMyEmployees() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub MyEmployeesRowChangeEventHandler(ByVal sender As Object, ByVal e As MyEmployeesRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class MyEmployeesDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnemployeeid As DataColumn
        
        Private columnlastname As DataColumn
        
        Private columnfirstname As DataColumn
        
        Friend Sub New()
            MyBase.New("MyEmployees")
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
        
        Friend ReadOnly Property employeeidColumn As DataColumn
            Get
                Return Me.columnemployeeid
            End Get
        End Property
        
        Friend ReadOnly Property lastnameColumn As DataColumn
            Get
                Return Me.columnlastname
            End Get
        End Property
        
        Friend ReadOnly Property firstnameColumn As DataColumn
            Get
                Return Me.columnfirstname
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As MyEmployeesRow
            Get
                Return CType(Me.Rows(index),MyEmployeesRow)
            End Get
        End Property
        
        Public Event MyEmployeesRowChanged As MyEmployeesRowChangeEventHandler
        
        Public Event MyEmployeesRowChanging As MyEmployeesRowChangeEventHandler
        
        Public Event MyEmployeesRowDeleted As MyEmployeesRowChangeEventHandler
        
        Public Event MyEmployeesRowDeleting As MyEmployeesRowChangeEventHandler
        
        Public Overloads Sub AddMyEmployeesRow(ByVal row As MyEmployeesRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddMyEmployeesRow(ByVal lastname As String, ByVal firstname As String) As MyEmployeesRow
            Dim rowMyEmployeesRow As MyEmployeesRow = CType(Me.NewRow,MyEmployeesRow)
            rowMyEmployeesRow.ItemArray = New Object() {Nothing, lastname, firstname}
            Me.Rows.Add(rowMyEmployeesRow)
            Return rowMyEmployeesRow
        End Function
        
        Public Function FindByemployeeid(ByVal employeeid As Integer) As MyEmployeesRow
            Return CType(Me.Rows.Find(New Object() {employeeid}),MyEmployeesRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As MyEmployeesDataTable = CType(MyBase.Clone,MyEmployeesDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New MyEmployeesDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnemployeeid = Me.Columns("employeeid")
            Me.columnlastname = Me.Columns("lastname")
            Me.columnfirstname = Me.Columns("firstname")
        End Sub
        
        Private Sub InitClass()
            Me.columnemployeeid = New DataColumn("employeeid", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnemployeeid)
            Me.columnlastname = New DataColumn("lastname", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnlastname)
            Me.columnfirstname = New DataColumn("firstname", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnfirstname)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnemployeeid}, true))
            Me.columnemployeeid.AutoIncrement = true
            Me.columnemployeeid.AllowDBNull = false
            Me.columnemployeeid.ReadOnly = true
            Me.columnemployeeid.Unique = true
            Me.columnlastname.AllowDBNull = false
            Me.columnfirstname.AllowDBNull = false
        End Sub
        
        Public Function NewMyEmployeesRow() As MyEmployeesRow
            Return CType(Me.NewRow,MyEmployeesRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New MyEmployeesRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(MyEmployeesRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.MyEmployeesRowChangedEvent) Is Nothing) Then
                RaiseEvent MyEmployeesRowChanged(Me, New MyEmployeesRowChangeEvent(CType(e.Row,MyEmployeesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.MyEmployeesRowChangingEvent) Is Nothing) Then
                RaiseEvent MyEmployeesRowChanging(Me, New MyEmployeesRowChangeEvent(CType(e.Row,MyEmployeesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.MyEmployeesRowDeletedEvent) Is Nothing) Then
                RaiseEvent MyEmployeesRowDeleted(Me, New MyEmployeesRowChangeEvent(CType(e.Row,MyEmployeesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.MyEmployeesRowDeletingEvent) Is Nothing) Then
                RaiseEvent MyEmployeesRowDeleting(Me, New MyEmployeesRowChangeEvent(CType(e.Row,MyEmployeesRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveMyEmployeesRow(ByVal row As MyEmployeesRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class MyEmployeesRow
        Inherits DataRow
        
        Private tableMyEmployees As MyEmployeesDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableMyEmployees = CType(Me.Table,MyEmployeesDataTable)
        End Sub
        
        Public Property employeeid As Integer
            Get
                Return CType(Me(Me.tableMyEmployees.employeeidColumn),Integer)
            End Get
            Set
                Me(Me.tableMyEmployees.employeeidColumn) = value
            End Set
        End Property
        
        Public Property lastname As String
            Get
                Return CType(Me(Me.tableMyEmployees.lastnameColumn),String)
            End Get
            Set
                Me(Me.tableMyEmployees.lastnameColumn) = value
            End Set
        End Property
        
        Public Property firstname As String
            Get
                Return CType(Me(Me.tableMyEmployees.firstnameColumn),String)
            End Get
            Set
                Me(Me.tableMyEmployees.firstnameColumn) = value
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class MyEmployeesRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As MyEmployeesRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As MyEmployeesRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As MyEmployeesRow
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
