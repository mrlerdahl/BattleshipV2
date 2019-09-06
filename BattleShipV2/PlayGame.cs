using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class PlayGame
    {
        public PlayGame()
        {
            bool userSelection;

            WriteText.StartGameText();
            Menu.StartGameChoice(UserInput.GetString());
            Console.WriteLine("");

            Console.Clear();

            WriteText.PlayerOrComputerSelection();
            userSelection = Menu.GameSelection(UserInput.GetNumber());

            if(userSelection)
                new PlayerVsPlayer();
            if (!userSelection)
                new PlayerVsComputer();
        }
        
    }
}
