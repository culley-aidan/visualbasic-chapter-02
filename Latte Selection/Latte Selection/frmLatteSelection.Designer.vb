<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLatteSelection
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picPumpkin = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPumpkin = New System.Windows.Forms.Button()
        Me.btnMocha = New System.Windows.Forms.Button()
        Me.btnSelectLatte = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picPumpkin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.125!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.Location = New System.Drawing.Point(268, 60)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(178, 27)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Latte Selection"
        '
        'picPumpkin
        '
        Me.picPumpkin.Location = New System.Drawing.Point(29, 127)
        Me.picPumpkin.Name = "picPumpkin"
        Me.picPumpkin.Size = New System.Drawing.Size(300, 250)
        Me.picPumpkin.TabIndex = 1
        Me.picPumpkin.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(385, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 250)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnPumpkin
        '
        Me.btnPumpkin.Location = New System.Drawing.Point(91, 431)
        Me.btnPumpkin.Name = "btnPumpkin"
        Me.btnPumpkin.Size = New System.Drawing.Size(145, 40)
        Me.btnPumpkin.TabIndex = 3
        Me.btnPumpkin.Text = "Pumpkin Spice"
        Me.btnPumpkin.UseVisualStyleBackColor = True
        '
        'btnMocha
        '
        Me.btnMocha.Location = New System.Drawing.Point(479, 431)
        Me.btnMocha.Name = "btnMocha"
        Me.btnMocha.Size = New System.Drawing.Size(145, 40)
        Me.btnMocha.TabIndex = 4
        Me.btnMocha.Text = "Mocha"
        Me.btnMocha.UseVisualStyleBackColor = True
        '
        'btnSelectLatte
        '
        Me.btnSelectLatte.Location = New System.Drawing.Point(286, 431)
        Me.btnSelectLatte.Name = "btnSelectLatte"
        Me.btnSelectLatte.Size = New System.Drawing.Size(145, 40)
        Me.btnSelectLatte.TabIndex = 5
        Me.btnSelectLatte.Text = "Select Latte"
        Me.btnSelectLatte.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(199, 515)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(316, 14)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Choose a latte flavor and then click Select Latte button."
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(284, 546)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(146, 14)
        Me.lblConfirmation.TabIndex = 7
        Me.lblConfirmation.Text = "Enjoy your latte selection"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(285, 584)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(145, 40)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmLatteSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 661)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnSelectLatte)
        Me.Controls.Add(Me.btnMocha)
        Me.Controls.Add(Me.btnPumpkin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picPumpkin)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmLatteSelection"
        Me.Text = "Latte Selection"
        CType(Me.picPumpkin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picPumpkin As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPumpkin As Button
    Friend WithEvents btnMocha As Button
    Friend WithEvents btnSelectLatte As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnExit As Button
End Class
