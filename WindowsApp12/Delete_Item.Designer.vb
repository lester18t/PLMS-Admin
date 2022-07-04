<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete_Item
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
        Me.gunaheader = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Update_items = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.delete_label = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gunaheader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gunaheader
        '
        Me.gunaheader.BackColor = System.Drawing.Color.Transparent
        Me.gunaheader.Controls.Add(Me.GunaCircleButton1)
        Me.gunaheader.Controls.Add(Me.Label1)
        Me.gunaheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.gunaheader.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.gunaheader.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.gunaheader.Location = New System.Drawing.Point(0, 0)
        Me.gunaheader.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gunaheader.Name = "gunaheader"
        Me.gunaheader.Size = New System.Drawing.Size(366, 61)
        Me.gunaheader.TabIndex = 20
        '
        'GunaCircleButton1
        '
        Me.GunaCircleButton1.Animated = True
        Me.GunaCircleButton1.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton1.AnimationSpeed = 0.03!
        Me.GunaCircleButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.BorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton1.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton1.Image = Global.WindowsApp12.My.Resources.Resources.icons8_cancel_80
        Me.GunaCircleButton1.ImageSize = New System.Drawing.Size(40, 40)
        Me.GunaCircleButton1.Location = New System.Drawing.Point(302, 6)
        Me.GunaCircleButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.Size = New System.Drawing.Size(56, 52)
        Me.GunaCircleButton1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Delete Information"
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.gunaheader
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 5
        Me.GunaElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Update_items)
        Me.Panel1.Controls.Add(Me.GunaGradientButton1)
        Me.Panel1.Controls.Add(Me.SplitContainer2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 61)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 195)
        Me.Panel1.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(1, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(366, 41)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Delete Item?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Update_items
        '
        Me.Update_items.Animated = True
        Me.Update_items.AnimationHoverSpeed = 0.07!
        Me.Update_items.AnimationSpeed = 0.03!
        Me.Update_items.BackColor = System.Drawing.Color.Transparent
        Me.Update_items.BaseColor1 = System.Drawing.Color.White
        Me.Update_items.BaseColor2 = System.Drawing.Color.White
        Me.Update_items.BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Update_items.BorderSize = 1
        Me.Update_items.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Update_items.FocusedColor = System.Drawing.Color.Empty
        Me.Update_items.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_items.ForeColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Update_items.Image = Nothing
        Me.Update_items.ImageOffsetX = 2
        Me.Update_items.ImageSize = New System.Drawing.Size(20, 20)
        Me.Update_items.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.Update_items.Location = New System.Drawing.Point(215, 132)
        Me.Update_items.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Update_items.Name = "Update_items"
        Me.Update_items.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Update_items.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Update_items.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.Update_items.OnHoverForeColor = System.Drawing.Color.White
        Me.Update_items.OnHoverImage = Nothing
        Me.Update_items.OnPressedColor = System.Drawing.Color.Transparent
        Me.Update_items.OnPressedDepth = 20
        Me.Update_items.Radius = 3
        Me.Update_items.Size = New System.Drawing.Size(93, 41)
        Me.Update_items.TabIndex = 24
        Me.Update_items.Text = "No"
        Me.Update_items.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Update_items.UseTransfarantBackground = True
        '
        'GunaGradientButton1
        '
        Me.GunaGradientButton1.Animated = True
        Me.GunaGradientButton1.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton1.AnimationSpeed = 0.03!
        Me.GunaGradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.BaseColor1 = System.Drawing.Color.White
        Me.GunaGradientButton1.BaseColor2 = System.Drawing.Color.White
        Me.GunaGradientButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.BorderSize = 1
        Me.GunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GunaGradientButton1.Image = Nothing
        Me.GunaGradientButton1.ImageOffsetX = 2
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton1.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.GunaGradientButton1.Location = New System.Drawing.Point(68, 132)
        Me.GunaGradientButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaGradientButton1.OnPressedDepth = 20
        Me.GunaGradientButton1.Radius = 3
        Me.GunaGradientButton1.Size = New System.Drawing.Size(93, 41)
        Me.GunaGradientButton1.TabIndex = 23
        Me.GunaGradientButton1.Text = "Yes"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaGradientButton1.UseTransfarantBackground = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 68)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.Black
        Me.SplitContainer2.Panel1.Controls.Add(Me.delete_label)
        Me.SplitContainer2.Panel1.Font = New System.Drawing.Font("Segoe UI Symbol", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.Crimson
        Me.SplitContainer2.Panel2Collapsed = True
        Me.SplitContainer2.Size = New System.Drawing.Size(366, 41)
        Me.SplitContainer2.SplitterWidth = 3
        Me.SplitContainer2.TabIndex = 22
        '
        'delete_label
        '
        Me.delete_label.BackColor = System.Drawing.Color.White
        Me.delete_label.Dock = System.Windows.Forms.DockStyle.Fill
        Me.delete_label.Font = New System.Drawing.Font("Segoe UI Symbol", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_label.ForeColor = System.Drawing.Color.Black
        Me.delete_label.Location = New System.Drawing.Point(0, 0)
        Me.delete_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.delete_label.Name = "delete_label"
        Me.delete_label.Size = New System.Drawing.Size(366, 41)
        Me.delete_label.TabIndex = 3
        Me.delete_label.Text = "Oops!!"
        Me.delete_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolTip1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 10
        Me.ToolTip1.ShowAlways = True
        '
        'Delete_Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 256)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gunaheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Delete_Item"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete_Item"
        Me.TopMost = True
        Me.gunaheader.ResumeLayout(False)
        Me.gunaheader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gunaheader As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Update_items As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents delete_label As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
End Class
