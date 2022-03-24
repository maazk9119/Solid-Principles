using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Principles._2_Open_Closed_Principle
{
    public class openClosedPrinciple
    {
        public static void Start()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = 5;
            rectangle.Height = 5;

            Square square = new Square();
            square.Length = 2;
            square.Breadth = 2;

            var shapes = new IShape[2];
            shapes[0] = rectangle;
            shapes[1] = square;

            List<double> areas = Calculation.AreaCalculator(shapes);

            foreach (var area in areas)
            {
                Console.WriteLine("Area :" + area);
            }
        }
    }


    public interface IShape
    {
        double Length { get; set; }

        double Breadth { get; set; }

        double Height { get; set; }

        double Radius { get; set; }

        double CalculateArea();
    }

    public class Square : IShape
    {
        public double Length { get; set; } = 10;
        public double Breadth { get; set; } = 10;
        public double Height { get; set; } = 10;
        public double Radius { get; set; } = 10;


        public double CalculateArea()
        {
            return this.Length * this.Breadth;
        }
    }

    public class Rectangle : IShape
    {
        public double Length { get; set; } = 10;
        public double Breadth { get; set; } = 20;
        public double Height { get; set; } = 5;
        public double Radius { get; set; } = 10;


        public double CalculateArea()
        {
            return this.Length * this.Height;
        }
    }

    public static class Calculation
    {
        public static List<double> AreaCalculator(IShape[] shapes)
        {
            List<double> SquaresArea = new List<double>();

            foreach (var shape in shapes)
            {
                double tempArea = shape.CalculateArea();
                SquaresArea.Add(tempArea);
            }

            return SquaresArea;
        }
    }
}
