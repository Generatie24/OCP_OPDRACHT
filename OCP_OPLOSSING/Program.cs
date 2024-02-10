using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_OPLOSSING
{

    internal class Program
    {
        static void Main(string[] args)
        {
            ITransportmiddel bus = new Bus();
            Reis busReis = new Reis(bus);
            Console.WriteLine(busReis.StartReis());

            ITransportmiddel trein = new Trein();
            Reis treinReis = new Reis(trein);
            Console.WriteLine(treinReis.StartReis());

            ITransportmiddel vliegtuig = new Vliegtuig();
            Reis vliegtuigReis = new Reis(vliegtuig);
            Console.WriteLine(vliegtuigReis.StartReis());
        }
    }
}
