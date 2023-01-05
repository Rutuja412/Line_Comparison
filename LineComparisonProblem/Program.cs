using System;

namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison");
            //LenghtOfLine lenghtOfLine = new LenghtOfLine();
            //lenghtOfLine.Calculate();

            CheckEquality checkEquality = new CheckEquality();
            checkEquality.Equality();
        }
    }
}
