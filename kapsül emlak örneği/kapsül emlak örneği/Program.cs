using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsül_emlak_örneği
{
    internal class Program
    {
        static void Main(string[] args)
        {
            emlak a = new emlak();
            a.SEHİR = "istanbul";
            a.MAH = "akalan";
            a.KAT = -2;
            a.ODA = -5;
            a.KİRA = 1500;
            Console.WriteLine(a.SEHİR);
            Console.WriteLine(a.MAH);
            Console.WriteLine(a.KAT);
            Console.WriteLine(a.ODA);
            Console.WriteLine(a.KİRA);
            Console.ReadLine();
        }
    }
}
