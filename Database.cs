
namespace voiting_app
{
    public class InMemory
    {
        List<User> _users;
        public InMemory()
        {
            _users = new List<User>
            {
                new User { id = 1, Username = "Serhat", Password = "12345" },
                new User { id = 2, Username = "Serkan", Password = "54321" },
                new User { id = 3, Username = "Ali", Password = "12345" },
                new User { id = 4, Username = "Veli", Password = "12345" },
                new User { id = 5, Username = "Deli", Password = "12345" },
            };

        }
        public void Add (User user)
        {
            _users.Add(user);
        }
        public List<User> GetUsers()
        {
            return _users; 
        }
        public User Get(string userName)
        {
            return _users.Find(x => x.Username == userName);
        }



    }
}