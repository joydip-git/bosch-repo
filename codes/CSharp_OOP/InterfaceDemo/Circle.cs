using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    sealed class Circle : IShape
    {
        double _radius;
        public Circle()
        {

        }
        public Circle(double radius)
        {
            this._radius = radius;
        }

        public double Radius { get => _radius; set => _radius = value; }

        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
