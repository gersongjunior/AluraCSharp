using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variaveis");
        
        //variaveis int
        Console.WriteLine("Variaveis Int");
        int idade = 36;
        Console.WriteLine("A idade é " + idade);
        idade = 36 - 5;
        Console.WriteLine("A idade após a subtração é " + idade);

        //variaveis ponto flutuante
        Console.WriteLine("Variaveis ponto flutuante");
        double salario;
        salario = 3000.13;
        Console.WriteLine("O salário é de "+salario);

        //conversões de tipos
        Console.WriteLine("Conversão de tipos");

        double salariod;
        salariod = 5000.50;

        int salarioInteiro;
        salarioInteiro = (int)salariod;
        Console.WriteLine("Salario Double "+salariod);
        Console.WriteLine("Cast de double para int....Salario "+salarioInteiro);

        long x;
        x = 200000000000;

        Console.WriteLine("Variavel do tipo long "+x);

        short y;
        y = 15000;

        float altura = 1.78f;

        Console.WriteLine("Variavel do tipo short "+y);
        Console.WriteLine("Variavel do tipo float "+altura);

        //Caracteres e textos
        Console.WriteLine("Caracteres e textos");
        char letra = 'a';
        Console.WriteLine("Variavel do tipo char "+letra);

        letra = (char)65;
        Console.WriteLine("Cast de int para char "+letra);

        string primeiraFrase = "Cursos de tecnologia";
        Console.WriteLine("Variavel do tipo string "+primeiraFrase);


        string cursos = @"Cursos disponiveis: 
                            - C#
                            - Ruby
                            - Java";

        Console.WriteLine("Cursos com quebra de linha "+cursos);


        Console.ReadLine();

    }
}