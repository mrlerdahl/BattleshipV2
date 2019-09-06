using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class PlayerVsComputer
    {

        public PlayerVsComputer()
        {

            Board gameBoard = new Board();

            Player playerOne = new Player("PlayerOne");

            int horizontalCoordinate;
            int verticalCoordinate;
            string direction;

            Console.Clear();

            // PlayerOne sets their ships
            WriteText.PlayerSetShipText(playerOne);
            for (int i = 0; i < playerOne.listOfShips.Length; i++)
            {
                bool shipOverLap = false;
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
                shipOverLap = Validattion.IsShipOverLap(verticalCoordinate, horizontalCoordinate, playerOne.listOfShips[i].AbbrType, direction, playerOne);

                // This loop will verifiy the direction is not over lapping another ship
                // Loop will keep running until a ship is not being overlapped
                // IsShipOverLap will return true if there is an overlap other wise false
                while (shipOverLap)
                {
                    WriteText.ChooseDirectionText();
                    direction = Validattion.EnterDirectionValidation(UserInput.GetString());
                    shipOverLap = Validattion.IsShipOverLap(verticalCoordinate, horizontalCoordinate, playerOne.listOfShips[i].AbbrType, direction, playerOne);
                }

                playerOne.setShip(verticalCoordinate, horizontalCoordinate, playerOne.listOfShips[i].AbbrType, direction);
                Console.Clear();
            }



        }
    }
}
