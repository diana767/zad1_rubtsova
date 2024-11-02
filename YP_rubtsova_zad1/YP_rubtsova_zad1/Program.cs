using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_rubtsova_zad1
{
    
    class Program
    {
        static void Main(string[] args)
        {
       
            Cat catt = new Cat();
            Console.WriteLine("Введите имя вашего котика");
            string name = Console.ReadLine();
            catt.Name = name;
            Console.WriteLine("Введите вес вашего котика");
            double ves = Convert.ToDouble(Console.ReadLine());        
            catt.Ves = ves;
            catt.Meow();
            Console.ReadKey();
        }
    }

    
}
