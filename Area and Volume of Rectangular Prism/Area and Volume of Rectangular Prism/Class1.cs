using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surface_Area_and_Volume_of_Rectangular_Prism
{
    public class Calc
    {
        private double SA;
        private double V;

        public Calc()
        {
            Console.WriteLine("Please Enter the Length number of your Rectangular Prism : ");
            double L = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Width number of your Rectangular Prism : ");
            double W = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Height number of your Rectangular Prism : ");
            double H = Double.Parse(Console.ReadLine());

            SA = 2 * (L * W + L * H + W * H);

            Console.WriteLine("Surface Area of Your Rectangular Prism Equal by : {0}.", SA);

            V = L * W * H;

            Console.WriteLine("Volume of Your Rectangular Prism Equal by : {0}.", V);
        }

    }


}
