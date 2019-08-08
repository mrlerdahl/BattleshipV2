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
            Console.WriteLine($"\n\t{player.PlayerName}");
            Console.WriteLine("  Place your ships");
        }
        public static void SetShipText(BaseShip ship)
        {
            Console.WriteLine($"  Choose first coordinate for your {ship.ShipType}, then select a direction to place it");
            Console.WriteLine("  (Ex. Left, Right, Up, or Down");
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
        public static void SetShipText()
        {

        }

        public static void HitShipText()
        {
            Console.WriteLine("Direct hit!");
        }
        //public static void ShipDestroyed(string shipType)
        //{
        //    Console.WriteLine(");
        //}
    }
}
