<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVRForward
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnCrown = New System.Windows.Forms.Button()
        Me.btnEarBud = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picEarBud = New System.Windows.Forms.PictureBox()
        Me.picCrown = New System.Windows.Forms.PictureBox()
        CType(Me.picEarBud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCrown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.DarkGray
        Me.lblName.Location = New System.Drawing.Point(298, 21)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(205, 39)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "VR Forward"
        '
        'btnCrown
        '
        Me.btnCrown.Location = New System.Drawing.Point(152, 309)
        Me.btnCrown.Name = "btnCrown"
        Me.btnCrown.Size = New System.Drawing.Size(75, 23)
        Me.btnCrown.TabIndex = 3
        Me.btnCrown.Text = "VR Crown"
        Me.btnCrown.UseVisualStyleBackColor = True
        '
        'btnEarBud
        '
        Me.btnEarBud.Location = New System.Drawing.Point(570, 309)
        Me.btnEarBud.Name = "btnEarBud"
        Me.btnEarBud.Size = New System.Drawing.Size(75, 23)
        Me.btnEarBud.TabIndex = 4
        Me.btnEarBud.Text = "VR Earbud"
        Me.btnEarBud.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(363, 379)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picEarBud
        '
        Me.picEarBud.Image = Global.Virtual_Reality_Headsets.My.Resources.Resources.earbud
        Me.picEarBud.Location = New System.Drawing.Point(460, 87)
        Me.picEarBud.Name = "picEarBud"
        Me.picEarBud.Size = New System.Drawing.Size(282, 216)
        Me.picEarBud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEarBud.TabIndex = 2
        Me.picEarBud.TabStop = False
        Me.picEarBud.Visible = False
        '
        'picCrown
        '
        Me.picCrown.Image = Global.Virtual_Reality_Headsets.My.Resources.Resources.crown
        Me.picCrown.Location = New System.Drawing.Point(58, 87)
        Me.picCrown.Name = "picCrown"
        Me.picCrown.Size = New System.Drawing.Size(282, 216)
        Me.picCrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCrown.TabIndex = 1
        Me.picCrown.TabStop = False
        Me.picCrown.Visible = False
        '
        'frmVRForward
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEarBud)
        Me.Controls.Add(Me.btnCrown)
        Me.Controls.Add(Me.picEarBud)
        Me.Controls.Add(Me.picCrown)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmVRForward"
        Me.Text = "VR Forward"
        CType(Me.picEarBud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCrown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents picCrown As PictureBox
    Friend WithEvents picEarBud As PictureBox
    Friend WithEvents btnCrown As Button
    Friend WithEvents btnEarBud As Button
    Friend WithEvents btnExit As Button
End Class
