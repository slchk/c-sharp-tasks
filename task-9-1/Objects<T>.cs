namespace task_9_1;

public class GenericArray<T>
{
    private T[] array;
    private int count;

    public GenericArray(int size)
    {
        array = new T[size];
        count = 0;
    }

public void Add(T item)
    {
        if(count < array.Length)
        {
            array[count] = item;
            count++;
        }
        else
        {
            Console.WriteLine("Can't add item to array");
        }
    }
    public void Remove(T item)
    {
        int index = Array.IndexOf<T>(array, item);
        
        for (int i = index; i < count - 1; i++)
        {
            array[i] = array[i + 1];
        }
        
        count--;
        array[count] = default(T); 
    }
    
    public T ArrayIndex(int index)
    {
        if (index >= 0 && index < count)
        {
            return array[index];
        }
        else
        {
            throw new IndexOutOfRangeException("Index Out Of Range Exception");
        }
    }
    
    public int ArrayLength()
    {
      return array.Length;
    }
    
}