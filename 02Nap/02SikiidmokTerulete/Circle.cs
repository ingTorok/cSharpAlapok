﻿using System;

namespace _02SikiidmokTerulete
{
    public class Circle
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return 2 * radius * Math.PI;
        }
    }
}