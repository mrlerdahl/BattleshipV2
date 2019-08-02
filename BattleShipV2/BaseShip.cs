using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class BaseShip
    {
        protected virtual int shipHealth { get; set; } = 4;
        public virtual string ShipType { get; } = "BaseShip";
        public virtual string AbbrType { get; } = "S";

        public bool ShipDestroyed(bool x = true)
        {
            return x;
        }

        public void ShipHit()
        {

        }

    }
}
