using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T : new()
{
    private Queue<T> objQueue = new Queue<T>();

    public T GetOrCreate()
    {
        if (objQueue.Count > 0)
        {
            return objQueue.Dequeue();
        }
        else
        {
            return new T();
        }
    }

    public void Return(T obj)
    {
        objQueue.Enqueue(obj);
    }
}
