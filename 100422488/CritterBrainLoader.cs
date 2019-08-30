using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CritterBrains;

namespace _100422488
{
    public class CritterBrainLoader : ICritterFactory
    {
        const int totalCritterCount = 3;
        const int critterVarieties = 3;

        public IEnumerable<CritterBrains.CritterBrain> GetCritterBrains()
        {
            for (int i = 0; i < totalCritterCount; i++)
            {
                switch (i % critterVarieties)
                {
                    case 0: yield return new CritterBrain1(); break;
                    case 1: yield return new CritterBrain2(); break;
                    case 2: yield return new CritterBrain3(); break;
                }
            }
        }
    }
}