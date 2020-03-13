using System;

namespace ShopLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Order myOrder = new Order(10, 20);
            Order cloneOrder = myOrder.clone();

            
            cloneOrder.TotalCost = 20;
            cloneOrder.WeightInKG = 40;

            Console.WriteLine("---------------------");
            Console.WriteLine("Orignial Cost " + myOrder.TotalCost);
            Console.WriteLine("Orignial Weight " + myOrder.WeightInKG);
            Console.WriteLine("---------------------");
            Console.WriteLine("Cloned Cost " + cloneOrder.TotalCost);
            Console.WriteLine("Cloned Weight " + cloneOrder.WeightInKG);
            Console.WriteLine("---------------------");
        }
    }
}
