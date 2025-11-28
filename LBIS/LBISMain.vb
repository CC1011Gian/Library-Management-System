Imports MySql.Data.MySqlClient

Public Class LBISMain
    Private ReadOnly connectionString As String = "server=localhost;userid=root;password=;database=crud_db"
    Private ReadOnly connection As New MySqlConnection(connectionString)


    Private adapter As MySqlDataAdapter
    Private table As DataTable

    Private Sub LBISMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim query As String = "SELECT * FROM Books"

            adapter = New MySqlDataAdapter(query, connection)
            table = New DataTable()

            adapter.Fill(table)
            ViewBooks.DataSource = table

            ViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            ViewBooks.AutoResizeColumns()

            For Each col As DataGridViewColumn In ViewBooks.Columns
                col.MinimumWidth = col.Width
            Next

            ViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

            If ViewBooks.Columns.Contains("Title") Then
                ViewBooks.Columns("Title").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Else
                ViewBooks.Columns(ViewBooks.Columns.Count - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadBooks()
        Try
            Dim query As String = "SELECT * FROM Books"

            adapter = New MySqlDataAdapter(query, connection)
            table = New DataTable()

            adapter.Fill(table)
            ViewBooks.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ReloadIfOK(dlg As DialogResult)
        If dlg = DialogResult.OK Then
            LoadBooks()
        End If
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim frm As New AddOrEdit()
        Dim res As DialogResult = frm.ShowDialog()
        ReloadIfOK(res)
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If ViewBooks.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a book to edit.", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim idObj = ViewBooks.SelectedRows(0).Cells("BookID").Value
        If idObj Is Nothing OrElse idObj Is DBNull.Value Then
            MessageBox.Show("Selected row has no BookID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim bookID As Integer = Convert.ToInt32(idObj)
        Dim frm As New AddOrEdit(bookID)
        Dim res As DialogResult = frm.ShowDialog()
        ReloadIfOK(res)
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If ViewBooks.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a book to delete.", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim idObj = ViewBooks.SelectedRows(0).Cells("BookID").Value
        If idObj Is Nothing OrElse idObj Is DBNull.Value Then
            MessageBox.Show("Selected row has no BookID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim bookID As Integer = Convert.ToInt32(idObj)

        If MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Try
                connection.Open()

                Dim query As String = "DELETE FROM Books WHERE BookID=@id"
                Dim adapter As New MySqlDataAdapter()
                adapter.DeleteCommand = New MySqlCommand(query, connection)
                adapter.DeleteCommand.Parameters.AddWithValue("@id", bookID)

                adapter.DeleteCommand.ExecuteNonQuery()

                MessageBox.Show("Book deleted successfully.")
                LoadBooks()

            Catch ex As Exception
                MessageBox.Show("Error deleting book: " & ex.Message)
            Finally
                If connection.State = ConnectionState.Open Then connection.Close()
            End Try
        End If
    End Sub

    Private Sub SearchBooks(keyword As String)
        Try
            Dim query As String = "SELECT * FROM Books WHERE Title LIKE @kw OR Author LIKE @kw OR Category LIKE @kw"

            adapter = New MySqlDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")

            table = New DataTable()
            adapter.Fill(table)
            ViewBooks.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Error searching: " & ex.Message)
        End Try
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        SearchBooks(SearchBox.Text)
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        SearchBooks(SearchBox.Text)
    End Sub
End Class
