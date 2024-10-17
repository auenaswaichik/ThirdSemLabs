using System.Collections;
using Lab_2.Interfaces;

namespace Lab_2.Collections;

public class MyCustomeCollection<T> : ICustomeCollection<T>, IEnumerable<T>
{
    public class Node {
        public Node? Next{get;set;}
        public T Value{get;set;}
        public Node(T value){ Value = value; Next = null;}
        public Node(T value, Node? next){ Value = value; Next = next;}
    }
    private Node? Root;
    private Node? Current;
    private Node? End;

    public MyCustomeCollection()
    {
        Root = null;
        Current = null;
        End = null;
    }

    private int count = 0;
    public void Reset() {

        Current = Root;

    }
    public void Next() {

        if(Current is null) throw new System.IndexOutOfRangeException();
        if(Current.Next is null) throw new System.IndexOutOfRangeException();

        Current = Current.Next;

    }
    public T GetCurrent() {

        if(Current is null) throw new System.IndexOutOfRangeException();

        return Current.Value;

    }
    public int Count => count;

    public T this[int index] { 

        get {

            if(Root is null) throw new System.IndexOutOfRangeException();

            int CurPos = 0;
            Node? TempNode = Root;
            while(CurPos != index && TempNode is not null) {

                TempNode = TempNode.Next;
                ++CurPos;

            }

            if(TempNode is null) throw new System.IndexOutOfRangeException();

            return TempNode.Value;

        }

        set {

            if(Root is null) throw new System.IndexOutOfRangeException();

            int CurPos = 0;
            Node TempNode = Root;
            while(CurPos != index && TempNode is not null) {

                if(TempNode.Next is null) throw new System.IndexOutOfRangeException();
                TempNode = TempNode.Next;
                ++CurPos;

            }

            if(TempNode is null) throw new System.IndexOutOfRangeException();

            TempNode.Value = value;
        }

     }
    public void Add(T item) {

        if (Root == null) {

            End = null;
            Root = new Node(item, End);
            Current = Root;

        }
        else {

            Node? tempNode = Root;
            while(tempNode.Next is not null) {

                tempNode = tempNode.Next;

            }

            tempNode.Next = new Node(item);

        }

        ++ count;

    }
    public void Remove(T item)
    {
        Node? TempCurrent = Root;

        if(TempCurrent is null) throw new System.IndexOutOfRangeException();

        if (TempCurrent.Next is null) throw new System.IndexOutOfRangeException();

        while(TempCurrent.Next is not null) {

            if(EqualityComparer<T>.Default.Equals(TempCurrent.Value, item)) {

                TempCurrent.Value = TempCurrent.Next.Value;
                TempCurrent.Next = TempCurrent.Next.Next;
                --count;

            }
            else {

                TempCurrent = TempCurrent.Next;

            }

        }

        if(TempCurrent is not null) {

            if(EqualityComparer<T>.Default.Equals(TempCurrent.Value, item)) {

                TempCurrent = null;
                --count;

            }

        }

    }
    public T RemoveCurrent()
    {
        if(Current is null || Current.Next is null) throw new System.IndexOutOfRangeException();

        T RemovedData = Current.Value;

        Current.Value = Current.Next.Value;
        Current.Next = Current.Next.Next;
        
        --count;

        return RemovedData;

    }

    private IEnumerator<T> GetEnumerator()
    {
        Node? tempCurr = Root;

        while(tempCurr is not null) {

            yield return tempCurr.Value;
              tempCurr = tempCurr.Next;

        }
    }
    
    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}