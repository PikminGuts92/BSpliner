using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSpliner
{

    public static class PresetPoints
    {
        /// <summary>
        /// Generates Tornado Points
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static List<Vertex> Tornado(Vertex min, Vertex max)
        {
            List<Vertex> verts = new List<Vertex>();

            float height = min.Z;
            float heightInc = Math.Abs((max.Z - min.Z) / 50.0f); // Ammount to increment at each step for z

            float width = (Math.Abs(max.X - min.X) + Math.Abs(max.Y - min.Y)) / 200.0f; // Ammount to increment each step for x and y
            float widthInc = width;

            float neg = 1.0f; // Used for altneration
            
            for (int i = 0; height < max.Z; i++)
            {
                if (i % 2 == 0) // Even
                    verts.Add(new Vertex(0.0f, neg * width, height));
                else
                {
                    verts.Add(new Vertex(neg * width, 0.0f, height));
                    neg = -neg; // Swaps sign
                }

                width += widthInc;
                height += heightInc;
            }
            
            
            return verts;
        }

        /// <summary>
        /// Generates Box Points
        /// </summary>
        /// <returns></returns>
        public static List<Vertex> Box()
        {
            List<Vertex> verts = new List<Vertex>();

            verts.Add(new Vertex(100.0f, 100.0f, 100.0f));
            verts.Add(new Vertex(100.0f, -100.0f, 100.0f));
            verts.Add(new Vertex(-100.0f, -100.0f, 100.0f));
            verts.Add(new Vertex(-100.0f, 100.0f, 100.0f));

            verts.Add(new Vertex(100.0f, 100.0f, -100.0f));
            verts.Add(new Vertex(100.0f, -100.0f, -100.0f));
            verts.Add(new Vertex(-100.0f, -100.0f, -100.0f));
            verts.Add(new Vertex(-100.0f, 100.0f, -100.0f));

            return verts;
        }

        /// <summary>
        /// Generates Triangle Points
        /// </summary>
        /// <returns></returns>
        public static List<Vertex> Triangle()
        {
            List<Vertex> verts = new List<Vertex>();

            verts.Add(new Vertex(-100.0f, 100.0f, 100.0f));
            verts.Add(new Vertex(100.0f, 100.0f, -100.0f));
            verts.Add(new Vertex(0.0f, -100.0f, 100.0f));

            return verts;
        }

        /// <summary>
        /// Generates Random Points
        /// </summary>
        /// <param name="numVerts"></param>
        /// <param name="range">Abosolute Range</param>
        /// <returns></returns>
        public static List<Vertex> Random(int numVerts, float range)
        {
            Random r = new Random(DateTime.Now.Millisecond); // Sets seed based on time
            List<Vertex> verts = new List<Vertex>();

            while (numVerts > 0)
            {
                float x = (float)(Math.Pow(-1.0, r.Next() % 2)); // -1 raised to the power of 0 or 1
                x = x * (float)r.NextDouble() * range; // Result times random float between 0 and 1 times range 

                float y = (float)(Math.Pow(-1.0, r.Next() % 2));
                y = y * (float)r.NextDouble() * range;

                float z = (float)(Math.Pow(-1.0, r.Next() % 2));
                z = z * (float)r.NextDouble() * range;

                verts.Add(new Vertex(x, y, z));

                numVerts--;
            }

            return verts;
        }

        /// <summary>
        /// Generates Clover Points
        /// </summary>
        /// <returns></returns>
        public static List<Vertex> Clover()
        {
            List<Vertex> verts = new List<Vertex>();

            verts.Add(new Vertex(0.0f, 0.0f, 0.0f));

            verts.Add(new Vertex(50.0f, -20.0f, 0.0f));
            verts.Add(new Vertex(100.0f, 0.0f, 0.0f));
            verts.Add(new Vertex(50.0f, 20.0f, 0.0f));
            verts.Add(new Vertex(0.0f, 0.0f, 0.0f));

            verts.Add(new Vertex(-20.0f, -50.0f, 0.0f));
            verts.Add(new Vertex(0.0f, -100.0f, 0.0f));
            verts.Add(new Vertex(20.0f, -50.0f, 0.0f));
            verts.Add(new Vertex(0.0f, 0.0f, 0.0f));

            verts.Add(new Vertex(-50.0f, 20.0f, 0.0f));
            verts.Add(new Vertex(-100.0f, 0.0f, 0.0f));
            verts.Add(new Vertex(-50.0f, -20.0f, 0.0f));
            verts.Add(new Vertex(0.0f, 0.0f, 0.0f));

            verts.Add(new Vertex(20.0f, 50.0f, 0.0f));
            verts.Add(new Vertex(0.0f, 100.0f, 0.0f));
            verts.Add(new Vertex(-20.0f, 50.0f, 0.0f));
            verts.Add(new Vertex(0.0f, 0.0f, 0.0f));

            return verts;
        }
    }
}
