<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lblSymbol = New Label()
        lblAcendingOutput = New Label()
        lblDecendingOutput = New Label()
        txtSmbol = New TextBox()
        btnAcending = New Button()
        btnDescending = New Button()
        nmcSize = New NumericUpDown()
        lblSize = New Label()
        CType(nmcSize, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblSymbol
        ' 
        lblSymbol.AutoSize = True
        lblSymbol.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblSymbol.Location = New Point(91, 57)
        lblSymbol.Name = "lblSymbol"
        lblSymbol.Size = New Size(131, 38)
        lblSymbol.TabIndex = 0
        lblSymbol.Text = "Symbol: "
        ' 
        ' lblAcendingOutput
        ' 
        lblAcendingOutput.AutoSize = True
        lblAcendingOutput.BackColor = SystemColors.ButtonFace
        lblAcendingOutput.BorderStyle = BorderStyle.FixedSingle
        lblAcendingOutput.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblAcendingOutput.ForeColor = Color.Black
        lblAcendingOutput.Location = New Point(91, 231)
        lblAcendingOutput.MaximumSize = New Size(250, 250)
        lblAcendingOutput.MinimumSize = New Size(250, 250)
        lblAcendingOutput.Name = "lblAcendingOutput"
        lblAcendingOutput.Size = New Size(250, 250)
        lblAcendingOutput.TabIndex = 1
        ' 
        ' lblDecendingOutput
        ' 
        lblDecendingOutput.AutoSize = True
        lblDecendingOutput.BackColor = SystemColors.ButtonFace
        lblDecendingOutput.BorderStyle = BorderStyle.FixedSingle
        lblDecendingOutput.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblDecendingOutput.ForeColor = Color.Black
        lblDecendingOutput.Location = New Point(547, 231)
        lblDecendingOutput.MaximumSize = New Size(250, 250)
        lblDecendingOutput.MinimumSize = New Size(250, 250)
        lblDecendingOutput.Name = "lblDecendingOutput"
        lblDecendingOutput.Size = New Size(250, 250)
        lblDecendingOutput.TabIndex = 2
        ' 
        ' txtSmbol
        ' 
        txtSmbol.Location = New Point(228, 65)
        txtSmbol.Name = "txtSmbol"
        txtSmbol.Size = New Size(150, 31)
        txtSmbol.TabIndex = 3
        ' 
        ' btnAcending
        ' 
        btnAcending.BackColor = Color.RosyBrown
        btnAcending.Location = New Point(125, 145)
        btnAcending.Name = "btnAcending"
        btnAcending.Size = New Size(189, 52)
        btnAcending.TabIndex = 4
        btnAcending.Text = "Ascending"
        btnAcending.UseVisualStyleBackColor = False
        ' 
        ' btnDescending
        ' 
        btnDescending.BackColor = Color.RosyBrown
        btnDescending.Location = New Point(567, 145)
        btnDescending.Name = "btnDescending"
        btnDescending.Size = New Size(173, 52)
        btnDescending.TabIndex = 5
        btnDescending.Text = "Decending"
        btnDescending.UseVisualStyleBackColor = False
        ' 
        ' nmcSize
        ' 
        nmcSize.Location = New Point(585, 65)
        nmcSize.Name = "nmcSize"
        nmcSize.Size = New Size(180, 31)
        nmcSize.TabIndex = 6
        ' 
        ' lblSize
        ' 
        lblSize.AutoSize = True
        lblSize.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblSize.Location = New Point(478, 57)
        lblSize.Name = "lblSize"
        lblSize.Size = New Size(85, 38)
        lblSize.TabIndex = 7
        lblSize.Text = "Size: "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(893, 532)
        Controls.Add(lblSize)
        Controls.Add(nmcSize)
        Controls.Add(btnDescending)
        Controls.Add(btnAcending)
        Controls.Add(txtSmbol)
        Controls.Add(lblDecendingOutput)
        Controls.Add(lblAcendingOutput)
        Controls.Add(lblSymbol)
        Name = "Form1"
        Text = "Acending Descending Order "
        CType(nmcSize, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSymbol As Label
    Friend WithEvents lblAcendingOutput As Label
    Friend WithEvents lblDecendingOutput As Label
    Friend WithEvents txtSmbol As TextBox
    Friend WithEvents btnAcending As Button
    Friend WithEvents btnDescending As Button
    Friend WithEvents nmcSize As NumericUpDown
    Friend WithEvents lblSize As Label
End Class
