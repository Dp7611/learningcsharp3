namespace learningcsharp3;
class Program
{
    static void Main(string[] args)
    {
        string username;

        Console.WriteLine("Hello, World!");
        Console.WriteLine("Please enter yor name");
        username = Console.ReadLine();
        Console.WriteLine($"Goodbye, {username}!");
        Console.ReadKey(true);
    }
}
