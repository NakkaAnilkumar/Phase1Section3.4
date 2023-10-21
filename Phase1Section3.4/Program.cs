using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section3._4
{
     class Program
    {
        static void Main(string[] args)
        {
            doApp();
            Console.ReadLine();
        }

        static public void doApp()
        {

            bool xbool = true;
            byte xbyte = 250;
            sbyte xsbyte = -125;
            char xchar = 'h';
            decimal xdecimal = 92.9M;
            double xdouble = 652.09;
            float xfloat = 426.1f;
            int xint = -8909;
            uint xuint = 91890;
            long xlong = -1313412012;
            ulong xulong = 01919441;
            object xobject = new object();
            short xshort = -19;
            ushort xushort = 17;
            string xstring = "Anil";

            if (xbool == true && xbyte < 300)
                Console.WriteLine("This expression evaluates to true");
            if (xshort > 6 || xint > -9000)
                Console.WriteLine("This expression evaluates to false");

            
        }



    }
}

