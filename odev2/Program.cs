using System;

namespace odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());
            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());
            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());
            
            
            Result.solve(meal_cost,tip_percent,tax_percent);
        }

        class Result
        {
            public static void solve (double meal_cost, int tip_percent, int tax_percent)
            {
                double tip = (meal_cost/100)*tip_percent;
                double tax = (meal_cost/100)*tax_percent;
                double total_cost = meal_cost + tip + tax;
                Console.WriteLine(Math.Round(total_cost));
                Console.ReadLine();
            }
        }
    }
}
