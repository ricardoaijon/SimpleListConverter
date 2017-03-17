using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using LibraryCasteableIList.Helper;

namespace LibraryCasteableIList.ListExtensions
{
    public static class ExtensionList
    {
        /// <summary>
        /// Convert Type A to Type B , unsafely for your entity´s health
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T">Salida</typeparam>
        /// <param name="inputList"></param>
        /// <param name="outputList"></param>
        public static void ConvertTo<T1,T>(this IList<T1> inputList,out List<T> outputList ) where T:class
        {
           
            var currentAssem = Assembly.GetExecutingAssembly();
            outputList = new List<T>();
            foreach (var item in inputList)
            {
                if (item == null) continue;
                var instancia = new SimpleInstanciator().CreateInstanceSOf<T>(currentAssem);
                var getItemAtributes = item.GetType().GetProperties();
                foreach (var atribute in getItemAtributes)
                {
                    var ss= outputList.GetType().GetProperties();
                    var propertiSelected = ss.Where(c => c.PropertyType == typeof (T)).ToList();
                    foreach (var propertiSalida in propertiSelected)
                    {
                        if (propertiSalida.PropertyType.BaseType == null) continue;
                        var propiedades = propertiSalida.PropertyType.BaseType.GetProperties();
                        foreach (var itemProp in propiedades)
                        {
                            if (itemProp.Name != atribute.Name) continue;
                            var y = item.GetType().GetProperties().First(c => c.Name == itemProp.Name);
                            var t=y.GetValue(item);      
                            var propiedadesInstancia = instancia.GetType().GetProperties();
                            foreach (var imp in from imp in propiedadesInstancia let propertyName = imp.Name where propertyName == itemProp.Name select imp)
                            {
                                imp.SetValue(instancia,t);
                            }
                        }
                    }
                }
                outputList.Add((T)instancia);
            }
           
           
        }


    }


}