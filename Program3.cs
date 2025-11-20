namespace TriangelWhileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmnurk");

            int n = int.Parse(Console.ReadLine());
            int i = 1;

            while (i <= n)
            {
                Console.WriteLine();
                int j = 1;
                while (j <= i)
                {
                    Console.Write("*" + " ");
                    j++;
                }
                i++;
            }
            Console.WriteLine();
        }
    }
}
