using UnityEngine;

/*
public class Player : MonoBehaviour
{
    public string id;
    public int currentHP;

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
    }
}

public class Enemy : MonoBehaviour
{
    public Player targetPlayer;

    public void AttackToTarget(Player target)
    {
        target.TakeDamage(10);
    }
}

public class PlayerTest : MonoBehaviour
{
    private void Start()
    {
        Player player01 = new Player();
        player01.TakeDamage(10);

        Player player02;
    }
}

public class Player
{
    public string id;
    public int hp;

    public Player()
    {
        id = "Noname";
        hp = 100;
    }

    public Player(string id, int hp)
    {
        this.id = id;
        this.hp = hp;
    }

    ~Player()
    {
    }

    public Player DeepCopy()
    {
        Player clone = new Player();
        clone.id = id;
        clone.hp = hp;
        return clone;
    }
}
*/
public class PlayerChaining
{
    public string id;
    public int hp;

    public PlayerChaining() : this("Noname", 100)
    {
    }

    public PlayerChaining(string id) : this(id, 100)
    {
    }

    public PlayerChaining(string id, int hp)
    {
        this.id = id;
        this.hp = hp;
    }
}