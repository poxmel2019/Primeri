using System;
using System.Collections.Generic;

namespace primeri
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> questions = new List<string> { "1 + 1", "1 - 1", "1 * 1", "1 / 1" };
            List<int> answers = new List<int> { 2, 0, 1, 1 };
            List<string> signs = new List<string>();

            Dictionary<string, int> questions_answers = new Dictionary<string, int>();
            Dictionary<string, int> userAnswersDict = new Dictionary<string, int>();
            int[] userAnswers = new int[4];

            for (int i = 0; i < questions.Count; i++)
            {
                questions_answers[questions[i]] = answers[i];
            }

            int j = 0;
            int user_answer;

            while (j < questions.Count)
            {
                Console.WriteLine(questions[j] + " =\n");
                try
                {
                    user_answer = Convert.ToInt32(Console.ReadLine());
                    userAnswersDict[questions[j]] = user_answer;
                    userAnswers[j] = user_answer;
                    j++;
                }
                catch (FormatException)
                {

                    Console.WriteLine("Enter number!");
                }

            }



            int count = 0;
            foreach (KeyValuePair<string, int> el in userAnswersDict)
            {
                foreach (KeyValuePair<string, int> xl in questions_answers)
                {
                    if (el.Key == xl.Key)
                    {
                        if (el.Value == xl.Value)
                        {
                            count++;
                            signs.Add("+");
                        }
                        else
                        {
                            signs.Add("-");
                        }
                    }
                }
            }




            Console.WriteLine($"Quantity of right answers: {count}");

            switch (count)
            {
                case 1:
                    Console.WriteLine("Your mark is 3");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Your mark is 4");
                    break;
                case 4:
                    Console.WriteLine("Your mark is 5");
                    break;
                default:
                    Console.WriteLine("Your mark is 2");
                    break;
            }

            while (true)
            {
                Console.WriteLine("Do you want to see your work?");
                string seeWork = Console.ReadLine();
                if (seeWork == "y" || seeWork == "yes")
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine($"{i + 1}) {questions[i]} = {userAnswers[i]} {signs[i]} {answers[i]}");
                    }
                    break;
                }
                else if (seeWork == "n" || seeWork == "no")
                {
                    Console.WriteLine("Buy!");
                    break;
                }
            }

            Console.ReadLine();
        }
        static void ShowData(List<string> array)
        {
            foreach (string el in array)
            {
                Console.WriteLine(el);
            }
        }
        static void ShowData(List<int> array)
        {
            foreach (int el in array)
            {
                Console.WriteLine(el);
            }
        }
        static void ShowData(Dictionary<string, int> array)
        {
            foreach (KeyValuePair<string, int> el in array)
            {
                Console.WriteLine(el.Key + " - " + el.Value);
            }
        }
    }
}