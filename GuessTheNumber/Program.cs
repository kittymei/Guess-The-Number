using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to \"Guess the Number Game\"!");
            Console.WriteLine("---------------------------------------------------------");
            PlayerMode();
        }

        public static void PlayerMode()
        {
            int ModeChoice;

            Console.WriteLine("\t1 = Human Player");
            Console.WriteLine("\t2 = Computer Player");
            Console.WriteLine("\t3 = Bisectional Algorithm");
            Console.Write("Select the player mode from above: ");
            ModeChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------");

            if (ModeChoice == 1)
            {
                HumanPlayer();
            }
            else if (ModeChoice == 2)
            {
                ComputerPlayer();
            }
            else if (ModeChoice == 3)
            {

            }
            else
            {
                Console.WriteLine("ERROR! Enter a valid mode");
                Console.WriteLine("---------------------------------------------------------");

                PlayerMode();
            }
        }
        public static void HumanPlayer()
            {
                Random num = new Random();
                int RandomNum = num.Next(1, 1000);
                int UserGuess = 0;
                int AllowedTries = 10;
                int NumOfTries = 0;

                Console.WriteLine("You selected the Human Player mode. \nRULES: The computer will generate a random number between 1-1000 and you will have 10 attempts to guess that number");
                Console.WriteLine("---------------------------------------------------------");

            while (UserGuess != RandomNum)
                {
                    NumOfTries++;

                    Console.Write("\nEnter a guess between 1-1000: ");
                    UserGuess = Convert.ToInt32(Console.ReadLine());

                    if (UserGuess > RandomNum)
                    {
                        Console.WriteLine("\nYou guessed " + UserGuess);
                        Console.WriteLine("Enter a SMALLER number");
                    }

                    if (UserGuess < RandomNum)
                    {
                        Console.WriteLine("\nYour guess: " + UserGuess);
                        Console.WriteLine("Enter a BIGGER number");
                    }
                    if (UserGuess == RandomNum)
                    {
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine("\nYou guessed " + UserGuess);
                        Console.WriteLine($"Congrats! Your guess of {RandomNum} was the correct number");
                        break;
                    }
                    if (AllowedTries == NumOfTries)
                    {
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine("\nSorry you lost. The random generated number is " + RandomNum);
                        break;
                    }
                    Console.WriteLine($"\nNumber of guesses left {AllowedTries - NumOfTries}");
                    Console.WriteLine("---------------------------------------------------------");
                }
            }

        public static void ComputerPlayer()
        {
            string help;
            Random num = new Random();
            int ComputerGuess = num.Next(1, 100);
            int MinNum = 1;
            int MaxNum = 100;
            int NumISelected = 50;
            int NumOfTries = 0;
            int AllowedTries = 10;
            int number = 16;

            Console.WriteLine("You selected the Computer Mode. \nRULES: You will pick a number between 1-100 and the computer will guess your number.");
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Hello! My name is Dell");

            Console.WriteLine("\nThroughout the game please respond with one of the options below to help me guess your number");
            Console.WriteLine("\tToo high");
            Console.WriteLine("\tToo Low");
            Console.WriteLine("\tWINNER!");
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine($"Dell's guesses {ComputerGuess}");

            Console.Write("\nHINT: Your guess is ");

            help = Console.ReadLine();

            while (NumISelected != ComputerGuess)
            {
                NumOfTries++;

                if (help.ToLower() == "too high")
                {
                    Console.WriteLine("---------------------------------------------------------");

                    Console.WriteLine($"Dell's next guess is {ComputerGuess}");
                    break;

                }
                else if (help.ToLower() == "too low")
                {
                    Console.WriteLine("---------------------------------------------------------");

                    Console.WriteLine($"Dell's next guess is {ComputerGuess}");
                    break;

                }
                else if (help.ToLower() == "winner!")
                {
                    Console.WriteLine("---------------------------------------------------------");
                }
                if (AllowedTries == NumOfTries)
                {
                    Console.WriteLine("---------------------------------------------------------");
                    break;
                }
                Console.WriteLine($"\nNumber of guesses left {AllowedTries - NumOfTries}");
                Console.WriteLine("---------------------------------------------------------");
            }
        }

        }
    }
