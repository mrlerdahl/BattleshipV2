using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class PlayGame
    {
        public PlayGame()
        {
            WriteText.StartGameText();
            Menu.StartGameChoice(UserInput.GetString());
            Console.WriteLine("");

            Board gameBoard = new Board();
            Player playerOne = new Player("PlayerOne");
            Player playerTwo = new Player("PlayerTwo");


            gameBoard.PlayerBoard();
            gameBoard.SetCoordinate(3, 4, " S");
            gameBoard.SetCoordinate(3, 5, " S");
            gameBoard.SetCoordinate(3, 6, " S");
            gameBoard.SetCoordinate(3, 7, " S");
            gameBoard.PlayerBoard();
        }
        
    }
}
