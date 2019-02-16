﻿using System;

namespace _02SikiidmokTerulete
{
    public class Square : IPlane
    {
        private int side;

        public Square(int side)
        {
            this.side = side;
        }

        public int Area()
        {
            return side * side;
        }
    }
}