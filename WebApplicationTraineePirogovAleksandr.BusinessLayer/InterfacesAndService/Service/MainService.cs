using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationTraineePirogovAleksandr.BusinessLayer.InterfacesAndService.Service.MathService;

namespace WebApplicationTraineePirogovAleksandr.BusinessLayer.InterfacesAndService.Service
{
    public class MainService
    {
        MainService()
        {

        }

        public static double NewtonMain(string numberUnderTheRootString, int rootLevel, string epsilonString)
        {
            var epsilonDouble = Convert.ToDouble(epsilonString.Replace('.',','));

            if(epsilonDouble >= 1)
            {
                epsilonDouble = 0.0000001;
            }

            var numberUnderTheRootDouble = Convert.ToDouble(numberUnderTheRootString.Replace('.', ','));

            var result = NewtonService.NewtonMethod(numberUnderTheRootDouble, rootLevel, epsilonDouble);
            
            return result;
        }

        public static double NewtonMain(string numberUnderTheRoot, int rootLevel)
        {
            string epsilon = "0.0000001";

            var result = NewtonMain(numberUnderTheRoot, rootLevel, epsilon);

            return result;
        }
    }
}
