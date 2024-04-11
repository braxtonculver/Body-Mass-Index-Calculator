Public Class Form1

    Private Sub BMICalculatorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate height dropdown with values from 4 feet to 8 feet
        For feet As Integer = 4 To 8
            For inches As Integer = 0 To 11
                cmbFeetInches.Items.Add($"{feet} ft {inches} in")
            Next
        Next

        ' Set default selection to 5 feet 0 inches
        cmbFeetInches.SelectedIndex = 12 ' (5 feet * 12 inches/foot) + 0 inches
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Validate input
        If cmbFeetInches.SelectedIndex = -1 Then
            MessageBox.Show("Please select a height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtWeight.Text) OrElse Not IsNumeric(txtWeight.Text) Then
            MessageBox.Show("Please enter a valid weight.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Extract height in inches from selected item
        Dim heightSelection As String = cmbFeetInches.SelectedItem.ToString()
        Dim feet As Integer = CInt(heightSelection.Split(" ")(0)) ' Get feet part
        Dim inches As Integer = CInt(heightSelection.Split(" ")(2)) ' Get inches part
        Dim heightInches As Integer = (feet * 12) + inches ' Convert height to inches

        ' Calculate BMI
        Dim weight As Double = CDbl(txtWeight.Text)
        Dim bmi As Double = weight / (heightInches * heightInches) * 703 ' Convert height to inches and apply BMI formula

        ' Display BMI
        txtBMI.Text = bmi.ToString("0.00")

        ' Determine BMI category
        Dim category As String = ""
        If bmi < 18.5 Then
            category = "Underweight"
        ElseIf bmi >= 18.5 AndAlso bmi < 25 Then
            category = "Normal weight"
        ElseIf bmi >= 25 AndAlso bmi < 30 Then
            category = "Overweight"
        Else
            category = "Obese"
        End If

        lblCategory.Text = category
    End Sub
End Class
