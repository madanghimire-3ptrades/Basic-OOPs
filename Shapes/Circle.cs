﻿using System;

namespace BasicOOPSRevise.Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius;
        }
    }
}
