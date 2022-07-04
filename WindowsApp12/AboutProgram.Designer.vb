<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AboutProgram
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GunaGradient2Panel2 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.titleLabel = New Guna.UI.WinForms.GunaLabel()
        Me.scrollPanel = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.borderPanel = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaGradient2Panel4 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator2 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GunaGradient2Panel2.SuspendLayout()
        Me.scrollPanel.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.borderPanel.SuspendLayout()
        Me.GunaGradient2Panel4.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GunaGradient2Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.scrollPanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(462, 415)
        Me.SplitContainer1.SplitterDistance = 56
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'GunaGradient2Panel2
        '
        Me.GunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel2.Controls.Add(Me.GunaCircleButton1)
        Me.GunaGradient2Panel2.Controls.Add(Me.titleLabel)
        Me.GunaGradient2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradient2Panel2.GradientColor1 = System.Drawing.Color.Magenta
        Me.GunaGradient2Panel2.GradientColor2 = System.Drawing.Color.SkyBlue
        Me.GunaGradient2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradient2Panel2.Name = "GunaGradient2Panel2"
        Me.GunaGradient2Panel2.Size = New System.Drawing.Size(462, 56)
        Me.GunaGradient2Panel2.TabIndex = 0
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.Animated = True
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.GunaCircleButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = Global.WindowsApp12.My.Resources.Resources.icons8_cancel_80
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(415, 0)
        Me.GunaCircleButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.Size = New System.Drawing.Size(47, 56)
        Me.GunaCircleButton1.TabIndex = 9
        Me.GunaCircleButton1.TabStop = False
        '
        'titleLabel
        '
        Me.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titleLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.titleLabel.ForeColor = System.Drawing.Color.White
        Me.titleLabel.Location = New System.Drawing.Point(0, 0)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(462, 56)
        Me.titleLabel.TabIndex = 8
        Me.titleLabel.Text = "ABOUT PROGRAM"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'scrollPanel
        '
        Me.scrollPanel.AutoScroll = True
        Me.scrollPanel.BackColor = System.Drawing.Color.Transparent
        Me.scrollPanel.Controls.Add(Me.GunaPanel1)
        Me.scrollPanel.GradientColor1 = System.Drawing.Color.White
        Me.scrollPanel.GradientColor2 = System.Drawing.Color.White
        Me.scrollPanel.Location = New System.Drawing.Point(0, 0)
        Me.scrollPanel.Name = "scrollPanel"
        Me.scrollPanel.Size = New System.Drawing.Size(483, 358)
        Me.scrollPanel.TabIndex = 0
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.borderPanel)
        Me.GunaPanel1.Location = New System.Drawing.Point(3, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(456, 835)
        Me.GunaPanel1.TabIndex = 1
        '
        'borderPanel
        '
        Me.borderPanel.BackColor = System.Drawing.Color.Transparent
        Me.borderPanel.Controls.Add(Me.GunaGradient2Panel4)
        Me.borderPanel.GradientColor1 = System.Drawing.Color.Fuchsia
        Me.borderPanel.GradientColor2 = System.Drawing.Color.SkyBlue
        Me.borderPanel.Location = New System.Drawing.Point(9, 15)
        Me.borderPanel.Name = "borderPanel"
        Me.borderPanel.Padding = New System.Windows.Forms.Padding(3)
        Me.borderPanel.Radius = 25
        Me.borderPanel.Size = New System.Drawing.Size(438, 809)
        Me.borderPanel.TabIndex = 0
        '
        'GunaGradient2Panel4
        '
        Me.GunaGradient2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel4.Controls.Add(Me.GunaLabel5)
        Me.GunaGradient2Panel4.Controls.Add(Me.GunaSeparator2)
        Me.GunaGradient2Panel4.Controls.Add(Me.GunaLabel4)
        Me.GunaGradient2Panel4.Controls.Add(Me.GunaSeparator1)
        Me.GunaGradient2Panel4.Controls.Add(Me.GunaLabel3)
        Me.GunaGradient2Panel4.Controls.Add(Me.GunaLabel2)
        Me.GunaGradient2Panel4.Controls.Add(Me.GunaPictureBox1)
        Me.GunaGradient2Panel4.Controls.Add(Me.GunaLabel1)
        Me.GunaGradient2Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradient2Panel4.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradient2Panel4.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel4.Location = New System.Drawing.Point(3, 3)
        Me.GunaGradient2Panel4.Name = "GunaGradient2Panel4"
        Me.GunaGradient2Panel4.Radius = 25
        Me.GunaGradient2Panel4.Size = New System.Drawing.Size(432, 803)
        Me.GunaGradient2Panel4.TabIndex = 1
        '
        'GunaLabel5
        '
        Me.GunaLabel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel5.Location = New System.Drawing.Point(0, 741)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(432, 53)
        Me.GunaLabel5.TabIndex = 9
        Me.GunaLabel5.Text = "April 2020"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaSeparator2
        '
        Me.GunaSeparator2.LineColor = System.Drawing.Color.Black
        Me.GunaSeparator2.Location = New System.Drawing.Point(88, 515)
        Me.GunaSeparator2.Name = "GunaSeparator2"
        Me.GunaSeparator2.Size = New System.Drawing.Size(237, 22)
        Me.GunaSeparator2.TabIndex = 8
        '
        'GunaLabel4
        '
        Me.GunaLabel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(0, 537)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(432, 204)
        Me.GunaLabel4.TabIndex = 7
        Me.GunaLabel4.Text = "Bastasa, Jelynelle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dasalla, Cris Eric Jr." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tubo, Lester"
        Me.GunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Black
        Me.GunaSeparator1.Location = New System.Drawing.Point(88, 376)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(237, 22)
        Me.GunaSeparator1.TabIndex = 6
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(0, 376)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(432, 161)
        Me.GunaLabel3.TabIndex = 5
        Me.GunaLabel3.Text = "In Partial Fulfillment of the Requirements" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in CPE 223 Software Design" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2nd Semes" &
    "ter, SY 2019 - 2020"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(0, 226)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(432, 150)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "A Visual Basic Program Presented to the Faculty" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " of the College of Engineering E" &
    "ducation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "University of Mindanao, Davao City"
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPictureBox1.Image = Global.WindowsApp12.My.Resources.Resources._220px_University_of_Mindanao_Logo__1_2
        Me.GunaPictureBox1.Location = New System.Drawing.Point(0, 92)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(432, 134)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 3
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(432, 92)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Physics Laboratory" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Management System"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'AboutProgram
        '
        Me.AcceptButton = Me.GunaCircleButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.GunaCircleButton1
        Me.ClientSize = New System.Drawing.Size(462, 415)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(462, 415)
        Me.MinimumSize = New System.Drawing.Size(462, 415)
        Me.Name = "AboutProgram"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AboutProgram"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GunaGradient2Panel2.ResumeLayout(False)
        Me.scrollPanel.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.borderPanel.ResumeLayout(False)
        Me.GunaGradient2Panel4.ResumeLayout(False)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GunaGradient2Panel2 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents titleLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents scrollPanel As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents borderPanel As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaGradient2Panel4 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator2 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer1 As Timer
End Class
