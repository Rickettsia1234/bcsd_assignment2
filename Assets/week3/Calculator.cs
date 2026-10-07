using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result;
    }

    public void Multiple(int num1, int num2)
    {
        int result = num1 * num2;
        Debug.Log(result);
    }
}

public class MethodParameterExample : MonoBehaviour
{
    private void Start()
    {
        int a = 3;
        int b = 4;

        Swap(a, b);
        Debug.Log($"a : {a}, b : {b}");

        Swap(ref a, ref b);
        Debug.Log($"a : {a}, b : {b}");

        int result1;
        int result2;
        Divide(10, 3, out result1, out result2);
        Debug.Log($"몫 : {result1}, 나머지 : {result2}");
    }

    public void Swap(int num1, int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    public void Swap(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    public void Divide(int num1, int num2, out int result1, out int result2)
    {
        result1 = num1 / num2;
        result2 = num1 % num2;
    }
}

public class MethodOverloadingExample : MonoBehaviour
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public float Add(float num1, float num2)
    {
        return num1 + num2;
    }
}

public class ParamsExample : MonoBehaviour
{
    public int TotalSum(params int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }
}

public class PlayerExample : MonoBehaviour
{
    private void Start()
    {
        Player("고박사");
        Player("고박사", 500);
        Player(health: 1000, id: "고박사");
    }

    public void Player(string id, int health = 1000)
    {
        Debug.Log($"ID : {id}, Health : {health}");
    }
}