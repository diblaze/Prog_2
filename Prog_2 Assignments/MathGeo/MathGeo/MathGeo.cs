using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGeo
{
    static class MathGeo
    {
        /// <summary>
        /// Calculate the area of a rectangle
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
        /// Calculate the perimeter of a rectangle
        /// </summary>
        /// <param name="side1">First side</param>
        /// <param name="side2">Second side</param>
        /// <returns></returns>
        public static float RectanglePerimeter(float side1, float side2)
        {
            float perimeter = (2 * side1) + (2 * side2);
            return perimeter;
        }

        /// <summary>
        /// Calculate the area of a circle
        /// </summary>
        /// <param name="radius">Radius</param>
        /// <returns></returns>
        public static float CircleArea(float radius)
        {
            float area = (float) (Math.PI * (radius * radius));
            return area;
        }

        /// <summary>
        /// Calculate the perimeter of a circle
        /// </summary>
        /// <param name="radius">Radius</param>
        /// <returns></returns>
        public static float CirclePerimeter(float radius)
        {
            float perimeter = (float) (2 * Math.PI * radius);
            return perimeter;
        }

        /// <summary>
        /// Calculate the sector area of a circle
        /// </summary>
        /// <param name="angle">Angle</param>
        /// <param name="radius">Radius</param>
        /// <returns></returns>
        public static float CircleSectorArea(float angle, float radius)
        {
            float sectorArea = (float) ((angle / 360) * Math.PI * (radius * radius));
            return sectorArea;
        }


    }
}
