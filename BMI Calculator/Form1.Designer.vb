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
        EffectualTheme1 = New EffectualTheme()
        lblCategory = New TextBox()
        txtBMI = New TextBox()
        btnCalculate = New EffectualButtonOrange()
        txtWeight = New TextBox()
        Label2 = New Label()
        cmbFeetInches = New ComboBox()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        EffectualTheme1.SuspendLayout()
        SuspendLayout()
        ' 
        ' EffectualTheme1
        ' 
        EffectualTheme1.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        EffectualTheme1.Controls.Add(Label4)
        EffectualTheme1.Controls.Add(Label3)
        EffectualTheme1.Controls.Add(lblCategory)
        EffectualTheme1.Controls.Add(txtBMI)
        EffectualTheme1.Controls.Add(btnCalculate)
        EffectualTheme1.Controls.Add(txtWeight)
        EffectualTheme1.Controls.Add(Label2)
        EffectualTheme1.Controls.Add(cmbFeetInches)
        EffectualTheme1.Controls.Add(Label1)
        EffectualTheme1.Dock = DockStyle.Fill
        EffectualTheme1.Location = New Point(0, 0)
        EffectualTheme1.Name = "EffectualTheme1"
        EffectualTheme1.Size = New Size(196, 282)
        EffectualTheme1.Subtext = Nothing
        EffectualTheme1.TabIndex = 0
        EffectualTheme1.Text = "EffectualTheme1"
        ' 
        ' lblCategory
        ' 
        lblCategory.Location = New Point(12, 249)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(170, 23)
        lblCategory.TabIndex = 6
        ' 
        ' txtBMI
        ' 
        txtBMI.Location = New Point(12, 204)
        txtBMI.Name = "txtBMI"
        txtBMI.Size = New Size(170, 23)
        txtBMI.TabIndex = 5
        txtBMI.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.Transparent
        btnCalculate.ForeColor = Color.FromArgb(CByte(205), CByte(205), CByte(205))
        btnCalculate.Location = New Point(12, 158)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(170, 23)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Calculate"
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(61, 116)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(121, 23)
        txtWeight.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(12, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 2
        Label2.Text = "Weight"
        ' 
        ' cmbFeetInches
        ' 
        cmbFeetInches.FormattingEnabled = True
        cmbFeetInches.Location = New Point(61, 73)
        cmbFeetInches.Name = "cmbFeetInches"
        cmbFeetInches.Size = New Size(121, 23)
        cmbFeetInches.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(12, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 0
        Label1.Text = "Height"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(12, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 15)
        Label3.TabIndex = 7
        Label3.Text = "BMI"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(12, 231)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 8
        Label4.Text = "Category"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(196, 282)
        Controls.Add(EffectualTheme1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form1"
        ShowIcon = False
        Text = "B's BMI Calculator"
        TransparencyKey = Color.Fuchsia
        EffectualTheme1.ResumeLayout(False)
        EffectualTheme1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents EffectualTheme1 As EffectualTheme
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbFeetInches As ComboBox
    Friend WithEvents btnCalculate As EffectualButtonOrange
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBMI As TextBox
    Friend WithEvents lblCategory As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label

End Class
