using App003.Protobuf.Proto.Generated;

namespace App003.Protobuf;

internal class Program
{
    static void Main(string[] args)
    {
        var d = new Data
        {
            SomeString = "Hello World!",
            SomeInt = 42,
        };
        Console.WriteLine(d.SomeString);
        Console.WriteLine(d.SomeInt);
    }
}