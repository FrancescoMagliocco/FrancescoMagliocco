using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    using System.IO;
    using System.Management;

    using FrancescoMagliocco.Utils.Helpers;

    class Program
    {
        static void Main(string[] args)
        {
            

            var g = 111111111111111111111111111111111111111F;

            var h = 11111111111111111111111111111l;
            Console.WriteLine(double.MaxValue.ToString("0"));
            Console.ReadKey();
            return;


            var allText = File.ReadAllLines(@"C:\Users\Anonr\Desktop\OSType.txt");

            var sB = new StringBuilder();

            for (var index = 1; index < allText.Length; index += 2)
            {
                
                
                    var str = allText[index];
                    sB.AppendLine("/// <summary>");
                    sB.AppendLine("/// " + str);
                    sB.AppendLine("/// </summary>");
                sB.AppendLine(str.Replace(" ", string.Empty).Replace("(", string.Empty).Replace(")", string.Empty).Replace("/", "_") + " = " + allText[index - 1].Split(new[] { '(' }, StringSplitOptions.RemoveEmptyEntries)[1].Replace(')', ','));
                sB.AppendLine();

                

            }

            File.WriteAllText(@"C:\Users\Anonr\Desktop\Types.txt", sB.ToString());



            Console.ReadKey();

        }
    }
}
