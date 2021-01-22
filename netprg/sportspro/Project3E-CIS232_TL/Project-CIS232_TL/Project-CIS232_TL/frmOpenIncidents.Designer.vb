<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpenIncidents
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
        Me.lvIncidents = New System.Windows.Forms.ListView()
        Me.ProductCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateOpened = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CustomerID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TechID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lvIncidents
        '
        Me.lvIncidents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductCode, Me.DateOpened, Me.CustomerID, Me.TechID, Me.Title})
        Me.lvIncidents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvIncidents.HideSelection = False
        Me.lvIncidents.Location = New System.Drawing.Point(0, 0)
        Me.lvIncidents.Name = "lvIncidents"
        Me.lvIncidents.Size = New System.Drawing.Size(1274, 629)
        Me.lvIncidents.TabIndex = 0
        Me.lvIncidents.UseCompatibleStateImageBehavior = False
        Me.lvIncidents.View = System.Windows.Forms.View.Details
        '
        'ProductCode
        '
        Me.ProductCode.Text = "Product Code"
        Me.ProductCode.Width = 100
        '
        'DateOpened
        '
        Me.DateOpened.Text = "Date Openned"
        Me.DateOpened.Width = 100
        '
        'CustomerID
        '
        Me.CustomerID.Text = "Customer"
        Me.CustomerID.Width = 100
        '
        'TechID
        '
        Me.TechID.Text = "Technician"
        Me.TechID.Width = 100
        '
        'Title
        '
        Me.Title.Text = "Title"
        Me.Title.Width = 200
        '
        'frmOpenIncidents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 629)
        Me.Controls.Add(Me.lvIncidents)
        Me.Name = "frmOpenIncidents"
        Me.Text = "Open Incidents (3-A) [Project-CIS232-TL]"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvIncidents As ListView
    Friend WithEvents ProductCode As ColumnHeader
    Friend WithEvents DateOpened As ColumnHeader
    Friend WithEvents CustomerID As ColumnHeader
    Friend WithEvents TechID As ColumnHeader
    Friend WithEvents Title As ColumnHeader
End Class
