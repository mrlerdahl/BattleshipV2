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
    }
}
