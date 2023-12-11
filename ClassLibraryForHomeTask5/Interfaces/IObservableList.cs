using ClassLibraryForHomeTask5.Event;

namespace ClassLibraryForHomeTask5.Interfaces
{
    public interface IObservableList<T> : ICollection<T>
    {
        event EventHandler<ItemChangedEventArgs<T>>? ItemAdded;
        event EventHandler<ItemChangedEventArgs<T>>? ItemInserted;
        event EventHandler<ItemChangedEventArgs<T>>? ItemRemoved;
        event EventHandler<ItemChangedEventArgs<T>>? ItemChanged;
        event EventHandler ItemsCleared;
    }
}