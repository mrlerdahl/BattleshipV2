using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class Player
    {
        public readonly string PlayerName;
        private const int power = 1;
        Board DisplayShips = new Board();
        Board DisplayHitMiss = new Board();
        BaseShip carrier;
        BaseShip battleship;
        BaseShip cruiser;
        BaseShip submarine;
        BaseShip destroyer;
        
        public Player(string name) => PlayerName = name;

        public void setShip(int x, int y, string shipType)
        {

        }

        public void FireOnShip(int x, int y)
        {

        }
    }
}
