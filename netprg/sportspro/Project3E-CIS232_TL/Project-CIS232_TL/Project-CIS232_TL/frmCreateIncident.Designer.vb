<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateIncident
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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.cboProduct = New System.Windows.Forms.ComboBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(71, 504)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(301, 81)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create Incident"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(435, 504)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(301, 81)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(66, 49)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(104, 25)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Customer"
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Location = New System.Drawing.Point(66, 122)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(86, 25)
        Me.lblProduct.TabIndex = 3
        Me.lblProduct.Text = "Product"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(66, 195)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(53, 25)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Title"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(66, 266)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(120, 25)
        Me.lblDesc.TabIndex = 5
        Me.lblDesc.Text = "Description"
        '
        'cboCustomer
        '
        Me.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(193, 49)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(533, 33)
        Me.cboCustomer.TabIndex = 6
        '
        'cboProduct
        '
        Me.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduct.FormattingEnabled = True
        Me.cboProduct.Location = New System.Drawing.Point(193, 122)
        Me.cboProduct.Name = "cboProduct"
        Me.cboProduct.Size = New System.Drawing.Size(533, 33)
        Me.cboProduct.TabIndex = 7
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(193, 195)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(533, 31)
        Me.txtTitle.TabIndex = 8
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(193, 266)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(533, 198)
        Me.txtDesc.TabIndex = 9
        '
        'frmCreateIncident
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(800, 625)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.cboProduct)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "frmCreateIncident"
        Me.Text = "Create Incident (3-B) [Project-CIS232_TL]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblProduct As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents cboCustomer As ComboBox
    Friend WithEvents cboProduct As ComboBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtDesc As TextBox
End Class
