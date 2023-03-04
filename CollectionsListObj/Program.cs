using CollectionsListObj;
using System;

class Program
{
    static void Main(string[] args)
    {
        //    var aulaIntro = new Aula("Introdução às coleções", 20);
        //    var aulaModelando = new Aula("Modelando a Classe Aula", 20);
        //    var aulaSets = new Aula("Trabalhando com conjuntos", 16);

        //    List<Aula> aulas = new List<Aula>();
        //    aulas.Add(aulaIntro);
        //    aulas.Add(aulaModelando);
        //    aulas.Add(aulaSets);


        //    Imprimir(aulas);

        //    aulas.Sort();
        //    Imprimir(aulas);

        //    aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
        //    Imprimir(aulas);

        Curso csharpColecoes = new Curso("C# Collections", "Gerson");
        csharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
        //adicionar duas aulas
        csharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
        csharpColecoes.Adiciona(new Aula("Modelando com coleções", 15));

        //copiar a lsita para outra lista e ordenar
        List<Aula> aulasCopia = new List<Aula>(csharpColecoes.Aulas);
        aulasCopia.Sort();
                
        Imprimir(aulasCopia);
        Console.WriteLine(csharpColecoes.TempoTotal);

        //Imprimir detalhes do curso
        Console.WriteLine(csharpColecoes);





    }

    private static void Imprimir(IList<Aula> aulas)
    {
        Console.Clear();
        foreach (var aula in aulas)
        {
            Console.WriteLine(aula);

        }
    }
}
