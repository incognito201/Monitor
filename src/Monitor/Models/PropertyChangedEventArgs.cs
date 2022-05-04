using System.ComponentModel;

namespace Monitor.Models
{
    public class PropertyChangedEventArgs<T> : PropertyChangedEventArgs
    {
        public PropertyChangedEventArgs(string propertyName, T source)
            : base(propertyName)
        {
            Source = source;
        }

        public T Source { get; }
    }
}