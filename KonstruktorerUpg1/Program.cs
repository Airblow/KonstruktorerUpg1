using System;
using System.Xml;

namespace KonstruktorerUpg1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool failsafe = false;

            while (failsafe != true)
            {
                try
                {
                    Console.WriteLine("Skapa ett bilregister");
                    Console.WriteLine("Skriv in bilens märke");
                    string brand = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Skriv in bilens modell");
                    string carModel = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Skriv in bilens färg");
                    string carColor = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Vilket år producerades bilen");
                    int productionYear = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Hur långt har bilen körts? (I KM)");
                    int distanceTraveled = int.Parse(Console.ReadLine());
                    Console.Clear();


                    Bilregister b1 = new Bilregister(brand, carModel, carColor, productionYear, distanceTraveled);

                    b1.Output(brand, carModel, carColor, productionYear, distanceTraveled);
                }
                catch
                {
                    Console.WriteLine("Något gick fel, försök igen.");
                    Console.ReadLine();
                    Console.Clear();
                }

            }

        }

        
    }

}