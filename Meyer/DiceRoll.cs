using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Meyer
{
    class DiceRoll
    {

        public string DiceGenerator()
        {
            Random rd = new Random();

            int firstDice = rd.Next(1, 7);
            int secondDice = rd.Next(1, 7);

            Console.WriteLine(firstDice);
            Console.WriteLine(secondDice);

            string result = Convert.ToString(firstDice + secondDice);


            return result;
        }
    }
}
