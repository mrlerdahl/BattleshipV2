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

            int horizontalCoordinate;
            int verticalCoordinate;
            string direction;

            WriteText.PlayerSetShipText(playerOne);
            for (int i = 0; i < playerOne.listOfShips.Length; i++)
            {            
                playerOne.DisplayShips.PlayerBoard();
                WriteText.SetShipText(playerOne.listOfShips[i]);
                WriteText.CoordinateText();
                horizontalCoordinate = UserInput.GetNumber();
                WriteText.SeconCoordinateText();
                verticalCoordinate = UserInput.GetNumber();
                WriteText.ChooseDirectionText();
                direction = UserInput.GetString();
                playerOne.setShip(verticalCoordinate, horizontalCoordinate, playerOne.listOfShips[i].AbbrType, direction);
                Console.Clear();
            }
            WriteText.PlayerSetShipText(playerTwo);
            for (int i = 0; i < playerTwo.listOfShips.Length; i++)
            {
                playerTwo.DisplayShips.PlayerBoard();
                WriteText.SetShipText(playerTwo.listOfShips[i]);
                WriteText.CoordinateText();
                horizontalCoordinate = UserInput.GetNumber();
                WriteText.SeconCoordinateText();
                verticalCoordinate = UserInput.GetNumber();
                WriteText.ChooseDirectionText();
                direction = UserInput.GetString();
                playerTwo.setShip(verticalCoordinate, horizontalCoordinate, playerTwo.listOfShips[i].AbbrType, direction);
                Console.Clear();
            }

            while(playerOne.IsAlive() && playerTwo.IsAlive())
            {
                bool isHit;
                Console.WriteLine("\n\tLets play!!\n");
                WriteText.PlayerTurn(playerOne);
                Console.Clear();
                playerOne.DisplayShips.PlayerBoard();
                playerOne.DisplayHitMiss.PlayerBoard();
                WriteText.CoordinateText();
                horizontalCoordinate = UserInput.GetNumber();
                WriteText.SeconCoordinateText();
                verticalCoordinate = UserInput.GetNumber();
                isHit = playerOne.IsHit(verticalCoordinate, horizontalCoordinate, playerTwo);
                playerOne.PlotHitMiss(verticalCoordinate, horizontalCoordinate, isHit);
                WriteText.PressEnterToContinue();

                Console.Clear();

                WriteText.PlayerTurn(playerTwo);
                Console.Clear();
                playerTwo.DisplayShips.PlayerBoard();
                playerTwo.DisplayHitMiss.PlayerBoard();
                WriteText.CoordinateText();
                horizontalCoordinate = UserInput.GetNumber();
                WriteText.SeconCoordinateText();
                verticalCoordinate = UserInput.GetNumber();
                isHit = playerTwo.IsHit(verticalCoordinate, horizontalCoordinate, playerOne);
                playerTwo.PlotHitMiss(verticalCoordinate, horizontalCoordinate, isHit);
                WriteText.PressEnterToContinue();

                Console.Clear();

            }

            if(playerOne.IsAlive())
                Console.WriteLine("\n\tPlayerOne Wins!!\n");
            if(playerTwo.IsAlive())
                Console.WriteLine("\n\tPlayerTwoWins!!\n");

            //gameBoard.PlayerBoard();
            //gameBoard.SetCoordinate(3, 4, " S");
            //gameBoard.SetCoordinate(3, 5, " S");
            //gameBoard.SetCoordinate(3, 6, " S");
            //gameBoard.SetCoordinate(3, 7, " S");
            //gameBoard.PlayerBoard();
        }
        
    }
}
