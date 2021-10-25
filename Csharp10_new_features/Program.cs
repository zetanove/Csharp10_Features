/** file scoped namespace **/
namespace Csharp10.Features; 

public class Program
{
    static void Main()
    {       
        /** const string interpolation **/
        const string version = "10";
        const string language = $"C# {version}";
        const string greetings = $"Hello {language}!";
        Console.WriteLine(greetings);

        /** global using from file usings.cs **/
        Console.WriteLine(Sqrt(100));
        Console.WriteLine(E.OSVersion);

        /** implicit using System **/
        Console.WriteLine(language);

        Console.WriteLine(typeof(Program).FullName); //print "Csharp10.Features.Program", file scoped namespace

        //sealed ToString in record
        Child t = new Child("child");
        Console.WriteLine(t.ToString());

        Point pt1=new Point() { X = 1, Y = 2 };
        

    }
}

/** sealed ToString in record **/
public record Mother(string Name)
{
    public sealed override string ToString() => "I am "+Name;
}

public record Child(string Name) : Mother(Name)
{
    //public override string ToString() { return "";  } //cannot override sealed method
}


/** Record Struct **/
record struct Point
{
    public double X;
    public double Y;
}

/** Readonly Record Struct positional syntax **/
readonly record struct Point3D(double X, double Y, double Z);



//static abstract interface (preview)
//interface IntStat
//{
//    static abstract int Prop { get; }
//}