using ConsoleApplicationCasteableList.ModelsTest.interfaces;

namespace ConsoleApplicationCasteableList.ModelsTest.models
{
    public class Gallina:EntityAnimal,IGallina
    {
        public int LongitudCresta { set; get; }
        public int OndaCacareo { set; get; }

        public Gallina()
        {
            LongitudCresta = 0;
            OndaCacareo = 0;
        }

        public Gallina SetParams(int longitud, int onda)
        {
            LongitudCresta = longitud;
            OndaCacareo = onda;
            return this;
        }

        public override string ToString()
        {
            return "Especie:" + Especie 
                + "\n" + "Nombre:" + Nombre 
                + "\nNumero de Patas:" + NumeroPatas
                + "\nLongitudCresta:" +LongitudCresta
                +"\nOndaCacareo:"+OndaCacareo
                ;
        }




    }
}