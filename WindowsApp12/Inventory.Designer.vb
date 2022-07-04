<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.help2 = New Guna.UI.WinForms.GunaLabel()
        Me.help1 = New Guna.UI.WinForms.GunaLabel()
        Me.Id_radio = New Guna.UI.WinForms.GunaRadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.name_radio = New Guna.UI.WinForms.GunaRadioButton()
        Me.inventoryItem = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SearchItem = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaGradient2Panel3 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GunaContextMenuStrip1 = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.inventoryItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel2.SuspendLayout()
        Me.GunaGradient2Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.help2)
        Me.Panel1.Controls.Add(Me.help1)
        Me.Panel1.Controls.Add(Me.Id_radio)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.name_radio)
        Me.Panel1.Controls.Add(Me.inventoryItem)
        Me.Panel1.Controls.Add(Me.SearchItem)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.GunaShadowPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 606)
        Me.Panel1.TabIndex = 0
        '
        'help2
        '
        Me.help2.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.help2.Location = New System.Drawing.Point(105, 566)
        Me.help2.Name = "help2"
        Me.help2.Size = New System.Drawing.Size(122, 34)
        Me.help2.TabIndex = 86
        Me.help2.Text = "To edit item details." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For more option."
        Me.help2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'help1
        '
        Me.help1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.help1.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.help1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.help1.Location = New System.Drawing.Point(17, 566)
        Me.help1.Name = "help1"
        Me.help1.Size = New System.Drawing.Size(92, 34)
        Me.help1.TabIndex = 85
        Me.help1.Text = "DOUBLE CLICK:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RIGHT CLICK:"
        Me.help1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Id_radio
        '
        Me.Id_radio.BaseColor = System.Drawing.SystemColors.Control
        Me.Id_radio.Checked = True
        Me.Id_radio.CheckedOffColor = System.Drawing.Color.Gray
        Me.Id_radio.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Id_radio.FillColor = System.Drawing.Color.White
        Me.Id_radio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_radio.Location = New System.Drawing.Point(656, 107)
        Me.Id_radio.Margin = New System.Windows.Forms.Padding(2)
        Me.Id_radio.Name = "Id_radio"
        Me.Id_radio.Size = New System.Drawing.Size(48, 22)
        Me.Id_radio.TabIndex = 84
        Me.Id_radio.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(566, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Filtered by:"
        '
        'name_radio
        '
        Me.name_radio.BaseColor = System.Drawing.SystemColors.Control
        Me.name_radio.CheckedOffColor = System.Drawing.Color.Gray
        Me.name_radio.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.name_radio.FillColor = System.Drawing.Color.White
        Me.name_radio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_radio.Location = New System.Drawing.Point(708, 107)
        Me.name_radio.Margin = New System.Windows.Forms.Padding(2)
        Me.name_radio.Name = "name_radio"
        Me.name_radio.Size = New System.Drawing.Size(75, 22)
        Me.name_radio.TabIndex = 82
        Me.name_radio.Text = "Name"
        '
        'inventoryItem
        '
        Me.inventoryItem.AllowDrop = True
        Me.inventoryItem.AllowUserToAddRows = False
        Me.inventoryItem.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.inventoryItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.inventoryItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.inventoryItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.inventoryItem.BackgroundColor = System.Drawing.Color.White
        Me.inventoryItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.inventoryItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.inventoryItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.inventoryItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.inventoryItem.ColumnHeadersHeight = 60
        Me.inventoryItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5})
        Me.inventoryItem.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.inventoryItem.DefaultCellStyle = DataGridViewCellStyle3
        Me.inventoryItem.EnableHeadersVisualStyles = False
        Me.inventoryItem.GridColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.inventoryItem.Location = New System.Drawing.Point(20, 152)
        Me.inventoryItem.Margin = New System.Windows.Forms.Padding(11, 8, 8, 12)
        Me.inventoryItem.Name = "inventoryItem"
        Me.inventoryItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.inventoryItem.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.inventoryItem.RowHeadersVisible = False
        Me.inventoryItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Symbol", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.inventoryItem.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.inventoryItem.RowTemplate.Height = 50
        Me.inventoryItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.inventoryItem.Size = New System.Drawing.Size(834, 408)
        Me.inventoryItem.TabIndex = 27
        Me.inventoryItem.TabStop = False
        Me.inventoryItem.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Light
        Me.inventoryItem.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.inventoryItem.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.inventoryItem.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.inventoryItem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.inventoryItem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.inventoryItem.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.inventoryItem.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.inventoryItem.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.inventoryItem.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.inventoryItem.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventoryItem.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.inventoryItem.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.inventoryItem.ThemeStyle.HeaderStyle.Height = 60
        Me.inventoryItem.ThemeStyle.ReadOnly = False
        Me.inventoryItem.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.inventoryItem.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.inventoryItem.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventoryItem.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.inventoryItem.ThemeStyle.RowsStyle.Height = 50
        Me.inventoryItem.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.inventoryItem.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.FillWeight = 70.0!
        Me.Column1.HeaderText = "NO."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Name"
        Me.Column2.FillWeight = 160.0!
        Me.Column2.HeaderText = "NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Quantity"
        Me.Column3.HeaderText = "QUANTITY"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Date_Added"
        Me.Column5.HeaderText = "DATE ADDED"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'SearchItem
        '
        Me.SearchItem.BackColor = System.Drawing.Color.Transparent
        Me.SearchItem.BaseColor = System.Drawing.Color.White
        Me.SearchItem.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.SearchItem.BorderSize = 1
        Me.SearchItem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchItem.FocusedBaseColor = System.Drawing.Color.White
        Me.SearchItem.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.SearchItem.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.SearchItem.Font = New System.Drawing.Font("Segoe UI Symbol", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchItem.Location = New System.Drawing.Point(91, 100)
        Me.SearchItem.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchItem.Name = "SearchItem"
        Me.SearchItem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchItem.Radius = 15
        Me.SearchItem.Size = New System.Drawing.Size(437, 35)
        Me.SearchItem.TabIndex = 21
        Me.SearchItem.TextOffsetX = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(16, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 22)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Search"
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel2.Controls.Add(Me.GunaGradient2Panel3)
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(8, 16)
        Me.GunaShadowPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.Radius = 5
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaShadowPanel2.ShadowDepth = 115
        Me.GunaShadowPanel2.ShadowShift = 15
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(847, 62)
        Me.GunaShadowPanel2.TabIndex = 5
        '
        'GunaGradient2Panel3
        '
        Me.GunaGradient2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel3.Controls.Add(Me.MetroLabel1)
        Me.GunaGradient2Panel3.Controls.Add(Me.PictureBox2)
        Me.GunaGradient2Panel3.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradient2Panel3.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GunaGradient2Panel3.Location = New System.Drawing.Point(12, 2)
        Me.GunaGradient2Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaGradient2Panel3.MaximumSize = New System.Drawing.Size(855, 50)
        Me.GunaGradient2Panel3.Name = "GunaGradient2Panel3"
        Me.GunaGradient2Panel3.Radius = 5
        Me.GunaGradient2Panel3.Size = New System.Drawing.Size(825, 50)
        Me.GunaGradient2Panel3.TabIndex = 1
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(39, 15)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel1.MaximumSize = New System.Drawing.Size(375, 32)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(239, 25)
        Me.MetroLabel1.TabIndex = 5
        Me.MetroLabel1.Text = "LABORATORY MATERIALS"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp12.My.Resources.Resources.icons8_in_inventory_301
        Me.PictureBox2.Location = New System.Drawing.Point(10, 12)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'GunaContextMenuStrip1
        '
        Me.GunaContextMenuStrip1.BackColor = System.Drawing.Color.RoyalBlue
        Me.GunaContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.GunaContextMenuStrip1.Name = "GunaContextMenuStrip1"
        Me.GunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Transparent
        Me.GunaContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.GunaContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.GunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Black
        Me.GunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault
        Me.GunaContextMenuStrip1.Size = New System.Drawing.Size(118, 52)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(880, 606)
        Me.MinimumSize = New System.Drawing.Size(880, 606)
        Me.Name = "Inventory"
        Me.Size = New System.Drawing.Size(880, 606)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.inventoryItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel2.ResumeLayout(False)
        Me.GunaGradient2Panel3.ResumeLayout(False)
        Me.GunaGradient2Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaGradient2Panel3 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SearchItem As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Public WithEvents inventoryItem As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Id_radio As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents name_radio As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents help2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents help1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaContextMenuStrip1 As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
