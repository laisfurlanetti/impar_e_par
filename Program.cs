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

            int numero;

            Console.Write("Digite um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Epar(numero);

            Console.Read(); 
        }
        public static void Epar(int numero)
        {
            if (numero % 2 == 0)
                Console.Write("Seu numero e par");
            else
                Console.Write("Seu numero e impar");
        }
    }
}
