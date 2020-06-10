using System;
using System.Collections.Generic;

namespace primeri
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] answers = { 2, 0, 1, 1 };
            string[] questions = { "1 + 1", "1 - 1", "1 * 1", "1 / 1" };
            List<string> signs = new List<string>();

            Dictionary<string, int> questions_answers = new Dictionary<string, int>();
            Dictionary<string, int> userAnswersDict = new Dictionary<string, int>();
            int[] userAnswers = new int[4];
            int mark;
            int count = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                questions_answers[questions[i]] = answers[i];
            }

           
            
            

            //Ask question
            StartTest(questions, userAnswersDict, userAnswers);
            //counts amount of right answers and put corresponding sign
            ShowData(signs);

            count = CountsRightAnswers(count, userAnswersDict, questions_answers, signs);
           
          
            //Put mark
            PutMark(count, out mark);
            
            //offer to show your work
            OfferToShowWork(questions, answers, signs, userAnswers);
            ShowData(signs);
            Console.ReadLine();
        }
        
        static void PutMark(int count, out int mark)
        {
            switch (count)
            {
                case 1:
                    mark = 3;
                    break;
                case 2:
                case 3:
                    mark = 4;
                    break;
                case 4:
                    mark = 5;
                    break;
                default:
                    mark = 2;
                    break;
            }

            Console.WriteLine($"Your mark is {mark}");

        }

        static void OfferToShowWork(string[] questions, int[] answers, List<string> signs, int[] userAnswers)
        {
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

        }

        static int CountsRightAnswers(int count, Dictionary<string,int> userAnswersDict, Dictionary<string,int> questions_answers, List<string> signs)
        {
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
            
            num++;
            Console.WriteLine($"Quantity of right answers: {count}");
            return count;

        }

        static void StartTest(string[] questions, Dictionary<string,int> userAnswersDict, int[] userAnswers)
        {
            int j = 0;
            int user_answer;
            while (j < questions.Length)
            {
                Console.WriteLine(j + 1 + ") " + questions[j] + " =\n");
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
                catch (OverflowException)
                {
                    Console.WriteLine("Number  is too big");
                }

            }
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