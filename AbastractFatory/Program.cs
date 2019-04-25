using System;

namespace AbastractFatory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = ExecutaAbstractFactory.montarcarro("Luxo");
            Carro c2 = ExecutaAbstractFactory.montarcarro("Popular");

            
            Console.ReadKey();
        }
    }
}
