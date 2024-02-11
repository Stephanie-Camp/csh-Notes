using System.Globalization;

namespace Atv8 {
    class Program {
        static void Main(string[] args) {

            Triangulo t1 = new Triangulo();
            Console.WriteLine("\nArea = "+ t1.Area().ToString("F2", CultureInfo.InvariantCulture)); //resultado

        }
    }
}