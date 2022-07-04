<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Error_message
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Error_message))
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.back_error = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Crimson
        Me.GunaPanel2.Controls.Add(Me.Label1)
        Me.GunaPanel2.Controls.Add(Me.SplitContainer1)
        Me.GunaPanel2.Controls.Add(Me.PictureBox1)
        resources.ApplyResources(Me.GunaPanel2, "GunaPanel2")
        Me.GunaPanel2.Name = "GunaPanel2"
        '
        'SplitContainer1
        '
        resources.ApplyResources(Me.SplitContainer1, "SplitContainer1")
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Crimson
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Crimson
        Me.SplitContainer1.Panel2Collapsed = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Crimson
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Crimson
        Me.PictureBox1.Image = Global.WindowsApp12.My.Resources.Resources.icons8_cancel_110
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.back_error)
        resources.ApplyResources(Me.GunaPanel1, "GunaPanel1")
        Me.GunaPanel1.Name = "GunaPanel1"
        '
        'back_error
        '
        Me.back_error.Animated = True
        Me.back_error.AnimationHoverSpeed = 0.07!
        Me.back_error.AnimationSpeed = 0.03!
        Me.back_error.BackColor = System.Drawing.Color.Transparent
        Me.back_error.BaseColor1 = System.Drawing.Color.Crimson
        Me.back_error.BaseColor2 = System.Drawing.Color.Crimson
        Me.back_error.BorderColor = System.Drawing.Color.Crimson
        Me.back_error.BorderSize = 1
        Me.back_error.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.back_error.FocusedColor = System.Drawing.Color.Empty
        resources.ApplyResources(Me.back_error, "back_error")
        Me.back_error.ForeColor = System.Drawing.Color.White
        Me.back_error.Image = Nothing
        Me.back_error.ImageOffsetX = 2
        Me.back_error.ImageSize = New System.Drawing.Size(20, 20)
        Me.back_error.Name = "back_error"
        Me.back_error.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.back_error.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.back_error.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.back_error.OnHoverForeColor = System.Drawing.Color.White
        Me.back_error.OnHoverImage = Nothing
        Me.back_error.OnPressedColor = System.Drawing.Color.Transparent
        Me.back_error.OnPressedDepth = 20
        Me.back_error.Radius = 15
        Me.back_error.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.back_error.UseTransfarantBackground = True
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 5
        Me.GunaElipse1.TargetControl = Me
        '
        'Error_message
        '
        Me.AcceptButton = Me.back_error
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.back_error
        Me.CausesValidation = False
        Me.ControlBox = False
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "Error_message"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.GunaPanel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents back_error As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents PictureBox1 As PictureBox
End Class
