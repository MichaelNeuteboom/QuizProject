using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Question> questionsList = new List<Question>() {
                new Question() { Text ="Who was the inventor of Java?",Answer = "James Gosling", Category = "Knowledge",Level = 4 },
                new ChoiceQuestion() { Text = "In which country was the inventor of Java born?", Answer = "Canada", Choices = { "Australia", "Canada", "Denmark", "United States" }, Category = "Knowledge", Level = 2 }
             };


            IEnumerable<Question> result = questionsList.Where(s => s.Category== "Knowledge");
            IEnumerable<Question> OrderdResult = result.OrderBy(p=> p.Level);
            foreach(var r in OrderdResult){
                presentQuestion(r);

            }
           // presentQuestion(questions[0]);
            //presentQuestion(questions[1]);
        }

        public static void presentQuestion(Question q)
        {
            q.display();

            Console.WriteLine("Your answer: ");
            String response = Console.ReadLine();
            Console.WriteLine(q.checkAnswer(response));
        }
    }
}
