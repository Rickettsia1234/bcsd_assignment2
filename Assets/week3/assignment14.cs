using UnityEngine;
/*
public class Player : MonoBehaviour
{
    private int currentHP;

    public int CurrentHP
    {
        get
        {
            return currentHP;
        }
        set
        {
            if (value < 0)
            {
                currentHP = 0;
            }
            else
            {
                currentHP = value;
            }
        }
    }
}
*/
public class PlayerAutoProperty : MonoBehaviour
{
    public string ID { get; set; }
    public int CurrentHP { get; set; }
}

public class GameController : MonoBehaviour
{
    private void Awake()
    {
        PlayerAutoProperty player01 = new PlayerAutoProperty();
        player01.ID = "고박사";
        player01.CurrentHP = 100;

        Debug.Log(player01.ID);
        Debug.Log(player01.CurrentHP);

        PlayerAutoProperty player02 = new PlayerAutoProperty() { ID = "유니티", CurrentHP = 50 };
    }
}

public interface IEntity
{
    string ID { get; set; }
    int CurrentHP { get; set; }
}

public class EntityPlayer : MonoBehaviour, IEntity
{
    public string ID { get; set; }
    public int CurrentHP { get; set; }
}

public abstract class BaseEntity : MonoBehaviour
{
    public abstract int Shield { get; set; }
    public int Defense { get; set; }
}

public class PlayerAbstractProperty : BaseEntity
{
    private int shield;

    public override int Shield
    {
        get
        {
            return shield;
        }
        set
        {
            shield = value;
        }
    }

    public string ID { get; set; }
}