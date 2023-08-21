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
        lblFirstNum = New Label()
        lblOperator = New Label()
        lblSecondNum = New Label()
        lblAns = New Label()
        lblOutput = New Label()
        txtFirstNum = New TextBox()
        txtSecondNum = New TextBox()
        rdbtnAdd = New RadioButton()
        rdbtnSubtrac = New RadioButton()
        rdbtnMultiply = New RadioButton()
        rdbtnDivide = New RadioButton()
        btnCalculate = New Button()
        SuspendLayout()
        ' 
        ' lblFirstNum
        ' 
        lblFirstNum.AutoSize = True
        lblFirstNum.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblFirstNum.Location = New Point(73, 128)
        lblFirstNum.Name = "lblFirstNum"
        lblFirstNum.Size = New Size(133, 25)
        lblFirstNum.TabIndex = 0
        lblFirstNum.Text = "First Number: "
        ' 
        ' lblOperator
        ' 
        lblOperator.AutoSize = True
        lblOperator.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblOperator.Location = New Point(73, 184)
        lblOperator.Name = "lblOperator"
        lblOperator.Size = New Size(89, 25)
        lblOperator.TabIndex = 1
        lblOperator.Text = "Operator"
        ' 
        ' lblSecondNum
        ' 
        lblSecondNum.AutoSize = True
        lblSecondNum.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblSecondNum.Location = New Point(73, 239)
        lblSecondNum.Name = "lblSecondNum"
        lblSecondNum.Size = New Size(159, 25)
        lblSecondNum.TabIndex = 2
        lblSecondNum.Text = "Second Number: "
        ' 
        ' lblAns
        ' 
        lblAns.AutoSize = True
        lblAns.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblAns.Location = New Point(73, 40)
        lblAns.Name = "lblAns"
        lblAns.Size = New Size(114, 32)
        lblAns.TabIndex = 3
        lblAns.Text = "Answer: "
        ' 
        ' lblOutput
        ' 
        lblOutput.AutoSize = True
        lblOutput.BorderStyle = BorderStyle.FixedSingle
        lblOutput.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblOutput.Location = New Point(234, 40)
        lblOutput.MaximumSize = New Size(100, 100)
        lblOutput.MinimumSize = New Size(80, 80)
        lblOutput.Name = "lblOutput"
        lblOutput.Size = New Size(80, 80)
        lblOutput.TabIndex = 4
        ' 
        ' txtFirstNum
        ' 
        txtFirstNum.Location = New Point(234, 132)
        txtFirstNum.Name = "txtFirstNum"
        txtFirstNum.Size = New Size(171, 31)
        txtFirstNum.TabIndex = 5
        ' 
        ' txtSecondNum
        ' 
        txtSecondNum.Location = New Point(234, 247)
        txtSecondNum.Name = "txtSecondNum"
        txtSecondNum.Size = New Size(175, 31)
        txtSecondNum.TabIndex = 6
        ' 
        ' rdbtnAdd
        ' 
        rdbtnAdd.AutoSize = True
        rdbtnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        rdbtnAdd.Location = New Point(225, 193)
        rdbtnAdd.Name = "rdbtnAdd"
        rdbtnAdd.Size = New Size(72, 29)
        rdbtnAdd.TabIndex = 7
        rdbtnAdd.TabStop = True
        rdbtnAdd.Text = "Add"
        rdbtnAdd.UseVisualStyleBackColor = True
        ' 
        ' rdbtnSubtrac
        ' 
        rdbtnSubtrac.AutoSize = True
        rdbtnSubtrac.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        rdbtnSubtrac.Location = New Point(302, 193)
        rdbtnSubtrac.Name = "rdbtnSubtrac"
        rdbtnSubtrac.Size = New Size(109, 29)
        rdbtnSubtrac.TabIndex = 8
        rdbtnSubtrac.TabStop = True
        rdbtnSubtrac.Text = "Subtract"
        rdbtnSubtrac.UseVisualStyleBackColor = True
        ' 
        ' rdbtnMultiply
        ' 
        rdbtnMultiply.AutoSize = True
        rdbtnMultiply.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        rdbtnMultiply.Location = New Point(411, 193)
        rdbtnMultiply.Name = "rdbtnMultiply"
        rdbtnMultiply.Size = New Size(108, 29)
        rdbtnMultiply.TabIndex = 9
        rdbtnMultiply.TabStop = True
        rdbtnMultiply.Text = "Multiply"
        rdbtnMultiply.UseVisualStyleBackColor = True
        ' 
        ' rdbtnDivide
        ' 
        rdbtnDivide.AutoSize = True
        rdbtnDivide.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        rdbtnDivide.Location = New Point(535, 193)
        rdbtnDivide.Name = "rdbtnDivide"
        rdbtnDivide.Size = New Size(91, 29)
        rdbtnDivide.TabIndex = 10
        rdbtnDivide.TabStop = True
        rdbtnDivide.Text = "Divide"
        rdbtnDivide.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = SystemColors.WindowFrame
        btnCalculate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnCalculate.ForeColor = SystemColors.ActiveCaptionText
        btnCalculate.Location = New Point(73, 328)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(354, 59)
        btnCalculate.TabIndex = 11
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(800, 450)
        Controls.Add(btnCalculate)
        Controls.Add(rdbtnDivide)
        Controls.Add(rdbtnMultiply)
        Controls.Add(rdbtnSubtrac)
        Controls.Add(rdbtnAdd)
        Controls.Add(txtSecondNum)
        Controls.Add(txtFirstNum)
        Controls.Add(lblOutput)
        Controls.Add(lblAns)
        Controls.Add(lblSecondNum)
        Controls.Add(lblOperator)
        Controls.Add(lblFirstNum)
        Name = "Form1"
        Text = "BasicCalculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFirstNum As Label
    Friend WithEvents lblOperator As Label
    Friend WithEvents lblSecondNum As Label
    Friend WithEvents lblAns As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtFirstNum As TextBox
    Friend WithEvents txtSecondNum As TextBox
    Friend WithEvents rdbtnAdd As RadioButton
    Friend WithEvents rdbtnSubtrac As RadioButton
    Friend WithEvents rdbtnMultiply As RadioButton
    Friend WithEvents rdbtnDivide As RadioButton
    Friend WithEvents btnCalculate As Button
End Class
