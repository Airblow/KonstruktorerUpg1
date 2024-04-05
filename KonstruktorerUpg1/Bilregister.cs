using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonstruktorerUpg1
{
    class Bilregister
    {
        private string brand;
        private string carModel;
        private string carColor;
        private int productionYear;
        private int distanceTraveled;

        public Bilregister(string b, string cM, string cC, int pY, int dT)
        {
            brand = b;
            carModel = cM;
            carColor = cC;
            productionYear = pY;
            distanceTraveled = dT;

        }

        public void Output(string b, string cM, string cC, int pY, int dT)
        {
            Console.WriteLine(b);
            Console.WriteLine(cM);
            Console.WriteLine(cC);
            Console.WriteLine(pY);
            Console.WriteLine(dT);
        }
    }
}
