﻿using LibraryCasteableIList.Interface;

namespace ConsoleApplicationCasteableList.ModelsTest.interfaces
{
    public interface IAnimal: ICasteableEntity
    {
        string Especie { get; set; }
        string Nombre { set; get; }
        int NumeroPatas { set; get; }
    }
}