using Microsoft.Data.SqlClient;
using System;
using System.Data;
//using System.Data.SqlClient;

namespace AdminPanel
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void AddUser()
        {
    
        }

        private static string ConnectionString = "Data Source=SERVER\\SERVER;Initial Catalog=AdminPanel;Intergrated Security=true";
        private static SqlConnection connection = new SqlConnection(ConnectionString);
        private static SqlCommand command;
        private static SqlDataAdapter adapter;
        private static DataTable data;
    }
}
