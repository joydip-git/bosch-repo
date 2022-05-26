using System;

namespace SampleLib
{
    public class Circle : IShape
    {
        private double _radius;
        public Circle()
        {

        }
        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
