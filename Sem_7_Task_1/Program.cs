class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите значение M:");
        int M = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine($"Все натуральные числа в промежутке от {M} до {N}:");
        pNum(M, N);
    }

    static void pNum(int M, int N)
    {
        if (M > N)
        {
            return;
        }

        Console.Write(M + " ");
        pNum(M + 1, N);
    }
}