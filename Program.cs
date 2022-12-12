using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6_cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Jack", Gender.Male);

            cat1.Jump();
            cat1.Jump();
            cat1.Jump();
            cat1.Jump();
            cat1.Jump();
            cat1.Jump();
            cat1.Jump();
            cat1.CheckEnergy();
            cat1.Jump();
            cat1.Jump();
            cat1.Jump();
            cat1.CheckEnergy();
            cat1.Sleep();
            cat1.Sleep();



            Console.ReadKey();
        }
    }
}
