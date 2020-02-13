﻿using System;
using System.Collections.Generic;

namespace primeri
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer;
            string[] exercises = { "1 + 1","1 - 1","1 * 1","1 / 1"};
            string[] rightAnswers = { "2", "0", "1", "1" };
            int[] rightAnswersInt = { 2,0,1,1 };
            int count = 0;
            int handledAnswer = 0;
            Dictionary<string, int> exercises2 = new Dictionary<string, int>();
            
            for(int i = 0; i < exercises.Length; i++)
            { 
                while (true)
                {
                    Console.WriteLine($"{i + 1}) " + exercises[i] + " = ");
                    userAnswer = Console.ReadLine();
                    try {
                        handledAnswer = Convert.ToInt32(userAnswer);
                        
                        if (handledAnswer == rightAnswersInt[i]) { count++; }
                        break;
                    }
                    catch (FormatException e)
                    {
                        if (userAnswer == "") Console.WriteLine("You entered nothing");
                        else Console.WriteLine("Asnwer should be number");
                    }
                    
                    
                    

                }



            }

            Console.WriteLine("Right answers: " + count);
            Console.WriteLine("Wrong answers: " + (exercises.Length-count));


            Console.ReadKey();

        }
        static void ShowCol(string[] array)
        {

        }
    }
}
