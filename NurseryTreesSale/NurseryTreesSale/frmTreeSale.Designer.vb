<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTreeSale
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.picTreePreview = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkPlanting = New System.Windows.Forms.CheckBox()
        Me.chkDelivery = New System.Windows.Forms.CheckBox()
        Me.txtNumberOfTrees = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radMeyerLemon = New System.Windows.Forms.RadioButton()
        Me.radPersianLime = New System.Windows.Forms.RadioButton()
        Me.radKeyLime = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.picTreePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(46, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(521, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nursery Tree Sale"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.txtNumberOfTrees)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 295)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Details"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.picTreePreview)
        Me.GroupBox5.Location = New System.Drawing.Point(254, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(239, 256)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tree Preview"
        '
        'picTreePreview
        '
        Me.picTreePreview.Location = New System.Drawing.Point(6, 23)
        Me.picTreePreview.Name = "picTreePreview"
        Me.picTreePreview.Size = New System.Drawing.Size(227, 227)
        Me.picTreePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTreePreview.TabIndex = 1
        Me.picTreePreview.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkPlanting)
        Me.GroupBox3.Controls.Add(Me.chkDelivery)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(206, 70)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Additional Services"
        '
        'chkPlanting
        '
        Me.chkPlanting.AutoSize = True
        Me.chkPlanting.Location = New System.Drawing.Point(7, 44)
        Me.chkPlanting.Name = "chkPlanting"
        Me.chkPlanting.Size = New System.Drawing.Size(124, 17)
        Me.chkPlanting.TabIndex = 6
        Me.chkPlanting.Text = "Planting ($8 per tree)"
        Me.chkPlanting.UseVisualStyleBackColor = True
        '
        'chkDelivery
        '
        Me.chkDelivery.AutoSize = True
        Me.chkDelivery.Location = New System.Drawing.Point(7, 20)
        Me.chkDelivery.Name = "chkDelivery"
        Me.chkDelivery.Size = New System.Drawing.Size(91, 17)
        Me.chkDelivery.TabIndex = 5
        Me.chkDelivery.Text = "Delivery ($10)"
        Me.chkDelivery.UseVisualStyleBackColor = True
        '
        'txtNumberOfTrees
        '
        Me.txtNumberOfTrees.Location = New System.Drawing.Point(22, 167)
        Me.txtNumberOfTrees.Name = "txtNumberOfTrees"
        Me.txtNumberOfTrees.Size = New System.Drawing.Size(206, 20)
        Me.txtNumberOfTrees.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of Trees"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radMeyerLemon)
        Me.GroupBox2.Controls.Add(Me.radPersianLime)
        Me.GroupBox2.Controls.Add(Me.radKeyLime)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tree Type"
        '
        'radMeyerLemon
        '
        Me.radMeyerLemon.AutoSize = True
        Me.radMeyerLemon.Location = New System.Drawing.Point(7, 66)
        Me.radMeyerLemon.Name = "radMeyerLemon"
        Me.radMeyerLemon.Size = New System.Drawing.Size(89, 17)
        Me.radMeyerLemon.TabIndex = 3
        Me.radMeyerLemon.TabStop = True
        Me.radMeyerLemon.Text = "Meyer Lemon"
        Me.radMeyerLemon.UseVisualStyleBackColor = True
        '
        'radPersianLime
        '
        Me.radPersianLime.AutoSize = True
        Me.radPersianLime.Location = New System.Drawing.Point(6, 43)
        Me.radPersianLime.Name = "radPersianLime"
        Me.radPersianLime.Size = New System.Drawing.Size(85, 17)
        Me.radPersianLime.TabIndex = 2
        Me.radPersianLime.TabStop = True
        Me.radPersianLime.Text = "Persian Lime"
        Me.radPersianLime.UseVisualStyleBackColor = True
        '
        'radKeyLime
        '
        Me.radKeyLime.AutoSize = True
        Me.radKeyLime.Location = New System.Drawing.Point(7, 20)
        Me.radKeyLime.Name = "radKeyLime"
        Me.radKeyLime.Size = New System.Drawing.Size(68, 17)
        Me.radKeyLime.TabIndex = 1
        Me.radKeyLime.TabStop = True
        Me.radKeyLime.Text = "Key Lime"
        Me.radKeyLime.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtAddress)
        Me.GroupBox4.Controls.Add(Me.txtPhone)
        Me.GroupBox4.Controls.Add(Me.txtName)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(46, 389)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(521, 128)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Customer Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(70, 99)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(417, 20)
        Me.txtAddress.TabIndex = 9
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(72, 65)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(415, 20)
        Me.txtPhone.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(70, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(417, 20)
        Me.txtName.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name"
        '
        'btnSummary
        '
        Me.btnSummary.BackColor = System.Drawing.Color.DarkGreen
        Me.btnSummary.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummary.ForeColor = System.Drawing.Color.White
        Me.btnSummary.Location = New System.Drawing.Point(46, 544)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(126, 23)
        Me.btnSummary.TabIndex = 10
        Me.btnSummary.Text = "View Cost Summary"
        Me.btnSummary.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(190, 544)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(126, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Crimson
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(334, 544)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmTreeSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 606)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTreeSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Florida Exotic Citrus Nursery Tree Sale"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.picTreePreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkPlanting As CheckBox
    Friend WithEvents chkDelivery As CheckBox
    Friend WithEvents txtNumberOfTrees As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents picTreePreview As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radMeyerLemon As RadioButton
    Friend WithEvents radPersianLime As RadioButton
    Friend WithEvents radKeyLime As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSummary As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox5 As GroupBox
End Class
