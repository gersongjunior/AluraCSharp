using System;

class Program
{
    static void Main(string[] args)
    {
        string aulaIntro = "Introdução às coleções";
        string aulaModelando = "Modelando a Classe Aula";
        string aulaSets = "Trabalhando com conjuntos";


        string[] aulas = new string[3];
        aulas[0] = aulaIntro;
        aulas[1] = aulaModelando;
        aulas[2] = aulaSets;
        Imprimir(aulas);

        Console.WriteLine("Aula Modelando esta no índice " +Array.IndexOf(aulas, aulaIntro));
        Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

        Array.Reverse(aulas);
        Imprimir(aulas);

        Array.Reverse(aulas);
        Imprimir(aulas);

        Array.Resize(ref aulas, 3);
        Imprimir(aulas);

        aulas[aulas.Length - 1] = "Conclusão";
        Imprimir(aulas);

        Array.Sort(aulas);
        Imprimir(aulas);


        string[] copia = new string[2];
        Array.Copy(aulas, 1, copia, 0, 2);
        Imprimir(copia);

        string[] clone = aulas.Clone() as string[];
        Imprimir(clone);

        Array.Clear(clone, 1, 2);
        Imprimir(clone);


        

    }

    private static void Imprimir(string[] aulas)
    {
        //foreach (var aula in aulas)
        //{
        //    Console.WriteLine(aula);
        //}

        for (int i = 0; i < aulas.Length; i++)
        {
            Console.WriteLine(aulas[i]);

        }
    }
}