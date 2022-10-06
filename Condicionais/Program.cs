using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Condicionais");

        int idadeJoao = 17;
        int qtdDePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Idade do Joao " + idadeJoao);
            Console.WriteLine("Acesso liberado");
        }
        else
        {
            if (qtdDePessoas > 1)
            {
                Console.WriteLine("Idade do Joao " + idadeJoao);
                Console.WriteLine("Qtd De pessoas " + qtdDePessoas);
                Console.WriteLine("Acesso Liberado, Joao esta acompanhado");
            }
            else
            {
                Console.WriteLine("Idade do Joao " + idadeJoao);
                Console.WriteLine("Acesso negado");

            }
        }

    }
}

