using System;
using System.Collections.Generic;

namespace InheritanceProject
{

    class Program:Carmanufacturer //run stuff
    {
        static void Main()
        {
            Console.WriteLine("Type the number of the car brand you want and press enter.");
            Console.WriteLine("0. Volkswagen, 1. BMW, 2. Audi, 3. Volvo, 4. Ford.");
            List<string> carBrands = new List<string>();
            carBrands.Add("vw");
            carBrands.Add("bmw");
            carBrands.Add("Audi");
            carBrands.Add("Volvo");
            carBrands.Add("Ford");
            int Brand = int.Parse(Console.ReadLine());
            Console.ReadKey();

            
            Console.WriteLine("Now choose the size of the car. You can type either:" +
                "s (small) " +
                "m (medium) " +
                "l (large).");
            string size = Console.ReadLine();
            Console.ReadKey();
            Carmanufacturer ccf = new Carmanufacturer();
            if (size == "s")
            {
                ccf.SmallCarModel(carBrands[Brand]);
            }
            else if (size == "m")
            {
                ccf.MediumCarModel(carBrands[Brand]);
            }
            else if (size == "l")
            {
                ccf.BigAssCarModel(carBrands[Brand]);
            }
            Console.ReadKey();



            
            

            

        }
    }

}
