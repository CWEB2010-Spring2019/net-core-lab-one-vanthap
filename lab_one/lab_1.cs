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

            //Array to hold user's input and selection choice
            string[] userSelection = new string[10];

            //Array to hold the question for the quiz
            string[] quizQuestions = new string[10] {
                "Is .NET core open-source?",
                "Does .NET core support cross-platform scenarios?",
                "When was .NET core released?",
                "What is the current version of .NET core?",
                "How many cross-platform scenarios can .NET core support?",
                "",
                "",
                "",
                "",
                ""
            };

            //Multi-dimensional array that holds options for each questions
            string[,] quizQuestionOptions =  {
                {"A) .NET core is not public yet", "B) Yes", "C) I don't know", "D) No"},
                {"A) Need permission from Microsoft for cross-platform", "B) Yes", "C) No", "D) In current development"},
                {"A) 2019", "B) 2003", "C) 2016", "D) 1990"},
                {"A) 2.2", "B) 1.5", "C) 0.7", "D) 6.4"},
                {"A) 2", "B) 1", "C) 0", "D) 4"},
                {"AA) ", "B) ", "C) ", "D) "},
                {"AA) ", "B) ", "C) ", "D) "},
                {"A) ", "B) ", "CC) ", "D) "},
                {"A) ", "B) ", "C) ", "DD) "},
                {"AA) ", "B) ", "C) ", "D) "}
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
                for (num x = 0; x < quizQuestions.Length; x++)
                {

                    Console.WriteLine(quizQuestions[10]);
                    for (num i = 0; i < quizQuestionOptions.GetLength(0); i++)
                    {
                        Console.WriteLine(quizQuestionOptions[x, i]);
                    }

                    Console.WriteLine("Please enter an option:");
                    selection = ReadLine();
                    userSelection[x] = selection;

                    //If statement to determind if the selection was correct or wrong
                    if (selection == correctAnswers[x])
                        correct.Add(selection);

                    else
                        wrong.Add("Question: " + (x + 1) + selection);

                    wrong.Clear;
                    correct.Clear;
                }
            }
            //END While

            //Output their score out of 10
            Console.WriteLine("You answered " + correct.Count + " out of " + quizQuestionOptions.Length);

            //Determind if they passed
            var results = (correct.Count >= 1) ? "You passed the assesment" : "You didn't pass";

            //Output the questions they got wrong
            Console.WriteLine("Listed below are the questions you got wrong");
            wrong.ForEach(x => { Console.WriteLine(x); });

            Console.WriteLine("To take the quiz again, enter any value other than -1. To exit enter -1");
            start = ReadLine();

            Console.WriteLine("Program has concluded");
        }

    }
}