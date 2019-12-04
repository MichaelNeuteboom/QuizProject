using System;
namespace QuizProject
{
    public class Question
    {
        public string Text { get; set; }
        public string Answer { get; set; }
        public string Category { get; set; }
        public int Level { get; set; }





        public bool checkAnswer(String response)
        {
            
            return response.Equals(Answer);
        }
   
        public virtual void display()
        {
            Console.WriteLine(Text);
            
        }
    }
}
