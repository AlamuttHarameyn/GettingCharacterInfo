using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._14._2_IfElseYapisi
{
    class KarakterBilgisiAlma
    {
        static void Main(string[] args)
        {
            var k = (char)Console.Read(); //gelen ifadeyi karakter yaptık
            if (char.IsDigit(k)) //rakam mı
            {
                Console.WriteLine("Rakamdır!");
            }
            else if (char.IsLower(k))//kucuk mu
            {
                Console.WriteLine("Kucuk karakter");
            }
            else if (char.IsUpper(k)) //buyuk mu
            {
                Console.WriteLine("Buyuk karakter");
            }
            else //hiçbiri değilse bilinmeyen
            {
                Console.WriteLine("bilinmeyen karakter");
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
