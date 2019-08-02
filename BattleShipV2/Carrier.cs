using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class Carrier : BaseShip
    {
        protected override int shipHealth { get; set; } = 5;
        public override string ShipType { get; } = "Carrier";
        public override string AbbrType { get; } = "C";
    }
}
