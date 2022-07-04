<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageViewer
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaCircleButton1 = New Guna.UI.WinForms.GunaCircleButton()
        Me.titleLabel = New Guna.UI.WinForms.GunaLabel()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaGradient2Panel3 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaGradient2Panel2 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.compose_journal = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GunaGradient2Panel1.SuspendLayout()
        Me.GunaShadowPanel2.SuspendLayout()
        Me.GunaGradient2Panel3.SuspendLayout()
        Me.GunaGradient2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 381)
        Me.Panel1.TabIndex = 0
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.GunaGradient2Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GunaShadowPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(488, 381)
        Me.SplitContainer1.SplitterDistance = 46
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaCircleButton1)
        Me.GunaGradient2Panel1.Controls.Add(Me.titleLabel)
        Me.GunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.Purple
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(488, 46)
        Me.GunaGradient2Panel1.TabIndex = 0
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
        Me.GunaCircleButton1.Location = New System.Drawing.Point(441, 0)
        Me.GunaCircleButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaCircleButton1.Name = "GunaCircleButton1"
        Me.GunaCircleButton1.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverForeColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.OnHoverImage = Nothing
        Me.GunaCircleButton1.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaCircleButton1.Size = New System.Drawing.Size(47, 46)
        Me.GunaCircleButton1.TabIndex = 8
        Me.GunaCircleButton1.TabStop = False
        '
        'titleLabel
        '
        Me.titleLabel.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.titleLabel.ForeColor = System.Drawing.Color.White
        Me.titleLabel.Location = New System.Drawing.Point(12, 7)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(361, 28)
        Me.titleLabel.TabIndex = 7
        Me.titleLabel.Text = "JOURNAL"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaShadowPanel2.Controls.Add(Me.GunaGradient2Panel3)
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(17, 7)
        Me.GunaShadowPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.Radius = 8
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel2.ShadowDepth = 115
        Me.GunaShadowPanel2.ShadowShift = 15
        Me.GunaShadowPanel2.ShadowStyle = Guna.UI.WinForms.ShadowMode.ForwardDiagonal
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(469, 326)
        Me.GunaShadowPanel2.TabIndex = 104
        '
        'GunaGradient2Panel3
        '
        Me.GunaGradient2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel3.Controls.Add(Me.GunaGradient2Panel2)
        Me.GunaGradient2Panel3.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradient2Panel3.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel3.Location = New System.Drawing.Point(5, 4)
        Me.GunaGradient2Panel3.Name = "GunaGradient2Panel3"
        Me.GunaGradient2Panel3.Padding = New System.Windows.Forms.Padding(8)
        Me.GunaGradient2Panel3.Radius = 15
        Me.GunaGradient2Panel3.Size = New System.Drawing.Size(444, 302)
        Me.GunaGradient2Panel3.TabIndex = 0
        '
        'GunaGradient2Panel2
        '
        Me.GunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel2.Controls.Add(Me.compose_journal)
        Me.GunaGradient2Panel2.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradient2Panel2.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel2.Location = New System.Drawing.Point(11, 11)
        Me.GunaGradient2Panel2.Name = "GunaGradient2Panel2"
        Me.GunaGradient2Panel2.Padding = New System.Windows.Forms.Padding(8)
        Me.GunaGradient2Panel2.Radius = 15
        Me.GunaGradient2Panel2.Size = New System.Drawing.Size(422, 280)
        Me.GunaGradient2Panel2.TabIndex = 1
        '
        'compose_journal
        '
        Me.compose_journal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.compose_journal.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compose_journal.Location = New System.Drawing.Point(0, 0)
        Me.compose_journal.Multiline = True
        Me.compose_journal.Name = "compose_journal"
        Me.compose_journal.ReadOnly = True
        Me.compose_journal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.compose_journal.Size = New System.Drawing.Size(439, 280)
        Me.compose_journal.TabIndex = 1
        Me.compose_journal.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MessageViewer
        '
        Me.AcceptButton = Me.GunaCircleButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.GunaCircleButton1
        Me.ClientSize = New System.Drawing.Size(488, 381)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(488, 381)
        Me.MinimumSize = New System.Drawing.Size(488, 381)
        Me.Name = "MessageViewer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MessageViewer"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GunaGradient2Panel1.ResumeLayout(False)
        Me.GunaShadowPanel2.ResumeLayout(False)
        Me.GunaGradient2Panel3.ResumeLayout(False)
        Me.GunaGradient2Panel2.ResumeLayout(False)
        Me.GunaGradient2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents titleLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCircleButton1 As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaGradient2Panel3 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaGradient2Panel2 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents compose_journal As TextBox
End Class
