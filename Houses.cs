using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._1._1
{
    public class Houses
    {
        public int Number {  get; set; }
       public  string Street { get; set; }
        public string Type { get; set; }
        public Houses() 
        {
            Console.WriteLine("Type House Numer");
            Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type Street name");
            Street = Console.ReadLine();
            Console.WriteLine("Type House type such as Colonial or Ranch");
            Type = Console.ReadLine();

        }
    }
}
