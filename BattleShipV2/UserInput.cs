using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    public class UserInput
    {
        public static string GetString()
        {
            string input = Console.ReadLine();           
            return input;
        }

        public static int GetNumber()
        {
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
