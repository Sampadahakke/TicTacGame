using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome to Tic Tac Toe Game=========");
            Game.Board();
            Game.GetInput();
            Console.ReadLine();
        }
    }
}
