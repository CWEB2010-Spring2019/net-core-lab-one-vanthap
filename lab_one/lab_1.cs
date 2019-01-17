using System;
using System.Collections.Generic;

namespace Lab_1
{
    class program
    {
        static void Main(string[] args)
        {
            //Declaring an array that holds correctAnswers
            string correctAnswers = new string[10] { "B", "B", "C", "A", "D", "A", "A", "C", "D", "A" };

            //An array for end-users selection
            string userSelection = new string[10];

            //Declare an array that holds the questions
            string quizQuestions = new string[10] { "Is .NET core open-source?", "Does .NET core support cross-platform scenarios?", "When was .NET core released?", "What is the current version of .NET core?", "How many cross-platform scenarios can .NET core support?" };

            //Declare a Multi-dimensional array that holds options for each questions
            string quizQuestionOptions = new string[,]  {
                {"A) .NET core is not public yet", "B) Yes", "C) I don't know", "D) No"},
                {"A) Need permission from Microsoft for cross-platform", "B) Yes", "C) No", "D) In current development"},
                {"A) 2019", "B) 2003", "C) 2016", "D) 1990"},
                {"A) 2.2", "B) 1.5", "C) 0.7", "D) 6.4"},
                {"A) 2", "B) 1", "C) 0", "D) 4"},
                {"AA) ", "B) ", "C) ", "D) "},
                {"AA) ", "B) ", "C) ", "D) "},
                {"A) ", "B) ", "CC) ", "D) "},
                {"A) ", "B) ", "C) ", "DD) "},
                {"AA) ", "B) ", "C) ", "D) "},
            };

            string selection;
            string num = start;

            string num = EXIT[-1];     //Sentinel Value

            List<string> correct = new List<string>();
            List<string> wrong = new List<string>();

            Console.WriteLine("Welcome, this program will assess your knowledge of .NET core");
            Console.WriteLine("To get started, please enter a number other than -1 to start the program");
            userInput = Console.ReadLine();
            int x = Int32.Parse(Console.ReadLine());

            while (start() != EXIT()) ;


                for (num x = 0; x < quizQuestions.Length; x++) {

                    Console.WriteLine(quizQuestions[10]);
                    for (num i = 0; i < quizQuestionOptions.GetLength(0); i++) {
                        Console.WriteLine(quizQuestionOptions[x, i])
                        };

                    Console.WriteLine("Please enter an option");
                    userInput = selection();
                    userSelection[x] = selection;

                    //Need to determind if the user's selection is the correct answer
                    if (selection == correctAnswers[x]) {
                        correct.Add(selection);
			        else
				        wrong.Add(selection); }


                    string wrong.Clear
                    string correct.Clear

                }

                Console.WriteLine("You answered " + correct.Count + " out of " + quizQuestionOptions.Length);

                //Determind if they passed
                var results = (correct.Count >= 1) ? "You passed the assesment" : "You didn't pass";

                //OUTPUT the wrong questions
                Console.WriteLine("Listed below are the questions you got wrong");
                Console.WriteLine(wrong.ForEach(x => { x} ));



                Console.WriteLine("To take the quiz again, enter any value other than -1. To exit enter -1");
                INPUT start

            //ENDWHILE

            Console.WriteLine("Program has concluded");
        }

    }
}