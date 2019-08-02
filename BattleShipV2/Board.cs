﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class Board
    {
        private int height = 10;
        private int width = 10;
        private string[,] drawBoard = new string[10, 10];

        public Board()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    drawBoard[i, j] = " ~";
                }
            }
        }

        public void SetCoordinate(int x, int y, string shipType)
        {
            drawBoard[x, y] = shipType;
        }

        public void PlayerBoard()
        {
            Console.WriteLine("     0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   +---------------------+");
            for (int i = 0; i < height; i++)
            {
                Console.Write($"  {i}|");
                for (int j = 0; j < width; j++)
                {
                    Console.Write(drawBoard[i, j]);
                }
                Console.WriteLine(" |");
            }
            Console.WriteLine("   +---------------------+");
        }
    }
}
