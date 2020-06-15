﻿using System;
using System.Collections.Generic;
using System.Text;

namespace primeri
{
    public class User
    {
        /*
        bool hasKnowledgeInMath;
        bool HasKnowledgeInMath { get; }

        int experience = 1;
        int Experience { get; }

        int mark;
        int Mark { get; }
        */

        Dictionary<string, int> userAnswersDict = new Dictionary<string, int>();
        int[] userAnswers = new int[4];

        public Dictionary<string, int> UserAnswersDict
        {
            get
            {
                return userAnswersDict;
            }
        }

        public int[] UserAnswers
        {
            get
            {
                return userAnswers;
            }
        }

        public void getUserAnswersDict()
        {
            Show(userAnswersDict);
        }

        public void getUsersAnswers()
        {
            Show(userAnswers);
        }

        public void TakeTheTest(Test test)
        {
            int j = 0;
            int user_answer;
            while (j < test.Questions.Length)
            {
                Console.WriteLine(j + 1 + ") " + test.Questions[j] + " =\n");
                try
                {
                    user_answer = Convert.ToInt32(Console.ReadLine());
                    userAnswersDict[test.Questions[j]] = user_answer;
                    userAnswers[j] = user_answer;
                    j++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter number!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is too big");
                }

            }
        }
        public void ShowTheResult(Teacher teacher) {
            Console.WriteLine();
            Console.WriteLine($"All: {UserAnswers.Length}\n"+
                $"Right: {teacher.Count}\nWrong: {UserAnswers.Length-teacher.Count}\n" + 
                $"Mark is {teacher.Mark}"
                ); }

        public void Show(int[] array)
        {
            foreach (int elem in array)
            {
                Console.WriteLine(elem);
            }
        }
        public void Show(Dictionary<string, int> QuestionsAnswers)
        {
            foreach (KeyValuePair<string, int> elem in QuestionsAnswers)
            {
                Console.WriteLine(elem);
            }
        }





    }
}