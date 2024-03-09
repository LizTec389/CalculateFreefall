using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFreefall
{
    public class CalculateFreefall
    {
        public static double CalculateVelocityFinal(double height)
        {
            const double gravity = 9.8;/*  Acceleration due to gravity in m / s²*/
            return Math.Sqrt(2 * gravity * height);
        }


    }
}
