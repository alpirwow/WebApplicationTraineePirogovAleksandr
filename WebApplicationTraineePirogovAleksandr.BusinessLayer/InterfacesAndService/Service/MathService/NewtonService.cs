using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationTraineePirogovAleksandr.BusinessLayer.InterfacesAndService.Service.MathService
{
    public static class NewtonService
    {
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
