using System;
using System.Collections.Generic;
using System.Text;

namespace primeri
{
    public class UsersStatics: User
    {
        
        int id = 0;
       
        //public int Mark { get { return mark; } set { mark = value; } }

       // public string Name { get { return name; } set { name = value; } }

        public UsersStatics(User user)
        {
            
            id++;
            Mark = user.Mark;
            Name = user.Name;
        }

        public int Id { get { return id; }  }

        

    }
}
