public bool AuthenticateUser(string username, string password)
{
    using (SqlConnection connection = new SqlConnection(<connection_string>))
    {
        string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@Username", username);
        command.Parameters.AddWithValue("@Password", password);
        
        connection.Open();
        
        SqlDataReader reader = command.ExecuteReader();
        return reader.HasRows;
    }
}
