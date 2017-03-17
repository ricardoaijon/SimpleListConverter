using System.Collections.Generic;

namespace ConsoleApplicationCasteableList.ModelsTest.interfaces
{
    public interface IListCasteable<T> : IList<T> where T : class
    {
        bool IsCasteable(IList<T> lista);

        IList<T> SafeCast<TOutput>(IList<T> lista);
    }
}