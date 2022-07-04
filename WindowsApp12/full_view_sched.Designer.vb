<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class full_view_sched
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
        Me.allCheckBox = New Guna.UI.WinForms.GunaCheckBox()
        Me.save_butt = New Guna.UI.WinForms.GunaGradientButton()
        Me.SearchItem = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaGradient2Panel2 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.full_view = New Guna.UI.WinForms.GunaDataGridView()
        Me.markCol = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.GunaGradient2Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.full_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.allCheckBox)
        Me.Panel1.Controls.Add(Me.save_butt)
        Me.Panel1.Controls.Add(Me.SearchItem)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.GunaShadowPanel1)
        Me.Panel1.Controls.Add(Me.full_view)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.MaximumSize = New System.Drawing.Size(880, 606)
        Me.Panel1.MinimumSize = New System.Drawing.Size(880, 606)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 606)
        Me.Panel1.TabIndex = 0
        '
        'allCheckBox
        '
        Me.allCheckBox.BaseColor = System.Drawing.Color.White
        Me.allCheckBox.CheckedOffColor = System.Drawing.Color.Purple
        Me.allCheckBox.CheckedOnColor = System.Drawing.Color.Purple
        Me.allCheckBox.FillColor = System.Drawing.Color.White
        Me.allCheckBox.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allCheckBox.ForeColor = System.Drawing.Color.Purple
        Me.allCheckBox.Location = New System.Drawing.Point(19, 570)
        Me.allCheckBox.Name = "allCheckBox"
        Me.allCheckBox.Size = New System.Drawing.Size(88, 21)
        Me.allCheckBox.TabIndex = 25
        Me.allCheckBox.Text = "Check All"
        '
        'save_butt
        '
        Me.save_butt.Animated = True
        Me.save_butt.AnimationHoverSpeed = 0.07!
        Me.save_butt.AnimationSpeed = 0.03!
        Me.save_butt.BackColor = System.Drawing.Color.Transparent
        Me.save_butt.BaseColor1 = System.Drawing.Color.White
        Me.save_butt.BaseColor2 = System.Drawing.Color.White
        Me.save_butt.BorderColor = System.Drawing.Color.Purple
        Me.save_butt.BorderSize = 1
        Me.save_butt.DialogResult = System.Windows.Forms.DialogResult.None
        Me.save_butt.FocusedColor = System.Drawing.Color.Empty
        Me.save_butt.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.save_butt.ForeColor = System.Drawing.Color.Purple
        Me.save_butt.Image = Nothing
        Me.save_butt.ImageOffsetX = 2
        Me.save_butt.ImageSize = New System.Drawing.Size(20, 20)
        Me.save_butt.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.save_butt.Location = New System.Drawing.Point(122, 565)
        Me.save_butt.Margin = New System.Windows.Forms.Padding(2)
        Me.save_butt.Name = "save_butt"
        Me.save_butt.OnHoverBaseColor1 = System.Drawing.Color.Purple
        Me.save_butt.OnHoverBaseColor2 = System.Drawing.Color.Purple
        Me.save_butt.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.save_butt.OnHoverForeColor = System.Drawing.Color.White
        Me.save_butt.OnHoverImage = Nothing
        Me.save_butt.OnPressedColor = System.Drawing.Color.Transparent
        Me.save_butt.OnPressedDepth = 20
        Me.save_butt.Radius = 13
        Me.save_butt.Size = New System.Drawing.Size(112, 29)
        Me.save_butt.TabIndex = 24
        Me.save_butt.Text = "Delete Selected"
        Me.save_butt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.save_butt.UseTransfarantBackground = True
        '
        'SearchItem
        '
        Me.SearchItem.BackColor = System.Drawing.Color.Transparent
        Me.SearchItem.BaseColor = System.Drawing.Color.White
        Me.SearchItem.BorderColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.SearchItem.BorderSize = 1
        Me.SearchItem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchItem.FocusedBaseColor = System.Drawing.Color.White
        Me.SearchItem.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.SearchItem.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.SearchItem.Font = New System.Drawing.Font("Segoe UI Symbol", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchItem.Location = New System.Drawing.Point(98, 125)
        Me.SearchItem.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchItem.Name = "SearchItem"
        Me.SearchItem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchItem.Radius = 15
        Me.SearchItem.Size = New System.Drawing.Size(738, 35)
        Me.SearchItem.TabIndex = 23
        Me.SearchItem.TextOffsetX = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(14, 130)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 25)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Search"
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.GunaGradient2Panel2)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(10, 28)
        Me.GunaShadowPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 5
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 115
        Me.GunaShadowPanel1.ShadowShift = 15
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(838, 63)
        Me.GunaShadowPanel1.TabIndex = 12
        '
        'GunaGradient2Panel2
        '
        Me.GunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel2.Controls.Add(Me.Label1)
        Me.GunaGradient2Panel2.Controls.Add(Me.PictureBox1)
        Me.GunaGradient2Panel2.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GunaGradient2Panel2.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GunaGradient2Panel2.Location = New System.Drawing.Point(11, 3)
        Me.GunaGradient2Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaGradient2Panel2.MaximumSize = New System.Drawing.Size(855, 50)
        Me.GunaGradient2Panel2.Name = "GunaGradient2Panel2"
        Me.GunaGradient2Panel2.Radius = 5
        Me.GunaGradient2Panel2.Size = New System.Drawing.Size(815, 50)
        Me.GunaGradient2Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(64, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PHYSICS LABORATORY RESERVATION RECORDS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp12.My.Resources.Resources.icons8_menu_30
        Me.PictureBox1.Location = New System.Drawing.Point(26, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'full_view
        '
        Me.full_view.AllowUserToAddRows = False
        Me.full_view.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.full_view.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.full_view.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.full_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.full_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.full_view.BackgroundColor = System.Drawing.Color.White
        Me.full_view.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.full_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.full_view.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.full_view.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.full_view.ColumnHeadersHeight = 50
        Me.full_view.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.markCol, Me.Column12, Me.Column9, Me.Column7, Me.Column8, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column10, Me.Column11})
        Me.full_view.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.full_view.DefaultCellStyle = DataGridViewCellStyle3
        Me.full_view.EnableHeadersVisualStyles = False
        Me.full_view.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.full_view.Location = New System.Drawing.Point(11, 181)
        Me.full_view.Margin = New System.Windows.Forms.Padding(11, 8, 8, 12)
        Me.full_view.Name = "full_view"
        Me.full_view.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.full_view.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.full_view.RowHeadersVisible = False
        Me.full_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.full_view.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.full_view.RowTemplate.Height = 50
        Me.full_view.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.full_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.full_view.Size = New System.Drawing.Size(861, 371)
        Me.full_view.TabIndex = 11
        Me.full_view.TabStop = False
        Me.full_view.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid
        Me.full_view.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.full_view.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.full_view.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.full_view.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.full_view.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.full_view.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.full_view.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.full_view.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.full_view.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.full_view.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.full_view.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.full_view.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.full_view.ThemeStyle.HeaderStyle.Height = 50
        Me.full_view.ThemeStyle.ReadOnly = False
        Me.full_view.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.DarkGray
        Me.full_view.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.full_view.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.full_view.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.full_view.ThemeStyle.RowsStyle.Height = 50
        Me.full_view.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.full_view.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'markCol
        '
        Me.markCol.FillWeight = 17.39647!
        Me.markCol.HeaderText = ""
        Me.markCol.Name = "markCol"
        Me.markCol.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "ID"
        Me.Column12.FillWeight = 40.0!
        Me.Column12.HeaderText = "No."
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "Code"
        Me.Column9.FillWeight = 44.72783!
        Me.Column9.HeaderText = "Code"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "startTime"
        Me.Column7.FillWeight = 36.34135!
        Me.Column7.HeaderText = "Start"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "endTime"
        Me.Column8.FillWeight = 36.34135!
        Me.Column8.HeaderText = "End"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Mon"
        Me.Column1.FillWeight = 30.75038!
        Me.Column1.HeaderText = "Mon"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Tue"
        Me.Column2.FillWeight = 30.75038!
        Me.Column2.HeaderText = "Tue"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Wed"
        Me.Column3.FillWeight = 30.75038!
        Me.Column3.HeaderText = "Wed"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Thu"
        Me.Column4.FillWeight = 30.75038!
        Me.Column4.HeaderText = "Thu"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Fri"
        Me.Column5.FillWeight = 30.75038!
        Me.Column5.HeaderText = "Fri"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Sat"
        Me.Column6.FillWeight = 27.95489!
        Me.Column6.HeaderText = "Sat"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "State"
        Me.Column10.FillWeight = 55.90978!
        Me.Column10.HeaderText = "Type"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "DateToUse"
        Me.Column11.FillWeight = 55.90978!
        Me.Column11.HeaderText = "Sched"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'full_view_sched
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(880, 606)
        Me.MinimumSize = New System.Drawing.Size(880, 606)
        Me.Name = "full_view_sched"
        Me.Size = New System.Drawing.Size(880, 606)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaGradient2Panel2.ResumeLayout(False)
        Me.GunaGradient2Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.full_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Public WithEvents full_view As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaGradient2Panel2 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SearchItem As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents save_butt As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents allCheckBox As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents markCol As DataGridViewCheckBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As DataGridViewCheckBoxColumn
    Friend WithEvents Column3 As DataGridViewCheckBoxColumn
    Friend WithEvents Column4 As DataGridViewCheckBoxColumn
    Friend WithEvents Column5 As DataGridViewCheckBoxColumn
    Friend WithEvents Column6 As DataGridViewCheckBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
End Class
