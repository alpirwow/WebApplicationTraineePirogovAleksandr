using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationTraineePirogovAleksandr.BusinessLayer.InterfacesAndService.Service.MathService
{
    /// <summary>
    /// Class for calculating the root of the N degree from a number by the Newton method with a given accuracy
    /// </summary>
    public static class NewtonService
    {
        /// <summary>
        /// Static method for calculating the root of the N degree from a number by the Newton method with a given accuracy
        /// </summary>
        /// <param name="numberUnderTheRoot"> Number under the root. Type - double.</param>
        /// <param name="rootLevel">Root level. Type - int.</param>
        /// <param name="epsilon">Epsilon. Type - double</param>
        /// <returns>Double result</returns>
        public static double NewtonMethod(double numberUnderTheRoot, int rootLevel, double epsilon) 
        {
            double result = numberUnderTheRoot;
            double prev = 0;
            while (Math.Abs(prev - result) >= epsilon)
            {
                prev = result;
                result = (1.0 / rootLevel) * ((rootLevel - 1) * result + numberUnderTheRoot / (Math.Pow(result, rootLevel - 1)));
            }
            return result;
        }
    }
}
