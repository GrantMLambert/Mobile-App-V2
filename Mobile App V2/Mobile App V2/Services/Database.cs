using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Essentials;
using SQLite;
using Mobile_App_V2.Models;

namespace Mobile_App_V2.Services
{
    public static class Database
    {
        static SQLiteAsyncConnection db;

        static async Task Init()
        {
            if (db != null)
                return;
            
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<User>();


        }

        public static async Task AddUser(string name)
        {
            await Init();

            var user = new User
            {
                UserName = name
            };
        }
    }
}
