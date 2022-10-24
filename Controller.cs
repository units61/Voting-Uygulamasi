
namespace voiting_app
{
    public class UserController
    {
        InMemory inMemory = new InMemory();

        public bool Controller(string UserName,string Password)
        {
           User user = inMemory.Get(UserName);

                
                    if (user.Password == Password)
                    {
                        return true;
                    }
                    else return false;
              
                   
                
                
          
                  
        }
        public bool AddUser(string UserName,string PassWord)
        {
            int i = 0;  
            List<User> users = inMemory.GetUsers();
           foreach(User user in users)
            {
                if (user.Username == UserName)
                {
                    i++;
                }
            }
           if (i == 0)
            {
                return false;
            }
           else
            {
                User user = new User { id = users.Count+1, Username = UserName, Password = PassWord } ;
                inMemory.Add(user);
                return true;
            }

        }
    }
}

 