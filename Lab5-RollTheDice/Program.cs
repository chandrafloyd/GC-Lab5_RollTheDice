using System;

namespace Lab5_RollTheDice
{
    class Program
    {
        static void Main(string[] args)  //MAIN
        {
            //OBJECTIVE
            //Create an application that simulates dice rolling

            //WELCOME
                 Console.WriteLine("Welcome to the Casino!");

            //PLAY OR END GAME?
                bool EndGame = false;  //start with EndGame set to false in order to play the game

                Console.WriteLine("Would you like to roll the dice? Y/N ");
                string RollDice = Console.ReadLine();


            //DON'T ROLL THE DICE - END GAME
            if (RollDice == "N")
            {
                EndGame = true;  //set EndGame to true in order to exit
                Console.WriteLine("Thanks for playing! Goodbye!");
            }

            //YES, ROLL THE DICE - PLAY THE GAME
            else
            {
                EndGame = false;          //set to true for initial execution and to repeat

                while (EndGame == false)   //do this as long as ContinueProgram is set to true 
                {
                    //INPUT - define variables for user input, methods, interim calculations, results  //the while will loop back to here
                    Console.WriteLine("How many sides are there on each die?");  //this sets NumberSides as the parameters for random numbers 
                    int NumberSides = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ok, let's play now!");

                    //PROCESS - random number generator 

                    Random RandomDice1 = new Random();
                    Random RandomDice2 = new Random();
                    int RandomNumber1 = RandomDice1.Next(2, NumberSides);
                    int RandomNumber2 = RandomDice2.Next(2, NumberSides);

                    //OUTPUT

                    Console.WriteLine("You rolled a RandomNumber " + RandomNumber1 + " and a " + RandomNumber2 + "!");


                    //PLAY OR END GAME?
                    Console.WriteLine("Continue? Y/N");
                    string Continue = Console.ReadLine();

                    if (Continue == "N")   //if continue = N, End the game
                    {
                        EndGame = true;  //set EndGame to true in order to end the loop and exit
                        Console.WriteLine("Thanks for playing!");
                    }
                    else                   //if continue = Y, continue/play again
                    {
                        EndGame = false;
                        Console.WriteLine("Ok let's play again!");
                        Console.Clear();
                    }

                }
            }
            
        }

    }
}
