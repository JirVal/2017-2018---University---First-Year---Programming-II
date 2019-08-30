﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

// CritterBody is a thin wrapper around the ICritter interface for use by critter brains.

namespace CritterBrains
{
    public class CritterBody : ICritter
    {
        ICritter _body;

        public CritterBody(ICritter body)
        {
            _body = body;
        }

        /// <summary>
        /// Stop the critter moving
        /// </summary>
        public void Stop()
        {
            _body.Stop();
        }

        /// <summary>
        /// Set/Get the current speed of the critter
        /// </summary>
        public int Speed
        {
            get
            {
                return _body.Speed;
            }
            set
            {
                _body.Speed = value;
            }
        }

        /// <summary>
        /// Set/Get the direction the critter is to move
        /// </summary>
        public int Direction
        {
            set
            {
                _body.Direction = value;
            }
            get
            {
                return _body.Direction;
            }
        }

        /// <summary>
        /// Get the current energy value of the critter
        /// </summary>
        public int Energy
        {
            get
            {
                return _body.Energy;
            }
        }

        /// <summary>
        /// Get the current age of the critter
        /// </summary>
        public int Age
        {
            get
            {
                return _body.Age;
            }
        }

        public int X => _body.X;

        public int Y => _body.Y;

        /// <summary>
        /// Get the direction to the specified x, y position
        /// </summary>
        public int GetDirectionTo(int x, int y)
        {
            return _body.GetDirectionTo(x, y);
        }

        /// <summary>
        /// Returns the Rectangle representing the goal to be reached.
        /// </summary>
        public Rectangle GetDestination()
        {
            return _body.GetDestination();
        }

        /// <summary>
        /// Is terrain blocking the direct route to the specified x, y coordinates
        /// </summary>
        public bool IsTerrainBlockingRouteTo(int x, int y)
        {
            return _body.IsTerrainBlockingRouteTo(x, y);
        }

        /// <summary>
        /// Scan for nearby objects.
        /// </summary>
        /// <returns>Array of IWorldObjectS.</returns>
        public IWorldObject[] Scan()
        {
            return _body.Scan();
        }

        /// <summary>
        /// Get direction to a given object.
        /// </summary>
        /// <param name="other">Reference to object.</param>
        /// <returns>Direction in degrees.</returns>
        public int GetDirectionTo(IWorldObject other)
        {
            return _body.GetDirectionTo(other);
        }

        /// <summary>
        /// Is terrain blocking the route to an object?
        /// </summary>
        /// <param name="other">Reference to object.</param>
        /// <returns>True if line-of-sight blocked by terrain. False otherwise.</returns>
        public bool IsTerrainBlockingRouteTo(IWorldObject other)
        {
            return _body.IsTerrainBlockingRouteTo(other);
        }

        /// <summary>
        /// Get the strength of a given critter.
        /// </summary>
        /// <param name="otherCritter">Reference to other critter.</param>
        /// <returns>Strength</returns>
        public Strength GetStrengthOf(IOtherCritter otherCritter)
        {
            return _body.GetStrengthOf(otherCritter);
        }

        /// <summary>
        /// Attack a given critter.
        /// </summary>
        /// <param name="otherCritter">Reference to other critter.</param>
        /// <returns>Result of attack.</returns>
        public EnumAttackResult Attack(IOtherCritter otherCritter)
        {
            return _body.Attack(otherCritter);
        }
    }
}
