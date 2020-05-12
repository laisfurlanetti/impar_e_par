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

            decimal numero;

            Console.Write("Digite um numero: ");
            numero = Convert.ToDecimal(Console.ReadLine());

            if (numero % 2 == 0)
                Console.Write("Seu numero e par");
            else
                Console.Write("Seu numero e impar");

            Console.Read();

        }
    }
}
