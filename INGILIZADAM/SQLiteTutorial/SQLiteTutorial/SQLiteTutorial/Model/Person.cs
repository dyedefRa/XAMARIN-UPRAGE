using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteTutorial.Model
{
    public class Person
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Subscribed { get; set; }
    }
}
