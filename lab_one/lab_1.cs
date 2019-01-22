using System;
using System.Collections.Generic;
using static System.Console;

namespace Lab_1
{
    //This program is a quiz application to asses the knowledge of .NET core

    class program
    {
        static void Main(string[] args)
        {
            //Array to hold the correct answers. Answer key: B, B, C, A, D, A, A, C, D, A
            string[] correctAnswers = new string[10] { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };

            //Array to hold users input and selection choice
            string[] userSelection = new string[10];
            

            //Array to hold the question for the quiz
            string[] quizQuestions = new string[10] {
                "Is .NET core open-source?",
                "Does .NET core support cross-platform scenarios?",
                "When was .NET core released?",
                "What is the current version of .NET core?",
                "How many cross-platform scenarios can .NET core support?",
                ".NET core was develope by:",
                "Which language is not supported by .NET core?",
                "Which language(s) was used to build .NET core?",
                ".NET core compatiable with:",
                "Which operating system is supported by .NET core?"
            };

            //Multi-dimensional array that holds options for each questions
            string[,] quizQuestionOptions =  {
                {"A) .NET core is not public yet", "B) Yes", "C) I don't know", "D) No"},
                {"A) Need permission from Microsoft for cross-platform", "B) Yes", "C) No", "D) In current development"},
                {"A) 2019", "B) 2003", "C) 2016", "D) 1990"},
                {"A) 2.2", "B) 1.5", "C) 0.7", "D) 6.4"},
                {"A) 2", "B) 1", "C) 0", "D) 4"},
                {"A) .NET Foundation", "B) Microsoft", "C) John Rollocks", "D) Apple"},
                {"A) Python", "B) C#", "C) F#", "D) Visual Basic"},
                {"A)C# ", "B) F#", "C) Both A & D", "D) C++"},
                {"A) Mono", "B) .NET Framwork", "C) Xamarin", "D) All of the above"},
                {"A) All of the below", "B) Windows", "C) Linux", "D) macOS"}
            };

            string selection;
            int start;
            int EXIT = -1;     //Sentinel Value

            //Lists to contain the correct selection and wrong selection
            List<string> correct = new List<string>();
            List<string> wrong = new List<string>();

            //Calls in another method/function
            start = greetings();

            //START While
            while (start != EXIT)
            {
                for (int x = 0; x < quizQuestions.Length; x++)
                {
                    Console.WriteLine(quizQuestions[x]);
                    for (int i = 0; i < quizQuestionOptions.GetLength(1); i++)
                    {
                        Console.WriteLine(quizQuestionOptions[x, i]);
                    }

                    Console.WriteLine("Please enter and option: ");
                    selection = ReadLine().ToUpper();

                    
                    userSelection[x] = selection;

                    //Need to determing if the user's selectio is the correct answer
                    if (selection == correctAnswers[x])
                        correct.Add(selection);
                    else
                        wrong.Add("Question: " + (x + 1) + ") " + selection);
                }
                Console.WriteLine("You answered " + correct.Count + " out of " + quizQuestions.Length);

                // Determing if they passed
                var results = (correct.Count >= 8) ? "You passed the assessment" : "You didnt pass the assessment";
                Console.WriteLine(results);

                //Output the wrong questions
                if (wrong.Count > 0)
                    Console.WriteLine("Listed below are the questions you got wrong.");
                wrong.ForEach(x => { Console.WriteLine(x); });

                //Clear both list
                wrong.Clear();
                correct.Clear();


                Console.WriteLine("To take the quiz again, enter any value other than -1. To exit enter -1.");
                string startAsString = ReadLine();
                start = Convert.ToInt32(startAsString);
            }

            //END While

            Console.WriteLine("Program has concluded");
        }

        static int greetings()
        {
            int start;
            Console.WriteLine("Welcome, this program will assess your knowledge of .NET core.");
            Console.WriteLine("To get started, please enter a number other than -1");
            string startAsString = ReadLine();
            start = Convert.ToInt32(startAsString);

            return start;
        }

    }
}