<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Journal_view
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaShadowPanel4 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.save_butt = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaShadowPanel3 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaGradient2Panel3 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.compose_journal = New System.Windows.Forms.RichTextBox()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaGradient2Panel2 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GunaShadowPanel4.SuspendLayout()
        Me.GunaShadowPanel3.SuspendLayout()
        Me.GunaGradient2Panel1.SuspendLayout()
        Me.GunaShadowPanel2.SuspendLayout()
        Me.GunaGradient2Panel3.SuspendLayout()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.GunaGradient2Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.GunaShadowPanel4)
        Me.Panel1.Controls.Add(Me.GunaShadowPanel3)
        Me.Panel1.Controls.Add(Me.GunaShadowPanel2)
        Me.Panel1.Controls.Add(Me.GunaShadowPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 491)
        Me.Panel1.TabIndex = 1
        '
        'GunaShadowPanel4
        '
        Me.GunaShadowPanel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel4.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel4.Controls.Add(Me.save_butt)
        Me.GunaShadowPanel4.Location = New System.Drawing.Point(429, 397)
        Me.GunaShadowPanel4.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaShadowPanel4.Name = "GunaShadowPanel4"
        Me.GunaShadowPanel4.Radius = 5
        Me.GunaShadowPanel4.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel4.ShadowDepth = 15
        Me.GunaShadowPanel4.ShadowShift = 15
        Me.GunaShadowPanel4.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal
        Me.GunaShadowPanel4.Size = New System.Drawing.Size(120, 58)
        Me.GunaShadowPanel4.TabIndex = 105
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
        Me.save_butt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_butt.ForeColor = System.Drawing.Color.Purple
        Me.save_butt.Image = Nothing
        Me.save_butt.ImageOffsetX = 2
        Me.save_butt.ImageSize = New System.Drawing.Size(20, 20)
        Me.save_butt.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.save_butt.Location = New System.Drawing.Point(19, 14)
        Me.save_butt.Margin = New System.Windows.Forms.Padding(2)
        Me.save_butt.Name = "save_butt"
        Me.save_butt.OnHoverBaseColor1 = System.Drawing.Color.Purple
        Me.save_butt.OnHoverBaseColor2 = System.Drawing.Color.Purple
        Me.save_butt.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.save_butt.OnHoverForeColor = System.Drawing.Color.White
        Me.save_butt.OnHoverImage = Nothing
        Me.save_butt.OnPressedColor = System.Drawing.Color.Transparent
        Me.save_butt.OnPressedDepth = 20
        Me.save_butt.Radius = 15
        Me.save_butt.Size = New System.Drawing.Size(93, 36)
        Me.save_butt.TabIndex = 0
        Me.save_butt.Text = "Save"
        Me.save_butt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.save_butt.UseTransfarantBackground = True
        '
        'GunaShadowPanel3
        '
        Me.GunaShadowPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel3.BaseColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel3.Controls.Add(Me.ListBox1)
        Me.GunaShadowPanel3.Controls.Add(Me.GunaGradient2Panel1)
        Me.GunaShadowPanel3.Location = New System.Drawing.Point(560, 102)
        Me.GunaShadowPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaShadowPanel3.Name = "GunaShadowPanel3"
        Me.GunaShadowPanel3.Radius = 5
        Me.GunaShadowPanel3.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel3.ShadowDepth = 50
        Me.GunaShadowPanel3.ShadowShift = 15
        Me.GunaShadowPanel3.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal
        Me.GunaShadowPanel3.Size = New System.Drawing.Size(297, 368)
        Me.GunaShadowPanel3.TabIndex = 104
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(14, 49)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(270, 302)
        Me.ListBox1.TabIndex = 98
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Controls.Add(Me.Label2)
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.Purple
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(14, 17)
        Me.GunaGradient2Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaGradient2Panel1.MaximumSize = New System.Drawing.Size(855, 50)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Radius = 5
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(271, 34)
        Me.GunaGradient2Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 34)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "SAVED JOURNALS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.Purple
        Me.GunaShadowPanel2.Controls.Add(Me.GunaGradient2Panel3)
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(30, 119)
        Me.GunaShadowPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.Radius = 8
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel2.ShadowDepth = 50
        Me.GunaShadowPanel2.ShadowShift = 15
        Me.GunaShadowPanel2.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(526, 278)
        Me.GunaShadowPanel2.TabIndex = 103
        '
        'GunaGradient2Panel3
        '
        Me.GunaGradient2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel3.Controls.Add(Me.compose_journal)
        Me.GunaGradient2Panel3.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradient2Panel3.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel3.Location = New System.Drawing.Point(5, 4)
        Me.GunaGradient2Panel3.Name = "GunaGradient2Panel3"
        Me.GunaGradient2Panel3.Padding = New System.Windows.Forms.Padding(8)
        Me.GunaGradient2Panel3.Radius = 15
        Me.GunaGradient2Panel3.Size = New System.Drawing.Size(501, 255)
        Me.GunaGradient2Panel3.TabIndex = 0
        '
        'compose_journal
        '
        Me.compose_journal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.compose_journal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.compose_journal.Font = New System.Drawing.Font("Segoe UI", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compose_journal.ForeColor = System.Drawing.Color.Silver
        Me.compose_journal.Location = New System.Drawing.Point(8, 8)
        Me.compose_journal.Name = "compose_journal"
        Me.compose_journal.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.compose_journal.Size = New System.Drawing.Size(485, 239)
        Me.compose_journal.TabIndex = 0
        Me.compose_journal.Text = "Compose New Journal..."
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.GunaGradient2Panel2)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(19, 20)
        Me.GunaShadowPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 5
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 80
        Me.GunaShadowPanel1.ShadowShift = 15
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(838, 63)
        Me.GunaShadowPanel1.TabIndex = 101
        '
        'GunaGradient2Panel2
        '
        Me.GunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel2.Controls.Add(Me.Label1)
        Me.GunaGradient2Panel2.Controls.Add(Me.PictureBox1)
        Me.GunaGradient2Panel2.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GunaGradient2Panel2.GradientColor2 = System.Drawing.Color.Purple
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
        Me.Label1.Size = New System.Drawing.Size(275, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ADMINISTRATORS' JOURNALS"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Purple
        Me.Label3.Location = New System.Drawing.Point(40, 411)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "NOTE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 13)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "You have to wait one minute to save another entry."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Purple
        Me.Label5.Location = New System.Drawing.Point(82, 411)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "1 Minute Cooldown"
        '
        'Journal_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Journal_view"
        Me.Size = New System.Drawing.Size(880, 491)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GunaShadowPanel4.ResumeLayout(False)
        Me.GunaShadowPanel3.ResumeLayout(False)
        Me.GunaGradient2Panel1.ResumeLayout(False)
        Me.GunaShadowPanel2.ResumeLayout(False)
        Me.GunaGradient2Panel3.ResumeLayout(False)
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaGradient2Panel2.ResumeLayout(False)
        Me.GunaGradient2Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents save_butt As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaGradient2Panel2 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaShadowPanel3 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaShadowPanel4 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents compose_journal As RichTextBox
    Friend WithEvents GunaGradient2Panel3 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
