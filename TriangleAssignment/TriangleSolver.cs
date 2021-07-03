using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleAssignment
{
    public static class TriangleSolver
    {
        static string triangletype;

        public static string Analyze(int Side_A, int Side_B, int Side_C)
        {
            if (((Side_A + Side_B) > Side_C) && ((Side_B + Side_C) > Side_A) && ((Side_A + Side_C) > Side_B))
            {
                if (Side_A == Side_B && Side_B == Side_C)
                {
                    triangletype = "Equilateral";
                }

                else if (Side_A == Side_B || Side_A == Side_C || Side_B == Side_C)
                {
                    triangletype = "Isoceles";
                }

                else if (Side_A != Side_B && Side_B != Side_C && Side_A != Side_C)
                {

                    triangletype = "Scalene";
                }
            }

            return triangletype;
        }

    }



}
