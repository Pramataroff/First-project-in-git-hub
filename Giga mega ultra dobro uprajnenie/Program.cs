using System.Threading.Channels;

namespace Giga_mega_ultra_dobro_uprajnenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (num.Length == 1 )
            {
                Console.WriteLine(num[0]);
            }
            else if (num.Length % 2 == 0)
            {
                Console.WriteLine(num.Length / 2);
                Console.WriteLine(num.Length / 2 + 1);

            }
            else if (num.Length % 2 == 1)
            {
                Console.WriteLine(num.Length / 2);
                Console.WriteLine(num.Length / 2 + 1);
                Console.WriteLine(num.Length / 2 + 2);
            }


        }
    }
}
