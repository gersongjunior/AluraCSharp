List<string> frutas = new List<string>
{
    "abacate", "banana", "caqui", "damasco","figo"
};
foreach (var item in frutas)
{
    Console.WriteLine(item);
}

LinkedList<string> dias = new LinkedList<string>();

var d5 = dias.AddFirst("Quinta");
var d7 = dias.AddLast("Sabado");
var d3 = dias.AddBefore(d5, "Terça");
var d6 = dias.AddAfter(d5, "Sexta");
var d2 = dias.AddBefore(d3, "Segunda");
var d4 = dias.AddAfter(d3, "Quarta");
var d1 = dias.AddFirst("Sabado");

foreach (var item in dias)
{
    Console.WriteLine("Dia da semana: "+item); ;
}