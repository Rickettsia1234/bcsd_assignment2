using UnityEngine;
/*
public class Player : MonoBehaviour
{
    private int currentHP;

    public void SetCurrentHP(int hp)
    {
        currentHP = hp;
    }

    public int GetCurrentHP()
    {
        return currentHP;
    }
}

public class Entity : MonoBehaviour
{
    public string id;
    public int currentHP;

    private void Initialize()
    {
    }

    public void RecoveryHP(int hp)
    {
        currentHP += hp;
    }
}

public class PlayerInheritance : Entity
{
    public string id;

    public void SetID(string id)
    {
        this.id = id;
        base.id = id;
    }
}

public class Enemy : MonoBehaviour
{
    public virtual void TakeDamage(int damage)
    {
        Debug.Log("Enemy가 데미지를 입었습니다.");
    }
}

public class Slime : Enemy
{
    public override void TakeDamage(int damage)
    {
        Debug.Log("슬라임이 몸통 박치기 공격을 당해 데미지를 입었습니다.");
    }
}

public class Goblin : Enemy
{
    public override void TakeDamage(int damage)
    {
        Debug.Log("고블린이 몽둥이 스매시 공격을 당해 데미지를 입었습니다.");
    }
}

public class PolymorphismController : MonoBehaviour
{
    private void Start()
    {
        Enemy[] enemies = new Enemy[2];
        enemies[0] = new Slime();
        enemies[1] = new Goblin();

        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].TakeDamage(10);
        }
    }
}

public class TypeCheckExample : MonoBehaviour
{
    private void Start()
    {
        Entity entity = new Slime();

        if (entity is Slime)
        {
            Debug.Log("entity는 Slime 타입입니다.");
        }

        Goblin goblin = entity as Goblin;
        if (goblin == null)
        {
            Debug.Log("Goblin으로 형변환에 실패하였습니다.");
        }
    }
}

public abstract class AbstractEntity : MonoBehaviour
{
    public int damage;
    public int currentHP;

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
    }

    public abstract void Attack();
}

public class AbstractGoblin : AbstractEntity
{
    public override void Attack()
    {
        Debug.Log("고블린 공격");
    }
}
*/
public interface IMovingEntity
{
    void MoveTo();
}

public interface IPerson : IMovingEntity
{
    void Talk();
}

public class InterfacePlayer : MonoBehaviour, IPerson
{
    public void MoveTo()
    {
        Debug.Log("플레이어 이동");
    }

    public void Talk()
    {
        Debug.Log("플레이어 대화");
    }
}