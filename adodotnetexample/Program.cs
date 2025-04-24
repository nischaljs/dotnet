using System;
using MySql.Data.MySqlClient;

class Program
{
    static string connectionString = "server=localhost;user=root;password=;database=adodotnetexample";

    static void Main()
    {
        using var connection = new MySqlConnection(connectionString);
        connection.Open();
        Console.WriteLine("✅ Connected to MySQL!");

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n=== Student Database Menu ===");
            Console.WriteLine("1. Create Student");
            Console.WriteLine("2. Read Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateStudent(connection);
                    break;
                case "2":
                    ReadStudents(connection);
                    break;
                case "3":
                    UpdateStudent(connection);
                    break;
                case "4":
                    DeleteStudent(connection);
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("❌ Invalid choice. Try again.");
                    break;
            }
        }

        Console.WriteLine("👋 Exiting the program.");
    }


static void CreateStudent(MySqlConnection connection)
{
    try
    {
        Console.Write("Enter student name: ");
        string? name = Console.ReadLine();

        Console.Write("Enter the student class: ");
        string? studentClass = Console.ReadLine();

        Console.Write("Enter the student sex: \n 1. Male \n 2. Female \n 3. Others\n");
        string? choice = Console.ReadLine();
        string sexString;

        switch (choice)
        {
            case "1":
                sexString = "MALE";
                break;
            case "2":
                sexString = "FEMALE";
                break;
            default:
                sexString = "OTHERS";
                break;
        }

        string query = "INSERT INTO student (name, class, sex) VALUES (@name, @class, @sex)";
        using var cmd = new MySqlCommand(query, connection);
        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@class", studentClass);
        cmd.Parameters.AddWithValue("@sex", sexString);

        int rowsAffected = cmd.ExecuteNonQuery();
        Console.WriteLine($"✅ {rowsAffected} student(s) added.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("❌ Error while inserting student: " + ex.Message);
    }
}



static void ReadStudents(MySqlConnection connection)
{
    try
    {
        string query = "SELECT * FROM student";
        using var cmd = new MySqlCommand(query, connection);
        using var reader = cmd.ExecuteReader();

        Console.WriteLine("\n--- Student Records ---");
        while (reader.Read())
        {
            Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Class: {reader["class"]}, Sex: {reader["sex"]}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("❌ Error while reading students: " + ex.Message);
    }
}


   

    static void UpdateStudent(MySqlConnection connection)
    {
        try
        {
            Console.Write("Enter student ID to update: ");
        int id = int.Parse(Console.ReadLine()!);

        Console.Write("Enter new name: ");
        string? newName = Console.ReadLine();

        string query = "UPDATE student SET name = @name WHERE id = @id";
        using var cmd = new MySqlCommand(query, connection);
        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@name", newName);
        cmd.Parameters.AddWithValue("@id", id);

        int rowsAffected = cmd.ExecuteNonQuery();
        Console.WriteLine($"✅ {rowsAffected} student(s) updated.");
        }
        catch (Exception ex)
        {
            
            Console.Write("Error while updating the student" + ex.Message);
        }
    }

    static void DeleteStudent(MySqlConnection connection)
    {
     try{
           Console.Write("Enter student ID to delete: ");
        int id = int.Parse(Console.ReadLine()!);

        string query = "DELETE FROM student WHERE id = @id";
        using var cmd = new MySqlCommand(query, connection);
        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@id", id);

        int rowsAffected = cmd.ExecuteNonQuery();
        Console.WriteLine($"✅ {rowsAffected} student(s) deleted.");
     }
     catch (Exception ex)
     {
        Console.Write("❌ Error while deleting the student " + ex.Message);
     }
    }
}
