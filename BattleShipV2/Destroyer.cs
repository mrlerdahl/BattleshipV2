using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class Destroyer : BaseShip
    {
        protected override int shipHealth { get; set; } = 2;
        public override string ShipType { get; } = "Destroyer";
    }
}
