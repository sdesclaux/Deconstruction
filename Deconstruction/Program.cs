using Deconstruction;

Console.WriteLine("Hello, World!");

// Create  akeyValuePair and Assign it classicaly
var keyValuePair = new KeyValuePair<string, int>("test1 :", 1);
Console.WriteLine(keyValuePair.Key + keyValuePair.Value);

// Use builtin Deconstruct
var (x , y) = new KeyValuePair<string, int>("test2 :", 2);
Console.WriteLine(x + y);

//Use built manually Deconstruct
var (xx, yy) = new Point1 { X = "test3 :", Y = 3 };
Console.WriteLine(xx + yy);

//Use builtin record Deconstruct
var (x4, y4) = new Point2("test4 :", 4);
Console.WriteLine(x4 + y4);

//Use it with a builtin class with the creation of an extension method (here for the exemple !)
var (message, stacktrace) = new Exception();
Console.WriteLine(message + " - " + stacktrace);

//Example with DateTime
var (date, time) = DateTime.Now;
Console.WriteLine(date + " - " + time);

Console.WriteLine("Bye, World!");

internal class Point1()
{
    public string? X { get; set; }
    public int Y { get; set; }

    public void Deconstruct(out string? x, out int y)
    {
        x = X;
        y = Y;
    }
}

internal record Point2(string X, int Y);
