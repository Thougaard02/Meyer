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

                    if (randomNumber == 32)
                    {
                        Console.WriteLine("Hit a " + randomNumber + " Fællesskål");
                    }


                    Console.WriteLine("Hit a " + randomNumber);
                    Console.ReadKey();
                }


            }
        }
    }
}
