using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clients
{
    class Client : Person
    {
        private List<Product> salaryHistory;
        private int IDclient;
        
        //for new clients - ID sets automaicly
        public Client(string name, string lastname, string sex, DateTime birthday)
        {
            this.FirstName = name;
            this.LastName = lastname;
            this.Sex = sex;
            this.Birthday = birthday;
            this.salaryHistory = new List<Product>();
            AddToDatabase();
        }

        //for existing clients - get data from DB via ID
        public Client(int id)
        {
            this.IDclient = id;
            GetDataFromDB();
        }

        private void GetDataFromDB()
        {
            using (SqlConnection connection = new SqlConnection(Program.DBconnectionString))
            {
                connection.Open();
                //Console.WriteLine($"Connected to {connection.Database}");
                var selectQuerry = $"SELECT * FROM dbo.Clients WHERE id = {IDclient}";
                SqlCommand command = new SqlCommand(selectQuerry,connection);
                SqlDataReader outReader = command.ExecuteReader();
                outReader.Read();
                IDataRecord record = (IDataReader) outReader;
                var a = record[0].ToString();
                var b = record[1];
                var c = record[2];
                var d = record[3];
                var e = record[4].ToString();
                var f = record[5].ToString();
                Console.WriteLine($"{a}, {b}, {c}, {d}, {e}, {f}");
            }
        }

        private void AddToDatabase()
        {
            using (SqlConnection connection = new SqlConnection(Program.DBconnectionString))
            {
                connection.Open();
               // Console.WriteLine($"Connected to {connection.Database}");
                string insertQuerry = $"INSERT INTO dbo.Clients VALUES ('{FirstName}', '{LastName}', '{Sex}', CAST('{Birthday.ToString("yyyy-MM-dd")}' AS DATE), 0); ";
                SqlCommand command = new SqlCommand(insertQuerry, connection);
                command.ExecuteNonQuery();
                string getIDQuerry = "SELECT max(id) FROM dbo.Clients";
                command = new SqlCommand(getIDQuerry, connection);
                IDclient = (int)command.ExecuteScalar();
            }
           
        }


        public void Bying(string item, float price)
        {
            salaryHistory.Add(new Product(item,price));
        }
    }
}
