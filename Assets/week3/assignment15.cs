using System.Collections;
using UnityEngine;
/*
public class ArrayListExercise : MonoBehaviour
{
    private void Start()
    {
        ArrayList arrayList = new ArrayList();

        int index = arrayList.Add(10);
        Debug.Log(index);

        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);

        arrayList.Insert(1, 100);

        ArrayList temp = new ArrayList();
        temp.Add(200);
        temp.Add(300);

        arrayList.AddRange(temp);

        arrayList.Sort();

        arrayList.Remove(10);
        arrayList.RemoveAt(0);
        arrayList.RemoveRange(0, 2);

        arrayList.Clear();
        Debug.Log(arrayList.Count);
    }

    private void PrintArrayList(ArrayList list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i]);
        }
    }
}
*/
public class ArrayListExercise : MonoBehaviour
{
    private void Start()
    {
        ArrayList arrayList = new ArrayList();

        int index = arrayList.Add(10);
        Debug.Log(index);

        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);

        arrayList.Insert(1, 100);

        ArrayList temp = new ArrayList();
        temp.Add(200);
        temp.Add(300);

        arrayList.AddRange(temp);

        arrayList.Sort();

        arrayList.Remove(10);
        arrayList.RemoveAt(0);
        arrayList.RemoveRange(0, 2);

        arrayList.Clear();
        Debug.Log(arrayList.Count);
    }

    private void PrintArrayList(ArrayList list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i]);
        }
    }
}

public class QueueExercise : MonoBehaviour
{
    private void Start()
    {
        Queue queue = new Queue();

        for (int i = 0; i < 5; i++)
        {
            queue.Enqueue(i);
        }

        Debug.Log(queue.Count);
        Debug.Log(queue.Peek());
        Debug.Log(queue.Dequeue());
        Debug.Log(queue.Count);

        queue.Clear();
        Debug.Log(queue.Count);
    }
}

public class StackExercise : MonoBehaviour
{
    private void Start()
    {
        Stack stack = new Stack();

        for (int i = 0; i < 5; i++)
        {
            stack.Push(i);
        }

        Debug.Log(stack.Count);
        Debug.Log(stack.Peek());
        Debug.Log(stack.Pop());
        Debug.Log(stack.Count);

        stack.Clear();
        Debug.Log(stack.Count);
    }
}

public class Goblin
{
}

public class Slime
{
}

public class HashtableExercise : MonoBehaviour
{
    private void Start()
    {
        Hashtable hash = new Hashtable();

        Goblin goblin = new Goblin();
        Slime slime = new Slime();

        hash["Player"] = "고박사";
        hash[1] = 100;
        hash[2.5f] = "FloatValue";

        hash.Add("Goblin", goblin);
        hash.Add("Slime", slime);

        foreach (object key in hash.Keys)
        {
            Debug.Log($"Key : {key}, Value : {hash[key]}");
        }

        if (hash.ContainsKey("Slime"))
        {
            Debug.Log("Slime 키가 존재합니다.");
        }

        if (hash.ContainsValue(goblin))
        {
            Debug.Log("goblin 값이 존재합니다.");
        }

        Debug.Log(hash.Count);

        hash.Remove("Slime");

        Debug.Log(hash.Count);

        hash.Clear();

        Debug.Log(hash.Count);
    }
}