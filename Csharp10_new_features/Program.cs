// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//sealed ToString in record
Figlia t = new Figlia("nome");
Console.WriteLine(t.ToString());
public record Persona(string Name)
{
    public sealed override string ToString() => "Io sono "+Name;
}

public record Figlia(string Name) : Persona(Name)
{
}

//static abstract interface (preview)
//interface IntStat
//{
//    static abstract int Prop { get; }
//}