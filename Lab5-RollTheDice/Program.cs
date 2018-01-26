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
                Console.WriteLine("Would you like to roll the dice? Y/N ");

            //PLAY OR END GAME?
                bool EndGame = false;  //start with EndGame set to false; aka play the game
                string RollDice = Console.ReadLine();
                if (RollDice == "N")
                    {
                        EndGame = true;  //set EndGame to true in order to exit
                        Console.WriteLine("Thanks for playing!");
                
                        // **** how to exit? it continues after this line
                    }



            //INPUT - define variables for user input, methods, interim calculations, results
                Console.WriteLine("How many sides are there one each die?");
                int NumberSides = int.Parse(Console.ReadLine());
                Console.WriteLine("Ok let's play now!");
                
                
            //WHILE - execute as long as condition is true
                EndGame = false;                //set to true for initial execution and to repeat
                while (EndGame==false)          //do this as long as ContinueProgram is set to true 
                
                    {
                //PROCESS - RANDOM NUMBER GENERATOR -- the while will loop back to here
                //for, if/else, call methods, cwl the output, define what makes EndGame true

                
                        ///THIS code doesnt work; repeats numbers
                        //Random random = new Random();
                        //int randomNumber = random.Next(0, 10);
                        //Console.WriteLine(random);

                        ///THIS code doesnt work; repeats numbers
                        //Random rnd = new Random();
                        //int dice1 = rnd.Next(1, 13); // creates a number between 1 and 12
                        //int dice2 = rnd.Next(1, 7);   // creates a number between 1 and 6


                        //DOESNT WORK
                        //Function to get random number private static readonly 
                        //Random getrandom = new Random();
                        //public static int GetRandomNumber(int min, int max) { lock(getrandom ) {

                        // synchronize 
                        //        return getrandom.Next(min, max); } 



                Random RandomDice1 = new Random();

                int Goal = RandomDice1.Next(1, 8);
                string Input;

                int Guess = 0;
                while (Guess != Goal)
                    {
                    Console.WriteLine("Give me a number between 1 and 8:");
                    Input = Console.ReadLine();
                    Guess = Convert.ToInt32(Input);

                }
                //OUTPUT
                Console.WriteLine("Congrats! You rolled " + Guess + "!");
                

                    }

            //PLAY OR END GAME?
            Console.WriteLine("Continue? Y/N");
                string Continue = Console.ReadLine();

                    if (Continue == "Y")
                    {
                        EndGame = false;  
                        Console.WriteLine("Ok let's play again!");
                    }

                    else
                    {
                        EndGame = true;  //set EndGame to true in order to end the loop and exit
                        Console.WriteLine("Thanks for playing!");
                    }
 
        }

    }

   // class Random  //insert random number generator
    //{


    //    public int RollDice()  //METHOD TO GENERATE RANDOM NUMBERS
    //    {
    //        int dice1, dice2;
    //        Console.WriteLine(" ");
    //    }

    //}
}
