using System;
using WebApplicationTraineePirogovAleksandr.BusinessLayer.InterfacesAndService.Service.MathService;

namespace WebApplicationTraineePirogovAleksandr.BusinessLayer.InterfacesAndService.Service
{
    /// <summary>
    /// Main class for math computing
    /// </summary>
    public class MainService
    {
        /// <summary>
        /// Static method for convert type "string" to type "double" with replace "." to "," and calling NewtonService.NewtonMethod.
        /// </summary>
        /// <param name="numberUnderTheRootString">Number under the root. Type - String.</param>
        /// <param name="rootLevel">Root level. Type - int.</param>
        /// <param name="epsilonString">Epsilon. Type - String.</param>
        /// <returns>Double result</returns>
        public static double NewtonMain(string numberUnderTheRootString, int rootLevel, string epsilonString)
        {
            var epsilonDouble = Convert.ToDouble(epsilonString.Replace('.',','));
            var numberUnderTheRootDouble = Convert.ToDouble(numberUnderTheRootString.Replace('.', ','));

            if (epsilonDouble >= 1)
            {
                epsilonDouble = 0.0000001;
            }           

            var result = NewtonService.NewtonMethod(numberUnderTheRootDouble, rootLevel, epsilonDouble);
            
            return result;
        }
        /// <summary>
        /// A positive number is checked
        /// </summary>
        /// <param name="number">Input number for converter</param>
        /// <returns>If true returns a binary string, if false then an error message</returns>
        public static string ConverterMain(int number)
        {
            if (number > 0)
            {
                return ConverterService.ConverterPositiveNumberToBinary(number);
            }
            else
            {
                return "The entered number is less than or equal to zero";
            }
        }
    }
}
