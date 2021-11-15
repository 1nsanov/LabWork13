using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            var landPlot = new LandPlot(400, 300);
            landPlot.Square();
            Console.WriteLine(landPlot);

            var cornField = new Field("Кукуруза", 16, 500, 800);
            cornField.Square();
            Console.WriteLine(cornField);

            Console.ReadLine();
        }
    }
}
