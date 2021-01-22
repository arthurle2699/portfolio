<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateIncident
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
        Me.lblIncidentID = New System.Windows.Forms.Label()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.lblTechnician = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTextToAdd = New System.Windows.Forms.Label()
        Me.txtIncidentID = New System.Windows.Forms.TextBox()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtTechnician = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtTextToAdd = New System.Windows.Forms.TextBox()
        Me.btnGetIncident = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblDateOpened = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDateOpened = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblIncidentID
        '
        Me.lblIncidentID.AutoSize = True
        Me.lblIncidentID.Location = New System.Drawing.Point(45, 55)
        Me.lblIncidentID.Name = "lblIncidentID"
        Me.lblIncidentID.Size = New System.Drawing.Size(113, 25)
        Me.lblIncidentID.TabIndex = 0
        Me.lblIncidentID.Text = "Incident ID"
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(45, 113)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(104, 25)
        Me.lblCustomer.TabIndex = 1
        Me.lblCustomer.Text = "Customer"
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Location = New System.Drawing.Point(45, 171)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(86, 25)
        Me.lblProduct.TabIndex = 2
        Me.lblProduct.Text = "Product"
        '
        'lblTechnician
        '
        Me.lblTechnician.AutoSize = True
        Me.lblTechnician.Location = New System.Drawing.Point(45, 229)
        Me.lblTechnician.Name = "lblTechnician"
        Me.lblTechnician.Size = New System.Drawing.Size(117, 25)
        Me.lblTechnician.TabIndex = 3
        Me.lblTechnician.Text = "Technician"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(45, 287)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(53, 25)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Title"
        '
        'lblTextToAdd
        '
        Me.lblTextToAdd.AutoSize = True
        Me.lblTextToAdd.Location = New System.Drawing.Point(45, 577)
        Me.lblTextToAdd.Name = "lblTextToAdd"
        Me.lblTextToAdd.Size = New System.Drawing.Size(129, 25)
        Me.lblTextToAdd.TabIndex = 5
        Me.lblTextToAdd.Text = "Text To Add"
        '
        'txtIncidentID
        '
        Me.txtIncidentID.Location = New System.Drawing.Point(197, 52)
        Me.txtIncidentID.Name = "txtIncidentID"
        Me.txtIncidentID.Size = New System.Drawing.Size(247, 31)
        Me.txtIncidentID.TabIndex = 6
        '
        'txtCustomer
        '
        Me.txtCustomer.Enabled = False
        Me.txtCustomer.Location = New System.Drawing.Point(197, 110)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(531, 31)
        Me.txtCustomer.TabIndex = 7
        '
        'txtProduct
        '
        Me.txtProduct.Enabled = False
        Me.txtProduct.Location = New System.Drawing.Point(197, 168)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(531, 31)
        Me.txtProduct.TabIndex = 8
        '
        'txtTechnician
        '
        Me.txtTechnician.Enabled = False
        Me.txtTechnician.Location = New System.Drawing.Point(197, 226)
        Me.txtTechnician.Name = "txtTechnician"
        Me.txtTechnician.Size = New System.Drawing.Size(531, 31)
        Me.txtTechnician.TabIndex = 9
        '
        'txtTitle
        '
        Me.txtTitle.Enabled = False
        Me.txtTitle.Location = New System.Drawing.Point(197, 284)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(531, 31)
        Me.txtTitle.TabIndex = 10
        '
        'txtTextToAdd
        '
        Me.txtTextToAdd.Enabled = False
        Me.txtTextToAdd.Location = New System.Drawing.Point(197, 577)
        Me.txtTextToAdd.Multiline = True
        Me.txtTextToAdd.Name = "txtTextToAdd"
        Me.txtTextToAdd.Size = New System.Drawing.Size(531, 159)
        Me.txtTextToAdd.TabIndex = 11
        '
        'btnGetIncident
        '
        Me.btnGetIncident.Location = New System.Drawing.Point(473, 45)
        Me.btnGetIncident.Name = "btnGetIncident"
        Me.btnGetIncident.Size = New System.Drawing.Size(255, 44)
        Me.btnGetIncident.TabIndex = 12
        Me.btnGetIncident.Text = "Get Incident"
        Me.btnGetIncident.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(197, 767)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(143, 48)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Enabled = False
        Me.btnClose.Location = New System.Drawing.Point(391, 767)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(143, 48)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(585, 767)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(143, 48)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblDateOpened
        '
        Me.lblDateOpened.AutoSize = True
        Me.lblDateOpened.Location = New System.Drawing.Point(45, 345)
        Me.lblDateOpened.Name = "lblDateOpened"
        Me.lblDateOpened.Size = New System.Drawing.Size(139, 25)
        Me.lblDateOpened.TabIndex = 16
        Me.lblDateOpened.Text = "Date Opened"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(45, 403)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(120, 25)
        Me.lblDescription.TabIndex = 17
        Me.lblDescription.Text = "Description"
        '
        'txtDateOpened
        '
        Me.txtDateOpened.Enabled = False
        Me.txtDateOpened.Location = New System.Drawing.Point(197, 342)
        Me.txtDateOpened.Name = "txtDateOpened"
        Me.txtDateOpened.Size = New System.Drawing.Size(531, 31)
        Me.txtDateOpened.TabIndex = 18
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Location = New System.Drawing.Point(197, 400)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(531, 159)
        Me.txtDescription.TabIndex = 19
        '
        'frmUpdateIncident
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 864)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtDateOpened)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblDateOpened)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnGetIncident)
        Me.Controls.Add(Me.txtTextToAdd)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtTechnician)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.txtIncidentID)
        Me.Controls.Add(Me.lblTextToAdd)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblTechnician)
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.lblIncidentID)
        Me.Name = "frmUpdateIncident"
        Me.Text = "Update Incident (3-C) [Project-CIS232_TL]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIncidentID As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblProduct As Label
    Friend WithEvents lblTechnician As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTextToAdd As Label
    Friend WithEvents txtIncidentID As TextBox
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents txtTechnician As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtTextToAdd As TextBox
    Friend WithEvents btnGetIncident As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblDateOpened As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDateOpened As TextBox
    Friend WithEvents txtDescription As TextBox
End Class
