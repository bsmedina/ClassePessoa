using System;

namespace ClassePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite o nome:");
            pessoa.nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            pessoa.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu rg:");
            pessoa.rg = Console.ReadLine();

            Console.WriteLine("Digite seu CPF:");
            pessoa.cpf = Console.ReadLine();

            Console.WriteLine("Nome: {0}", pessoa.nome);
            Console.WriteLine("Idade: {0}", pessoa.idade);
            Console.WriteLine("RG: {0}", pessoa.rg);
            Console.WriteLine("CPF: {0}", pessoa.cpf);

            Pessoa pessoaDiego = new Pessoa();
            pessoaDiego.nome = "Diego Fernando";
            pessoaDiego.idade = 33;
            pessoaDiego.rg = "11.111.111-1";
            pessoaDiego.cpf = "111.111.111-11";

            Console.WriteLine("Nome: {0}", pessoa.nome);
            Console.WriteLine("Idade: {0}", pessoa.idade);
            Console.WriteLine("RG: {0}", pessoa.rg);
            Console.WriteLine("CPF: {0}", pessoa.cpf);

            pessoa.Acenar(pessoaDiego);
            pessoa.PerguntaIdade(pessoaDiego);
        }
    }
}
