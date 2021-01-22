<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTechnicianIncidents
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
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Me.TechSupportDataSet2C = New Project_CIS232_TL.TechSupportDataSet2C()
        Me.IncidentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IncidentsTableAdapter = New Project_CIS232_TL.TechSupportDataSet2CTableAdapters.IncidentsTableAdapter()
        Me.TechnicianBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.cboTech = New System.Windows.Forms.ComboBox()
        Me.TechnicianBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IncidentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IncidentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersTableAdapter1 = New Project_CIS232_TL.TechSupportDataSet2ATableAdapters.CustomersTableAdapter()
        NameLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        CType(Me.TechSupportDataSet2C, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TechnicianBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TechnicianBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(18, 27)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(123, 25)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Technician:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(46, 68)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(71, 25)
        EmailLabel.TabIndex = 2
        EmailLabel.Text = "Email:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(40, 108)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(80, 25)
        PhoneLabel.TabIndex = 4
        PhoneLabel.Text = "Phone:"
        '
        'TechSupportDataSet2C
        '
        Me.TechSupportDataSet2C.DataSetName = "TechSupportDataSet2C"
        Me.TechSupportDataSet2C.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IncidentsBindingSource
        '
        Me.IncidentsBindingSource.DataMember = "Incidents"
        Me.IncidentsBindingSource.DataSource = Me.TechSupportDataSet2C
        '
        'IncidentsTableAdapter
        '
        Me.IncidentsTableAdapter.ClearBeforeFill = True
        '
        'TechnicianBindingSource
        '
        Me.TechnicianBindingSource.DataSource = GetType(TechSupportData.Technician)
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechnicianBindingSource, "Email", True))
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(87, 65)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(387, 31)
        Me.txtEmail.TabIndex = 3
        '
        'txtPhone
        '
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TechnicianBindingSource, "Phone", True))
        Me.txtPhone.Enabled = False
        Me.txtPhone.Location = New System.Drawing.Point(87, 105)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(225, 31)
        Me.txtPhone.TabIndex = 5
        '
        'cboTech
        '
        Me.cboTech.DataSource = Me.TechnicianBindingSource
        Me.cboTech.DisplayMember = "Name"
        Me.cboTech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTech.FormattingEnabled = True
        Me.cboTech.Location = New System.Drawing.Point(87, 24)
        Me.cboTech.Name = "cboTech"
        Me.cboTech.Size = New System.Drawing.Size(387, 33)
        Me.cboTech.TabIndex = 6
        Me.cboTech.ValueMember = "TechID"
        '
        'TechnicianBindingSource1
        '
        Me.TechnicianBindingSource1.DataSource = GetType(TechSupportData.Technician)
        '
        'IncidentBindingSource
        '
        Me.IncidentBindingSource.DataSource = GetType(TechSupportData.Incident)
        '
        'IncidentDataGridView
        '
        Me.IncidentDataGridView.AllowUserToAddRows = False
        Me.IncidentDataGridView.AllowUserToDeleteRows = False
        Me.IncidentDataGridView.AutoGenerateColumns = False
        Me.IncidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IncidentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn7})
        Me.IncidentDataGridView.DataSource = Me.IncidentBindingSource
        Me.IncidentDataGridView.Location = New System.Drawing.Point(0, 145)
        Me.IncidentDataGridView.Name = "IncidentDataGridView"
        Me.IncidentDataGridView.ReadOnly = True
        Me.IncidentDataGridView.RowHeadersWidth = 82
        Me.IncidentDataGridView.Size = New System.Drawing.Size(736, 220)
        Me.IncidentDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Product"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 131
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DateOpened"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Date Opened"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 184
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CustomerName"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Customer "
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 155
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
        'CustomersTableAdapter1
        '
        Me.CustomersTableAdapter1.ClearBeforeFill = True
        '
        'frmTechnicianIncidents
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(738, 367)
        Me.Controls.Add(Me.IncidentDataGridView)
        Me.Controls.Add(Me.cboTech)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(NameLabel)
        Me.Name = "frmTechnicianIncidents"
        Me.Text = "Open Incidents by Technician (3-D) [Project-CIS232_TL]"
        CType(Me.TechSupportDataSet2C, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TechnicianBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TechnicianBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TechSupportDataSet2C As TechSupportDataSet2C
    Friend WithEvents IncidentsBindingSource As BindingSource
    Friend WithEvents IncidentsTableAdapter As TechSupportDataSet2CTableAdapters.IncidentsTableAdapter
    Friend WithEvents TechnicianBindingSource As BindingSource
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents cboTech As ComboBox
    Friend WithEvents TechnicianBindingSource1 As BindingSource
    Friend WithEvents IncidentBindingSource As BindingSource
    Friend WithEvents IncidentDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents CustomersTableAdapter1 As TechSupportDataSet2ATableAdapters.CustomersTableAdapter
End Class
