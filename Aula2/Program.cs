using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();


            Console.Write("Digite o código do produto: ");
            prod.setCodigo(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Digite a descrição do produto: ");
            prod.setDescricao(Console.ReadLine());

            Console.Write("Digite o valor do produto: ");
            prod.setValor(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Digite a categoria do produto: ");
            prod.setCategoria(Console.ReadLine());



            Console.WriteLine(prod.getCodigo());
            Console.WriteLine(prod.getValor());
            Console.WriteLine(prod.getDescricao());
            Console.WriteLine(prod.getCategoria());

            Console.ReadKey();


        }
    }
}
