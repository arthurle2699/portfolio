<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerMaintenance
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
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipCodeLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerMaintenance))
        Me.TechSupportDataSet2B = New Project_CIS232_TL.TechSupportDataSet2B()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New Project_CIS232_TL.TechSupportDataSet2BTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New Project_CIS232_TL.TechSupportDataSet2BTableAdapters.TableAdapterManager()
        Me.StatesTableAdapter = New Project_CIS232_TL.TechSupportDataSet2BTableAdapters.StatesTableAdapter()
        Me.CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.StatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TechSupportDataSet2BBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FillByCustomerIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CustomerIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CustomerIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByCustomerIDToolStripButton = New System.Windows.Forms.ToolStripButton()
        CustomerIDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipCodeLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.TechSupportDataSet2B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomersBindingNavigator.SuspendLayout()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TechSupportDataSet2BBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByCustomerIDToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(24, 104)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(136, 25)
        CustomerIDLabel.TabIndex = 1
        CustomerIDLabel.Text = "Customer ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(86, 141)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(74, 25)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(63, 178)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(97, 25)
        AddressLabel.TabIndex = 5
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(105, 215)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(55, 25)
        CityLabel.TabIndex = 7
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(92, 252)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(68, 25)
        StateLabel.TabIndex = 9
        StateLabel.Text = "State:"
        '
        'ZipCodeLabel
        '
        ZipCodeLabel.AutoSize = True
        ZipCodeLabel.Location = New System.Drawing.Point(359, 252)
        ZipCodeLabel.Name = "ZipCodeLabel"
        ZipCodeLabel.Size = New System.Drawing.Size(105, 25)
        ZipCodeLabel.TabIndex = 11
        ZipCodeLabel.Text = "Zip Code:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(80, 291)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(80, 25)
        PhoneLabel.TabIndex = 13
        PhoneLabel.Text = "Phone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(89, 328)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(71, 25)
        EmailLabel.TabIndex = 15
        EmailLabel.Text = "Email:"
        '
        'TechSupportDataSet2B
        '
        Me.TechSupportDataSet2B.DataSetName = "TechSupportDataSet2B"
        Me.TechSupportDataSet2B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.TechSupportDataSet2B
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.StatesTableAdapter = Me.StatesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Project_CIS232_TL.TechSupportDataSet2BTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StatesTableAdapter
        '
        Me.StatesTableAdapter.ClearBeforeFill = True
        '
        'CustomersBindingNavigator
        '
        Me.CustomersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomersBindingNavigator.BindingSource = Me.CustomersBindingSource
        Me.CustomersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomersBindingNavigator.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomersBindingNavigatorSaveItem, Me.btnCancel})
        Me.CustomersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomersBindingNavigator.Name = "CustomersBindingNavigator"
        Me.CustomersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomersBindingNavigator.Size = New System.Drawing.Size(779, 50)
        Me.CustomersBindingNavigator.TabIndex = 0
        Me.CustomersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(46, 44)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(71, 44)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(46, 44)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(46, 44)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(46, 44)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 50)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 39)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 50)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(46, 44)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(46, 44)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 50)
        '
        'CustomersBindingNavigatorSaveItem
        '
        Me.CustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomersBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomersBindingNavigatorSaveItem.Name = "CustomersBindingNavigatorSaveItem"
        Me.CustomersBindingNavigatorSaveItem.Size = New System.Drawing.Size(46, 44)
        Me.CustomersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnCancel
        '
        Me.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 44)
        Me.btnCancel.Text = "Cancel"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(166, 101)
        Me.CustomerIDTextBox.MaxLength = 2147483647
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(185, 31)
        Me.CustomerIDTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(166, 138)
        Me.NameTextBox.MaxLength = 50
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(426, 31)
        Me.NameTextBox.TabIndex = 4
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(166, 175)
        Me.AddressTextBox.MaxLength = 50
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(426, 31)
        Me.AddressTextBox.TabIndex = 6
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(166, 212)
        Me.CityTextBox.MaxLength = 20
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(426, 31)
        Me.CityTextBox.TabIndex = 8
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "ZipCode", True))
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(470, 249)
        Me.ZipCodeTextBox.MaxLength = 9
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(122, 31)
        Me.ZipCodeTextBox.TabIndex = 12
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(166, 288)
        Me.PhoneTextBox.MaxLength = 20
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(426, 31)
        Me.PhoneTextBox.TabIndex = 14
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(166, 325)
        Me.EmailTextBox.MaxLength = 50
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(426, 31)
        Me.EmailTextBox.TabIndex = 16
        '
        'StateComboBox
        '
        Me.StateComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersBindingSource, "State", True))
        Me.StateComboBox.DataSource = Me.StatesBindingSource
        Me.StateComboBox.DisplayMember = "StateName"
        Me.StateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Location = New System.Drawing.Point(166, 249)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(185, 33)
        Me.StateComboBox.TabIndex = 17
        Me.StateComboBox.ValueMember = "StateCode"
        '
        'StatesBindingSource
        '
        Me.StatesBindingSource.DataMember = "States"
        Me.StatesBindingSource.DataSource = Me.TechSupportDataSet2B
        '
        'TechSupportDataSet2BBindingSource
        '
        Me.TechSupportDataSet2BBindingSource.DataSource = Me.TechSupportDataSet2B
        Me.TechSupportDataSet2BBindingSource.Position = 0
        '
        'CustomersBindingSource1
        '
        Me.CustomersBindingSource1.DataMember = "Customers"
        Me.CustomersBindingSource1.DataSource = Me.TechSupportDataSet2B
        '
        'FillByCustomerIDToolStrip
        '
        Me.FillByCustomerIDToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.FillByCustomerIDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerIDToolStripLabel, Me.CustomerIDToolStripTextBox, Me.FillByCustomerIDToolStripButton})
        Me.FillByCustomerIDToolStrip.Location = New System.Drawing.Point(0, 50)
        Me.FillByCustomerIDToolStrip.Name = "FillByCustomerIDToolStrip"
        Me.FillByCustomerIDToolStrip.Size = New System.Drawing.Size(779, 50)
        Me.FillByCustomerIDToolStrip.TabIndex = 18
        Me.FillByCustomerIDToolStrip.Text = "FillByCustomerIDToolStrip"
        '
        'CustomerIDToolStripLabel
        '
        Me.CustomerIDToolStripLabel.Name = "CustomerIDToolStripLabel"
        Me.CustomerIDToolStripLabel.Size = New System.Drawing.Size(146, 44)
        Me.CustomerIDToolStripLabel.Text = "CustomerID:"
        '
        'CustomerIDToolStripTextBox
        '
        Me.CustomerIDToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CustomerIDToolStripTextBox.Name = "CustomerIDToolStripTextBox"
        Me.CustomerIDToolStripTextBox.Size = New System.Drawing.Size(100, 50)
        '
        'FillByCustomerIDToolStripButton
        '
        Me.FillByCustomerIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByCustomerIDToolStripButton.Name = "FillByCustomerIDToolStripButton"
        Me.FillByCustomerIDToolStripButton.Size = New System.Drawing.Size(196, 44)
        Me.FillByCustomerIDToolStripButton.Text = "Get Customer ID"
        '
        'frmCustomerMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 395)
        Me.Controls.Add(Me.FillByCustomerIDToolStrip)
        Me.Controls.Add(Me.StateComboBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(ZipCodeLabel)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(Me.CustomersBindingNavigator)
        Me.Name = "frmCustomerMaintenance"
        Me.Text = "Customer Maintenance (2-B) [Project-CIS232_TL]"
        CType(Me.TechSupportDataSet2B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomersBindingNavigator.ResumeLayout(False)
        Me.CustomersBindingNavigator.PerformLayout()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TechSupportDataSet2BBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByCustomerIDToolStrip.ResumeLayout(False)
        Me.FillByCustomerIDToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TechSupportDataSet2B As TechSupportDataSet2B
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As TechSupportDataSet2BTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As TechSupportDataSet2BTableAdapters.TableAdapterManager
    Friend WithEvents CustomersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StatesTableAdapter As TechSupportDataSet2BTableAdapters.StatesTableAdapter
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents StateComboBox As ComboBox
    Friend WithEvents TechSupportDataSet2BBindingSource As BindingSource
    Friend WithEvents StatesBindingSource As BindingSource
    Friend WithEvents CustomersBindingSource1 As BindingSource
    Friend WithEvents FillByCustomerIDToolStrip As ToolStrip
    Friend WithEvents CustomerIDToolStripLabel As ToolStripLabel
    Friend WithEvents CustomerIDToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByCustomerIDToolStripButton As ToolStripButton
    Friend WithEvents btnCancel As ToolStripButton
End Class
