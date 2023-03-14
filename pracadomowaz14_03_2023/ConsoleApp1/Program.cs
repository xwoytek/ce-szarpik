

namespace pracadomowaz14_03_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dej wage (kg)");
            double waga = double.Parse(Console.ReadLine());
            Console.WriteLine("dej wzrost (m)");
            double wzrost = double.Parse(Console.ReadLine());
            double bmi = waga / Math.Pow(wzrost, 2);
            switch (bmi)
            {
                case < 16:
                    Console.WriteLine($"{bmi} bmi - starvation");
                    break;
                case > 16 and <16.99:
                    Console.WriteLine($"{bmi} bmi - emaciation");
                    break;
                case > 17 and < 18.49:
                    Console.WriteLine($"{bmi} bmi - underweight");
                    break;
                case > 18.5 and < 24.99:
                    Console.WriteLine($"{bmi} bmi - correct value");
                    break;
                case > 25 and < 29.99:
                    Console.WriteLine($"{bmi} bmi - overweight");
                    break;
                case > 30 and < 34.99:
                    Console.WriteLine($"{bmi} bmi - Obesity I degree");
                    break;
                case > 35 and < 39.99:
                    Console.WriteLine($"{bmi} bmi - 2nd degree of obesity");
                    break;
                case > 40:
                    Console.WriteLine($"{bmi} bmi - extreme obesity");
                    break;
                default:
                    Console.WriteLine($"{bmi} bmi - Was du schprecht?");
                    break;
            }
            Console.ReadLine();
        }
    }
}
