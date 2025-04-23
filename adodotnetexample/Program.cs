using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {

        //can't fo password="" since "" means start or end of the string literal and causes this connection string to break
        string connectionString = "server=localhost;user=root;password=;database=adodotnetexample";

    //preparing the connection string to connnect to the running databse
        using var connection = new MySqlConnection(connectionString);

        //making connection to the databse
        connection.Open();

        Console.WriteLine("Connected to MySQL!");

        //creating the query statement 
        using var command = new MySqlCommand("SELECT * FROM student", connection);
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine(reader["name"]);
        }
        // reader.close();
        // connection.close();
        // Console.WriteLine("Disconnected to the MySQL database");
    }
}
