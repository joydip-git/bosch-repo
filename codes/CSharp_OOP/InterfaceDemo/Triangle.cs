namespace InterfaceDemo
{
    class Triangle : IShape
    {
        double _tHeight;
        double _tBase;

        public Triangle()
        {

        }
        public Triangle(double tHeight, double tBase)
        {
            _tHeight = tHeight;
            _tBase = tBase;
        }

        public double THeight { get => _tHeight; set => _tHeight = value; }
        public double TBase { get => _tBase; set => _tBase = value; }

        public double CalculateArea()
        {
            return 0.5 * _tBase * _tHeight;
        }
    }
}
