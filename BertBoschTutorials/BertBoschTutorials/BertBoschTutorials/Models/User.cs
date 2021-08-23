using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BertBoschTutorials.Models
{
    public class User
    {
        public User()
        {

        }
        public User(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }
        [PrimaryKey]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool CheckInformation()
        {
            if (UserName==null|| Password==null|| UserName=="" || Password=="" )
                return false;
            else
                return true;
        }
    }
}
