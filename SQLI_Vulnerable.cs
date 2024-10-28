public bool AuthenticateUser(string username, string password)
{
    using (SqlConnection connection = new SqlConnection(<connection_string>))
    {
        string query = $"SELECT * FROM Users WHERE Username = '{username}' AND Password = '{password}'";
        SqlCommand command = new SqlCommand(query, connection);
        connection.Open();
        
        SqlDataReader reader = command.ExecuteReader();
        return reader.HasRows;
    }
} 