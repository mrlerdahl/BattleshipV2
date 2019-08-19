using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    public class Menu
    {
       public static bool StartGameChoice(string input, bool decision = true )
        {           
            if (input.ToLower() == "yes")
            {
                return true;
            }
            if (input.ToLower() == "no")
            {
                Environment.Exit(0);
            }
            else
            {
                WriteText.InvalidInputText();
                WriteText.StartGameText();
                StartGameChoice(Console.ReadLine());
            }
            return decision;
        } 
    }
}
