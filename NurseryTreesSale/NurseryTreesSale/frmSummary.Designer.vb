<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblGrossTotal = New System.Windows.Forms.Label()
        Me.lblTaxRate = New System.Windows.Forms.Label()
        Me.lblNetTotal = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblDeliveryCost = New System.Windows.Forms.Label()
        Me.lblPlantingCost = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblPlantingQuantity = New System.Windows.Forms.Label()
        Me.lblDeliveryPrice = New System.Windows.Forms.Label()
        Me.lblPlantingPrice = New System.Windows.Forms.Label()
        Me.lblDelivery = New System.Windows.Forms.Label()
        Me.lblPlanting = New System.Windows.Forms.Label()
        Me.lblTreeCost = New System.Windows.Forms.Label()
        Me.lblTreeQuantity = New System.Windows.Forms.Label()
        Me.lblTreeTypePrice = New System.Windows.Forms.Label()
        Me.lblTreeType = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(27, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Florida Exotic Citrus Nursery Tree Order Summary"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 137)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.White
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress.Location = New System.Drawing.Point(74, 56)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(316, 23)
        Me.lblAddress.TabIndex = 5
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPhone
        '
        Me.lblPhone.BackColor = System.Drawing.Color.White
        Me.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPhone.Location = New System.Drawing.Point(74, 96)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(316, 23)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Location = New System.Drawing.Point(74, 20)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(316, 23)
        Me.lblName.TabIndex = 1
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.lblGrossTotal)
        Me.GroupBox2.Controls.Add(Me.lblTaxRate)
        Me.GroupBox2.Controls.Add(Me.lblNetTotal)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.lblDeliveryCost)
        Me.GroupBox2.Controls.Add(Me.lblPlantingCost)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lblPlantingQuantity)
        Me.GroupBox2.Controls.Add(Me.lblDeliveryPrice)
        Me.GroupBox2.Controls.Add(Me.lblPlantingPrice)
        Me.GroupBox2.Controls.Add(Me.lblDelivery)
        Me.GroupBox2.Controls.Add(Me.lblPlanting)
        Me.GroupBox2.Controls.Add(Me.lblTreeCost)
        Me.GroupBox2.Controls.Add(Me.lblTreeQuantity)
        Me.GroupBox2.Controls.Add(Me.lblTreeTypePrice)
        Me.GroupBox2.Controls.Add(Me.lblTreeType)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(436, 254)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Order Particulars"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(185, 214)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 13)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "Net Total After Tax"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(242, 181)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 13)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "Tax Rate"
        '
        'lblGrossTotal
        '
        Me.lblGrossTotal.BackColor = System.Drawing.Color.White
        Me.lblGrossTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrossTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossTotal.Location = New System.Drawing.Point(323, 143)
        Me.lblGrossTotal.Name = "lblGrossTotal"
        Me.lblGrossTotal.Size = New System.Drawing.Size(82, 23)
        Me.lblGrossTotal.TabIndex = 19
        Me.lblGrossTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTaxRate
        '
        Me.lblTaxRate.BackColor = System.Drawing.Color.White
        Me.lblTaxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTaxRate.Location = New System.Drawing.Point(323, 176)
        Me.lblTaxRate.Name = "lblTaxRate"
        Me.lblTaxRate.Size = New System.Drawing.Size(82, 23)
        Me.lblTaxRate.TabIndex = 18
        Me.lblTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNetTotal
        '
        Me.lblNetTotal.BackColor = System.Drawing.Color.White
        Me.lblNetTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNetTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetTotal.Location = New System.Drawing.Point(323, 209)
        Me.lblNetTotal.Name = "lblNetTotal"
        Me.lblNetTotal.Size = New System.Drawing.Size(82, 23)
        Me.lblNetTotal.TabIndex = 17
        Me.lblNetTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(229, 148)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Gross Total"
        '
        'lblDeliveryCost
        '
        Me.lblDeliveryCost.BackColor = System.Drawing.Color.White
        Me.lblDeliveryCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDeliveryCost.Location = New System.Drawing.Point(323, 77)
        Me.lblDeliveryCost.Name = "lblDeliveryCost"
        Me.lblDeliveryCost.Size = New System.Drawing.Size(82, 23)
        Me.lblDeliveryCost.TabIndex = 15
        Me.lblDeliveryCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPlantingCost
        '
        Me.lblPlantingCost.BackColor = System.Drawing.Color.White
        Me.lblPlantingCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlantingCost.Location = New System.Drawing.Point(323, 110)
        Me.lblPlantingCost.Name = "lblPlantingCost"
        Me.lblPlantingCost.Size = New System.Drawing.Size(82, 23)
        Me.lblPlantingCost.TabIndex = 14
        Me.lblPlantingCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(250, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 23)
        Me.Label13.TabIndex = 13
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlantingQuantity
        '
        Me.lblPlantingQuantity.BackColor = System.Drawing.Color.White
        Me.lblPlantingQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlantingQuantity.Location = New System.Drawing.Point(250, 110)
        Me.lblPlantingQuantity.Name = "lblPlantingQuantity"
        Me.lblPlantingQuantity.Size = New System.Drawing.Size(75, 23)
        Me.lblPlantingQuantity.TabIndex = 12
        Me.lblPlantingQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDeliveryPrice
        '
        Me.lblDeliveryPrice.BackColor = System.Drawing.Color.White
        Me.lblDeliveryPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDeliveryPrice.Location = New System.Drawing.Point(176, 77)
        Me.lblDeliveryPrice.Name = "lblDeliveryPrice"
        Me.lblDeliveryPrice.Size = New System.Drawing.Size(75, 23)
        Me.lblDeliveryPrice.TabIndex = 11
        Me.lblDeliveryPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlantingPrice
        '
        Me.lblPlantingPrice.BackColor = System.Drawing.Color.White
        Me.lblPlantingPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlantingPrice.Location = New System.Drawing.Point(176, 110)
        Me.lblPlantingPrice.Name = "lblPlantingPrice"
        Me.lblPlantingPrice.Size = New System.Drawing.Size(75, 23)
        Me.lblPlantingPrice.TabIndex = 10
        Me.lblPlantingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDelivery
        '
        Me.lblDelivery.BackColor = System.Drawing.Color.White
        Me.lblDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDelivery.Location = New System.Drawing.Point(26, 77)
        Me.lblDelivery.Name = "lblDelivery"
        Me.lblDelivery.Size = New System.Drawing.Size(152, 23)
        Me.lblDelivery.TabIndex = 9
        Me.lblDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPlanting
        '
        Me.lblPlanting.BackColor = System.Drawing.Color.White
        Me.lblPlanting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlanting.Location = New System.Drawing.Point(26, 110)
        Me.lblPlanting.Name = "lblPlanting"
        Me.lblPlanting.Size = New System.Drawing.Size(152, 23)
        Me.lblPlanting.TabIndex = 8
        Me.lblPlanting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTreeCost
        '
        Me.lblTreeCost.BackColor = System.Drawing.Color.White
        Me.lblTreeCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTreeCost.Location = New System.Drawing.Point(323, 44)
        Me.lblTreeCost.Name = "lblTreeCost"
        Me.lblTreeCost.Size = New System.Drawing.Size(82, 23)
        Me.lblTreeCost.TabIndex = 7
        Me.lblTreeCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTreeQuantity
        '
        Me.lblTreeQuantity.BackColor = System.Drawing.Color.White
        Me.lblTreeQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTreeQuantity.Location = New System.Drawing.Point(250, 44)
        Me.lblTreeQuantity.Name = "lblTreeQuantity"
        Me.lblTreeQuantity.Size = New System.Drawing.Size(75, 23)
        Me.lblTreeQuantity.TabIndex = 6
        Me.lblTreeQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTreeTypePrice
        '
        Me.lblTreeTypePrice.BackColor = System.Drawing.Color.White
        Me.lblTreeTypePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTreeTypePrice.Location = New System.Drawing.Point(176, 44)
        Me.lblTreeTypePrice.Name = "lblTreeTypePrice"
        Me.lblTreeTypePrice.Size = New System.Drawing.Size(75, 23)
        Me.lblTreeTypePrice.TabIndex = 5
        Me.lblTreeTypePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTreeType
        '
        Me.lblTreeType.BackColor = System.Drawing.Color.White
        Me.lblTreeType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTreeType.Location = New System.Drawing.Point(26, 44)
        Me.lblTreeType.Name = "lblTreeType"
        Me.lblTreeType.Size = New System.Drawing.Size(152, 23)
        Me.lblTreeType.TabIndex = 4
        Me.lblTreeType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(320, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Total Cost"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(247, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(173, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Item"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(388, 482)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 535)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tree Order Summary"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblDelivery As Label
    Friend WithEvents lblPlanting As Label
    Friend WithEvents lblTreeCost As Label
    Friend WithEvents lblTreeQuantity As Label
    Friend WithEvents lblTreeTypePrice As Label
    Friend WithEvents lblTreeType As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblGrossTotal As Label
    Friend WithEvents lblTaxRate As Label
    Friend WithEvents lblNetTotal As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblDeliveryCost As Label
    Friend WithEvents lblPlantingCost As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblPlantingQuantity As Label
    Friend WithEvents lblDeliveryPrice As Label
    Friend WithEvents lblPlantingPrice As Label
    Friend WithEvents btnClose As Button
End Class
