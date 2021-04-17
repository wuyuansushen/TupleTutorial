using System;

namespace TupleTutorial
{
    class Program
    {
        static (int interger,double decimalPart) separateDouble(double PNumber)
        {
            double outDec = PNumber % 1;
            int outInt = (int)(PNumber - outDec);

            return (outInt, outDec);
        }
        static void Main(string[] args)
        {
            var outTest = separateDouble(113.514);
            Console.WriteLine($"{outTest.interger}\n{outTest.decimalPart:F3}\n{outTest.GetType()}");
        }
    }
}
