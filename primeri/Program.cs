using System;
using System.Collections.Generic;
using System.Linq;

namespace primeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Test test = new Test();
            User user = new User();
            
            user.TakeTheTest(test);
            teacher.CheckTheTest(user, test);
            user.SeeTheResult(test,teacher);

            using (ApplicationContext db = new ApplicationContext())
            {
                UsersStatics us = new UsersStatics { Name = user.Name, Mark = user.Mark};

                db.Users.Add(us);

                db.SaveChanges();

                Console.WriteLine("Objects are successffully saved!");

                var uss = db.Users.ToList();
                foreach (UsersStatics u in uss)
                {
                    Console.WriteLine($"{u.Id} | {u.Name} | {u.Mark}");
                }
            }

            Console.ReadLine();
        }

    }
}
      
       