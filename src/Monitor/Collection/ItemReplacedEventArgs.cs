using System;

namespace Monitor.Collection
{
    public class ItemReplacedEventArgs<T> : EventArgs
    {
        public ItemReplacedEventArgs(T newItem, T oldItem)
        {
            NewItem = newItem;
            OldItem = oldItem;
        }

        public T NewItem { get; }
        public T OldItem { get; }
    }
}
