

using CollectionsSetModel;

Curso csharpColecoes = new Curso("C# Coleções", "Marcelo O");
csharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
csharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
csharpColecoes.Adiciona(new Aula("Modelando com coleções", 24));


Aluno a1 = new Aluno("Vanessa Tonini", 34672);
Aluno a2 = new Aluno("Ana Lonak", 5617);
Aluno a3 = new Aluno("Rafael Nercessian", 17645);

csharpColecoes.Matricula(a1);
csharpColecoes.Matricula(a2);
csharpColecoes.Matricula(a3);

Console.WriteLine("Imprimindo alunos matriculados"); ;
foreach (var item in csharpColecoes.Alunos)
{
    Console.WriteLine(item);

}
Console.Clear();
//Imprimir: "O ALuno esta matriculado ?"
Console.WriteLine($"O aluno a1{a1.Nome} esta matriculado ?");
Console.WriteLine(csharpColecoes.EstaMatriculado(a1));


Console.WriteLine("Quem é o aluno com a matricula 5617");
Aluno aluno5617 = csharpColecoes.BuscaMatriculado(5617);
Console.WriteLine("aluno5617 "+ aluno5617);

//implementando um dicionário de alunos no curso
Console.WriteLine("Quem é o aluno com a matricula 5618");
Aluno aluno5618 = csharpColecoes.BuscaMatriculado(5618);
Console.WriteLine("aluno5618 " + aluno5618);

