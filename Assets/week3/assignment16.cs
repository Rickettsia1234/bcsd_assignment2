using System.Collections.Generic;
using UnityEngine;

public class GenericMethodExercise : MonoBehaviour
{
    private void Awake()
    {
        DataInformation<int>(36);
        DataInformation<float>(12.3f);
        DataInformation<string>("안녕하세요 고박사입니다.");
    }

    public void DataInformation<T>(T data)
    {
        Debug.Log(data);
        Debug.Log(data.GetType());
    }
}

public class Player<T>
{
    public T value;
}

public class GenericClassExercise : MonoBehaviour
{
    private void Awake()
    {
        Player<int> player01 = new Player<int>();
        player01.value = 10;
        Debug.Log(player01.value);

        Player<string> player02 = new Player<string>();
        player02.value = "안녕하세요 고박사입니다";
        Debug.Log(player02.value);
    }
}

public class ListExercise : MonoBehaviour
{
    private void Start()
    {
        List<int> list = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            list.Add(i);
        }

        PrintList(list);

        list.Insert(0, 10000);

        PrintList(list);

        list.RemoveAt(1);

        PrintList(list);

        Debug.Log(list.Count);

        list.Clear();

        Debug.Log(list.Count);
    }

    private void PrintList<T>(List<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i]);
        }
    }
}

public class GenericQueueExercise : MonoBehaviour
{
    private void Start()
    {
        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < 5; i++)
        {
            queue.Enqueue(i);
        }

        Debug.Log(queue.Count);

        while (queue.Count > 0)
        {
            Debug.Log(queue.Dequeue());
        }

        Debug.Log(queue.Count);
    }
}

public class GenericStackExercise : MonoBehaviour
{
    private void Start()
    {
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < 5; i++)
        {
            stack.Push(i);
        }

        Debug.Log(stack.Count);

        while (stack.Count > 0)
        {
            Debug.Log(stack.Pop());
        }

        Debug.Log(stack.Count);
    }
}

public class DictionaryExercise : MonoBehaviour
{
    private void Start()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        dictionary["1"] = "first";
        dictionary["2"] = "second";
        dictionary["3"] = "third";

        PrintDictionary(dictionary);

        dictionary.Add("사과", "apple");

        PrintDictionary(dictionary);

        dictionary.Remove("1");

        PrintDictionary(dictionary);
    }

    private void PrintDictionary<TKey, TValue>(Dictionary<TKey, TValue> dict)
    {
        Debug.Log(dict.Count);

        foreach (KeyValuePair<TKey, TValue> item in dict)
        {
            Debug.Log($"Key : {item.Key}, Value : {item.Value}");
        }
    }
}