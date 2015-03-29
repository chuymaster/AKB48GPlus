<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imageform
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
        Me.imageBoxFull = New System.Windows.Forms.PictureBox()
        Me.timerShowpic = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imageBoxFull, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imageBoxFull
        '
        Me.imageBoxFull.BackColor = System.Drawing.Color.Black
        Me.imageBoxFull.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imageBoxFull.ImageLocation = ""
        Me.imageBoxFull.Location = New System.Drawing.Point(0, 0)
        Me.imageBoxFull.Name = "imageBoxFull"
        Me.imageBoxFull.Size = New System.Drawing.Size(284, 261)
        Me.imageBoxFull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imageBoxFull.TabIndex = 31
        Me.imageBoxFull.TabStop = False
        '
        'timerShowpic
        '
        Me.timerShowpic.Interval = 3000
        '
        'imageform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.imageBoxFull)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "imageform"
        Me.Text = "image"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.imageBoxFull, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imageBoxFull As System.Windows.Forms.PictureBox
    Friend WithEvents timerShowpic As System.Windows.Forms.Timer
End Class
