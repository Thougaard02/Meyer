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
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Players();         
            player.PLayerChoice();
            //DiceRoll roll = new DiceRoll();
            //roll.DiceGenerator();
        }

    }
}