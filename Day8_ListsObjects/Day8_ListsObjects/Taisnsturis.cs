using System;
using System.Collections.Generic;
using System.Text;


namespace Day8_ListsObjects
{
    class Taisnsturis
    {
        public int SideA { get; set; }
        public int SideB { get; set; }

        public int Size()

        {
            int Size = SideA * SideB;
            return Size;

        }


        public Taisnsturis(int sideA, int sideB)
        {
            SideA = sideA;
            SideB = sideB;
            
        }

    }
}
