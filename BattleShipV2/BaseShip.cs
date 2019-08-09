using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipV2
{
    class BaseShip
    {
        protected virtual int shipHealth { get; set; } = 1;
        public virtual string ShipType { get; } = "BaseShip";
        public virtual string AbbrType { get; } = "S";

        public bool IsDestroyed()
        {
            if (this.shipHealth == 0)
            {
                return true;
            }
            return false;
        }

        public void ShipHit(int takeDamage)
        {
            shipHealth -= takeDamage;
        }

    }
}
