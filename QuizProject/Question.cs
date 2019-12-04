using System;
namespace QuizProject
{
    public class Question
    {
        private string text;
        private string answer;
      public Question()
        {
            text = "";
            answer = "";
        }

        public void setText(String questionText)
        {
            text = questionText;
        }
    
        public void setAnswer(String correctResponse)
        {
            answer = correctResponse;
        }
    
        public bool checkAnswer(String response)
        {
            
            return response.Equals(answer);
        }
   
        public void display()
        {
            Console.WriteLine(text);
            
        }
    }
}
