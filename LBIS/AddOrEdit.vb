Imports MySql.Data.MySqlClient
Imports System.Data

Public Class AddOrEdit
    Private ReadOnly connectionString As String = "server=localhost;userid=root;password=;database=crud_db"
    Private ReadOnly connection As New MySqlConnection(connectionString)

    Private isEdit As Boolean = False
    Private editBookID As Integer = -1

    Public Sub New()
        InitializeComponent()
        InitializeForm()
    End Sub

    Public Sub New(bookID As Integer)
        InitializeComponent()
        InitializeForm()
        isEdit = True
        editBookID = bookID
        LoadBookForEdit(bookID)
    End Sub

    Private Sub InitializeForm()
        StatusComboBox.Items.Clear()
        StatusComboBox.Items.Add("active")
        StatusComboBox.Items.Add("archived")
        StatusComboBox.SelectedIndex = 0

        AddHandler SaveBtn.Click, AddressOf btnSave_Click
        AddHandler CancelBtn.Click, AddressOf btnCancel_Click
    End Sub

    Private Sub LoadBookForEdit(bookID As Integer)
        Try
            Dim query As String = "SELECT * FROM Books WHERE BookID = @id"
            Dim adapter As New MySqlDataAdapter(query, connection)
            adapter.SelectCommand.Parameters.AddWithValue("@id", bookID)

            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count = 0 Then
                MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.DialogResult = DialogResult.Cancel
                Me.Close()
                Return
            End If

            Dim row As DataRow = table.Rows(0)
            TitleBox.Text = If(row.IsNull("Title"), "", row("Title").ToString())
            AuthorBox.Text = If(row.IsNull("Author"), "", row("Author").ToString())
            CategoryBox.Text = If(row.IsNull("Category"), "", row("Category").ToString())
            YearBox.Text = If(row.IsNull("Year"), "", row("Year").ToString())

            Dim st As String = If(row.Table.Columns.Contains("Status") AndAlso Not row.IsNull("Status"), row("Status").ToString(), "active")
            If StatusComboBox.Items.Contains(st) Then
                StatusComboBox.SelectedItem = st
            Else
                StatusComboBox.SelectedIndex = 0
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading book: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(TitleBox.Text) Then
            MessageBox.Show("Please enter the Title.")
            TitleBox.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(AuthorBox.Text) Then
            MessageBox.Show("Please enter the Author.")
            AuthorBox.Focus()
            Return
        End If

        Dim yearVal As Integer = 0
        Dim hasYear As Boolean = False
        If Not String.IsNullOrWhiteSpace(YearBox.Text) Then
            If Integer.TryParse(YearBox.Text, yearVal) Then
                hasYear = True
            Else
                MessageBox.Show("Year must be numeric (e.g. 1999) or left blank.")
                YearBox.Focus()
                Return
            End If
        End If

        Try
            connection.Open()

            If isEdit Then
                Dim updateSql As String = "UPDATE Books SET Title=@Title, Author=@Author, Category=@Category, Year=@Year, Status=@Status WHERE BookID=@BookID"
                Using cmd As New MySqlCommand(updateSql, connection)
                    cmd.Parameters.AddWithValue("@Title", TitleBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Author", AuthorBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Category", If(String.IsNullOrWhiteSpace(CategoryBox.Text), DBNull.Value, CType(CategoryBox.Text.Trim(), Object)))
                    If hasYear Then
                        cmd.Parameters.AddWithValue("@Year", yearVal)
                    Else
                        cmd.Parameters.AddWithValue("@Year", DBNull.Value)
                    End If
                    cmd.Parameters.AddWithValue("@Status", StatusComboBox.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@BookID", editBookID)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Book updated successfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim insertSql As String = "INSERT INTO Books (Title, Author, Category, Year, Status) VALUES (@Title, @Author, @Category, @Year, @Status)"
                Using cmd As New MySqlCommand(insertSql, connection)
                    cmd.Parameters.AddWithValue("@Title", TitleBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Author", AuthorBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Category", If(String.IsNullOrWhiteSpace(CategoryBox.Text), DBNull.Value, CType(CategoryBox.Text.Trim(), Object)))
                    If hasYear Then
                        cmd.Parameters.AddWithValue("@Year", yearVal)
                    Else
                        cmd.Parameters.AddWithValue("@Year", DBNull.Value)
                    End If
                    cmd.Parameters.AddWithValue("@Status", StatusComboBox.SelectedItem.ToString())

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Book added successfully.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error saving book: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
