using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            int secretNum = new Random().Next(0, 100);;

            int index = 0;

            bool isAnswerFound = false;

            bool isDifficultyCorrect = false;

            while(!isDifficultyCorrect)
            {
            Console.WriteLine("Hello! Choose diffuclty: easy, medium, hard, or cheater");

            string difficulty = Console.ReadLine();

            

            if(difficulty == "easy")
            {
                index = 8;
                isDifficultyCorrect = true;
            }
            else if(difficulty == "medium")
            {
                index = 6;
                isDifficultyCorrect = true;
            }
            else if(difficulty == "hard")
            {
                index = 4;
                isDifficultyCorrect = true;
            }
            else if(difficulty == "cheater")
            {
                index =  80;
                isDifficultyCorrect = true;
            }
            else
            {
                Console.WriteLine("that is not a difficulty. Please try again.");
            }
            }
            
            while ( index > 0 && !isAnswerFound) 
            {
            

            Console.WriteLine("Hello! Guess the secret number!");

            Console.Write($"Current guess {index}:");

            int guess = int.Parse(Console.ReadLine());
            
            index = index - 1;

            if(guess == secretNum)
            {
                Console.WriteLine("You Guessed it");
                isAnswerFound = true;
            }
            else if(guess > secretNum)
            {
               
                Console.WriteLine("Please try again, your guess is too high");
            }
            else if(guess < secretNum)
            {
                Console.WriteLine("Please try again, your guess is too low");
            }
            }
        }
    }
}
