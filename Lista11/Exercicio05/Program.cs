using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            Console.WriteLine("Local Time Zone ID: {0}", localZone.Id);
            Console.WriteLine("   Display Name is: {0}.", localZone.DisplayName);
            Console.WriteLine("   Standard name is: {0}.", localZone.StandardName);
            Console.WriteLine("   Daylight saving name is: {0}.", localZone.DaylightName);
            //Console.WriteLine("Informe a data no formato dd/mm/aaaa hh:mm");
            //Cinema x = new Cinema(DateTime.Parse(Console.ReadLine()));
            Cinema x = new Cinema(DateTime.Now);
            Console.WriteLine(x);
            Console.WriteLine(x.GetInteira());
            Console.ReadKey();
        }
    }
}
