using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTutorial.Model
{
    public class MyDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public MyDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Person>();
        }

        public Task<List<Person>> GetPeopleAsync()
        {
            return _database.Table<Person>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Person person)
        {
            return _database.InsertAsync(person);
        }

        public Task<int> UpdatePersonAsync(Person person)
        {
            return _database.UpdateAsync(person);
        }

        public Task<int> DeletePersonAsync(Person person)
        {
            return _database.DeleteAsync(person);
        }

        public Task<List<Person>> QuerySubscribedAsync()
        {
            return _database.QueryAsync<Person>("Select * from Person Where Subscribed = true");
        }

        public Task<List<Person>> LinqNotSubscribedAsync()
        {
            return _database.Table<Person>().Where(x => x.Subscribed == false).ToListAsync();
        }
    }
}
