namespace SwitchryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try Catch koos Switch-ga");

            //alguses tha switch kus saab sisestada numbreid 1 ja 2
            int input = int.Parse(Console.ReadLine());

            try
            {
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Sisestasid number 1");
                        break;

                    case 2:
                        Console.WriteLine("Sisestasid number 2");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Palun sisesta kehtiv number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Sisestatud number on liiga suur või liiga väike");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Tekkis ootamatu viga: {ex.Message}");
            }
        }
    }
}
