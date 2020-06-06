using System;
using System.Linq;

namespace BattleShip
{
    public class Ship
    {
        public enum Directions
        {
            NORTH,
            SOUTH,
            WEST,
            EAST,
            NONE
        }
        public enum Types
        {
            MINIDICK,
            DESTROYER,
            CRUISER,
            SUBMARINE,
            NONE
        }

        private Types type;
        private uint length;
        private Directions direction;
        private bool[] tuchee;

        public Types Type => type;

        public uint Length => length;

        public Directions Direction => direction;

        public bool[] Tuchee => tuchee;

        public Ship(Types type, Directions direction)
        {
            this.type = type;
            this.direction = direction;
            
            switch (type)
            {
                case Types.MINIDICK:
                    length = 2;
                    break;
                case Types.SUBMARINE:
                    length = 3;
                    break;
                case Types.CRUISER:
                    length = 3;
                    break;
                case Types.DESTROYER:
                    length = 4;
                    break;
                default:
                    throw new ArgumentException("Type is Incorrect");
            }
            tuchee = (bool[]) new bool[length];
        }

        public int Life => tuchee.Count(brick => !brick);

        public bool Tuched(int bloc)
        {
            if (bloc >= 0 && bloc < length)
            {
                if (!tuchee[bloc])
                {
                    tuchee[bloc] = true;
                    return true;
                }
            }
            return false;
        }
 
    }
}