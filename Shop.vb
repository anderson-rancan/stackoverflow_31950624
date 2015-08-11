Imports System.Collections.ObjectModel
Imports System.Collections.Specialized
Imports System.ComponentModel

Public Class Shop
    Inherits BusinessObject

#Region "Properties"

    Private WithEvents _shopItems As ObservableCollection(Of ShopItem)
    Private _grandTotal As Double

    Public ReadOnly Property ShopItems() As ObservableCollection(Of ShopItem)
        Get
            Return Me._shopItems
        End Get
    End Property

    Public Property GrandTotal() As Double
        Get
            Return Me._grandTotal
        End Get
        Private Set(value As Double)
            If Not (value = Me._grandTotal) Then
                Me._grandTotal = value
                Me.NotifyPropertyChanged()
            End If
        End Set
    End Property

#End Region

#Region "Constructors"

    Sub New()
        Me._shopItems = New ObservableCollection(Of ShopItem)()
    End Sub

#End Region

#Region "Main body"

    Private Sub _shopItems_CollectionChanged(sender As Object, e As NotifyCollectionChangedEventArgs) Handles _shopItems.CollectionChanged
        For Each item As ShopItem In Me._shopItems
            RemoveHandler item.PropertyChanged, AddressOf ShopItem_PropertyChanged
            AddHandler item.PropertyChanged, AddressOf ShopItem_PropertyChanged
        Next

        Me.Recalculate()
    End Sub

    Private Sub ShopItem_PropertyChanged(sender As Object, e As PropertyChangedEventArgs)
        Me.Recalculate()
    End Sub

    Private Sub Recalculate()
        Me.GrandTotal = Me._shopItems.Sum(Function(item) item.GrandTotal)
    End Sub

#End Region

End Class
