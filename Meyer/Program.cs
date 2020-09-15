using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Meyer
{
    class Program
    {
        public static string[] playerNames;


        static void Main(string[] args)
        {


            Console.WriteLine("Enter the number of players "
                + "2 " + "3 " + "4 " + "5 " + "6 " + "7 " + "8 ");

            int amount = Int32.Parse(Console.ReadLine());
            if (amount <= 1)
            {
                Console.WriteLine("Minimum two players!");
            }
            else
            {
                playerNames = new string[amount];
                for (int i = 0; i < playerNames.Length; i++)
                {
                    Console.WriteLine("Insert player " + (i + 1) + " name");
                    playerNames[i] = Console.ReadLine();
                    Console.Clear();
                }
            }
            StartGame();



            Console.ReadKey();
        }

        public static int StartGame()
        {
            while (true)
            {

                for (int i = 0; i < playerNames.Length; i++)
                {

                    Console.WriteLine(playerNames[i] + " Press any key to roll");
                    Console.ReadKey();

                    int[] numberOptions = new int[21] { 32, 41, 42, 43, 51, 52, 53, 54, 61, 62, 63, 64, 65, 11, 22, 33, 44, 55, 66, 13, 12 };

                    Random r = new Random();

                    int randomIndex = r.Next(0, 21);

                    int randomNumber = numberOptions[randomIndex];


                    switch (randomNumber)
                    {
                        case 32:
                            randomNumber = 32;
                            Console.WriteLine("Hit a " + randomNumber + " Fællesskål!");
                            break;
                        case 41:
                            randomNumber = 41;
                            Console.WriteLine("Hit a " + randomNumber);
                            break;
                        case 42:
                            randomNumber = 42;
                            Console.WriteLine("Hit a " + randomNumber);
                            break;
                        case 43:
                            randomNumber = 43;
                            Console.WriteLine("Hit a " + randomNumber);
                            break;
                        case 51:
                            randomNumber = 51;
                            Console.WriteLine("Hit a " + randomNumber);
                            break;
                        case 52:
                            randomNumber = 52;
                            Console.WriteLine("Hit a " + randomNumber);
                            break;
                        case 53:
                            randomNumber = 53;
                            Console.WriteLine("Hit a " + randomNumber);
                            break;
                        case 54:
                            randomNumber = 54;
                            Console.WriteLine("Hit a " + randomNumber);
                            break;
                        case 61:
                            randomNumber = 61;
                            Console.WriteLine("Hit a " + randomNumber);
                            break;
                        case 62:
                            randomNumber = 62;
                            Console.WriteLine("Hit a " + randomNumber);
                            break;
                        case 63:
                            randomNumber = 63;
                            Console.WriteLine("Hit a " + randomNumber);
                            break;
                        case 64:
                            randomNumber = 64;
                            Console.WriteLine("Hit a " + randomNumber);
                            break;
                        case 65:
                            randomNumber = 65;
                            Console.WriteLine("Hit a " + randomNumber);
                            break;
                        case 11:
                            randomNumber = 11;
                            Console.WriteLine("Hit a " + randomNumber + " Par 1'er!");
                            break;
                        case 22:
                            randomNumber = 22;
                            Console.WriteLine("Hit a " + randomNumber + " Par 2'er!");
                            break;
                        case 33:
                            randomNumber = 33;
                            Console.WriteLine("Hit a " + randomNumber + " Par 3'er!");
                            break;
                        case 44:
                            randomNumber = 44;
                            Console.WriteLine("Hit a " + randomNumber + " Par 4'er!");
                            break;
                        case 55:
                            randomNumber = 55;
                            Console.WriteLine("Hit a " + randomNumber + " Par 5'er!");
                            break;
                        case 66:
                            randomNumber = 66;
                            Console.WriteLine("Hit a " + randomNumber + " Par 6'er!");
                            break;
                        case 13:
                            randomNumber = 13;
                            Console.WriteLine("Hit a " + randomNumber + " Lille Meyer!");
                            break;
                        case 12:
                            randomNumber = 12;
                            Console.WriteLine("Hit a " + randomNumber + " Meyer!");
                            break;

                    }
                    Console.ReadKey();
                    Console.Clear();

                    if (i == playerNames.Length - 1)
                    {
                        Console.WriteLine(playerNames[i - i] + " What are you going to do");

                    }
                    else

                    {
                        Console.WriteLine(playerNames[i + 1] + " What are you going to do");

                    }
                    Console.WriteLine("Press 1 to trust!");
                    Console.WriteLine("Press 2 to dont believe");



                    // FIX OPTION ONE!!! IT TAKES THE SAME PLAYER AGIAN IT SHOULD TAKE THE NEXT PLAYER!
                    int userInput = Int32.Parse(Console.ReadLine());
                   if (userInput == 1)
                    {
                        Console.Clear();
                    }
                    else if (userInput == 2)
                    {
                        Console.WriteLine(playerNames[i] + " Slog " + randomNumber);
                        Console.ReadKey();
                        Console.Clear();
                    }
                   
                    Console.ReadKey();
                }

            }
        }
    }
}

//if (randomNumber == 32)
//{
//    Console.WriteLine("Hit a " + randomNumber + " Fællesskål");
//}
//else if (randomNumber == 11)
//{
//    Console.WriteLine("Hit a " + randomNumber + " Par 1'er");
//}