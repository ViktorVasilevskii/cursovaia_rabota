namespace CreationalDesignPatterns.Iterator
{
    public interface IIterator<out T>
    {
        bool MoveNext();
        void Reset();
        
        T Current { get; }
    }
}