using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class PlayerVsPlayer
    {
        public PlayerVsPlayer(){
            WriteText.StartGameText();
            Menu.StartGameChoice(UserInput.GetString());
            Console.WriteLine("");

            Board gameBoard = new Board();

            Player playerOne = new Player("PlayerOne");
            Player playerTwo = new Player("PlayerTwo");

            int horizontalCoordinate;
            int verticalCoordinate;
            string direction;
            bool shipOverLap = true;
            bool directionOutOfBounds = true;

            Console.Clear();

            // PlayerOne sets their ships
            WriteText.PlayerSetShipText(playerOne);
            for (int i = 0; i < playerOne.listOfShips.Length; i++)
            {
                
                Console.WriteLine("");
                playerOne.DisplayShips.PlayerBoard();

                WriteText.SetShipText(playerOne.listOfShips[i]);
                WriteText.SeconCoordinateText();
                verticalCoordinate = UserInput.GetNumber();
                WriteText.CoordinateText();
                horizontalCoordinate = UserInput.GetNumber();
                shipOverLap = Validattion.IsCoordOverLap(verticalCoordinate, horizontalCoordinate, playerOne);

                // This loop only runs if the user enters coordinates that they have choosen previously for a ship
                // It will continuously run until user chooses a coordinate that is not occupied by a ship
                while (shipOverLap)
                {
                    WriteText.SetShipText(playerOne.listOfShips[i]);
                    WriteText.SeconCoordinateText();
                    verticalCoordinate = UserInput.GetNumber();
                    WriteText.CoordinateText();
                    horizontalCoordinate = UserInput.GetNumber();
                    shipOverLap = Validattion.IsCoordOverLap(verticalCoordinate, horizontalCoordinate, playerOne);
                }


                WriteText.ChooseDirectionText();
                direction = Validattion.EnterDirectionValidation(UserInput.GetString());
                // verifies that the direction doesn't go out of bounds
                directionOutOfBounds = Validattion.IsDirectionOutOfBounds(verticalCoordinate, horizontalCoordinate, direction, playerOne.listOfShips[i].AbbrType);

                // this will loop until player chooses a direction that does not go out of bounds
                while (directionOutOfBounds)
                {
                    WriteText.ChooseDirectionText();
                    direction = Validattion.EnterDirectionValidation(UserInput.GetString());
                    directionOutOfBounds = Validattion.IsDirectionOutOfBounds(verticalCoordinate, horizontalCoordinate, direction, playerOne.listOfShips[i].AbbrType);
                }

                // verifies the that the ships don't over lap
               shipOverLap = Validattion.IsShipOverLap(verticalCoordinate, horizontalCoordinate, playerOne.listOfShips[i].AbbrType, direction, playerOne);

                // This loop will verifiy the direction is not over lapping another ship
                // Loop will keep running until a ship is not being overlapped
                // IsShipOverLap will return true if there is an overlap other wise false
                while (shipOverLap)
                {
                    WriteText.ChooseDirectionText();
                    direction = Validattion.EnterDirectionValidation(UserInput.GetString());
                    // To revalidate if direction is out of bounds
                    directionOutOfBounds = Validattion.IsDirectionOutOfBounds(verticalCoordinate, horizontalCoordinate, direction, playerOne.listOfShips[i].AbbrType);
                    // keep looping if direction is out of bounds
                    while (directionOutOfBounds)
                    {
                        WriteText.ChooseDirectionText();
                        direction = Validattion.EnterDirectionValidation(UserInput.GetString());
                        directionOutOfBounds = Validattion.IsDirectionOutOfBounds(verticalCoordinate, horizontalCoordinate, direction, playerOne.listOfShips[i].AbbrType);
                    }
                    shipOverLap = Validattion.IsShipOverLap(verticalCoordinate, horizontalCoordinate, playerOne.listOfShips[i].AbbrType, direction, playerOne);
                }

                playerOne.setShip(verticalCoordinate, horizontalCoordinate, playerOne.listOfShips[i].AbbrType, direction);
                Console.Clear();
            }


            // Player two sets their ships
            WriteText.PlayerSetShipText(playerTwo);
            for (int i = 0; i < playerTwo.listOfShips.Length; i++)
            {
                Console.WriteLine("");
                playerTwo.DisplayShips.PlayerBoard();

                WriteText.SetShipText(playerTwo.listOfShips[i]);
                WriteText.SeconCoordinateText();
                verticalCoordinate = UserInput.GetNumber();
                WriteText.CoordinateText();
                horizontalCoordinate = UserInput.GetNumber();
                shipOverLap = Validattion.IsCoordOverLap(verticalCoordinate, horizontalCoordinate, playerTwo);

                // This loop only runs if the user enters coordinates that they have choosen previously for a ship
                // It will continuously run until user chooses a coordinate that is not occupied by a ship
                while (shipOverLap)
                {
                    WriteText.SetShipText(playerTwo.listOfShips[i]);
                    WriteText.SeconCoordinateText();
                    verticalCoordinate = UserInput.GetNumber();
                    WriteText.CoordinateText();
                    horizontalCoordinate = UserInput.GetNumber();
                    shipOverLap = Validattion.IsCoordOverLap(verticalCoordinate, horizontalCoordinate, playerTwo);
                }

                WriteText.ChooseDirectionText();
                direction = Validattion.EnterDirectionValidation(UserInput.GetString());
                // verifies that the direction doesn't go out of bounds
                directionOutOfBounds = Validattion.IsDirectionOutOfBounds(verticalCoordinate, horizontalCoordinate, direction, playerTwo.listOfShips[i].AbbrType);

                // this will loop until player chooses a direction that does not go out of bounds
                while (directionOutOfBounds)
                {
                    WriteText.ChooseDirectionText();
                    direction = Validattion.EnterDirectionValidation(UserInput.GetString());
                    directionOutOfBounds = Validattion.IsDirectionOutOfBounds(verticalCoordinate, horizontalCoordinate, direction, playerTwo.listOfShips[i].AbbrType);
                }

                // verifies the that the ships don't over lap
                shipOverLap = Validattion.IsShipOverLap(verticalCoordinate, horizontalCoordinate, playerTwo.listOfShips[i].AbbrType, direction, playerTwo);

                // This loop will verifiy the direction is not over lapping another ship
                // Loop will keep running until a ship is not being overlapped
                // IsShipOverLap will return true if there is an overlap other wise false
                while (shipOverLap)
                {
                    WriteText.ChooseDirectionText();
                    direction = Validattion.EnterDirectionValidation(UserInput.GetString());
                    // To revalidate if direction is out of bounds
                    directionOutOfBounds = Validattion.IsDirectionOutOfBounds(verticalCoordinate, horizontalCoordinate, direction, playerTwo.listOfShips[i].AbbrType);
                    // keep looping if direction is out of bounds
                    while (directionOutOfBounds)
                    {
                        WriteText.ChooseDirectionText();
                        direction = Validattion.EnterDirectionValidation(UserInput.GetString());
                        directionOutOfBounds = Validattion.IsDirectionOutOfBounds(verticalCoordinate, horizontalCoordinate, direction, playerTwo.listOfShips[i].AbbrType);
                    }
                    shipOverLap = Validattion.IsShipOverLap(verticalCoordinate, horizontalCoordinate, playerTwo.listOfShips[i].AbbrType, direction, playerTwo);
                }

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

                WriteText.SeconCoordinateText();
                verticalCoordinate = UserInput.GetNumber();
                WriteText.CoordinateText();
                horizontalCoordinate = UserInput.GetNumber();
                sameShotSpot = Validattion.IsSameShotSpot(verticalCoordinate, horizontalCoordinate, playerOne); // Validates if the player has shot here already

                // Keeps looping until the player enters a location they have not already shot in
                while (sameShotSpot)
                {
                    WriteText.SeconCoordinateText();
                    verticalCoordinate = UserInput.GetNumber();
                    WriteText.CoordinateText();
                    horizontalCoordinate = UserInput.GetNumber();
                    sameShotSpot = Validattion.IsSameShotSpot(verticalCoordinate, horizontalCoordinate, playerOne);
                }

                isHit = playerOne.IsHit(verticalCoordinate, horizontalCoordinate, playerTwo);
                playerOne.PlotHitMiss(verticalCoordinate, horizontalCoordinate, isHit);
                WriteText.PressEnterToContinue();

                Console.Clear();

                WriteText.PlayerTurn(playerTwo);
                Console.Clear();
                playerTwo.DisplayShips.PlayerBoard();
                playerTwo.DisplayHitMiss.PlayerBoard();

                WriteText.SeconCoordinateText();
                verticalCoordinate = UserInput.GetNumber();
                WriteText.CoordinateText();
                horizontalCoordinate = UserInput.GetNumber();
                sameShotSpot = Validattion.IsSameShotSpot(verticalCoordinate, horizontalCoordinate, playerOne);

                // Same shot validation loop
                while (sameShotSpot)
                {
                    WriteText.SeconCoordinateText();
                    verticalCoordinate = UserInput.GetNumber();
                    WriteText.CoordinateText();
                    horizontalCoordinate = UserInput.GetNumber();
                    sameShotSpot = Validattion.IsSameShotSpot(verticalCoordinate, horizontalCoordinate, playerOne);
                }

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
