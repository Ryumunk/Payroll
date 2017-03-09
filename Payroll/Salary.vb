Imports System.Data

Public Class frmSalary
    Dim dbProvider As String
    Dim dbSource As String
    Dim dbPathAndFilename As String
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String


    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Close()

    End Sub

    Private Sub frmSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "Provider=Microsoft.Ace.OLEDB.12.0;"
        dbSource = "Data Source="
        Me.WindowState = FormWindowState.Maximized

        LoadData()
    End Sub

    Sub LoadData()
        dbPathAndFilename = "..\Payroll_Management.accdb"
        con.ConnectionString = dbProvider & dbSource & dbPathAndFilename
        con.Open()
        sql = "SELECT * FROM Salary;"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "salary")
        con.Close()

        dgvSalary.DataSource = ds.Tables("salary")
    End Sub

    Private Sub mnuReport_Click(sender As Object, e As EventArgs) Handles mnuReport.Click
        My.Forms.frmReport.Show()
    End Sub
End Class