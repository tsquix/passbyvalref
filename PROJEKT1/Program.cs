public class Program
{
    public static void Main(string[] args)
    {
        //ustawiamy jednakowe zmienne
        int x = 5;
        int y = 5;
        Console.WriteLine("Wartości startowe");
        Console.WriteLine("x = "+ x +" y = "+ y);
        //wywołujemy program przekazujacy parametry przez wartość
        byval(x);
        Console.WriteLine("Po przekazaniu po wartości:  x = "+ x );
        //wywołujemy program przekazujacy parametry referencyjnie
        byref(ref y);
        Console.WriteLine("Po przekazaniu referencyjnym:  y = "+ y);
    }
    public static void byval(int x)
    {
        x += 5;
    }
    public static void byref(ref int y)
    {
        y += 5;
    }
}