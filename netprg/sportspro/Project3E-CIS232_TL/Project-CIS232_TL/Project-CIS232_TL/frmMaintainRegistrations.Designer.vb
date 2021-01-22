<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintainRegistrations
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
        Me.components = New System.ComponentModel.Container()
        Dim lblCustomer As System.Windows.Forms.Label
        Dim lblProduct As System.Windows.Forms.Label
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.cboProduct = New System.Windows.Forms.ComboBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        lblCustomer = New System.Windows.Forms.Label()
        lblProduct = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCustomer
        '
        lblCustomer.AutoSize = True
        lblCustomer.Location = New System.Drawing.Point(114, 28)
        lblCustomer.Name = "lblCustomer"
        lblCustomer.Size = New System.Drawing.Size(166, 25)
        lblCustomer.TabIndex = 3
        lblCustomer.Text = "Customer Name"
        '
        'lblProduct
        '
        lblProduct.AutoSize = True
        lblProduct.Location = New System.Drawing.Point(305, 28)
        lblProduct.Name = "lblProduct"
        lblProduct.Size = New System.Drawing.Size(148, 25)
        lblProduct.TabIndex = 4
        lblProduct.Text = "Product Name"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(TechSupportData.Customer)
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataSource = GetType(TechSupportData.Product)
        '
        'cboCustomer
        '
        Me.cboCustomer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Name", True))
        Me.cboCustomer.DataSource = Me.CustomerBindingSource
        Me.cboCustomer.DisplayMember = "Name"
        Me.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(32, 72)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(248, 33)
        Me.cboCustomer.TabIndex = 4
        Me.cboCustomer.ValueMember = "CustomerID"
        '
        'cboProduct
        '
        Me.cboProduct.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "Name", True))
        Me.cboProduct.DataSource = Me.ProductBindingSource
        Me.cboProduct.DisplayMember = "Name"
        Me.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduct.FormattingEnabled = True
        Me.cboProduct.Location = New System.Drawing.Point(310, 72)
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.Size = New System.Drawing.Size(248, 33)
        Me.cboProduct.TabIndex = 5
        Me.cboProduct.ValueMember = "ProductCode"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(27, 124)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(253, 87)
        Me.btnRegister.TabIndex = 6
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(310, 124)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(253, 87)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMaintainRegistrations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 257)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(lblProduct)
        Me.Controls.Add(Me.cboProduct)
        Me.Controls.Add(lblCustomer)
        Me.Controls.Add(Me.cboCustomer)
        Me.Name = "frmMaintainRegistrations"
        Me.Text = "Maintain Product Registrations (3-E) [Project-CIS232_TL]"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents cboCustomer As ComboBox
    Friend WithEvents cboProduct As ComboBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnExit As Button
End Class
