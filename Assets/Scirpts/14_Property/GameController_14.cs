using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class GameController_14 : MonoBehaviour
{
    private void Awake()
	{
        // ������Ƽ ����
        Player_14 player = new Player_14();
        player.CurrentHP = 100;
        Debug.Log($"Player HP : {player.CurrentHP}");
		player.CurrentHP = -100;
		Debug.Log($"Player HP : {player.CurrentHP}");

        // �ڵ� ���� ������Ƽ
        Player_14_Auto player_auto = new Player_14_Auto();
        player_auto.ID = "��ڻ�";
        player_auto.CurrentHP = 100;
		Debug.Log($"{player_auto.ID} HP : {player_auto.CurrentHP}");

        // ������Ƽ�� ������
        Player_14_Constructor player_constructor = new Player_14_Constructor()
        {
            ID = "��ڻ�",
            CurrentHP = 100
        };

        // �߻� Ŭ���� ������Ƽ
        Player_14_abs player_abs = new Player_14_abs()
        {
            ID = "��ڻ�",
            Shield = 50,
            Defense = 10,
        };

        Debug.Log($"ID : {player_abs.ID}");
        Debug.Log($"���� : {player_abs.Defense}, �� : {player_abs.Shield}");

	}
}

// ������Ƽ ����
public class Player_14
{
    private int currentHP;
    public int CurrentHP
    {
        get => currentHP;
        set
        {
            if(currentHP > 0)
            {
                currentHP = value;
            }
            else
            {
                currentHP = 0;
            }
        }
    }
}

// �ڵ� ���� ������Ƽ
public class Player_14_Auto
{
    public int CurrentHP
	{
        get; set;
    }
    public string ID
    {
        get; set;
    }
}

// �б�/���� ���� ������Ƽ
// �б� ����
public class Player_14_Read
{
    private int currentHP;
	public int CurrentHP
	{
		get => currentHP;
	}
}
// ���� ����
public class Player_14_Write
{
	private int currentHP;
	public int CurrentHP
	{
		set => currentHP = value;
	}
}
// private ���� ������ ���
public class Player_14_RWPrivate
{
	private int currentHP;
    //public int CurrentHP
    //{
    //    private set; get;
    //}
    // �Ǵ�
	public int CurrentHP
	{
		private set => currentHP = value;
        get => currentHP;
	}
}

// ������Ƽ�� ������
public class Player_14_Constructor
{
    public int CurrentHP
    {
        get; set;
    }
    public string ID
    {
        get; set;
    }
}

// �������̽��� ������Ƽ
interface IBaseEntity_14
{
    string ID { get; set; }
    int Damage { get; set; }
    int CurrentHP { get; set; }
}

public class Player_14_interface : IBaseEntity_14
{
    private string id;
    public string ID
    {
        get => id;
        set => id = value;
    }
    public int Damage
    {
        get; set;
    }
    public int CurrentHP
    {
        get; set;
    }
}

// �߻� Ŭ���� ������Ƽ
public abstract class BaseEntity_14_abs
{
    abstract public int Shield
    {
        get; set;
    }
    public int Defense
    {
        get; set;
    }
}

public class Player_14_abs : BaseEntity_14_abs
{
    public override int Shield
    {
        get; set;
    }
    public string ID
    {
        get; set;
    }
}