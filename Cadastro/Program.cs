using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            Tela C;

            Console.WriteLine("Cadastro de  entrada");
            Console.WriteLine("insira o dados nescessarios");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            int cpf = int.Parse(Console.ReadLine());
            Console.Write("Endereco: ");
            string endereco = Console.ReadLine();

            C = new Tela(nome, cpf, endereco);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Informacoes adicionadas sao: ");

            
        }
    }
}
