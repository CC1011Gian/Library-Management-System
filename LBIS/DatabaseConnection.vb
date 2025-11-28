Imports MySql.Data.MySqlClient

Public Class DatabaseConnection

    Private ReadOnly connectionString As String = "server=localhost;userid=root;password=;database=crud_db"
    Private ReadOnly connection As MySqlConnection

    Public Sub New()
        connection = New MySqlConnection(connectionString)
    End Sub

    Public Sub OpenConnection()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error opening connection: " & ex.Message)
        End Try
    End Sub

    Public Sub CloseConnection()
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error closing connection: " & ex.Message)
        End Try
    End Sub

    Public Function GetConnection() As MySqlConnection
        Return connection
    End Function

    Public Function ExecuteQuery(query As String) As DataTable
        Dim table As New DataTable()
        Try
            OpenConnection()
            Using cmd As New MySqlCommand(query, connection)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Query error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        Return table
    End Function
End Class
