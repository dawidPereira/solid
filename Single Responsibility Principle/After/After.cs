namespace solid.Single_Responsibility_Principle.After
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
    }

    public class EmailValidator
    {
        public bool ValidateEmail(string email)
        {
            //...
            return default;
        }
    }

    public class UserRepository
    {
        public void SaveToDb()
        {
            //...
        }
    }

    public class PrinterManager
    {
        public void Print()
        {
            //...
        }
    }
}
