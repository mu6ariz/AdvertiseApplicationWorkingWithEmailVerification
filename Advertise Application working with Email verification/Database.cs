using System;
using System.Windows.Forms;

namespace RegisterApp_11_11_2019
{
    public class Database
    {
        private static int counter = 1;
        private static User[] users;

        static Database()
        { 
          users = new User[2];
            users[0] = new User();
            users[0].Email = "admin@gmail.com";
            users[0].Password = "12345";
            users[0].Name = "Admin";
            users[0].Surname = "Admin";
           // users[0].Id = 1;
        }
       
        public void AddUser(User user)
        {
            
            users[counter] = user;
            counter++;

            if (users.Length <= counter)
            {
                int newsize = users.Length * 2;
                Array.Resize(ref users, newsize);
            }
            MessageBox.Show("User successfully added");
        }

        public User[] GetAllUsers()
        {
            User[] allUsers = new User[counter];
            int count = 0;
            foreach (User user in users)
            {
                if (user != null)
                {
                    allUsers[count] = user;
                    count++;
                }
                  
            }
            return allUsers;
        }

        internal User FindUser(string email, string password)
        {
            User user = null;
            foreach (User user1 in users)
            {
                if (user1 == null)
                    continue;
                if(user1.Email == email && user1.Password == password)
                {
                    user = user1;
                }
            }
            return user;
        }
    }
}
