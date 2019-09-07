using System;
using System.Collections.Generic;
using System.Text;
namespace solid.Open_Closed_Principle.Before
{
    public class SecurityGuard
    {
        public bool ValidateUser(User user)
        {
            return ValidateName(user.Name)
                    && ValidateCloth(user.Cloth)
                    && ValidateAge(user.Age);
        }

        private bool ValidateName(string name)
        {
            //...
            return default;
        }
        private bool ValidateCloth(string cloth)
        {
            //...
            return default;
        }
        private bool ValidateAge(string age)
        {
            //...
            return default;
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Cloth { get; set; }
        public string Age { get; set; }
    }
}
