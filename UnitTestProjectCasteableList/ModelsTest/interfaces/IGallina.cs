namespace UnitTestProjectCasteableList.ModelsTest.interfaces
{
    public interface IGallina:IAnimal
    {
        int LongitudCresta { set; get; }
        /// <summary>
        /// Wave sound of Chicken Id ,format MP3
        /// </summary>
        int OndaCacareo { set; get; }
    }
}