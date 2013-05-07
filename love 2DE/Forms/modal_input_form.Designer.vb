<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modal_input_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modal_input_form))
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.txtMain = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cboMain = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(307, 5)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(52, 21)
        Me.btnAccept.TabIndex = 2
        Me.btnAccept.Text = "&Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Location = New System.Drawing.Point(12, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(40, 13)
        Me.lblMain.TabIndex = 0
        Me.lblMain.Text = "lblMain"
        '
        'txtMain
        '
        Me.txtMain.Location = New System.Drawing.Point(15, 29)
        Me.txtMain.Name = "txtMain"
        Me.txtMain.Size = New System.Drawing.Size(286, 20)
        Me.txtMain.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(307, 28)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(52, 21)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cboMain
        '
        Me.cboMain.FormattingEnabled = True
        Me.cboMain.Location = New System.Drawing.Point(15, 72)
        Me.cboMain.Name = "cboMain"
        Me.cboMain.Size = New System.Drawing.Size(286, 21)
        Me.cboMain.TabIndex = 4
        '
        'modal_input_form
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 59)
        Me.Controls.Add(Me.cboMain)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtMain)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.btnAccept)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "modal_input_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "love 2IDE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents txtMain As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cboMain As System.Windows.Forms.ComboBox
End Class
