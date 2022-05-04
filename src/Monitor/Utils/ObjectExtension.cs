using System.Linq;

namespace Monitor.Utils
{
    public static class ObjectExtension
    {
        public static object GetPropertyValue(this object obj, string propertyName)
        {
            return obj
                .GetType()
                .GetProperties()
                .Single(pi => pi.Name == propertyName)
                .GetValue(obj, null);
        }
    }
}
