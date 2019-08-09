﻿namespace BattleShipV2
{
    class Player
    {
        public readonly string PlayerName;
        private const int power = 1;
        private int health = 5;
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

        public bool IsHit(int vertical, int horizontal, Player opponent)
        {
            if (opponent.DisplayShips.GetCoordinate(vertical, horizontal).Contains("C"))
            {
                WriteText.HitShipText();
                opponent.listOfShips[0].ShipHit(power);
                opponent.DisplayShips.SetCoordinate(vertical, horizontal, " X");
                if (opponent.listOfShips[0].IsDestroyed())
                {
                    WriteText.ShipDestroyed(opponent.listOfShips[0].ShipType);
                    opponent.DecreaseHealth(true);
                }
                return true;
            }
            if (opponent.DisplayShips.GetCoordinate(vertical, horizontal).Contains("B"))
            {
                WriteText.HitShipText();
                opponent.listOfShips[1].ShipHit(power);
                opponent.DisplayShips.SetCoordinate(vertical, horizontal, " X");
                if (opponent.listOfShips[1].IsDestroyed())
                {
                    WriteText.ShipDestroyed(opponent.listOfShips[1].ShipType);
                    opponent.DecreaseHealth(true);
                }
                return true;
            }
            if (opponent.DisplayShips.GetCoordinate(vertical, horizontal).Contains("c"))
            {
                WriteText.HitShipText();
                opponent.listOfShips[2].ShipHit(power);
                opponent.DisplayShips.SetCoordinate(vertical, horizontal, " X");
                if (opponent.listOfShips[2].IsDestroyed())
                {
                    WriteText.ShipDestroyed(opponent.listOfShips[2].ShipType);
                    opponent.DecreaseHealth(true);
                }
                return true;
            }
            if (opponent.DisplayShips.GetCoordinate(vertical, horizontal).Contains("S"))
            {
                WriteText.HitShipText();
                opponent.listOfShips[3].ShipHit(power);
                opponent.DisplayShips.SetCoordinate(vertical, horizontal, " X");
                if (opponent.listOfShips[3].IsDestroyed())
                {
                    WriteText.ShipDestroyed(opponent.listOfShips[3].ShipType);
                    opponent.DecreaseHealth(true);
                }
                return true;
            }
            if (opponent.DisplayShips.GetCoordinate(vertical, horizontal).Contains("D"))
            {
                WriteText.HitShipText();
                opponent.listOfShips[4].ShipHit(power);
                opponent.DisplayShips.SetCoordinate(vertical, horizontal, " X");
                if (opponent.listOfShips[4].IsDestroyed())
                {
                    WriteText.ShipDestroyed(opponent.listOfShips[4].ShipType);
                    opponent.DecreaseHealth(true);
                }
                return true;
            }
            else
            {
                WriteText.MissShipText();
            }
            return false;
        }

        public bool IsAlive()
        {
            if (health == 0)
                return false;
            return true;
        }

        public void PlotHitMiss(int vertical, int horizontal, bool shotHit)
        {
            if (shotHit)
            {
                this.DisplayHitMiss.SetCoordinate(vertical, horizontal, " H");
            }
            else
            {
                this.DisplayHitMiss.SetCoordinate(vertical, horizontal, " M");
            }
        }

        public void DecreaseHealth(bool shipDestroyed)
        {
            if (shipDestroyed)
            {
                this.health -= 1;
            }
            
        }
        
    }
}
