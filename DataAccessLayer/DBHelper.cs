using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using DotNetEnv;

namespace DataAccessLayer
{
    public class DBHelper
    {
        public static NpgsqlConnection GetConnection()
        {
            
            string envPath = Path.Combine(Directory.GetCurrentDirectory(), "..", ".env");

            if (File.Exists(envPath))
            {
                Env.Load(envPath);
            }
            else
            {
               
                Env.Load();
            }

            string connectionString = Environment.GetEnvironmentVariable("SUPABASE_CONNECTION_STRING");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("SUPABASE_CONNECTION_STRING .env file mein nahi mili!");
            }

            return new NpgsqlConnection(connectionString);
        }
    }
}