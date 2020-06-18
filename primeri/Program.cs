using System;
using System.Collections.Generic;

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

            UsersStatics us = new UsersStatics(user);
            Console.WriteLine("ID | Name | Mark");
            Console.WriteLine($"{us.Id} | {us.Name} | {us.Mark} ");
           
           
            

            Console.ReadLine();
        }

    }
}
      
       