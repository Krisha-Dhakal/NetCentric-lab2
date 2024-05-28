using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class CRUDConsoleApp
    {
        static string connectionString = "Server= DESKTOP-JP9M4M6\\SQLEXPRESS; Database= ncclabkrisha; Trusted_Connection=true; TrustServerCertificate=true; Integrated Security=true;";
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\nEmployee CRUD Operations Demo");
                Console.WriteLine("1. Insert Employee");
                Console.WriteLine("2. Read Employees");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InsertEmployee();
                        break;
                    case 2:
                        ReadEmployees();
                        break;
                    case 3:
                        UpdateEmployee();
                        break;
                    case 4:
                        DeleteEmployee();
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (choice != 5);
        }

        static void InsertEmployee()
        {
            int id;
            string name;
            int age;
            string position;

            Console.Write("Enter Id: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter employee name: ");
            name = Console.ReadLine();

            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter position: ");
            position = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Employee (Id, Name, Age, Position) VALUES (@id, @name, @age, @position)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@position", position);

                try
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Employee inserted successfully!");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        static void ReadEmployees()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Employee";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine("Employees:");
                        Console.WriteLine("{0,-10} {1,-20} {2,-5} {3,-15}", "ID", "Name", "Age", "Position");
                        while (reader.Read())
                        {
                            int employeeId = reader.GetInt32(0);
                            string employeeName = reader.GetString(1);
                            int employeeAge = reader.GetInt32(2);
                            string employeePosition = reader.GetString(3);
                            Console.WriteLine("{0,-10} {1,-20} {2,-5} {3,-15}", employeeId, employeeName, employeeAge, employeePosition);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No employees found.");
                    }
                    reader.Close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        static void UpdateEmployee()
        {
            int employeeId;
            string name;
            int age;
            string position;

            Console.Write("Enter employee ID to update: ");
            employeeId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter new name: ");
            name = Console.ReadLine();

            Console.Write("Enter new age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter new position: ");
            position = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Employee SET Name = @name, Age = @age, Position = @position WHERE Id = @employeeId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@employeeId", employeeId);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@position", position);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Employee updated successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Employee not found.");
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        static void DeleteEmployee()
        {
            int employeeId;

            Console.Write("Enter employee ID to delete: ");
            employeeId = Convert.ToInt32(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Employee WHERE Id = @employeeId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@employeeId", employeeId);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Employee deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Employee not found.");
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }
    }
}
