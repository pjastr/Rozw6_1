using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozw_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba student1 = new Student("Jan", "Kowalski",1,2,34567);
            student1.WypiszInfo();


            Console.ReadKey();
        }
    }
}
