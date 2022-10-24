namespace voiting_app
{
   
        public class User
        {
            public int id {get; set;}

            public User(int id, string username, string password)
            {
                this.id = id;
                this.Username = username;
                this.Password = password;
            }

            public string Username { get; set; }
            public string Password { get; set; }
            public User() { 
               
            }
            
       
        }
    
}
