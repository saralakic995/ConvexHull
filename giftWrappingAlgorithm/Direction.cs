﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace giftWrappingAlgorithm
{
    public static class Direction
    {
        public enum Value { Lijevo, Pravo, Desno }

        
        /// Racunaje udaljenosti od linije (a,b) do linije (b,c).
        public static Value Izracunati(Point a, Point b, Point c)
        {
            // pomijeranje tacaka b i c to origin
            var novaB = new Point(b.X - a.X, b.Y - a.Y);
            var novaC = new Point(c.X - a.X, c.Y - a.Y);
            // calculate pseudoinner product
            var prod = novaC.Y * novaB.X - novaB.Y * novaC.X;

            if (prod > 0)
                return Value.Lijevo;

            if (prod < 0)
                return Value.Desno;

            return Value.Pravo;
        }
    }
}
