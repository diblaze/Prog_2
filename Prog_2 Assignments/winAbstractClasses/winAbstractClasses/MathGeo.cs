using System;

namespace winAbstractClasses
{
    internal static class MathGeo
    {
        /// <summary>
        ///     Calculate the area of a rectangle
        /// </summary>
        /// <param name="side1">First side</param>
        /// <param name="side2">Second side</param>
        /// <returns></returns>
        public static float RectangleArea(float side1, float side2)
        {
            float area = (side1 * side2);
            return area;
        }

        /// <summary>
        ///     Calculate the perimeter of a rectangle
        /// </summary>
        /// <param name="width">Width</param>
        /// <param name="height">Height/param>
        /// <returns></returns>
        public static float RectanglePerimeter(float width, float height)
        {
            float perimeter = (2 * width) + (2 * height);
            return perimeter;
        }



        /// <summary>
        ///     Calculate the area of a circle
        /// </summary>
        /// <param name="radius">Radius</param>
        /// <returns></returns>
        public static float CircleArea(double radius)
        {
            var area = (float)(Math.PI * (radius * radius));
            return area;
        }

        /// <summary>
        ///     Calculate the area of a circle
        /// </summary>
        /// <param name="diameter">diameter</param>
        /// <returns></returns>
        public static float CircleArea(float diameter)
        {
            var area = (float) (Math.PI * ((diameter/2) * (diameter/2)));
            return area;
        }

        /// <summary>
        ///     Calculate the area of a circle
        /// </summary>
        /// <param name="radius">Radius</param>
        /// <returns></returns>
        public static float CircleArea(string radius)
        {
            var area = (float) (Math.PI * (float.Parse(radius) * float.Parse(radius)));
            return area;
        }

        /// <summary>
        ///     Calculate the perimeter of a circle
        /// </summary>
        /// <param name="radius">Radius</param>
        /// <returns></returns>
        public static float CirclePerimeter(float radius)
        {
            var perimeter = (float) (2 * Math.PI * radius);
            return perimeter;
        }

        /// <summary>
        ///     Calculate the sector area of a circle
        /// </summary>
        /// <param name="angle">Angle</param>
        /// <param name="radius">Radius</param>
        /// <returns></returns>
        public static float CircleSectorArea(float angle, float radius)
        {
            var sectorArea = (float) ((angle / 360) * Math.PI * (radius * radius));
            return sectorArea;
        }
    }
}