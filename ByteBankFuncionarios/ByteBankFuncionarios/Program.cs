using ByteBankInter.Funcinários;
using System;

namespace ByteBankInter
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario Douglas = new Funcionario();

            Douglas.Nome = "Douglas";
            Douglas.Cpf = "49494944810";
            Douglas.Salario = 2000;

            gerenciador.Registrar(Douglas);

            Diretor Mariane = new Diretor();
            Mariane.Nome = "Mariane";
            Mariane.Cpf = "4545455590";
            Mariane.Salario = 5000;

            gerenciador.Registrar(Mariane);

            Console.WriteLine(Douglas.Nome);
            Console.WriteLine(Douglas.GetBonificacao());

            Console.WriteLine(Mariane.Nome);
            Console.WriteLine(Mariane.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            
        }
    }
}
