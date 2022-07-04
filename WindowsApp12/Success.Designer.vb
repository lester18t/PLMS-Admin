<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Success
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
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.success_button = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Nothing
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.GunaPanel2.Controls.Add(Me.SplitContainer1)
        Me.GunaPanel2.Controls.Add(Me.PictureBox1)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(254, 178)
        Me.GunaPanel2.TabIndex = 5
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 138)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Crimson
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(254, 41)
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 41)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Awesome!!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.WindowsApp12.My.Resources.Resources.icons8_ok_110
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 178)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.success_button)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 178)
        Me.GunaPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(254, 83)
        Me.GunaPanel1.TabIndex = 4
        '
        'success_button
        '
        Me.success_button.Animated = True
        Me.success_button.AnimationHoverSpeed = 0.07!
        Me.success_button.AnimationSpeed = 0.03!
        Me.success_button.BackColor = System.Drawing.Color.Transparent
        Me.success_button.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.success_button.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.success_button.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.success_button.BorderSize = 1
        Me.success_button.DialogResult = System.Windows.Forms.DialogResult.None
        Me.success_button.FocusedColor = System.Drawing.Color.Empty
        Me.success_button.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.success_button.ForeColor = System.Drawing.Color.White
        Me.success_button.Image = Nothing
        Me.success_button.ImageOffsetX = 2
        Me.success_button.ImageSize = New System.Drawing.Size(20, 20)
        Me.success_button.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.success_button.Location = New System.Drawing.Point(79, 27)
        Me.success_button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.success_button.Name = "success_button"
        Me.success_button.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.success_button.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.success_button.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.success_button.OnHoverForeColor = System.Drawing.Color.White
        Me.success_button.OnHoverImage = Nothing
        Me.success_button.OnPressedColor = System.Drawing.Color.Transparent
        Me.success_button.OnPressedDepth = 20
        Me.success_button.Radius = 15
        Me.success_button.Size = New System.Drawing.Size(95, 35)
        Me.success_button.TabIndex = 1
        Me.success_button.Text = "Go Back"
        Me.success_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.success_button.UseTransfarantBackground = True
        '
        'Success
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 261)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Success"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Success"
        Me.TopMost = True
        Me.GunaPanel2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents success_button As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
End Class
