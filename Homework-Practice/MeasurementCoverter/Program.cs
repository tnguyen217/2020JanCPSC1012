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
            decimal yourKm = 1.00m;

            const decimal MiCovertValue = 0.62137119m;

            decimal valueMi = MiCovertValue * yourKm;

            Console.WriteLine($"Your result from {yourKm} km to Mi is: {valueMi:0.00} mi");



            decimal yourMi = 1.00m;

            decimal valueKm = yourMi / MiCovertValue;

            Console.WriteLine($"Your result from {yourMi:0.00} mi to Km is: {valueKm:0.00} km");
        }
    }
}
