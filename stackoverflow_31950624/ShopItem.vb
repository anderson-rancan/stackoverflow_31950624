Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class ShopItem
    Inherits BusinessObject

#Region "Properties"

    Private _number As Integer
    Private _description As String
    Private _price As Double
    Private _quantity As Integer
    Private _total As Double
    Private _discount As Double
    Private _grandTotal As Double

    Public Property Number() As Integer
        Get
            Return Me._number
        End Get
        Set(ByVal value As Integer)
            If Not (value = Me._number) Then
                Me._number = value
                Me.NotifyPropertyChanged()
            End If
        End Set
    End Property

    Public Property Description() As String
        Get
            Return Me._description
        End Get
        Set(ByVal value As String)
            If Not (value = Me._description) Then
                Me._description = value
                Me.NotifyPropertyChanged()
            End If
        End Set
    End Property

    Public Property Price() As Double
        Get
            Return Me._price
        End Get
        Set(ByVal value As Double)
            If Not (value = Me._price) Then
                Me._price = value
                Me.NotifyPropertyChanged()
                Me.Recalculate()
            End If
        End Set
    End Property

    Public Property Quantity() As Integer
        Get
            Return Me._quantity
        End Get
        Set(ByVal value As Integer)
            If Not (value = Me._quantity) Then
                Me._quantity = value
                Me.NotifyPropertyChanged()
                Me.Recalculate()
            End If
        End Set
    End Property

    Public Property Total() As Double
        Get
            Return Me._total
        End Get
        Private Set(value As Double)
            If Not (value = Me._total) Then
                Me._total = value
                NotifyPropertyChanged()
            End If
        End Set
    End Property

    Public Property Discount() As Double
        Get
            Return Me._discount
        End Get
        Set(ByVal value As Double)
            If Not (value = Me._discount) Then
                Me._discount = value
                Me.NotifyPropertyChanged()
                Me.Recalculate()
            End If
        End Set
    End Property

    Public Property GrandTotal() As Double
        Get
            Return Me._grandTotal
        End Get
        Private Set(ByVal value As Double)
            If Not (value = Me._grandTotal) Then
                Me._grandTotal = value
                Me.NotifyPropertyChanged()
            End If
        End Set
    End Property


#End Region

#Region "Main body"

    Private Sub Recalculate()
        Me.Total = Me.Price * Me.Quantity

        If Me.Total <= 0 Then
            Me.GrandTotal = 0
        Else
            Me.GrandTotal = Me.Total - Me.Discount
        End If
    End Sub

#End Region

End Class
