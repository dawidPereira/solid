using System;
using System.Collections.Generic;
using System.Text;

namespace solid.Single_Responsibility_Principle.Before
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        public void SetName(string name)
        {
            //...
        }
        public bool ValidateEmail(string email)
        {
            //...
            return default;
        }

        public void SaveToDb()
        {
            //...
        }

        public void PrintUserData()
        {
            //...
        }
    }
}
