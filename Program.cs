using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_5_inheritance
{
    class Program
    {
        class product
        {

            protected string brand;


            public void setdata(string b)
            {
                brand = b;



            }

            public void displaybrand()
            {
                Console.WriteLine("The brand : " + brand);
            }




        }

        class tv : product
        {
            private int warrantyperiod;

            public void setwarrantyperiod(int w)
            {
                warrantyperiod = w;
            }

            public void displaywarrantyperiod()
            {
                Console.WriteLine("The warranty period : " + warrantyperiod + " Months");
            }


        }
        static void Main(string[] args)
        {
            tv tv1 = new tv();
            tv1.setdata("sony");
            tv1.displaybrand();
            tv1.setwarrantyperiod(10);
            tv1.displaywarrantyperiod();


            Console.ReadKey();
        }
    }
}
