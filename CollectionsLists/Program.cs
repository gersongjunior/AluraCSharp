using System;

class Program
{
    static void Main(string[] args)
    {
        string aulaIntro = "Introdução às coleções";
        string aulaModelando = "Modelando a Classe Aula";
        string aulaSets = "Trabalhando com conjuntos";

        //List<string> aulas = new List<string>
        //{
        //    aulaIntro,
        //    aulaModelando,
        //    aulaSets
        //};

        List<string> aulas = new List<string>();
        aulas.Add(aulaIntro);
        aulas.Add(aulaModelando);
        aulas.Add(aulaSets);
        
        Imprimir(aulas);

        Console.WriteLine("A primeira aula é "+ aulas[0]);
        Console.WriteLine("A primeira aula é "+ aulas.First());
        Console.WriteLine("A última aula é "+ aulas[aulas.Count -1]);
        Console.WriteLine("A última aula é "+ aulas.Last());


    }

    private static void Imprimir(List<string> aulas)
    {
        //apresentando as informações da lista com foreach
        //foreach (var aula in aulas)
        //{
        //    Console.WriteLine(aula);
        //}

        //apresentando as informações da lista com for
        //for (int i = 0; i < aulas.Count; i++)
        //{
        //    Console.WriteLine(aulas[i]);
        //}

        aulas.ForEach(aula =>
        {
            Console.WriteLine(aula);
        });

    }
}