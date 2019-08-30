using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CritterBrains;

namespace _100422488
{
    public class CritterBrain1 : CritterBrains.CritterBrain
    {
        Random random = new Random();
        int speed = 10;

        public CritterBrain1() : base("Arthos", "Jiri Valcikevic")
        {
        }

        public override void Birth()
        {
            speed = 10;
            Critter.Direction = random.Next(0, 360);
            Critter.Speed = speed;
        }

        public override void Think()
        {
            if (Critter.Energy > 15)
            {
                speed = 10;
            }
            else if (Critter.Energy > 10)
            {
                speed = 7;
            }
            else if (Critter.Energy > 5)
            {
                speed = 5;
            }
            else
            {
                speed = 1;
            }
            Critter.Speed = speed;
        }

        public override void NotifyBlockedByTerrain()
        {
            Critter.Direction = Critter.Direction + 90;
            Critter.Speed = speed;
        }

        public override void NotifyBumpedCritter(OtherCritter otherCritter)
        {
            Critter.Direction = Critter.Direction + 180;
            Critter.Speed = speed;
        }

        public override void NotifyCloseToFood(int x, int y)
        {
            if (!Critter.IsTerrainBlockingRouteTo(x, y))
            {
                int newDirection = Critter.GetDirectionTo(x, y);
                Critter.Direction = newDirection;
            }
        }

        public override void NotifyCloseToCritter(OtherCritter otherCritter)
        {
            if (otherCritter.IsTerrainBlockingRouteTo)
            {
                int newDirection = otherCritter.DirectionTo;
                Critter.Direction = newDirection + random.Next(90, 180);
            }
        }

    }
}
