using System;

namespace AbastractFatory
{
    class CarroLuxoFactory : CarroFactory
    {
        public override Roda montarRoda()
        {
            return new RodaLigaLeve();
        }

        public override Som montarSom()
        {
            return new BluetoothPlayer();
        }
    }
}
