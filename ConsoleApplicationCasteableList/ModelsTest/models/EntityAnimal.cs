using ConsoleApplicationCasteableList.ModelsTest.interfaces;

namespace ConsoleApplicationCasteableList.ModelsTest.models
{
    public class EntityAnimal: IAnimal
    {
        public string Especie { get; set; }
        public string Nombre { set; get; }
        public int NumeroPatas { set; get; }

        public EntityAnimal()
        {
            Especie = "Unknown";
            Nombre = "Unknown";
            NumeroPatas = 0;
        }

        public override string ToString()
        {
            return "Especie:" + Especie + "\n" + "Nombre:" + Nombre + "\nNumero de Patas:" + NumeroPatas;
        }

        public bool IsCasteable { get; set; }
    }
}