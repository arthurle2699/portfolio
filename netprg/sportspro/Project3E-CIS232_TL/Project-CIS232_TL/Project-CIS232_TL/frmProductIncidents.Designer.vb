<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductIncidents
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
        Dim ProductCodeLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim VersionLabel As System.Windows.Forms.Label
        Dim ReleaseDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductIncidents))
        Me.TechSupportDataSet2C = New Project_CIS232_TL.TechSupportDataSet2C()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New Project_CIS232_TL.TechSupportDataSet2CTableAdapters.ProductsTableAdapter()
        Me.TableAdapterManager = New Project_CIS232_TL.TechSupportDataSet2CTableAdapters.TableAdapterManager()
        Me.IncidentsTableAdapter = New Project_CIS232_TL.TechSupportDataSet2CTableAdapters.IncidentsTableAdapter()
        Me.ProductsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.VersionTextBox = New System.Windows.Forms.TextBox()
        Me.ReleaseDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IncidentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IncidentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerInfo = New System.Windows.Forms.DataGridViewButtonColumn()
        ProductCodeLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        VersionLabel = New System.Windows.Forms.Label()
        ReleaseDateLabel = New System.Windows.Forms.Label()
        CType(Me.TechSupportDataSet2C, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductsBindingNavigator.SuspendLayout()
        CType(Me.IncidentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductCodeLabel
        '
        ProductCodeLabel.AutoSize = True
        ProductCodeLabel.Location = New System.Drawing.Point(32, 71)
        ProductCodeLabel.Name = "ProductCodeLabel"
        ProductCodeLabel.Size = New System.Drawing.Size(149, 25)
        ProductCodeLabel.TabIndex = 1
        ProductCodeLabel.Text = "Product Code:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(107, 108)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(74, 25)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'VersionLabel
        '
        VersionLabel.AutoSize = True
        VersionLabel.Location = New System.Drawing.Point(90, 145)
        VersionLabel.Name = "VersionLabel"
        VersionLabel.Size = New System.Drawing.Size(91, 25)
        VersionLabel.TabIndex = 5
        VersionLabel.Text = "Version:"
        '
        'ReleaseDateLabel
        '
        ReleaseDateLabel.AutoSize = True
        ReleaseDateLabel.Location = New System.Drawing.Point(33, 183)
        ReleaseDateLabel.Name = "ReleaseDateLabel"
        ReleaseDateLabel.Size = New System.Drawing.Size(148, 25)
        ReleaseDateLabel.TabIndex = 7
        ReleaseDateLabel.Text = "Release Date:"
        '
        'TechSupportDataSet2C
        '
        Me.TechSupportDataSet2C.DataSetName = "TechSupportDataSet2C"
        Me.TechSupportDataSet2C.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.TechSupportDataSet2C
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Project_CIS232_TL.TechSupportDataSet2CTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IncidentsTableAdapter
        '
        Me.IncidentsTableAdapter.ClearBeforeFill = True
        '
        'ProductsBindingNavigator
        '
        Me.ProductsBindingNavigator.AddNewItem = Nothing
        Me.ProductsBindingNavigator.BindingSource = Me.ProductsBindingSource
        Me.ProductsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductsBindingNavigator.DeleteItem = Nothing
        Me.ProductsBindingNavigator.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ProductsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.ProductsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductsBindingNavigator.Name = "ProductsBindingNavigator"
        Me.ProductsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductsBindingNavigator.Size = New System.Drawing.Size(1367, 50)
        Me.ProductsBindingNavigator.TabIndex = 0
        Me.ProductsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(71, 44)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'ProductCodeTextBox
        '
        Me.ProductCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "ProductCode", True))
        Me.ProductCodeTextBox.Location = New System.Drawing.Point(187, 68)
        Me.ProductCodeTextBox.Name = "ProductCodeTextBox"
        Me.ProductCodeTextBox.Size = New System.Drawing.Size(200, 31)
        Me.ProductCodeTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(187, 105)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(424, 31)
        Me.NameTextBox.TabIndex = 4
        '
        'VersionTextBox
        '
        Me.VersionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "Version", True))
        Me.VersionTextBox.Location = New System.Drawing.Point(187, 142)
        Me.VersionTextBox.Name = "VersionTextBox"
        Me.VersionTextBox.Size = New System.Drawing.Size(200, 31)
        Me.VersionTextBox.TabIndex = 6
        '
        'ReleaseDateDateTimePicker
        '
        Me.ReleaseDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductsBindingSource, "ReleaseDate", True))
        Me.ReleaseDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReleaseDateDateTimePicker.Location = New System.Drawing.Point(187, 179)
        Me.ReleaseDateDateTimePicker.Name = "ReleaseDateDateTimePicker"
        Me.ReleaseDateDateTimePicker.Size = New System.Drawing.Size(424, 31)
        Me.ReleaseDateDateTimePicker.TabIndex = 8
        '
        'IncidentsBindingSource
        '
        Me.IncidentsBindingSource.DataMember = "ProductsIncidents"
        Me.IncidentsBindingSource.DataSource = Me.ProductsBindingSource
        '
        'IncidentsDataGridView
        '
        Me.IncidentsDataGridView.AllowUserToAddRows = False
        Me.IncidentsDataGridView.AllowUserToDeleteRows = False
        Me.IncidentsDataGridView.AutoGenerateColumns = False
        Me.IncidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IncidentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn8, Me.CustomerInfo})
        Me.IncidentsDataGridView.DataSource = Me.IncidentsBindingSource
        Me.IncidentsDataGridView.Location = New System.Drawing.Point(0, 236)
        Me.IncidentsDataGridView.Name = "IncidentsDataGridView"
        Me.IncidentsDataGridView.ReadOnly = True
        Me.IncidentsDataGridView.RowHeadersWidth = 82
        Me.IncidentsDataGridView.RowTemplate.Height = 33
        Me.IncidentsDataGridView.Size = New System.Drawing.Size(1367, 381)
        Me.IncidentsDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DateOpened"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DateOpened"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 178
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DateClosed"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DateClosed"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 169
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 98
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Customer"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Customer"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 149
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Technician"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Technician"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 162
        '
        'CustomerInfo
        '
        Me.CustomerInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CustomerInfo.HeaderText = ""
        Me.CustomerInfo.MinimumWidth = 10
        Me.CustomerInfo.Name = "CustomerInfo"
        Me.CustomerInfo.ReadOnly = True
        Me.CustomerInfo.Text = "Customer Info"
        Me.CustomerInfo.UseColumnTextForButtonValue = True
        Me.CustomerInfo.Width = 10
        '
        'frmProductIncidents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1367, 629)
        Me.Controls.Add(Me.IncidentsDataGridView)
        Me.Controls.Add(ReleaseDateLabel)
        Me.Controls.Add(Me.ReleaseDateDateTimePicker)
        Me.Controls.Add(VersionLabel)
        Me.Controls.Add(Me.VersionTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(ProductCodeLabel)
        Me.Controls.Add(Me.ProductCodeTextBox)
        Me.Controls.Add(Me.ProductsBindingNavigator)
        Me.Name = "frmProductIncidents"
        Me.Text = "Incidents by Products (2-C) [Project-CIS232_TL]"
        CType(Me.TechSupportDataSet2C, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductsBindingNavigator.ResumeLayout(False)
        Me.ProductsBindingNavigator.PerformLayout()
        CType(Me.IncidentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TechSupportDataSet2C As TechSupportDataSet2C
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As TechSupportDataSet2CTableAdapters.ProductsTableAdapter
    Friend WithEvents TableAdapterManager As TechSupportDataSet2CTableAdapters.TableAdapterManager
    Friend WithEvents ProductsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProductCodeTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents VersionTextBox As TextBox
    Friend WithEvents ReleaseDateDateTimePicker As DateTimePicker
    Friend WithEvents IncidentsTableAdapter As TechSupportDataSet2CTableAdapters.IncidentsTableAdapter
    Friend WithEvents IncidentsBindingSource As BindingSource
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents IncidentsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents CustomerInfo As DataGridViewButtonColumn
End Class
