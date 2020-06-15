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

            Console.ReadLine();
        }

    }
}
      
       