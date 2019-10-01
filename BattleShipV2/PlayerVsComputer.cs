using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class PlayerVsComputer
    {

        public PlayerVsComputer()
        {

            Player playerOne = new Player("PlayerOne");
            Player computerPlayer = new Player("Computer");

            int horizontalCoordinate;
            int verticalCoordinate;
            string direction;
            bool shipOverLap;
            bool directionOutOfBounds;
            Random computerInput = new Random();

            Console.Clear();

            // Computer sets ships
            WriteText.ComputerSettingShips();
            for (int i = 0; i < computerPlayer.listOfShips.Length; i++)
            {
                // Will loop depending if the ship doesn't over lap
                do
                {
                    verticalCoordinate = Validattion.ComputerInRangeValidation(computerInput.Next(9)); // making sure computer stays between 0-9
                    horizontalCoordinate = Validattion.ComputerInRangeValidation(computerInput.Next(9)); // making sure computer stays between 0-9
                    shipOverLap = Validattion.IsCoordOverLap(verticalCoordinate, horizontalCoordinate, computerPlayer);
                }while (shipOverLap);

                // Computer selects a direction, it is then validated to make sure it's not out of bounds, then verifies that it doesn't overlap a ship
                do
                {
                    do
                    {
                        int numDirection = computerInput.Next(3);
                        direction = computerPlayer.ComputerChooseDirection(numDirection);
                        directionOutOfBounds = Validattion.IsDirectionOutOfBounds(verticalCoordinate, horizontalCoordinate, direction, computerPlayer.listOfShips[i].AbbrType, computerPlayer);
                    } while (directionOutOfBounds);

                    shipOverLap = Validattion.IsShipOverLap(verticalCoordinate, horizontalCoordinate, computerPlayer.listOfShips[i].AbbrType, direction, computerPlayer);
                } while (shipOverLap);

                computerPlayer.setShip(verticalCoordinate, horizontalCoordinate, computerPlayer.listOfShips[i].AbbrType, direction);
                
            }

            computerPlayer.DisplayShips.PlayerBoard();
            WriteText.PressEnterToContinue();
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
                } while (shipOverLap) ;

                // This will verify that the direction is not out of bounds and that a ship is not being overlapped
                do
                {                   
                    // keep looping if direction is out of bounds
                    do
                    {
                        WriteText.ChooseDirectionText();
                        direction = Validattion.EnterDirectionValidation(UserInput.GetString());
                        directionOutOfBounds = Validattion.IsDirectionOutOfBounds(verticalCoordinate, horizontalCoordinate, direction, playerOne.listOfShips[i].AbbrType, playerOne);
                    } while (directionOutOfBounds) ;
                        shipOverLap = Validattion.IsShipOverLap(verticalCoordinate, horizontalCoordinate, playerOne.listOfShips[i].AbbrType, direction, playerOne);
                } while (shipOverLap);

                playerOne.setShip(verticalCoordinate, horizontalCoordinate, playerOne.listOfShips[i].AbbrType, direction);
                Console.Clear();
            }

            // Game starts
            while (playerOne.IsAlive() && computerPlayer.IsAlive())
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

                isHit = playerOne.IsHit(verticalCoordinate, horizontalCoordinate, computerPlayer);
                playerOne.PlotHitMiss(verticalCoordinate, horizontalCoordinate, isHit);
                WriteText.PressEnterToContinue();

                Console.Clear();

                WriteText.PlayerTurn(computerPlayer);
                Console.Clear();
                //computerPlayer.DisplayShips.PlayerBoard();
                //computerPlayer.DisplayHitMiss.PlayerBoard();

                // Same shot validation loop
                do
                {
                    verticalCoordinate = computerInput.Next(0, 9);
                    horizontalCoordinate = computerInput.Next(0, 9);
                    sameShotSpot = Validattion.IsSameShotSpot(verticalCoordinate, horizontalCoordinate, playerOne);
                } while (sameShotSpot);

                isHit = computerPlayer.IsHit(verticalCoordinate, horizontalCoordinate, playerOne);
                computerPlayer.PlotHitMiss(verticalCoordinate, horizontalCoordinate, isHit);
                WriteText.PressEnterToContinue();

                Console.Clear();

            }

            //Determins winner
            if (playerOne.IsAlive())
                Console.WriteLine("\n\tPlayerOne Wins!!\n");
            if (computerPlayer.IsAlive())
                Console.WriteLine("\n\tPlayerTwoWins!!\n");

        

        }
    }
}
