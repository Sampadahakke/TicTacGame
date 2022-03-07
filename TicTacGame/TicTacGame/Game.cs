using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacGame
{
    internal class Game
    {
        public static void Board()
        {
            char[] board = new char[10];
            for (int i = 1;i<10; i++)
            {
                Console.WriteLine(board[i]=' ');
            }
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Player 1 is playing with X char and player 2 is playing with O char");
            Console.WriteLine("Player 1");
            Console.Write("Please enter the input= ");
            char input1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Player 2");
            Console.Write("Please enter the input= ");
            char input2 = char.Parse(Console.ReadLine());   
        }

    }
}
