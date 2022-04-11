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
    public static class User
    {
        static SQLiteAsyncConnection db;

        static async Task Init()
        {
            if (db != null)
                return;
            
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "database.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Models.User>();


        }

        public static async Task AddUser(string name)
        {
            await Init();

            var user = new Models.User
            {
                UserName = name
            };

            var id = await db.InsertAsync(user);
        }

        public static async Task RemoveUser(int id)
        {
            await Init();

            await db.DeleteAsync<Models.User>(id);
        }

        public static async Task<IEnumerable<Models.User>> GetUser()
        {
            await Init();

            var user = await db.Table<Models.User>().ToListAsync();

            return user;
        }

        public static async Task UpdateUser(int id, string name)
        {
            await Init();

            await db.UpdateAsync(
                   new Models.User
                   {
                       id = id,
                       UserName = name

                   }
               );
        }
    }

}
