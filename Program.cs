using System;
using System.ComponentModel;
using System.Text;

namespace Monkey
{
    class MonkeyProgram {

        static void Main(string[] args)
        {

            string test = "Big Boi";
            Console.WriteLine(ConvertToHex(test));

        }

        static string ConvertToHex(string ToConvert)
        {   

            
            byte[] ConvertedBytes = Encoding.UTF8.GetBytes(ToConvert);


            string Converted = BitConverter.ToString(ConvertedBytes);
            Converted = Converted.Replace("-", " ");
            

            return Converted;

        }

    
    }

}