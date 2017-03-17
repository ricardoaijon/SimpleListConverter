using System.Collections.Generic;
using System.Linq;
using LibraryCasteableIList.ListExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProjectCasteableList.ModelsTest.models;

namespace UnitTestProjectCasteableList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

          
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
            listaAnimales.ConvertTo(out listasalida);

            Assert.IsTrue(listasalida.Any());

        }

        [TestMethod]
        public void TestMethod2()
        {


            var listaAnimales = new List<EntityAnimal>
            {
                new EntityAnimal()
                {
                    Nombre = "Acuatico",
                    Especie = "Peces",
                    NumeroPatas = 0
                },
                new Gallina()
                {
                    Nombre = "Ave",
                    Especie = "Plumiferos",
                    NumeroPatas = 2,
                    LongitudCresta = 23,
                    IsCasteable = true,
                    OndaCacareo = 23
                }
            };

            List<Gallina> listasalida;
            listaAnimales.ConvertTo(out listasalida);

            Assert.IsTrue(listasalida.Any());

        }
    }
}
