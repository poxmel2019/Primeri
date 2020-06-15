using System;
using System.Collections.Generic;
using System.Text;

namespace primeri
{
    public class Test
    {
        int[] answers = { 2, 0, 1, 1 };
        string[] questions = { "1 + 1", "1 - 1", "1 * 1", "1 / 1" };
        Dictionary<string, int> questionsAnswers = new Dictionary<string, int>();
        List<string> signs = new List<string>();

        public Test()
        {
            DoAccordance(questionsAnswers,questions,answers);
        }


        //for work
        public int[] Answers
        {
            get
            {
                return answers;
            }
        }
        public string[] Questions
        {
            get
            {
                return questions;
            }
        }

        public Dictionary<string, int> QuestionsAnswers
        {
            get
            {
                return questionsAnswers;
            }
        }

        
        //for logs
        public void getAnswers()
        {
            Show(answers);
        }
        public void getQuestions()
        {
            Show(questions);
        }
        public void getQuestionsAnswers()
        {
            Show(questionsAnswers);
        }

        public void DoAccordance(Dictionary<string, int> questionsAnswers, string[] questions, int[] answers)
        {
            for (int i = 0; i < questions.Length; i++)
            {
                questionsAnswers[questions[i]] = answers[i];
            }

        }
        public void Show(int[] array)
        {
            foreach(int elem in array)
            {
                Console.WriteLine(elem);
            }
        }
        public void Show(string[] array)
        {
            foreach (string elem in array)
            {
                Console.WriteLine(elem);
            }
        }
        public void Show(Dictionary<string,int> QuestionsAnswers)
        {
            foreach(KeyValuePair<string,int> elem in QuestionsAnswers)
            {
                Console.WriteLine(elem);
            }
        }

    }
}
