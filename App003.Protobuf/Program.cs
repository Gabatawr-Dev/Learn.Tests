using App003.Protobuf.Protos.Messages;
using App003.Protobuf.Protos.Messages.Enums;
using Google.Protobuf;

namespace App003.Protobuf;

internal class Program
{
    static void Main(string[] args)
    {
        var d = new Data
        {
            SomeString = "Hello World!",
            SomeInt = 42,
            DataType = {new[] {DataTypes.String, DataTypes.Int}},
            SomeTest = new Test {Name = "Test"}
        };
        
        Console.WriteLine(string.Join(", ", d.ToByteArray()));
    }
}