using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age;
            //Console.Write("When did you born: [    ]\b\b\b\b\b");
            //age = Convert.ToInt32(Console.ReadLine());
            ////Int is 4 bit ==== 4* 8 bits = 32 bits So Convert.ToInt32
            //// If it is short age then it will be 2*8bits Convert.ToInt16;
            //Console.WriteLine("*********************");
            //Console.WriteLine($"You are {2024 - age}");
            //Console.WriteLine("*********************");


            Console.WriteLine("******************ExPargo Electronics******************");
            Console.Write("How Much TV Do you Want [ ]\b\b");
            int NumberTV = Convert.ToInt32(Console.ReadLine());


            int CostTVWT = 1000 * NumberTV;
            int CostTVT = CostTVWT + (CostTVWT*4/100);
            Console.WriteLine($"One TV is 1000 Zloty. So The cost is : [{CostTVWT}]");
            Console.WriteLine($"Tax Rate is 4% So Total costs of TV is [{CostTVT}]");
            Console.Write("How much to your Home From Here [   ]\b\b\b\b");
            int distance = Convert.ToInt32(Console.ReadLine());
            int DistanceCost = distance * 10;
            Console.WriteLine($"Total Cost is : {CostTVT+DistanceCost} Zloty");
            Console.WriteLine("*************************************");



           
        }
    }
}
