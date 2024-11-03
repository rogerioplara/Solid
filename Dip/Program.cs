using Dip.Payments;

namespace Dip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentProcess payment = new();
            payment.Pay("ABC123");

            Console.ReadLine();
        }
    }
}
