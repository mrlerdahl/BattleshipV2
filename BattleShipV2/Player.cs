using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class Player
    {
        public readonly string PlayerName;
        private const int power = 1;
        public Board DisplayShips = new Board();
        public Board DisplayHitMiss = new Board();
        public BaseShip[] listOfShips = new BaseShip[] { new Carrier(), new Battleship(), new Cruiser(), new Submarine(), new Destroyer()};
       
        
        public Player(string name) => PlayerName = name;

        //TODO create a check location method to check whether a ship has been placed there or is overlapping
        public void setShip(int vertical, int horizontal, string abbrShipType, string direction)
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
                if(direction.ToLower() == "left" && i > 0)
                {
                    DisplayShips.SetCoordinate(vertical, --horizontal, $" {abbrShipType}");
                }
                if (direction.ToLower() == "right" && i > 0)
                {
                    DisplayShips.SetCoordinate(vertical, ++horizontal, $" {abbrShipType}");
                }
                if (direction.ToLower() == "up" && i > 0)
                {
                    DisplayShips.SetCoordinate(--vertical, horizontal, $" {abbrShipType}");
                }
                if (direction.ToLower() == "down" && i > 0)
                {
                    DisplayShips.SetCoordinate(++vertical, horizontal, $" {abbrShipType}");
                }
                DisplayShips.SetCoordinate(vertical, horizontal, $" {abbrShipType}");
            }
           
        }

        public void FireOnShip(int x, int y, Player opponent)
        {
            if (opponent.DisplayShips.GetCoordinate(x, y) == " C")
            {
                WriteText.HitShipText();
                opponent.listOfShips[0].ShipHit(power);
                
            }
        }

        
    }
}
