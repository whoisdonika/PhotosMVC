using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photos.View
{
    internal class Display
    {
        public int Count { get; set; }
        public string Size { get; set; }
        public string OrderMethod { get; set; }
        public double TotalSum { get; set; }
        public double Discount { get; set; }
        public double Sum {  get; set; }
        public void Input()
        {
            Console.Write("Enter the photos' count : ");
            int photoCount = int.Parse(Console.ReadLine());
            this.Count = photoCount;

            Console.Write("Enter the photos' size (9X13, 10X15, 13X18, 20X30) : ");
            string photoSize = Console.ReadLine();
            this.Size = photoSize;

            Console.Write("Will you order online or in the office? - ");
            string method = Console.ReadLine();
            this.OrderMethod = method;
        }
        
        public void Output()
        {
            Console.WriteLine($"Your sum before the discount was {this.Sum:f2}lv.");
            Console.WriteLine($"Your discount is {this.Discount :f2}lv.");
            Console.WriteLine($"Your total sum is {this.TotalSum:f2}lv.");
        }
    }
}
