using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementCoverter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valueKm = 1.00m;

            const decimal MiCovertValue = 0.62137119m;

            decimal valueMi = MiCovertValue * valueKm;

            Console.WriteLine($"Your result from {valueKm} km to Mi is: {valueMi:0.00} mi");

            
            valueKm = valueMi / MiCovertValue;

            Console.WriteLine($"Your result from {valueMi:0.00} mi to Km is: {valueKm:0.00} km");
        }
    }
}
