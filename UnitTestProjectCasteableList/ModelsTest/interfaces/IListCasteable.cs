using System.Collections.Generic;

namespace UnitTestProjectCasteableList.ModelsTest.interfaces
{
    public interface IListCasteable<T> : IList<T> where T : class
    {
        bool IsCasteable(IList<T> lista);

        IList<T> SafeCast<TOutput>(IList<T> lista);
    }
}