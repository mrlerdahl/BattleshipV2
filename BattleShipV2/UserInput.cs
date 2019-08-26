using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    public class UserInput
    {
        public static string GetString()
        {
            string input = Console.ReadLine().ToLower() ;           
            return input;
        }

        public static int GetNumber()
        {
            int input = Validattion.NumberValidation(Console.ReadLine());
            return input;
        }
    }
}
