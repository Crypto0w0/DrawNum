internal class Program
{
    private static void Main(string[] args)
    {
        string num = Console.ReadLine();
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] == '0')
            {
                Console.WriteLine("  000  ");
                Console.WriteLine(" 0   0 ");
                Console.WriteLine(" 0   0 ");
                Console.WriteLine(" 0   0 ");
                Console.WriteLine("  000  ");
                Console.WriteLine();
            }
            else if (num[i] == '1')
            {
                Console.WriteLine("   1   ");
                Console.WriteLine("  11   ");
                Console.WriteLine(" 1 1   ");
                Console.WriteLine("   1   ");
                Console.WriteLine(" 11111 ");
                Console.WriteLine();
            }
            else if (num[i] == '2')
            {
                Console.WriteLine("  222  ");
                Console.WriteLine(" 2   2 ");
                Console.WriteLine("    2  ");
                Console.WriteLine("   2   ");
                Console.WriteLine(" 22222 ");
                Console.WriteLine();
            }
            else if (num[i] == '3')
            {
                Console.WriteLine("  333  ");
                Console.WriteLine(" 3   3 ");
                Console.WriteLine("   33  ");
                Console.WriteLine(" 3   3 ");
                Console.WriteLine("  333  ");
                Console.WriteLine();
            }
            else if (num[i] == '4')
            {
                Console.WriteLine(" 4  4  ");
                Console.WriteLine(" 4  4  ");
                Console.WriteLine(" 4444  ");
                Console.WriteLine("    4  ");
                Console.WriteLine("    4  ");
                Console.WriteLine();
            }
            else if (num[i] == '5')
            {
                Console.WriteLine("  55555");
                Console.WriteLine("  5    ");
                Console.WriteLine("  555  ");
                Console.WriteLine("5    5 ");
                Console.WriteLine(" 5555  ");
                Console.WriteLine();
            }
            else if (num[i] == '6')
            {
                Console.WriteLine("  6666 ");
                Console.WriteLine(" 6     ");
                Console.WriteLine(" 6666  ");
                Console.WriteLine(" 6   6 ");
                Console.WriteLine("  666  ");
                Console.WriteLine();
            }
            else if (num[i] == '1')
            {
                Console.WriteLine(" 77777 ");
                Console.WriteLine("    7  ");
                Console.WriteLine("   7   ");
                Console.WriteLine("  7    ");
                Console.WriteLine(" 7     ");
                Console.WriteLine();
            }
            else if (num[i] == '8')
            {
                Console.WriteLine("  888  ");
                Console.WriteLine(" 8   8 ");
                Console.WriteLine("  888  ");
                Console.WriteLine(" 8   8 ");
                Console.WriteLine("  888  ");
                Console.WriteLine();
            }
            else if (num[i] == '9')
            {
                Console.WriteLine("  999  ");
                Console.WriteLine(" 9   9 ");
                Console.WriteLine("  999  ");
                Console.WriteLine("     9 ");
                Console.WriteLine("  999  ");
                Console.WriteLine();
            }
        }
    }
}