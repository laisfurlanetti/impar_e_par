using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace par_e_impar
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal n1;

            Console.Write("Digite um numero: ");
            n1 = Convert.ToDecimal(Console.ReadLine());

            if (n1 % 2 == 0)
                Console.Write("Seu numero e par");
            else
                Console.Write("Seu numero e impar");

            Console.Read();

        }
    }
}
