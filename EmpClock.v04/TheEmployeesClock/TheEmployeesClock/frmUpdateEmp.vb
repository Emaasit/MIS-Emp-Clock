'Name:            Update Employee Form
'Program:         this form allow the Administrator to update the employee table
'                 and push the updates to the database table
'Date:            Fall 2014
'Programmers:     Group 3

Public Class frmUpdateEmp

    Private Sub frmUpdateEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'when this form loads, it should open with the employee information selected from the "Empsclock" form
        If frmEmpsClock.lstEmployees.SelectedItem = True Then
            txtEmpFirstName.Text = frmEmpsClock.strEmpFirstName
            txtEmpLastName.Text = frmEmpsClock.strEmpLastName
            txtEmpID.Text = frmEmpsClock.intEmpID.ToString
            txtStreetAddr.Text = frmEmpsClock.strStreetAddr
            txtCity.Text = frmEmpsClock.strCity
            txtState.Text = frmEmpsClock.strState
            txtZip.Text = frmEmpsClock.intZip
            txtEmail.Text = frmEmpsClock.strEmail
            txtPayRate.Text = frmEmpsClock.dblPayRate.ToString
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtEmpFirstName.TextChanged

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'close the employee update form and show the Main form
        Me.Close()
        frmEmpsClock.Show()
    End Sub


End Class