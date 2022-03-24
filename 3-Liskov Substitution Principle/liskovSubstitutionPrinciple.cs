using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles._3_Liskov_Substitution_Principle
{
    public class liskovSubstitutionPrinciple
    {
        public static void Start()
        {
            Vehicle car = new car();
            Console.WriteLine(car.getType());

            Vehicle truck = new Truck();
            Console.WriteLine(truck.getType());
        }
    }


    public abstract class Vehicle
    {
        public abstract string getType();
    }
    public class Truck : Vehicle
    {
        public override string getType()
        {
            return "Truck";
        }
    }

    public class car : Vehicle
    {
        public override string getType()
        {
            return "Car";
        }
    }
}
