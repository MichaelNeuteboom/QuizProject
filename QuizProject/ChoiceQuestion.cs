using System;
using System.Collections.Generic;

namespace QuizProject
{
    public class ChoiceQuestion : Question
    {
        private List<String> choices;
        public ChoiceQuestion()
        {
            choices = new List<String>();
        }
        public void addChoice(String choice, bool correct)
        {
            
            choices.Add(choice); if (correct)
            {
        // Convert choices.size() to string
        String choiceString = "" + choices.Count; setAnswer(choiceString);
            }
        }
        public void display()
        {
            // Display the question text super.display();
            // Display the answer choices
            for (int i = 0; i < choices.Count; i++)
            {
                int choiceNumber = i + 1;
                Console.WriteLine(choiceNumber + ": " + choices[i]);
                
            }
        }
    }
}
