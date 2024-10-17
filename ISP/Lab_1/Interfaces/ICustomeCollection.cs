namespace Lab_1.Interfaces;

public interface ICustomeCollection<T>
{

    T this[int index]{get;set;}
    
    void Reset();
    void Next();

    T GetCurrent();

    int Count{get;}

    void Add(T item);
    void Remove(T item);

    T RemoveCurrent();

}