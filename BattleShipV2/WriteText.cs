using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class WriteText
    {
        public static void StartGameText()
        {
            Console.WriteLine("  Would you like to start a game?");
            Console.Write("  Type Yes or No: ");
        }

        public static void PlayerSetShipText(Player player)
        {
            Console.WriteLine($"\n\t{player.PlayerName} place your ships\n");
        }
        public static void SetShipText(BaseShip ship)
        {
            Console.WriteLine($"  Choose first coordinate for your {ship.ShipType}, then select a direction to place it");
            Console.WriteLine("  (Ex. Left, Right, Up, or Down)");
        }
        public static void CoordinateText()
        {
            Console.Write("  Enter horizontal coordinate: ");
        }
        public static void SeconCoordinateText()
        {
            Console.Write("  Enter vertical coordinate: " );
        }
        public static void ChooseDirectionText()
        {
            Console.Write(" Enter direction of ship: ");
        }

        public static void HitShipText()
        {
            Console.WriteLine("\n\tDirect hit!\n");
        }
        public static void MissShipText()
        {
            Console.WriteLine("\n\tShot missed!\n");
        }
        public static void ShipDestroyed(string shipType)
        {
            Console.WriteLine($"\n\t{shipType} destroyed!\n");
        }

        public static void PlayerTurn(Player player)
        {
            Console.WriteLine($"\n\t{player.PlayerName} your turn\n");
            Console.WriteLine("\n\tPress enter to continue...");
            Console.ReadKey();
        }

        public static void PressEnterToContinue()
        {
            Console.WriteLine("\n\tPress enter to continue...\n");
            Console.ReadKey();
        }
    }
}
