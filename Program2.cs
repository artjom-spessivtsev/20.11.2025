namespace whileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Do");

            int i = 1;

            do
            {
                Console.WriteLine(i);
                //i++ t´hendab, et sama mis i = i + 1
                i++;
            }  while(i <= 100);
        }
    }
}