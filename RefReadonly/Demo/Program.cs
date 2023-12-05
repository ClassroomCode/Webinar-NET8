namespace Demo;

internal class Program
{
    static void Main(string[] args)
    {
        var p = new Person {
            FirstName = "Bill",
            LastName = "Gates"
        };
        Foo(p);

        Console.WriteLine("Hello, World!");
    }

    static void Foo(Person p)
    {
        //
    }
}
