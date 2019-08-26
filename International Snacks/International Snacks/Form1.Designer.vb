<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSnack
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
        Me.btnBean = New System.Windows.Forms.Button()
        Me.btnFalafel = New System.Windows.Forms.Button()
        Me.picSpring = New System.Windows.Forms.PictureBox()
        Me.picGreek = New System.Windows.Forms.PictureBox()
        Me.picFalafel = New System.Windows.Forms.PictureBox()
        Me.picBean = New System.Windows.Forms.PictureBox()
        Me.btnGreek = New System.Windows.Forms.Button()
        Me.btnSpring = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblCInstructions = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        CType(Me.picSpring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFalafel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBean, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBean
        '
        Me.btnBean.Location = New System.Drawing.Point(12, 12)
        Me.btnBean.Name = "btnBean"
        Me.btnBean.Size = New System.Drawing.Size(119, 33)
        Me.btnBean.TabIndex = 4
        Me.btnBean.Text = "Bean Burrito"
        Me.btnBean.UseVisualStyleBackColor = True
        '
        'btnFalafel
        '
        Me.btnFalafel.Location = New System.Drawing.Point(12, 51)
        Me.btnFalafel.Name = "btnFalafel"
        Me.btnFalafel.Size = New System.Drawing.Size(119, 33)
        Me.btnFalafel.TabIndex = 5
        Me.btnFalafel.Text = "Falafel"
        Me.btnFalafel.UseVisualStyleBackColor = True
        '
        'picSpring
        '
        Me.picSpring.Image = Global.International_Snacks.My.Resources.Resources.spring_rolls
        Me.picSpring.Location = New System.Drawing.Point(240, 12)
        Me.picSpring.Name = "picSpring"
        Me.picSpring.Size = New System.Drawing.Size(320, 239)
        Me.picSpring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpring.TabIndex = 3
        Me.picSpring.TabStop = False
        Me.picSpring.Visible = False
        '
        'picGreek
        '
        Me.picGreek.Image = Global.International_Snacks.My.Resources.Resources.greek_yogurt
        Me.picGreek.Location = New System.Drawing.Point(240, 12)
        Me.picGreek.Name = "picGreek"
        Me.picGreek.Size = New System.Drawing.Size(320, 239)
        Me.picGreek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGreek.TabIndex = 2
        Me.picGreek.TabStop = False
        Me.picGreek.Visible = False
        '
        'picFalafel
        '
        Me.picFalafel.Image = Global.International_Snacks.My.Resources.Resources.Falafel
        Me.picFalafel.Location = New System.Drawing.Point(240, 12)
        Me.picFalafel.Name = "picFalafel"
        Me.picFalafel.Size = New System.Drawing.Size(320, 239)
        Me.picFalafel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFalafel.TabIndex = 1
        Me.picFalafel.TabStop = False
        Me.picFalafel.Visible = False
        '
        'picBean
        '
        Me.picBean.Image = Global.International_Snacks.My.Resources.Resources.bean_burrito
        Me.picBean.Location = New System.Drawing.Point(240, 12)
        Me.picBean.Name = "picBean"
        Me.picBean.Size = New System.Drawing.Size(320, 239)
        Me.picBean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBean.TabIndex = 0
        Me.picBean.TabStop = False
        Me.picBean.Visible = False
        '
        'btnGreek
        '
        Me.btnGreek.Location = New System.Drawing.Point(13, 91)
        Me.btnGreek.Name = "btnGreek"
        Me.btnGreek.Size = New System.Drawing.Size(119, 33)
        Me.btnGreek.TabIndex = 6
        Me.btnGreek.Text = "Greek Yogurt"
        Me.btnGreek.UseVisualStyleBackColor = True
        '
        'btnSpring
        '
        Me.btnSpring.Location = New System.Drawing.Point(13, 131)
        Me.btnSpring.Name = "btnSpring"
        Me.btnSpring.Size = New System.Drawing.Size(119, 33)
        Me.btnSpring.TabIndex = 7
        Me.btnSpring.Text = "Spring Rolls"
        Me.btnSpring.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.Location = New System.Drawing.Point(372, 307)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 8
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        Me.btnConfirm.Visible = False
        '
        'lblCInstructions
        '
        Me.lblCInstructions.AutoSize = True
        Me.lblCInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCInstructions.Location = New System.Drawing.Point(202, 265)
        Me.lblCInstructions.Name = "lblCInstructions"
        Me.lblCInstructions.Size = New System.Drawing.Size(406, 20)
        Me.lblCInstructions.TabIndex = 9
        Me.lblCInstructions.Text = "Click ready when you are done making a selection"
        Me.lblCInstructions.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(372, 337)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(286, 91)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(228, 20)
        Me.lblInstructions.TabIndex = 11
        Me.lblInstructions.Text = "Click a snack to get started"
        '
        'frmSnack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblCInstructions)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnSpring)
        Me.Controls.Add(Me.btnGreek)
        Me.Controls.Add(Me.btnFalafel)
        Me.Controls.Add(Me.btnBean)
        Me.Controls.Add(Me.picSpring)
        Me.Controls.Add(Me.picGreek)
        Me.Controls.Add(Me.picFalafel)
        Me.Controls.Add(Me.picBean)
        Me.Name = "frmSnack"
        Me.Text = "International Snacks"
        CType(Me.picSpring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFalafel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBean, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBean As PictureBox
    Friend WithEvents picFalafel As PictureBox
    Friend WithEvents picGreek As PictureBox
    Friend WithEvents picSpring As PictureBox
    Friend WithEvents btnBean As Button
    Friend WithEvents btnFalafel As Button
    Friend WithEvents btnGreek As Button
    Friend WithEvents btnSpring As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblCInstructions As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblInstructions As Label
End Class
