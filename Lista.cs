using System.Collections;


List<float> list = new List<float>();
List.Add(4f);
List.Add(2f);
List.Add(1f);
foreach (var n in list)
{
    float x = n + 1;
    Console.WriteLine(x);
}


/*public class List<T> : IEnumerable<T>
{
    private T[] values = new T[10];
    private int count = 0;

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new IndexOutOsRangeException();
            return values [index];
        }
        set
        {
            if (index < 0 || index >= count)
        }
    }
}*/

public class IntListIterator<T> : IEnumerator
{
    private List<int> list;
    int index = -1;
    public IntListIterator(IntListIterator<T>);
}

public interface IEnumerator<T>
{
    void Reset();
    T Current { get; }
    bool MoveNext();
}

public class LinkedList
{
    private LinkedListNode first = null;
    private int count = 0;
    public int Count => count;
    public int this[int index]
    {
        get
        {
            if (first == null)
                throw new IndexOutOfRandeException();
            var crr = first;
            for (int i = 0; i < index; i ++)
            {
                if (crr.Next == null)
                    throw new IndexOutOfRangeException();

                crr = crr.Next;
            }
            
            crr.Value = int.MaxValue;
        }
        
        set
        {
            if (first == null)
                throw new IndexOutOfRandeException();
            var crr = first;
            for (int i = 0; i < index; i ++)
            {
                if (crr.Next == null)
                    throw new IndexOutOfRangeException();

                crr = crr.Next;
            }
            
            crr.Value = int.MaxValue;
        }
    }
    public void Add (int value)
    {
        if (first == null)
        {
            first = new LinkedListNode();
            first.Value = value;
            count++;
            return;
        }

        var crr = first;
        while (crr.Next != null)
            crr = crr.Next;
        
        crr = new LinkedListNode();
        crr.Value = value;
        count++;
    }
}

public class LinkedListNode
{
    public int Value { get; set; }
    public LinkedListNode Next { get ; set; }
}
