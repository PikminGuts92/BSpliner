using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSpliner
{
    public class Curve
    {
        public delegate void CalculationProgress(float p);
        public event CalculationProgress ProgressChanged;

        // Event that gives updated progress
        protected virtual void OnProgressChanged(float p)
        {
            CalculationProgress handler = ProgressChanged;
            if (handler == null) return; // No subscribers

            handler(p);
        }

        /// <summary>
        /// Calculates B-Spline points
        /// </summary>
        /// <param name="controlPoints">Input control points</param>
        /// <param name="degree">Degree</param>
        /// <param name="steps">Count of generated B-Spline points</param>
        /// <returns>B-Spline points</returns>
        public List<Vertex> GenerateBSpline(List<Vertex> controlPoints, int degree, int steps)
        {
            List<Vertex> newPoints = new List<Vertex>();
            float inc = 1.0f / steps;
            //degree = controlPoints.Count;
            // # of Knots = m + 1 = p + n + 1
            //              m + 1 = (Control Points - 1) + Degree + 1
            //              m + 1 = Control Points + Degree
            int knotCount = controlPoints.Count + degree + 1;
            float[] T = GenerateKnotsUniform(knotCount, 0.0f, 1.0f);

            // Updates event - Start
            OnProgressChanged(0.0f);

            for (float t = 0.0f; t <= 1.0f; t += inc)
            {
                Vertex v = GetBSplinePoint(controlPoints, degree, t, T);
                newPoints.Add(v);

                // Updates event - During
                OnProgressChanged(t);
            }

            // Updates event - End
            OnProgressChanged(1.0f);

            return newPoints;
        }

        /// <summary>
        /// Generates knots and spreads values uniformly (Cardinal B-Spline)
        /// </summary>
        /// <param name="count"># Knots</param>
        /// <param name="min">Minimum Value</param>
        /// <param name="max">Maximum Value</param>
        /// <returns></returns>
        private float[] GenerateKnotsUniform(int count, float min, float max)
        {
            float[] T = new float[count]; // Knots
            float frac = (max - min) / (T.Length - 1);
            float total = min;

            // Generates knot values - Uniformly
            for (int i = 0; i < T.Length; i++)
            {
                if (i == T.Length - 1)
                {
                    T[i] = max;
                    break;
                }

                T[i] = total;
                total += frac;
            }

            // Returns knots
            return T;
        }

        /// <summary>
        /// Calculates B-Spline summation of point
        /// </summary>
        /// <param name="points">Control points</param>
        /// <param name="p">Degree</param>
        /// <param name="t"># of knots - 1</param>
        /// <param name="T">Knot vector</param>
        /// <returns></returns>
        private Vertex GetBSplinePoint(List<Vertex> points, int p, float t, float[] T)
        {
            float xSum = 0.0f;
            float ySum = 0.0f;
            float zSum = 0.0f;

            // Loops for total # of points in list (Summation)
            for (int i = 0; i < points.Count; i++)
            {
                // Calculates B-Spline point for each point (Point * Basis)
                xSum += points[i].X * GetBSplineBasis(i, p, t, T);
                ySum += points[i].Y * GetBSplineBasis(i, p, t, T);
                zSum += points[i].Z * GetBSplineBasis(i, p, t, T);
            }

            // Returns B-Spline point fron summation
            return new Vertex(xSum, ySum, zSum);
        }

        /// <summary>
        /// Recursive basis function for B-Spline
        /// </summary>
        /// <param name="i">Point Index</param>
        /// <param name="j">Degree</param>
        /// <param name="t">Step (Time)</param>
        /// <param name="T">Knots</param>
        /// <returns></returns>
        private float GetBSplineBasis(int i, int j, float t, float[] T)
        {
            // Base case
            if (j == 0)
            {
                if (T[i] <= t && t < T[i + 1])
                    return 1.0f;
                else
                    return 0.0f;
            }

            // Recursive step
            float answer = ((t - T[i]) / (T[i + j] - T[i])) * GetBSplineBasis(i, j - 1, t, T);
            answer += ((T[i + j + 1] - t) / (T[i + j + 1] - T[i + 1])) * GetBSplineBasis(i + 1, j - 1, t, T);

            return answer;
        }
        
    }
}
