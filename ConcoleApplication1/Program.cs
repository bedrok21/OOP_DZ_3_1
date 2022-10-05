
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введiть число: ");
        string? a = Console.ReadLine();
        try {
            Console.Write(Convert.ToInt32(a));
        }
        catch
        {
            Console.Write("Ви ввели не число!");
        }
    }
}