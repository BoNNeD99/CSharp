using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Class06.Task02.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        string[] Messages = new string[] {"Message 1 ", "Message 2"};

        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }




    }
}
