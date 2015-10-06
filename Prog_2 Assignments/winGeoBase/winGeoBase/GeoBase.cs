using System;

namespace winGeoBase
{
    internal abstract class GeoBase
    {
        public double Density { get; set; }
        public abstract double Volume();
        public abstract double Area();

        public double Mass()
        {
            return Volume() * Density;
        }
    }

    internal class Cube : GeoBase
    {
        public double Side { get; set; }

        public override double Volume()
        {
            return Math.Pow(Side, 3);
        }

        public override double Area()
        {
            return Math.Pow(Side, 2);
        }
    }

    internal class Cuboid : GeoBase
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }

        public override double Volume()
        {
            return Width * Height * Depth;
        }

        public override double Area()
        {
            return 2 * ((Width * Height) + (Width * Depth) + (Height * Depth));
        }
    }

    internal class Sphere : GeoBase
    {
        public double Radius { get; set; }

        public override double Volume()
        {
            return (4 * Math.PI * Math.Pow(Radius, 3) / 3);
        }

        public override double Area()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }
    }

    internal class Cone : GeoBase
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public override double Volume()
        {
            double circleArea = Math.PI * Math.Pow(Radius, 2);
            return (circleArea * Height) / 3;
        }

        public override double Area()
        {
            double distance = Math.Sqrt(Math.Pow(Radius, 2) + Math.Pow(Height, 2));

            return (Math.PI * Math.Pow(Radius, 2) + (Math.PI * Radius * distance));
        }
    }
}