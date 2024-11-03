using Isp.Vehicles;

namespace Isp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new("Azul", 2022, 2.0, 5, 4);
            Motorcycle motorcycle = new("Branca", 2023, 600);

            Console.ReadLine();
        }
    }
}
