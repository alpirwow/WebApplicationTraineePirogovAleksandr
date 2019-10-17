using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplicationTraineePirogovAleksandr.BusinessLayer.InterfacesAndService.Service.MathService
{
    /// <summary>
    /// Static class for converter
    /// </summary>
    public static class ConverterService
    {
        /// <summary>
        /// Converter positive number to binary
        /// </summary>
        /// <param name="number">Input number for converter</param>
        /// <returns>Binary string after convert</returns>
        public static string ConverterPositiveNumberToBinary(int number)
        {
            int numberNew = number;
            int countIn = 0;
            List<int> numberRootList = new List<int>();
            string binaryStringAfterConvert = "";
            string zeroForBinaryString = "0";
            string oneForBinaryString = "1";
            ///The cycle of finding powers of two
            while (numberNew > 1)
            {
                double y = numberNew;

                while (y > 1)
                {
                    y = Math.Floor(y * 0.5);
                    countIn++;
                }
                countIn++;
                numberRootList.Add(countIn);
                int a = Convert.ToInt32(Math.Pow(2, countIn - 1));
                numberNew -= a;
                countIn = 0;
            }
            ///Parity check, if the number is odd, then add 1 to the collection
            if (number %2 != 0)
            {
                numberRootList.Add(1);
            }
            ///Zero Fill Cycle
            for (int i = 0; i < numberRootList.Max(); i++)
            {
                binaryStringAfterConvert += zeroForBinaryString;
            }
            
            int binaryStringLength = binaryStringAfterConvert.Length;
            ///Added zeros for better looking
            while (binaryStringLength > 0)
            {
                binaryStringLength -= 4;
                if(binaryStringLength < 0)
                {
                    for(int i = binaryStringLength; i != 0; i++)
                    {
                        binaryStringAfterConvert += zeroForBinaryString;
                    }
                }
            }

            StringBuilder binaryStringBuilderAfterConvert = new StringBuilder(binaryStringAfterConvert);
            ///Unit allocation cycle
            foreach (var list in numberRootList)
            {
                binaryStringBuilderAfterConvert.Replace(zeroForBinaryString, oneForBinaryString, binaryStringBuilderAfterConvert.Length - list, 1);
            }

            binaryStringLength = binaryStringBuilderAfterConvert.Length;
            ///Added space for better looking
            for (int i = binaryStringLength; i > 0; i -= 4)
            {
                binaryStringBuilderAfterConvert.Insert(i, " ");
            }

            binaryStringAfterConvert = binaryStringBuilderAfterConvert.ToString();

            return binaryStringAfterConvert;
        }
    }
}
