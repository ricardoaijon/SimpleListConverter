using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApplicationCasteableList.ModelsTest.models;
using LibraryCasteableIList;
using LibraryCasteableIList.ListExtensions;


namespace ConsoleApplicationCasteableList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor=ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Transformando animales en gallinas, ^_^");
            var listaAnimales = new List<EntityAnimal>
            {
                new EntityAnimal()
                {
                    Nombre = "Acuatico",
                    Especie = "Peces",
                    NumeroPatas = 0
                },
                new EntityAnimal()
                {
                    Nombre = "Ave",
                    Especie = "Plumiferos",
                    NumeroPatas = 2
                }
            };
          
            List<Gallina> listasalida;
            listaAnimales.ConvertTo<EntityAnimal,Gallina>(out listasalida);

            if (listasalida.Any())
            {
                foreach (var iem in listasalida)
                {
                  
                    Console.WriteLine("*********************");
                    Console.WriteLine(iem.ToString());
                }
            }
         
            Console.ReadLine();
        }
    }
}
