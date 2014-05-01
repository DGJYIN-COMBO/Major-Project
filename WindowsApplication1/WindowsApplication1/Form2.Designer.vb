<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.VeiwBudgetBTN = New System.Windows.Forms.Button()
        Me.LoadBudgetBTN = New System.Windows.Forms.Button()
        Me.NewBudgetBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'VeiwBudgetBTN
        '
        Me.VeiwBudgetBTN.ForeColor = System.Drawing.Color.Blue
        Me.VeiwBudgetBTN.Location = New System.Drawing.Point(243, 295)
        Me.VeiwBudgetBTN.Name = "VeiwBudgetBTN"
        Me.VeiwBudgetBTN.Size = New System.Drawing.Size(120, 53)
        Me.VeiwBudgetBTN.TabIndex = 5
        Me.VeiwBudgetBTN.Text = "View Budgets"
        Me.VeiwBudgetBTN.UseVisualStyleBackColor = True
        '
        'LoadBudgetBTN
        '
        Me.LoadBudgetBTN.ForeColor = System.Drawing.Color.Blue
        Me.LoadBudgetBTN.Location = New System.Drawing.Point(243, 198)
        Me.LoadBudgetBTN.Name = "LoadBudgetBTN"
        Me.LoadBudgetBTN.Size = New System.Drawing.Size(120, 53)
        Me.LoadBudgetBTN.TabIndex = 4
        Me.LoadBudgetBTN.Text = "Load Budget"
        Me.LoadBudgetBTN.UseVisualStyleBackColor = True
        '
        'NewBudgetBTN
        '
        Me.NewBudgetBTN.ForeColor = System.Drawing.Color.Blue
        Me.NewBudgetBTN.Location = New System.Drawing.Point(243, 107)
        Me.NewBudgetBTN.Name = "NewBudgetBTN"
        Me.NewBudgetBTN.Size = New System.Drawing.Size(120, 53)
        Me.NewBudgetBTN.TabIndex = 3
        Me.NewBudgetBTN.Text = "New Budget"
        Me.NewBudgetBTN.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(606, 455)
        Me.Controls.Add(Me.VeiwBudgetBTN)
        Me.Controls.Add(Me.LoadBudgetBTN)
        Me.Controls.Add(Me.NewBudgetBTN)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VeiwBudgetBTN As System.Windows.Forms.Button
    Friend WithEvents LoadBudgetBTN As System.Windows.Forms.Button
    Friend WithEvents NewBudgetBTN As System.Windows.Forms.Button
End Class
