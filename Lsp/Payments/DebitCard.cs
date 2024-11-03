using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Payments
{
    internal class DebitCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Verificar saldo da conta...");
            Console.WriteLine("Saldo disponível");
        }
    }
}
