using System;

namespace AbastractFatory
{
    public class ExecutaAbstractFactory
    {
        public static Carro montarcarro(String tipo)
        {
            CarroFactory cf = null;
            switch(tipo)
            {
                case "Luxo":
                    cf = new CarroLuxoFactory();
                    break;
                case "Popular":
                    cf = new CarroPopular();
                    break;
            }

            Carro carro = new Carro();
            carro.roda = cf.montarRoda();
            carro.som = cf.montarSom();
            return carro;
        }
    }
}
