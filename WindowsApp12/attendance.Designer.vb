<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class attendance
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.time_lbl = New Guna.UI.WinForms.GunaLabel()
        Me.Id_radio = New Guna.UI.WinForms.GunaRadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.name_radio = New Guna.UI.WinForms.GunaRadioButton()
        Me.SearchItem = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.date_lbl = New Guna.UI.WinForms.GunaLabel()
        Me.attendance_table = New Guna.UI.WinForms.GunaDataGridView()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaGradient2Panel2 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.attendance_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.GunaGradient2Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.time_lbl)
        Me.Panel1.Controls.Add(Me.Id_radio)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.name_radio)
        Me.Panel1.Controls.Add(Me.SearchItem)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.date_lbl)
        Me.Panel1.Controls.Add(Me.attendance_table)
        Me.Panel1.Controls.Add(Me.GunaShadowPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(886, 609)
        Me.Panel1.TabIndex = 0
        '
        'time_lbl
        '
        Me.time_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_lbl.Location = New System.Drawing.Point(0, 120)
        Me.time_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.time_lbl.Name = "time_lbl"
        Me.time_lbl.Size = New System.Drawing.Size(886, 39)
        Me.time_lbl.TabIndex = 85
        Me.time_lbl.Text = "h:mm:ss tt"
        Me.time_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Id_radio
        '
        Me.Id_radio.BaseColor = System.Drawing.SystemColors.Control
        Me.Id_radio.Checked = True
        Me.Id_radio.CheckedOffColor = System.Drawing.Color.Gray
        Me.Id_radio.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Id_radio.FillColor = System.Drawing.Color.White
        Me.Id_radio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_radio.Location = New System.Drawing.Point(770, 184)
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
        Me.Label3.Location = New System.Drawing.Point(610, 184)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Filtered by:"
        '
        'name_radio
        '
        Me.name_radio.BaseColor = System.Drawing.SystemColors.Control
        Me.name_radio.CheckedOffColor = System.Drawing.Color.Gray
        Me.name_radio.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.name_radio.FillColor = System.Drawing.Color.White
        Me.name_radio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_radio.Location = New System.Drawing.Point(696, 184)
        Me.name_radio.Margin = New System.Windows.Forms.Padding(2)
        Me.name_radio.Name = "name_radio"
        Me.name_radio.Size = New System.Drawing.Size(75, 22)
        Me.name_radio.TabIndex = 82
        Me.name_radio.Text = "Name"
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
        Me.SearchItem.Location = New System.Drawing.Point(106, 176)
        Me.SearchItem.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchItem.Name = "SearchItem"
        Me.SearchItem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchItem.Radius = 15
        Me.SearchItem.Size = New System.Drawing.Size(488, 35)
        Me.SearchItem.TabIndex = 25
        Me.SearchItem.TextOffsetX = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(22, 180)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Search"
        '
        'date_lbl
        '
        Me.date_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_lbl.Location = New System.Drawing.Point(0, 96)
        Me.date_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.date_lbl.Name = "date_lbl"
        Me.date_lbl.Size = New System.Drawing.Size(886, 24)
        Me.date_lbl.TabIndex = 15
        Me.date_lbl.Text = "dddd, dd MMMM yyyy"
        Me.date_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'attendance_table
        '
        Me.attendance_table.AllowUserToAddRows = False
        Me.attendance_table.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.attendance_table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.attendance_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.attendance_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.attendance_table.BackgroundColor = System.Drawing.Color.White
        Me.attendance_table.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.attendance_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.attendance_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.attendance_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.attendance_table.ColumnHeadersHeight = 50
        Me.attendance_table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.attendance_table.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.attendance_table.DefaultCellStyle = DataGridViewCellStyle3
        Me.attendance_table.EnableHeadersVisualStyles = False
        Me.attendance_table.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.attendance_table.Location = New System.Drawing.Point(16, 228)
        Me.attendance_table.Margin = New System.Windows.Forms.Padding(11, 8, 8, 12)
        Me.attendance_table.Name = "attendance_table"
        Me.attendance_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.attendance_table.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.attendance_table.RowHeadersVisible = False
        Me.attendance_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Purple
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.attendance_table.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.attendance_table.RowTemplate.Height = 50
        Me.attendance_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.attendance_table.Size = New System.Drawing.Size(854, 291)
        Me.attendance_table.TabIndex = 16
        Me.attendance_table.TabStop = False
        Me.attendance_table.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid
        Me.attendance_table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.attendance_table.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.attendance_table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.attendance_table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.attendance_table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.attendance_table.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.attendance_table.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.attendance_table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.attendance_table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.attendance_table.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendance_table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.attendance_table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.attendance_table.ThemeStyle.HeaderStyle.Height = 50
        Me.attendance_table.ThemeStyle.ReadOnly = False
        Me.attendance_table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.attendance_table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.attendance_table.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendance_table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.attendance_table.ThemeStyle.RowsStyle.Height = 50
        Me.attendance_table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.attendance_table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.GunaGradient2Panel2)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(27, 23)
        Me.GunaShadowPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 5
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 115
        Me.GunaShadowPanel1.ShadowShift = 15
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(838, 63)
        Me.GunaShadowPanel1.TabIndex = 14
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
        Me.Label1.Size = New System.Drawing.Size(346, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PHYSICS LABORATORY ATTENDANCE"
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
        'Timer1
        '
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "No"
        Me.Column1.HeaderText = "No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ID"
        Me.Column2.HeaderText = "ID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Name"
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Time_In"
        Me.Column4.HeaderText = "Time In"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Time_Out"
        Me.Column5.HeaderText = "Time Out"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "attendance"
        Me.Size = New System.Drawing.Size(886, 609)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.attendance_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaGradient2Panel2.ResumeLayout(False)
        Me.GunaGradient2Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaGradient2Panel2 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents date_lbl As Guna.UI.WinForms.GunaLabel
    Public WithEvents attendance_table As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents SearchItem As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Id_radio As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents name_radio As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents time_lbl As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
