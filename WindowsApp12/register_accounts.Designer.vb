<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class register_accounts
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
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaGradient2Panel2 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Search_account = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.register_table = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_radio = New Guna.UI.WinForms.GunaRadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.name_radio = New Guna.UI.WinForms.GunaRadioButton()
        Me.help2 = New Guna.UI.WinForms.GunaLabel()
        Me.help1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaContextMenuStrip1 = New Guna.UI.WinForms.GunaContextMenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.GunaGradient2Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.register_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.GunaGradient2Panel2)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(8, 20)
        Me.GunaShadowPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 5
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 115
        Me.GunaShadowPanel1.ShadowShift = 15
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(859, 63)
        Me.GunaShadowPanel1.TabIndex = 4
        '
        'GunaGradient2Panel2
        '
        Me.GunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel2.Controls.Add(Me.Label1)
        Me.GunaGradient2Panel2.Controls.Add(Me.PictureBox1)
        Me.GunaGradient2Panel2.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradient2Panel2.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaGradient2Panel2.Location = New System.Drawing.Point(11, 2)
        Me.GunaGradient2Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaGradient2Panel2.MaximumSize = New System.Drawing.Size(855, 50)
        Me.GunaGradient2Panel2.Name = "GunaGradient2Panel2"
        Me.GunaGradient2Panel2.Radius = 8
        Me.GunaGradient2Panel2.Size = New System.Drawing.Size(839, 50)
        Me.GunaGradient2Panel2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(54, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Registered Accounts"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp12.My.Resources.Resources.icons8_in_inventory_301
        Me.PictureBox1.Location = New System.Drawing.Point(26, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Search_account
        '
        Me.Search_account.BackColor = System.Drawing.Color.Transparent
        Me.Search_account.BaseColor = System.Drawing.Color.White
        Me.Search_account.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Search_account.BorderSize = 1
        Me.Search_account.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Search_account.FocusedBaseColor = System.Drawing.Color.White
        Me.Search_account.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Search_account.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Search_account.Font = New System.Drawing.Font("Segoe UI Symbol", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_account.Location = New System.Drawing.Point(97, 99)
        Me.Search_account.Margin = New System.Windows.Forms.Padding(2)
        Me.Search_account.Name = "Search_account"
        Me.Search_account.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Search_account.Radius = 15
        Me.Search_account.Size = New System.Drawing.Size(460, 35)
        Me.Search_account.TabIndex = 23
        Me.Search_account.TextOffsetX = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(13, 104)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 25)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Search"
        '
        'register_table
        '
        Me.register_table.AllowUserToAddRows = False
        Me.register_table.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.register_table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.register_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.register_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.register_table.BackgroundColor = System.Drawing.Color.White
        Me.register_table.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.register_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.register_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.register_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.register_table.ColumnHeadersHeight = 45
        Me.register_table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.register_table.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.register_table.DefaultCellStyle = DataGridViewCellStyle3
        Me.register_table.EnableHeadersVisualStyles = False
        Me.register_table.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.register_table.Location = New System.Drawing.Point(16, 144)
        Me.register_table.Margin = New System.Windows.Forms.Padding(11, 8, 8, 12)
        Me.register_table.Name = "register_table"
        Me.register_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.register_table.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.register_table.RowHeadersVisible = False
        Me.register_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Symbol", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.register_table.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.register_table.RowTemplate.Height = 50
        Me.register_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.register_table.Size = New System.Drawing.Size(842, 411)
        Me.register_table.TabIndex = 7
        Me.register_table.TabStop = False
        Me.register_table.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WhiteGrid
        Me.register_table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.register_table.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.register_table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.register_table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.register_table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.register_table.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.register_table.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.register_table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.register_table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.register_table.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.register_table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.register_table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.register_table.ThemeStyle.HeaderStyle.Height = 45
        Me.register_table.ThemeStyle.ReadOnly = False
        Me.register_table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.register_table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.register_table.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.register_table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.register_table.ThemeStyle.RowsStyle.Height = 50
        Me.register_table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.register_table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.FillWeight = 50.0!
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "FirstName"
        Me.Column2.FillWeight = 75.0!
        Me.Column2.HeaderText = "NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "College"
        Me.Column3.HeaderText = "COLLEGE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.DataPropertyName = "Program"
        Me.Column4.HeaderText = "PROGRAM"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Id_radio
        '
        Me.Id_radio.BaseColor = System.Drawing.SystemColors.Control
        Me.Id_radio.Checked = True
        Me.Id_radio.CheckedOffColor = System.Drawing.Color.Gray
        Me.Id_radio.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Id_radio.FillColor = System.Drawing.Color.White
        Me.Id_radio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_radio.Location = New System.Drawing.Point(731, 106)
        Me.Id_radio.Margin = New System.Windows.Forms.Padding(2)
        Me.Id_radio.Name = "Id_radio"
        Me.Id_radio.Size = New System.Drawing.Size(48, 22)
        Me.Id_radio.TabIndex = 84
        Me.Id_radio.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(655, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Filter by:"
        '
        'name_radio
        '
        Me.name_radio.BaseColor = System.Drawing.SystemColors.Control
        Me.name_radio.CheckedOffColor = System.Drawing.Color.Gray
        Me.name_radio.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.name_radio.FillColor = System.Drawing.Color.White
        Me.name_radio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_radio.Location = New System.Drawing.Point(783, 106)
        Me.name_radio.Margin = New System.Windows.Forms.Padding(2)
        Me.name_radio.Name = "name_radio"
        Me.name_radio.Size = New System.Drawing.Size(75, 22)
        Me.name_radio.TabIndex = 82
        Me.name_radio.Text = "Name"
        '
        'help2
        '
        Me.help2.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.help2.Location = New System.Drawing.Point(105, 567)
        Me.help2.Name = "help2"
        Me.help2.Size = New System.Drawing.Size(133, 34)
        Me.help2.TabIndex = 88
        Me.help2.Text = "To edit account details." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For more option."
        Me.help2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'help1
        '
        Me.help1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.help1.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.help1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.help1.Location = New System.Drawing.Point(16, 567)
        Me.help1.Name = "help1"
        Me.help1.Size = New System.Drawing.Size(93, 34)
        Me.help1.TabIndex = 87
        Me.help1.Text = "DOUBLE CLICK:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RIGHT CLICK:"
        Me.help1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GunaContextMenuStrip1
        '
        Me.GunaContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.GunaContextMenuStrip1.Name = "GunaContextMenuStrip1"
        Me.GunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Transparent
        Me.GunaContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.GunaContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.GunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.GunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(170, Byte), Integer))
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
        'register_accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.help2)
        Me.Controls.Add(Me.help1)
        Me.Controls.Add(Me.Id_radio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.name_radio)
        Me.Controls.Add(Me.Search_account)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Controls.Add(Me.register_table)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(880, 606)
        Me.MinimumSize = New System.Drawing.Size(880, 606)
        Me.Name = "register_accounts"
        Me.Size = New System.Drawing.Size(880, 606)
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaGradient2Panel2.ResumeLayout(False)
        Me.GunaGradient2Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.register_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaGradient2Panel2 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Search_account As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Public WithEvents register_table As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Id_radio As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents name_radio As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents help2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents help1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaContextMenuStrip1 As Guna.UI.WinForms.GunaContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class
