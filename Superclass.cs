using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceProject
{
    class Carmanufacturer
    {
        public void SmallCarModel(string brand)
        {
            Console.WriteLine("This " + brand + " car is tiny");
        }
        public void MediumCarModel(string brand)
        {
            Console.WriteLine("This " + brand + "car is medium");
        }
        public void BigAssCarModel(string brand)
        {
            Console.WriteLine("This " + brand + " car is huge. (Good luck paying for gas.)");
        }
    }
}
