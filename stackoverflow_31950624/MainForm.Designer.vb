<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ShopItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.GrandTotalLabel = New System.Windows.Forms.Label()
        Me.GrandTotalTextBox = New System.Windows.Forms.TextBox()
        Me.AddMouseButton = New System.Windows.Forms.Button()
        Me.AddWebcamButton = New System.Windows.Forms.Button()
        CType(Me.ShopItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShopItemsDataGridView
        '
        Me.ShopItemsDataGridView.AllowUserToAddRows = False
        Me.ShopItemsDataGridView.AllowUserToDeleteRows = False
        Me.ShopItemsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShopItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ShopItemsDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.ShopItemsDataGridView.Name = "ShopItemsDataGridView"
        Me.ShopItemsDataGridView.Size = New System.Drawing.Size(827, 265)
        Me.ShopItemsDataGridView.TabIndex = 0
        '
        'GrandTotalLabel
        '
        Me.GrandTotalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrandTotalLabel.AutoSize = True
        Me.GrandTotalLabel.Location = New System.Drawing.Point(674, 286)
        Me.GrandTotalLabel.Name = "GrandTotalLabel"
        Me.GrandTotalLabel.Size = New System.Drawing.Size(59, 13)
        Me.GrandTotalLabel.TabIndex = 1
        Me.GrandTotalLabel.Text = "Grand total"
        '
        'GrandTotalTextBox
        '
        Me.GrandTotalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrandTotalTextBox.Location = New System.Drawing.Point(739, 283)
        Me.GrandTotalTextBox.Name = "GrandTotalTextBox"
        Me.GrandTotalTextBox.ReadOnly = True
        Me.GrandTotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GrandTotalTextBox.TabIndex = 2
        '
        'AddMouseButton
        '
        Me.AddMouseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AddMouseButton.Location = New System.Drawing.Point(12, 283)
        Me.AddMouseButton.Name = "AddMouseButton"
        Me.AddMouseButton.Size = New System.Drawing.Size(90, 23)
        Me.AddMouseButton.TabIndex = 3
        Me.AddMouseButton.Text = "Add a mouse"
        Me.AddMouseButton.UseVisualStyleBackColor = True
        '
        'AddWebcamButton
        '
        Me.AddWebcamButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AddWebcamButton.Location = New System.Drawing.Point(108, 283)
        Me.AddWebcamButton.Name = "AddWebcamButton"
        Me.AddWebcamButton.Size = New System.Drawing.Size(90, 23)
        Me.AddWebcamButton.TabIndex = 3
        Me.AddWebcamButton.Text = "Add a webcam"
        Me.AddWebcamButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 315)
        Me.Controls.Add(Me.AddWebcamButton)
        Me.Controls.Add(Me.AddMouseButton)
        Me.Controls.Add(Me.GrandTotalTextBox)
        Me.Controls.Add(Me.GrandTotalLabel)
        Me.Controls.Add(Me.ShopItemsDataGridView)
        Me.Name = "MainForm"
        Me.Text = "Main form"
        CType(Me.ShopItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShopItemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GrandTotalLabel As System.Windows.Forms.Label
    Friend WithEvents GrandTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddMouseButton As System.Windows.Forms.Button
    Friend WithEvents AddWebcamButton As System.Windows.Forms.Button

End Class
