using System.Security;

namespace grupo_d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int result = sun(2, 3);
            string Nombrecompleto = nombrecompleto("luis", "ramirez");
        }
        public static int sun(int n1, int n2)
        {
            return n1+n2;
        }
        public static string nombrecompleto(string name, string lastname)
        {
            return name+lastname;
        }
    }
}