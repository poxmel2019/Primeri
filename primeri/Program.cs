using System;
using System.Collections.Generic;

namespace primeri
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer;
            string[] exercises = { "1 + 1", "1 - 1", "1 * 1", "1 / 1" };
            int[] rightAnswersInt = { 2, 0, 1, 1 };
            string[] userAnswers = new string[exercises.Length];
            string[] isRight = new string[exercises.Length];
            
            int handledAnswer = 0;
            bool enabled = true;
            int counter = 0;
            int game = 0;

            Dictionary<string, int> quan = new Dictionary<string, int>();

            for(int i = 0; i < exercises.Length; i++)
            {
                quan.Add(exercises[i], rightAnswersInt[i]);  
            }
            Array.Sort(exercises);
            //ShowCol(quan);
            
            while (enabled)
            {
                int count = 0;
                game++;
                for (int i = 0; i < exercises.Length; i++)
                {
                    while (true)
                    {
                        Console.WriteLine($"{i + 1}) " + exercises[i] + " = ");
                        userAnswer = Console.ReadLine();
                        try
                        {
                            handledAnswer = Convert.ToInt32(userAnswer);
                            userAnswers[i] = userAnswer;
                            // correctness of user answer
                            foreach (KeyValuePair<string, int> el in quan)
                            {
                                if (exercises[i] == el.Key)
                                {
                                    if (handledAnswer == el.Value)
                                    {
                                        isRight[i] = "Correct";
                                        count++;
                                        break;
                                    }
                                    else isRight[i] = "Incorrect";
                                }
                            }
                            break;
                        }
                        catch (FormatException)
                        {
                            if (userAnswer == "") Console.WriteLine("You entered nothing");
                            else Console.WriteLine("Asnwer should be number");
                        }
                    }
                }
                if (count == rightAnswersInt.Length) counter++;

                Console.WriteLine("Right answers: " + count);

                Console.WriteLine("Wrong answers: " + (exercises.Length - count));

                string showWork;
                string someResult = "";

                while (true)
                {
                    Console.WriteLine("Do you want to see your work?");
                    showWork = Console.ReadLine();
                    if (showWork == "y")
                    {
                        for (int i = 0; i < exercises.Length; i++)
                        {
                            if (isRight[i] == "Incorrect") someResult = $"Right answer: {rightAnswersInt[i]}";
                            else someResult = "";
                            Console.WriteLine($"{i + 1}) {exercises[i]} = {userAnswers[i]} {isRight[i]}. {someResult}");
                        }
                        break;
                    }
                    else if (showWork == "n") break;
                }

                while (true)
                {
                    Console.WriteLine("Again?");
                    string again = Console.ReadLine();
                    if (again == "y") break;
                    else if (again == "n") 
                        {
                        enabled = false;
                        Console.WriteLine($"Played games: {game}\n" +
                            $"Win: {counter} \nLoses: {game - counter}");
                        Console.WriteLine("Buy!");
                        break;
                        }
                }


            }

            Console.ReadKey();

        }
        static void ShowCol(string[] array)
        {
            foreach (string el in array)
            {
                Console.WriteLine(el);
            }
        }
        static void ShowCol(Dictionary<string,int> array)
        {
            foreach (KeyValuePair<string,int> el in array)
            {
                Console.WriteLine(el.Key + " " + el.Value);
            }
        }
    }
}

