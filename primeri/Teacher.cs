using System;
using System.Collections.Generic;
using System.Text;

namespace primeri
{
    public class Teacher
    {
        int count;
        int mark;
        public int Mark { get { return mark; } }
        public int Count { get { return count; } }
        int Counter { get; }
        List<string> signs = new List<string>();
        public void CheckTheTest(User user,Test test)
        {
            
            foreach (KeyValuePair<string, int> el in user.UserAnswersDict)
            {
                foreach (KeyValuePair<string, int> xl in test.QuestionsAnswers)
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

            PutMark(count);
        }
        public void PutMark(int count)
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

            

        }
    }
}
