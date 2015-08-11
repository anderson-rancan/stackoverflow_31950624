Public Class MainForm

    Private _binding As BindingSource

#Region "Constructors"

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._binding = New BindingSource()
        Me._binding.DataSource = New Shop()
        Me._binding.DataMember = "ShopItems"

        Me.ShopItemsDataGridView.DataSource = Me._binding
        Me.ShopItemsDataGridView.AutoGenerateColumns = True
        Me.GrandTotalTextBox.DataBindings.Add("Text", CType(Me._binding.DataSource, Shop), "GrandTotal")
    End Sub

#End Region

#Region "Main body"

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim item1 As New ShopItem()
        item1.Number = 5500
        item1.Description = "Screen"
        item1.Price = 50
        item1.Quantity = 1
        item1.Discount = 5
        Me._binding.Add(item1)

        Dim item2 As New ShopItem()
        item2.Number = 6060
        item2.Description = "Case"
        item2.Price = 100
        item2.Quantity = 2
        item2.Discount = 50
        Me._binding.Add(item2)
    End Sub

    Private Sub AddMouseButton_Click(sender As Object, e As EventArgs) Handles AddMouseButton.Click
        Dim item As New ShopItem()
        item.Number = 57
        item.Description = "Mouse"
        item.Price = 20
        item.Quantity = 5
        item.Discount = 1
        Me._binding.Add(item)
    End Sub

    Private Sub AddWebcamButton_Click(sender As Object, e As EventArgs) Handles AddWebcamButton.Click
        Dim item As New ShopItem()
        item.Number = 90
        item.Description = "Webcam"
        item.Price = 120
        item.Quantity = 2
        item.Discount = 0
        Me._binding.Add(item)
    End Sub

#End Region

End Class
