using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class Validattion
    {
        // When a player tries to shoot in the same spot this will inform of that
        // Then will ask to player to choose a new coordinate
        public static int EnterVerticalAgain()
        {
            WriteText.SeconCoordinateText();
            return UserInput.GetNumber();

        }
        // This does the same thing as the about method but for horizontal coordinate
        public static int EnterHorizontalAgain()
        {
            WriteText.CoordinateText();
            return UserInput.GetNumber();

        }

        // This is to validate that the user is not trying to enter an yletters 
        // nor enter any values below zero or above nine
        public static int NumberValidation(string valInput)
        {
            string userInput;
            int newInput;
            bool keepGoing = false;
            do
            {
                keepGoing = int.TryParse(valInput, out newInput);
                if (!keepGoing || newInput < 0 || newInput > 9)
                {
                    WriteText.InvalidInputText();
                    WriteText.ReenterCoordinate();
                    userInput = Console.ReadLine();
                    keepGoing = int.TryParse(userInput, out newInput);
                    keepGoing = InRangeValidation(newInput);
                }
            } while (!keepGoing);

            return newInput;
        }
        // This is use to help the method above to check on last time that the 
        // numbers are in range before and send back to the above method weather its true or not
        static bool InRangeValidation(int valNum)
        {
            if (valNum < 0 || valNum > 9)
            {
                return false;
            }

            return true;
        }

        public static string EnterDirectionValidation(string input)
        {
            if (!input.Equals("right") && !input.Equals("left") && !input.Equals("down") && !input.Equals("up"))
            {
                WriteText.InvalidInputText();
                WriteText.ChooseDirectionText();
                input = EnterDirectionValidation(UserInput.GetString());
            }

            return input;
        }
        
        public static bool IsCoordOverLap(int verticalCoordinate, int horizontalCoordinate, Player playerBoard)
        {
           
            if(!playerBoard.DisplayShips.GetCoordinate(verticalCoordinate, horizontalCoordinate).Contains("~"))
            {
                WriteText.ShipOverLap();
                return true;
            }

            return false;
        }

        public static bool IsShipOverLap(int verticalCoordinate, int horizontalCoordinate, string abbrShipType, string direction,  Player playerBoard)
        {
            int count = 0;
            if (abbrShipType.Contains("C"))
            {
                count = 5;
            }
            if (abbrShipType.Contains("B"))
            {
                count = 4;
            }
            if (abbrShipType.Contains("c"))
            {
                count = 3;
            }
            if (abbrShipType.Contains("S"))
            {
                count = 3;
            }
            if (abbrShipType.Contains("D"))
            {
                count = 2;
            }
            for (int i = 0; i < count; i++)
            {
                if (direction.ToLower() == "left" && i > 0)
                {
                    if (!playerBoard.DisplayShips.GetCoordinate(verticalCoordinate, --horizontalCoordinate).Contains("~"))
                    {
                        WriteText.ShipOverLap();
                        return true;
                    }
                }
                if (direction.ToLower() == "right" && i > 0)
                {
                    if (!playerBoard.DisplayShips.GetCoordinate(verticalCoordinate, ++horizontalCoordinate).Contains("~"))
                    {
                        WriteText.ShipOverLap();
                        return true;
                    }
                }
                if (direction.ToLower() == "up" && i > 0)
                {
                    if (!playerBoard.DisplayShips.GetCoordinate(--verticalCoordinate, horizontalCoordinate).Contains("~"))
                    {
                        WriteText.ShipOverLap();
                        return true;
                    }
                }
                if (direction.ToLower() == "down" && i > 0)
                {
                    if (!playerBoard.DisplayShips.GetCoordinate(++verticalCoordinate, horizontalCoordinate).Contains("~"))
                    {
                        WriteText.ShipOverLap();
                        return true;
                    }
                }
            }

            
            

            return false;
        }

        public static bool IsSameShotSpot(int verticalCoordinate, int horizontalCoordinate, Player playerBoard)
        {

            if (!playerBoard.DisplayHitMiss.GetCoordinate(verticalCoordinate, horizontalCoordinate).Contains("~"))
            {
                WriteText.AlreadyShotHere();
                return true;
            }

            return false;
        }

        public static bool IsDirectionOutOfBounds(int verticalCoordinate, int horizontalCoordinate, string direction, string shipType)
        {
            int count = 0;
            if (shipType.Contains("C"))
            {
                count = 5;
            }
            if (shipType.Contains("B"))
            {
                count = 4;
            }
            if (shipType.Contains("c"))
            {
                count = 3;
            }
            if (shipType.Contains("S"))
            {
                count = 3;
            }
            if (shipType.Contains("D"))
            {
                count = 2;
            }

            for (int i = 0; i < count; i++)
            {
                if (direction.ToLower() == "left")
                {
                    if (--horizontalCoordinate < 0)
                    {
                        WriteText.DirectionOutOfBounds();
                        return true;
                    }          
                    
                }
                if(direction.ToLower() == "right")
                {
                    if (++horizontalCoordinate > 9)
                    {
                        WriteText.DirectionOutOfBounds();
                        return true;
                    }
                }
                if(direction.ToLower() == "up")
                {
                    if (--verticalCoordinate < 0)
                    {
                        WriteText.DirectionOutOfBounds();
                        return true;
                    }
                }
                if(direction.ToLower() == "down")
                {
                    if (++verticalCoordinate > 9)
                    {
                        WriteText.DirectionOutOfBounds();
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
