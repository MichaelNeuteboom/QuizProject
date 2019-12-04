using System;
using System.Collections.Generic;

namespace QuizProject
{
    public class ChoiceQuestion : Question {
        private List<String> _Choices = new List<string>();
        public List<String> Choices { get { return _Choices; } set { _Choices = value; } }


        public override void display()
        {
            Console.WriteLine(Text);
                for (int i = 0; i < Choices.Count; i++)
            {
                int choiceNumber = i + 1;
                
                Console.WriteLine(choiceNumber + ": " + Choices[i]);
                
            }
        }
    }
}
