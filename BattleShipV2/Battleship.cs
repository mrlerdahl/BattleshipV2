using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class Battleship : BaseShip
    {
        protected override int shipHealth { get; set; } = 4;
        public override string ShipType { get; } = "Battleship";
        public override string AbbrType { get; } = "B";
    }
}
