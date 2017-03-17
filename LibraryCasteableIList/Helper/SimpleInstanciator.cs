using System;
using System.Reflection;


namespace LibraryCasteableIList.Helper
{
    public class SimpleInstanciator
    {
        [Obsolete("only works if the classes were defined inside library class")]
        public  object CreateInstanceOf<T>(Assembly assemply )
        {
            var className = typeof(T).FullName;
            
                var instance = assemply.CreateInstance(className);
                return instance;
          
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="assemply"></param>
        /// <returns></returns>
        public  object CreateInstanceSOf<T>(Assembly assemply)
        {
            var instance = Activator.CreateInstance<T>();
           
            return instance;
        }
    }
}