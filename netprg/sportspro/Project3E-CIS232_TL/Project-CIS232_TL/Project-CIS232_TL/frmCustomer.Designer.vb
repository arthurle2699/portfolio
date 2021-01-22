<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipCodeLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Me.TechSupportDataSet2C = New Project_CIS232_TL.TechSupportDataSet2C()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New Project_CIS232_TL.TechSupportDataSet2CTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New Project_CIS232_TL.TechSupportDataSet2CTableAdapters.TableAdapterManager()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipCodeLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.TechSupportDataSet2C, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(32, 30)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(74, 25)
        NameLabel.TabIndex = 1
        NameLabel.Text = "Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(9, 67)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(97, 25)
        AddressLabel.TabIndex = 3
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(51, 104)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(55, 25)
        CityLabel.TabIndex = 5
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(407, 104)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(68, 25)
        StateLabel.TabIndex = 7
        StateLabel.Text = "State:"
        '
        'ZipCodeLabel
        '
        ZipCodeLabel.AutoSize = True
        ZipCodeLabel.Location = New System.Drawing.Point(597, 104)
        ZipCodeLabel.Name = "ZipCodeLabel"
        ZipCodeLabel.Size = New System.Drawing.Size(105, 25)
        ZipCodeLabel.TabIndex = 9
        ZipCodeLabel.Text = "Zip Code:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(26, 141)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(80, 25)
        PhoneLabel.TabIndex = 11
        PhoneLabel.Text = "Phone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(35, 178)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(71, 25)
        EmailLabel.TabIndex = 13
        EmailLabel.Text = "Email:"
        '
        'TechSupportDataSet2C
        '
        Me.TechSupportDataSet2C.DataSetName = "TechSupportDataSet2C"
        Me.TechSupportDataSet2C.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.TechSupportDataSet2C
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Project_CIS232_TL.TechSupportDataSet2CTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Name", True))
        Me.NameTextBox.Enabled = False
        Me.NameTextBox.Location = New System.Drawing.Point(112, 27)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(696, 31)
        Me.NameTextBox.TabIndex = 2
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.AddressTextBox.Enabled = False
        Me.AddressTextBox.Location = New System.Drawing.Point(112, 64)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(696, 31)
        Me.AddressTextBox.TabIndex = 4
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "City", True))
        Me.CityTextBox.Enabled = False
        Me.CityTextBox.Location = New System.Drawing.Point(112, 101)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(289, 31)
        Me.CityTextBox.TabIndex = 6
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "State", True))
        Me.StateTextBox.Enabled = False
        Me.StateTextBox.Location = New System.Drawing.Point(481, 101)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 31)
        Me.StateTextBox.TabIndex = 8
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "ZipCode", True))
        Me.ZipCodeTextBox.Enabled = False
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(708, 101)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(100, 31)
        Me.ZipCodeTextBox.TabIndex = 10
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Phone", True))
        Me.PhoneTextBox.Enabled = False
        Me.PhoneTextBox.Location = New System.Drawing.Point(112, 138)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(511, 31)
        Me.PhoneTextBox.TabIndex = 12
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Location = New System.Drawing.Point(112, 175)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(511, 31)
        Me.EmailTextBox.TabIndex = 14
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(629, 141)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(179, 68)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 238)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(ZipCodeLabel)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Name = "frmCustomer"
        Me.Text = "Customer (2-C) [Project-CIS232_TL]"
        CType(Me.TechSupportDataSet2C, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TechSupportDataSet2C As TechSupportDataSet2C
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As TechSupportDataSet2CTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As TechSupportDataSet2CTableAdapters.TableAdapterManager
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents btnClose As Button
End Class
