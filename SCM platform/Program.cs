using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCM_platform
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductClass pc = new ProductClass();
           
            Console.Write("Please Enter the quantity for Product A : ");

            int quantityA = Convert.ToInt32(Console.ReadLine());          
          
            Console.Write("Please Enter the quantity for Product B : ");
            int quantityB = Convert.ToInt32(Console.ReadLine());
       
           
            Console.Write("Please Enter the quantity for Product C : ");
            int quantityC = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter the quantity for Product D : ");
            int quantityD = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> numberNames = new Dictionary<string, int>();
            
            numberNames.Add("ProductA", quantityA);
            numberNames.Add("ProductB", quantityB);
            numberNames.Add("ProductC", quantityC);
            numberNames.Add("ProductD", quantityD);
           
            int D1 = pc.sumproduct(numberNames);
            Console.Write("Final Cart values are : " + D1);
            Console.ReadLine();



        }
    }
}
