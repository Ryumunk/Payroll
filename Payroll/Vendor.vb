Imports System.Data

Public Class frmVendor
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

    Private Sub frmVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "Provider=Microsoft.Ace.OLEDB.12.0;"
        dbSource = "Data Source="

        LoadData()
    End Sub

    Sub LoadData()
        dbPathAndFilename = "..\Payroll_Management.accdb"
        con.ConnectionString = dbProvider & dbSource & dbPathAndFilename
        con.Open()
        sql = "SELECT * FROM Vendors;"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Vendors")
        con.Close()

        dgvVendor.DataSource = ds.Tables("Vendors")
    End Sub
End Class