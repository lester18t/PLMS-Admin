﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class change_pass
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
        Me.GunaGradient2Panel2 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.repass = New Guna.UI.WinForms.GunaTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.newpass = New Guna.UI.WinForms.GunaTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.saveData = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.gunaheader = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaCircleButton2 = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.oldpass = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaGradient2Panel2.SuspendLayout()
        Me.gunaheader.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaGradient2Panel2
        '
        Me.GunaGradient2Panel2.BackColor = System.Drawing.Color.White
        Me.GunaGradient2Panel2.Controls.Add(Me.repass)
        Me.GunaGradient2Panel2.Controls.Add(Me.Label9)
        Me.GunaGradient2Panel2.Controls.Add(Me.newpass)
        Me.GunaGradient2Panel2.Controls.Add(Me.Label8)
        Me.GunaGradient2Panel2.Controls.Add(Me.saveData)
        Me.GunaGradient2Panel2.Controls.Add(Me.GunaGradientButton1)
        Me.GunaGradient2Panel2.Controls.Add(Me.gunaheader)
        Me.GunaGradient2Panel2.Controls.Add(Me.oldpass)
        Me.GunaGradient2Panel2.Controls.Add(Me.Panel1)
        Me.GunaGradient2Panel2.Controls.Add(Me.Label2)
        Me.GunaGradient2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradient2Panel2.Font = New System.Drawing.Font("Segoe UI Symbol", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradient2Panel2.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradient2Panel2.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GunaGradient2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradient2Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaGradient2Panel2.Name = "GunaGradient2Panel2"
        Me.GunaGradient2Panel2.Size = New System.Drawing.Size(413, 290)
        Me.GunaGradient2Panel2.TabIndex = 1
        '
        'repass
        '
        Me.repass.BackColor = System.Drawing.Color.Transparent
        Me.repass.BaseColor = System.Drawing.Color.White
        Me.repass.BorderColor = System.Drawing.Color.LightGray
        Me.repass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.repass.FocusedBaseColor = System.Drawing.Color.White
        Me.repass.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.repass.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.repass.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.repass.Location = New System.Drawing.Point(133, 183)
        Me.repass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.repass.Name = "repass"
        Me.repass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.repass.Radius = 5
        Me.repass.Size = New System.Drawing.Size(252, 37)
        Me.repass.TabIndex = 2
        Me.repass.TextOffsetX = 5
        Me.repass.UseSystemPasswordChar = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(30, 193)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Re-type new"
        '
        'newpass
        '
        Me.newpass.BackColor = System.Drawing.Color.Transparent
        Me.newpass.BaseColor = System.Drawing.Color.White
        Me.newpass.BorderColor = System.Drawing.Color.LightGray
        Me.newpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.newpass.FocusedBaseColor = System.Drawing.Color.White
        Me.newpass.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.newpass.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.newpass.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newpass.Location = New System.Drawing.Point(133, 136)
        Me.newpass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.newpass.Name = "newpass"
        Me.newpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.newpass.Radius = 5
        Me.newpass.Size = New System.Drawing.Size(252, 37)
        Me.newpass.TabIndex = 1
        Me.newpass.TextOffsetX = 5
        Me.newpass.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 146)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "New Password"
        '
        'saveData
        '
        Me.saveData.Animated = True
        Me.saveData.AnimationHoverSpeed = 0.07!
        Me.saveData.AnimationSpeed = 0.03!
        Me.saveData.BackColor = System.Drawing.Color.Transparent
        Me.saveData.BaseColor1 = System.Drawing.Color.White
        Me.saveData.BaseColor2 = System.Drawing.Color.White
        Me.saveData.BorderColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.saveData.BorderSize = 1
        Me.saveData.DialogResult = System.Windows.Forms.DialogResult.None
        Me.saveData.FocusedColor = System.Drawing.Color.Empty
        Me.saveData.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.saveData.Image = Nothing
        Me.saveData.ImageOffsetX = 2
        Me.saveData.ImageSize = New System.Drawing.Size(20, 20)
        Me.saveData.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.saveData.Location = New System.Drawing.Point(309, 232)
        Me.saveData.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.saveData.Name = "saveData"
        Me.saveData.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.saveData.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.saveData.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.saveData.OnHoverForeColor = System.Drawing.Color.White
        Me.saveData.OnHoverImage = Nothing
        Me.saveData.OnPressedColor = System.Drawing.Color.Transparent
        Me.saveData.OnPressedDepth = 20
        Me.saveData.Radius = 3
        Me.saveData.Size = New System.Drawing.Size(76, 41)
        Me.saveData.TabIndex = 12
        Me.saveData.Text = "Save"
        Me.saveData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.saveData.UseTransfarantBackground = True
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
        Me.GunaGradientButton1.Location = New System.Drawing.Point(229, 232)
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
        Me.GunaGradientButton1.Size = New System.Drawing.Size(76, 41)
        Me.GunaGradientButton1.TabIndex = 11
        Me.GunaGradientButton1.Text = "Cancel"
        Me.GunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaGradientButton1.UseTransfarantBackground = True
        '
        'gunaheader
        '
        Me.gunaheader.BackColor = System.Drawing.Color.Transparent
        Me.gunaheader.Controls.Add(Me.GunaCircleButton2)
        Me.gunaheader.Controls.Add(Me.GunaCircleButton1)
        Me.gunaheader.Controls.Add(Me.Label1)
        Me.gunaheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.gunaheader.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.gunaheader.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gunaheader.Location = New System.Drawing.Point(0, 0)
        Me.gunaheader.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gunaheader.Name = "gunaheader"
        Me.gunaheader.Size = New System.Drawing.Size(413, 76)
        Me.gunaheader.TabIndex = 18
        '
        'GunaCircleButton2
        '
        Me.GunaCircleButton2.Animated = True
        Me.GunaCircleButton2.AnimationHoverSpeed = 0.07!
        Me.GunaCircleButton2.AnimationSpeed = 0.03!
        Me.GunaCircleButton2.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.BorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaCircleButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaCircleButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaCircleButton2.ForeColor = System.Drawing.Color.White
        Me.GunaCircleButton2.Image = Global.WindowsApp12.My.Resources.Resources.icons8_key_100
        Me.GunaCircleButton2.ImageSize = New System.Drawing.Size(45, 45)
        Me.GunaCircleButton2.Location = New System.Drawing.Point(9, 16)
        Me.GunaCircleButton2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaCircleButton2.Name = "GunaCircleButton2"
        Me.GunaCircleButton2.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.OnHoverForeColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.OnHoverImage = Nothing
        Me.GunaCircleButton2.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton2.Size = New System.Drawing.Size(56, 52)
        Me.GunaCircleButton2.TabIndex = 4
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
        Me.GunaCircleButton1.Location = New System.Drawing.Point(344, 16)
        Me.GunaCircleButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.Size = New System.Drawing.Size(56, 52)
        Me.GunaCircleButton1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CHANGE PASSWORD"
        '
        'oldpass
        '
        Me.oldpass.BackColor = System.Drawing.Color.Transparent
        Me.oldpass.BaseColor = System.Drawing.Color.White
        Me.oldpass.BorderColor = System.Drawing.Color.LightGray
        Me.oldpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.oldpass.FocusedBaseColor = System.Drawing.Color.White
        Me.oldpass.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.oldpass.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.oldpass.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldpass.Location = New System.Drawing.Point(133, 91)
        Me.oldpass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.oldpass.Name = "oldpass"
        Me.oldpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.oldpass.Radius = 5
        Me.oldpass.Size = New System.Drawing.Size(252, 37)
        Me.oldpass.TabIndex = 0
        Me.oldpass.TextOffsetX = 5
        Me.oldpass.UseSystemPasswordChar = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Location = New System.Drawing.Point(0, 59)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 2)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(20, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Old Password"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'change_pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 290)
        Me.Controls.Add(Me.GunaGradient2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "change_pass"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "change_pass"
        Me.TopMost = True
        Me.GunaGradient2Panel2.ResumeLayout(False)
        Me.GunaGradient2Panel2.PerformLayout()
        Me.gunaheader.ResumeLayout(False)
        Me.gunaheader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGradient2Panel2 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents repass As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents newpass As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents saveData As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents gunaheader As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents oldpass As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaCircleButton2 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
End Class
