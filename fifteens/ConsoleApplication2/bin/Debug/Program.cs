using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteens
{
    class Program
    {
        static void Main(string[] args)
        {
            Game3 field = new Game3(1, 6, 4, 0, 2, 3, 5, 7, 8, 11, 10, 9, 14, 12, 13, 15);
            Game2 field1 = Game2.Randomize(field);
            field.Shift(4);
            field.Shift(5);
            field.Shift(10);
            Print.PrintInfo(field, 4);
            Console.WriteLine("Array before randomaize and after.");
            Print.PrintInfo(field1, 4);
            Console.WriteLine(field.GetStep(1));
            Console.WriteLine(field.GetStep(2));
            Console.WriteLine(field.GetStep(3));
        }
    }
}
