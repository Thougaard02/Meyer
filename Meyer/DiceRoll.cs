using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyer
{
    class DiceRoll
    {

        public void DiceGenerator()
        {
            Random rd = new Random();

            while (true)
            {
                int firstDice = rd.Next(1, 7);
                int secondDice = rd.Next(1, 6);

                Console.WriteLine(firstDice);
                Console.WriteLine(secondDice);

            Console.ReadKey();
            }
        }
    }
}
