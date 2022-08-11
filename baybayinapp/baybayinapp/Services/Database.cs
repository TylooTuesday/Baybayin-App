using baybayinapp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace baybayinapp.Services
{
    public class Database
    {
        private readonly SQLiteAsyncConnection db;
        public Database(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Record>();
        }

        public Task<List<Record>> GetRecordsAsync()
        {
            return db.Table<Record>().ToListAsync();
        }
        public Task<int> SaveRecordAsync(Record record)
        {
            db.CreateTableAsync<Record>();
            return db.InsertAsync(record);
        }
        /*
        public async Task Init()
        {
            if (db != null)
            {
                return;
            }
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "data.db");
            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Record>();
        }*/
    }
}
