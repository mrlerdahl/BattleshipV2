using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class PlayerVsPlayer
    {
        public PlayerVsPlayer(){
           
            Player playerOne = new Player("PlayerOne");
            Player playerTwo = new Player("PlayerTwo");

            int horizontalCoordinate;
            int verticalCoordinate;
            string direction;
            bool shipOverLap;
            bool directionOutOfBounds;

            Console.Clear();

            // PlayerOne sets their ships
            WriteText.PlayerSetShipText(playerOne);
            for (int i = 0; i < playerOne.listOfShips.Length; i++)
            {

                Console.WriteLine("");
                playerOne.DisplayShips.PlayerBoard();

                // It will continuously run until user chooses a coordinate that is not occupied by a ship
                do
                {
                    WriteText.SetShipText(playerOne.listOfShips[i]);
                    WriteText.SeconCoordinateText();
                    verticalCoordinate = UserInput.GetNumber();
                    WriteText.CoordinateText();
                    horizontalCoordinate = UserInput.GetNumber();
                    shipOverLap = Validattion.IsCoordOverLap(verticalCoordinate, horizontalCoordinate, playerOne);
                } while (shipOverLap);

                // This will verify that the direction is not out of bounds and that a ship is not being overlapped
                do
                {
                    // keep looping if direction is out of bounds
                    do
                    {
                        WriteText.ChooseDirectionText();
                        direction = Validattion.EnterDirectionValidation(UserInput.GetString());
                        directionOutOfBounds = Validattion.IsDirectionOutOfBounds(verticalCoordinate, horizontalCoordinate, direction, playerOne.listOfShips[i].AbbrType, playerOne);
                    } while (directionOutOfBounds);
                    shipOverLap = Validattion.IsShipOverLap(verticalCoordinate, horizontalCoordinate, playerOne.listOfShips[i].AbbrType, direction, playerOne);
                } while (shipOverLap);

                playerOne.setShip(verticalCoordinate, horizontalCoordinate, playerOne.listOfShips[i].AbbrType, direction);
                Console.Clear();
            }

            // Player two sets their ships
            WriteText.PlayerSetShipText(playerTwo);
            for (int i = 0; i < playerTwo.listOfShips.Length; i++)
            {

                Console.WriteLine("");
                playerTwo.DisplayShips.PlayerBoard();

                // It will continuously run until user chooses a coordinate that is not occupied by a ship
                do
                {
                    WriteText.SetShipText(playerTwo.listOfShips[i]);
                    WriteText.SeconCoordinateText();
                    verticalCoordinate = UserInput.GetNumber();
                    WriteText.CoordinateText();
                    horizontalCoordinate = UserInput.GetNumber();
                    shipOverLap = Validattion.IsCoordOverLap(verticalCoordinate, horizontalCoordinate, playerTwo);
                } while (shipOverLap);

                // This will verify that the direction is not out of bounds and that a ship is not being overlapped
                do
                {
                    // keep looping if direction is out of bounds
                    do
                    {
                        WriteText.ChooseDirectionText();
                        direction = Validattion.EnterDirectionValidation(UserInput.GetString());
                        directionOutOfBounds = Validattion.IsDirectionOutOfBounds(verticalCoordinate, horizontalCoordinate, direction, playerTwo.listOfShips[i].AbbrType, playerTwo);
                    } while (directionOutOfBounds);
                    shipOverLap = Validattion.IsShipOverLap(verticalCoordinate, horizontalCoordinate, playerTwo.listOfShips[i].AbbrType, direction, playerTwo);
                } while (shipOverLap);

                playerTwo.setShip(verticalCoordinate, horizontalCoordinate, playerTwo.listOfShips[i].AbbrType, direction);
                Console.Clear();
            }

            // Game starts
            while (playerOne.IsAlive() && playerTwo.IsAlive())
            {
                bool isHit;
                bool sameShotSpot;
                Console.WriteLine("\n\tLets play!!\n");
                WriteText.PlayerTurn(playerOne);
                Console.Clear();
                playerOne.DisplayShips.PlayerBoard();
                playerOne.DisplayHitMiss.PlayerBoard();

                // Keeps looping until the player enters a location they have not already shot in
                do
                {
                    WriteText.SeconCoordinateText();
                    verticalCoordinate = UserInput.GetNumber();
                    WriteText.CoordinateText();
                    horizontalCoordinate = UserInput.GetNumber();
                    sameShotSpot = Validattion.IsSameShotSpot(verticalCoordinate, horizontalCoordinate, playerOne);
                } while (sameShotSpot);

                isHit = playerOne.IsHit(verticalCoordinate, horizontalCoordinate, playerTwo);
                playerOne.PlotHitMiss(verticalCoordinate, horizontalCoordinate, isHit);
                WriteText.PressEnterToContinue();

                Console.Clear();

                WriteText.PlayerTurn(playerTwo);
                Console.Clear();
                playerTwo.DisplayShips.PlayerBoard();
                playerTwo.DisplayHitMiss.PlayerBoard();

                // Same shot validation loop
                do
                {
                    WriteText.SeconCoordinateText();
                    verticalCoordinate = UserInput.GetNumber();
                    WriteText.CoordinateText();
                    horizontalCoordinate = UserInput.GetNumber();
                    sameShotSpot = Validattion.IsSameShotSpot(verticalCoordinate, horizontalCoordinate, playerOne);
                } while (sameShotSpot);

                    isHit = playerTwo.IsHit(verticalCoordinate, horizontalCoordinate, playerOne);
                playerTwo.PlotHitMiss(verticalCoordinate, horizontalCoordinate, isHit);
                WriteText.PressEnterToContinue();

                Console.Clear();

            }

            //Determins winner
            if (playerOne.IsAlive())
                Console.WriteLine("\n\tPlayerOne Wins!!\n");
            if (playerTwo.IsAlive())
                Console.WriteLine("\n\tPlayerTwoWins!!\n");

        }

    }
}
