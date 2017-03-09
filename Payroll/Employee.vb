Imports System.Data

Public Class frmEmployee
    Dim dbProvider As String
    Dim dbSource As String
    Dim dbPathAndFilename As String
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "Provider=Microsoft.Ace.OLEDB.12.0;"
        dbSource = "Data Source="

        LoadData()
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub

    Sub LoadData()
        dbPathAndFilename = "..\Payroll_Management.accdb"
        con.ConnectionString = dbProvider & dbSource & dbPathAndFilename
        con.Open()
        sql = "SELECT * FROM Employee;"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Employee")
        con.Close()

        dgvEmployee.DataSource = ds.Tables("Employee")
    End Sub
End Class