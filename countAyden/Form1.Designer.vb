<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtSkip = New System.Windows.Forms.TextBox()
        Me.btnFor = New System.Windows.Forms.Button()
        Me.btnDo = New System.Windows.Forms.Button()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblSkip = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(88, 141)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 0
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(264, 141)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 1
        '
        'txtSkip
        '
        Me.txtSkip.Location = New System.Drawing.Point(440, 141)
        Me.txtSkip.Name = "txtSkip"
        Me.txtSkip.Size = New System.Drawing.Size(100, 20)
        Me.txtSkip.TabIndex = 2
        '
        'btnFor
        '
        Me.btnFor.Location = New System.Drawing.Point(353, 220)
        Me.btnFor.Name = "btnFor"
        Me.btnFor.Size = New System.Drawing.Size(75, 23)
        Me.btnFor.TabIndex = 3
        Me.btnFor.Text = "forCount"
        Me.btnFor.UseVisualStyleBackColor = True
        '
        'btnDo
        '
        Me.btnDo.Location = New System.Drawing.Point(179, 220)
        Me.btnDo.Name = "btnDo"
        Me.btnDo.Size = New System.Drawing.Size(75, 23)
        Me.btnDo.TabIndex = 4
        Me.btnDo.Text = "doCount"
        Me.btnDo.UseVisualStyleBackColor = True
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Location = New System.Drawing.Point(114, 109)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(53, 13)
        Me.lblNum1.TabIndex = 5
        Me.lblNum1.Text = "Number 1"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Location = New System.Drawing.Point(300, 109)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(53, 13)
        Me.lblNum2.TabIndex = 6
        Me.lblNum2.Text = "Number 2"
        '
        'lblSkip
        '
        Me.lblSkip.AutoSize = True
        Me.lblSkip.Location = New System.Drawing.Point(486, 109)
        Me.lblSkip.Name = "lblSkip"
        Me.lblSkip.Size = New System.Drawing.Size(28, 13)
        Me.lblSkip.TabIndex = 7
        Me.lblSkip.Text = "Skip"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 325)
        Me.Controls.Add(Me.lblSkip)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.btnDo)
        Me.Controls.Add(Me.btnFor)
        Me.Controls.Add(Me.txtSkip)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSkip As System.Windows.Forms.TextBox
    Friend WithEvents btnFor As System.Windows.Forms.Button
    Friend WithEvents btnDo As System.Windows.Forms.Button
    Friend WithEvents lblNum1 As System.Windows.Forms.Label
    Friend WithEvents lblNum2 As System.Windows.Forms.Label
    Friend WithEvents lblSkip As System.Windows.Forms.Label

End Class
