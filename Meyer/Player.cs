using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyer
{


    class Player
    {
        public string[] playerNames;
        public void Players()
        {
            //Create players
            Console.WriteLine("Enter the numbers of players 2+ ");

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
        }

        //public void PlayerTurn()
        //{
        //}
        public void PLayerChoice()
        {
            for (int i = 0; i < playerNames.Length; i++)
            {
                if (i == +i)
                {
                    Console.WriteLine(playerNames[i] + " What are you going to do");
                }
                
                Console.ReadKey();
            }
        }
    }
}
