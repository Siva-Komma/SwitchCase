using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSwitch
{
     class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("1.Addition\n 2.Subtraction\n 3.Multiplication\n 4.Division\n");
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    
                    int sum = num1 + num2;
                    Console.WriteLine("the sum of the numbers" + sum);
                    break;
                case 2:
                    
                    int sub = num1 - num2;
                    Console.WriteLine("the sum of the numbers" + sub);
                    break;
                case 3:
                    
                    int mul = num1 * num2;
                    Console.WriteLine("the sum of the numbers" + mul);
                    break;
                
               case 4:
                    
                    int div = num1 / num2;
                    Console.WriteLine("the sum of the numbers" + div);
                    break;

            }
            Console.ReadLine();

        }
    }
}
