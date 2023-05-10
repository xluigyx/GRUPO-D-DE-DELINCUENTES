using System.Security;

namespace grupo_d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int result = sun(2, 3);
        }
        public static int sun(int n1, int n2)
        {
            return n1+n2;
        }
    }
}