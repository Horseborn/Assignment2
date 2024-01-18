namespace Assignment2_0124;

class Program
{
    static void Main(string[] args)
    {
        // Beware, complex loop below
        int num = 10;
        for (int i = 0; i <= num; i += 2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Hello, World!");
        Hello("Sebastian");
    }

    // Here i am adding the complex method
    static void Hello(string Name)
    {
        Console.WriteLine($"Hello {Name}");
    }
}