using System;

namespace AbastractFatory
{
    public class CarroPopular : CarroFactory
    {
        public override Roda montarRoda()
        {
            return new RodaSimples();
        }

        public override Som montarSom()
        {
            return new CDPlayer();
        }
    }
}
