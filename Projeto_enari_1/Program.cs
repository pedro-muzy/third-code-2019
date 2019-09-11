using System;

namespace Projeto_enari_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de usuários a inserir:");
            int qtd_cad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome:");
            string nome_digitado = Console.ReadLine();

            Console.WriteLine("Informe o cpf:");
            string cpf_digitado = Console.ReadLine();

            Console.WriteLine("Informe o email:");
            string email_digitado = Console.ReadLine();

            Console.WriteLine("Informe a senha:");
            string senha_digitada = Console.ReadLine();

        }
    }
}
