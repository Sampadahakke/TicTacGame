﻿using System;
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
            for (int i = 0;board.Length > 0; i++)
            {
                Console.WriteLine(board[i]=' ');
            }
            Console.ReadLine();
        }
        
          
    }
}
