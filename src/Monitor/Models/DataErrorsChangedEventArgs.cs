using System.ComponentModel;

namespace Monitor.Models
{
    public class DataErrorsChangedEventArgs<T> : DataErrorsChangedEventArgs
    {
        public DataErrorsChangedEventArgs(string propertyName, T source)
            : base(propertyName)
        {
            Source = source;
        }

        public T Source { get; }
    }
}
