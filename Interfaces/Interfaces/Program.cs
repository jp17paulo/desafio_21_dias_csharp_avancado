using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Abstração

            Console.WriteLine("========TUP========");
            var veiculo = new Tup();
            veiculo.Ano = 2020;
            veiculo.Nome = "004DV";
            veiculo.Salvar();

            Console.WriteLine("========TORNESE========");
            var veiculo2 = new Tornese();
            veiculo2.Ano = 2020;
            veiculo2.Nome = "005DV";
            veiculo2.Salvar();
        }
    }
}
