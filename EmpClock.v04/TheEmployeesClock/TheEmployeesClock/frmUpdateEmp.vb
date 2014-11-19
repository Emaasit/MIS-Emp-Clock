'Name:            Update Employee Form
'Program:         this form allow the Administrator to update the employee table
'                 and push the updates to the database table
'Date:            Fall 2014
'Programmers:     Group 3

Public Class frmUpdateEmp

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtEmpFirstName.TextChanged

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'close the employee update form and show the Main form
        Me.Close()
        frmEmpsClock.Show()
    End Sub
End Class