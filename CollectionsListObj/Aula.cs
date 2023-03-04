class Aula : IComparable    
{
    private int tempo;
    private string titulo;

    public Aula(string titulo, int tempo)
    {
        this.tempo = tempo;
        this.titulo = titulo;
    }

    public string Titulo { get => titulo; set => titulo = value; }
    public int Tempo { get => tempo; set => tempo = value; }

    public int CompareTo(object? obj)
    {
        Aula that = obj as Aula;
        return this.titulo.CompareTo(that.titulo);
    }

    public override string ToString()
    {
        return $"[título: {titulo}, tempo: {tempo} minutos]";
    }
}