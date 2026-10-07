using UnityEngine;
/*
public class Parent : MonoBehaviour
{
    public void Method01()
    {
        Debug.Log("Parent Method01");
    }
}

public class Child : Parent
{
    public new void Method01()
    {
        Debug.Log("Child Method01");
    }
}

public class Entity : MonoBehaviour
{
    public virtual void TakeDamage(int damage)
    {
    }
}

public class MovingEntity : Entity
{
    public sealed override void TakeDamage(int damage)
    {
    }
}

public class Player : MovingEntity
{
}

public class OuterClass : MonoBehaviour
{
    private int outerValue;

    public class InnerClass
    {
        public void InnerMethod(OuterClass outer)
        {
            outer.outerValue = 10;
        }
    }
}

public partial class PartialClass : MonoBehaviour
{
    public int valueA;
}

public partial class PartialClass : MonoBehaviour
{
    public int valueB;
}

public struct PlayerData
{
    public string id;
    public int hp;
}

public class StructExample : MonoBehaviour
{
    private void Start()
    {
        PlayerData player01 = new PlayerData();
        player01.id = "고박사";
        player01.hp = 100;

        PlayerData player02;
        player02.id = "유니티";
        player02.hp = 200;
    }
}

public class TupleExample : MonoBehaviour
{
    private void Start()
    {
        var a = ("고박사", 35);
        Debug.Log(a.Item1);
        Debug.Log(a.Item2);

        var b = (name: "고박사", age: 35);
        Debug.Log(b.name);
        Debug.Log(b.age);

        var (name, age) = b;
        Debug.Log(name);
        Debug.Log(age);

        var (onlyName, _) = b;
        Debug.Log(onlyName);
    }
}

public class EnemyStatic : MonoBehaviour
{
    public int numeric;
    public static string species;

    public void InstanceRun()
    {
    }

    public static void StaticRun()
    {
    }
}

public class StaticTest : MonoBehaviour
{
    private void Awake()
    {
        EnemyStatic.StaticRun();
        EnemyStatic.species = "Monster";

        EnemyStatic enemy01 = new EnemyStatic();
        enemy01.InstanceRun();
        enemy01.numeric = 1;
    }
}

public static class StringExtension
{
    public static void PrintData(this string str)
    {
        Debug.Log(str);
    }
}

public class ExtensionTest : MonoBehaviour
{
    private void Awake()
    {
        string str = "Hello World";
        str.PrintData();
    }
}

namespace MySpace
{
    public class Player
    {
    }
}

namespace YourSpace
{
    public class Player
    {
    }
}

public class NamespaceTest : MonoBehaviour
{
    private void Start()
    {
        Player myPlayer = new Player();
        YourSpace.Player yourPlayer = new YourSpace.Player();
    }
}
*/