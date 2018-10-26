using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_MarsRover_CSharp.Domain
{
    public class Rover
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Direction Direction { get; private set; }

        public Rover(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public void MoveForward()
        {
            switch (Direction)
            {
                case Direction.North:
                    Y += 1;
                    break;
                case Direction.South:
                    Y -= 1;
                    break;
                case Direction.East:
                    X += 1;
                    break;
                case Direction.West:
                    break;
                default:
                    break;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            
            if(!(obj is Rover))
            {
                return false;
            }

            return Equals((Rover)obj);
        }

        private bool Equals(Rover rover)
        {
            return rover.X == X && rover.Y == Y;
        }

        public override int GetHashCode()
        {
            var hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;
        }

    }
}
