using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSpliner
{
    public class Vertex
    {
        /// <summary>
        /// Default constructor for Vertex (0.0 for all)
        /// </summary>
        public Vertex() : this(0.0f, 0.0f, 0.0f)
        {

        }

        /// <summary>
        /// Assigns same value to all points
        /// </summary>
        /// <param name="v">Value</param>
        public Vertex(float v) : this(v, v, v)
        {

        }

        /// <summary>
        /// Assign individual value to each coordinate
        /// </summary>
        /// <param name="x">X Coordinate</param>
        /// <param name="y">Y Coordinate</param>
        /// <param name="z">Z Coordinate</param>
        public Vertex(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Gets X, Y, Z values as string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", X.ToString("0.000000"), Y.ToString("0.000000"), Z.ToString("0.000000"));
        }

        /// <summary>
        /// X Coordinate
        /// </summary>
        public float X;

        /// <summary>
        /// Y Coordinate
        /// </summary>
        public float Y;

        /// <summary>
        /// Z Coordinate
        /// </summary>
        public float Z;
    }
}
