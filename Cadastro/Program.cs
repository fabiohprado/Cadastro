using System;
using System.Globalization;
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
            double cpf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Endereco: ");
            string endereco = Console.ReadLine();

            C = new Tela(nome, cpf, endereco);

            Console.Clear();

            Console.WriteLine("Informacoes adicionadas sao: ");
            Console.Write(C);

            Console.ReadLine();
            
        }
    }
}
