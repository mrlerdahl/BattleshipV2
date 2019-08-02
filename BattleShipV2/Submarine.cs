using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class Submarine : BaseShip
    {
        protected override int shipHealth { get; set; } = 3;
        public override string ShipType { get; } = "Submarine";
        public override string AbbrType { get; } = "S";
    }
}
