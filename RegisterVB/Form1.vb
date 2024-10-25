Imports System.Data.SqlClient

Public Class Form1
    'Insert Code'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(txtFisrtName.Text) OrElse
       String.IsNullOrWhiteSpace(txtMiddleName.Text) OrElse
       String.IsNullOrWhiteSpace(txtLastName.Text) OrElse
       String.IsNullOrWhiteSpace(txtAddress.Text) OrElse
       String.IsNullOrWhiteSpace(cmdGender.Text) OrElse
       String.IsNullOrWhiteSpace(txtPinCode.Text) OrElse
       String.IsNullOrWhiteSpace(cmdState.Text) Then

            MessageBox.Show("Please fill in all fields before submitting.")
            Exit Sub ' Exit the subroutine if any field is blank
        End If
        Dim con As New SqlConnection("Data Source=DESKTOP-NUDMVOB\SQLEXPRESS;Initial Catalog=VbDotNet;Integrated Security=True")
        Dim cmd As New SqlCommand("INSERT INTO Register (FirstName, MiddleName, LastName, Address, Gender, PinCode, State) " &
                              "VALUES (@FirstName, @MiddleName, @LastName, @Address, @Gender, @PinCode, @State)", con)


        cmd.Parameters.AddWithValue("@FirstName", txtFisrtName.Text)
        cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
        cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
        cmd.Parameters.AddWithValue("@Gender", cmdGender.Text)
        cmd.Parameters.AddWithValue("@PinCode", txtPinCode.Text)
        cmd.Parameters.AddWithValue("@State", cmdState.Text)

        Try
            con.Open()
            Dim result As Integer = cmd.ExecuteNonQuery()
            If result >= 1 Then
                MessageBox.Show("Data inserted successfully.")

                LoadDataIntoDataGridView()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()

        End Try
        LoadDataIntoDataGridView()
    End Sub

    'Update Code'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-NUDMVOB\SQLEXPRESS;Initial Catalog=VbDotNet;Integrated Security=True")
        Dim cmd As New SqlCommand("UPDATE Register SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, " &
                                   "Address = @Address, Gender = @Gender, PinCode = @PinCode, State = @State WHERE Id = @Id", con)


        cmd.Parameters.AddWithValue("@FirstName", txtFisrtName.Text)
        cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
        cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
        cmd.Parameters.AddWithValue("@Gender", cmdGender.Text)
        cmd.Parameters.AddWithValue("@PinCode", txtPinCode.Text)
        cmd.Parameters.AddWithValue("@State", cmdState.Text)


        cmd.Parameters.AddWithValue("@Id", CInt(Id.Text))

        Try
            con.Open()
            Dim result As Integer = cmd.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Data updated successfully.")
                LoadDataIntoDataGridView()
            Else
                MessageBox.Show("Data update failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'Display data code'
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        LoadDataIntoDataGridView()

    End Sub
    'fetch data '
    Private Sub LoadDataIntoDataGridView()
        Dim con As New SqlConnection("Data Source=DESKTOP-NUDMVOB\SQLEXPRESS;Initial Catalog=VbDotNet;Integrated Security=True")
        Dim query As String = "SELECT * FROM Register"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()

        Try
            con.Open()
            adapter.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoDataGridView()
    End Sub
    'Delete code'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrWhiteSpace(Id.Text) Then
            MessageBox.Show("Please enter an ID to delete.")
            Return
        End If

        Dim selectedId As Integer
        If Not Integer.TryParse(Id.Text, selectedId) Then
            MessageBox.Show("Invalid ID format. Please enter a valid numeric ID.")
            Return
        End If

        Dim con As New SqlConnection("Data Source=DESKTOP-NUDMVOB\SQLEXPRESS;Initial Catalog=VbDotNet;Integrated Security=True")
        Dim cmd As New SqlCommand("DELETE FROM Register WHERE Id = @Id", con)
        cmd.Parameters.AddWithValue("@Id", selectedId)

        Try
            con.Open()
            Dim result As Integer = cmd.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Data deleted successfully.")
            Else
                MessageBox.Show("Data deletion failed. No record found with the specified ID.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try


        LoadDataIntoDataGridView()
    End Sub
End Class
