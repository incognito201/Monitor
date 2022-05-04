﻿using System.ComponentModel;

namespace Monitor.Collection
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
