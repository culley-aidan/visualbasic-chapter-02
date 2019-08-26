<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCampusMusicCafe
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
        Me.picCafe = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        CType(Me.picCafe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCafe
        '
        Me.picCafe.Image = Global.Campus_Music_Cafe.My.Resources.Resources.cafe
        Me.picCafe.Location = New System.Drawing.Point(234, 12)
        Me.picCafe.Name = "picCafe"
        Me.picCafe.Size = New System.Drawing.Size(332, 196)
        Me.picCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCafe.TabIndex = 0
        Me.picCafe.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(279, 211)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(243, 20)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "All college students are welcome."
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(218, 277)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(103, 32)
        Me.btnDate.TabIndex = 2
        Me.btnDate.Text = "Date"
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(479, 277)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(103, 32)
        Me.btnDetails.TabIndex = 4
        Me.btnDetails.Text = "Further Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(360, 384)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(305, 338)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(194, 25)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "October 30, 2018"
        Me.lblDate.Visible = False
        '
        'lblDetails
        '
        Me.lblDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.Location = New System.Drawing.Point(148, 322)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(505, 41)
        Me.lblDetails.TabIndex = 1
        Me.lblDetails.Text = "The performance will be Open Mic and will start at 8:00PM for further details che" &
    "ck the Campus Music Cafe's Facebook"
        Me.lblDetails.Visible = False
        '
        'frmCampusMusicCafe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.picCafe)
        Me.Name = "frmCampusMusicCafe"
        Me.Text = "Campus Music Cafe"
        CType(Me.picCafe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCafe As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnDate As Button
    Friend WithEvents btnDetails As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblDetails As Label
End Class
