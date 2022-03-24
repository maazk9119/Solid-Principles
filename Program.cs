using System;
using Solid.Principles._1_SingleResponsibility_Principle;
using Solid.Principles._2_Open_Closed_Principle;
using Solid.Principles._3_Liskov_Substitution_Principle;
using Solid.Principles._4_Interface_Segregation_Principle;
using Solid.Principles._5_Depedency_Inversion_Principle;

namespace Solid.Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            singleResponsibilityPrinciple.Start();
            openClosedPrinciple.Start();
            liskovSubstitutionPrinciple.Start();
            interfaceSegregationPrinciple.Start();
            dependencyInversionPrinciple.Start();


            Console.ReadLine();
        }
    }
}
