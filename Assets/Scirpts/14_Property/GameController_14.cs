using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class GameController_14 : MonoBehaviour
{
    private void Awake()
	{
        // 프로퍼티 선언
        Player_14 player = new Player_14();
        player.CurrentHP = 100;
        Debug.Log($"Player HP : {player.CurrentHP}");
		player.CurrentHP = -100;
		Debug.Log($"Player HP : {player.CurrentHP}");

        // 자동 구현 프로퍼티
        Player_14_Auto player_auto = new Player_14_Auto();
        player_auto.ID = "고박사";
        player_auto.CurrentHP = 100;
		Debug.Log($"{player_auto.ID} HP : {player_auto.CurrentHP}");

        // 프로퍼티와 생성자
        Player_14_Constructor player_constructor = new Player_14_Constructor()
        {
            ID = "고박사",
            CurrentHP = 100
        };

        // 추상 클래스 프로퍼티
        Player_14_abs player_abs = new Player_14_abs()
        {
            ID = "고박사",
            Shield = 50,
            Defense = 10,
        };

        Debug.Log($"ID : {player_abs.ID}");
        Debug.Log($"방어력 : {player_abs.Defense}, 방어막 : {player_abs.Shield}");

	}
}

// 프로퍼티 선언
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

// 자동 구현 프로퍼티
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

// 읽기/쓰기 전용 프로퍼티
// 읽기 전용
public class Player_14_Read
{
    private int currentHP;
	public int CurrentHP
	{
		get => currentHP;
	}
}
// 쓰기 전용
public class Player_14_Write
{
	private int currentHP;
	public int CurrentHP
	{
		set => currentHP = value;
	}
}
// private 접근 지정자 사용
public class Player_14_RWPrivate
{
	private int currentHP;
    //public int CurrentHP
    //{
    //    private set; get;
    //}
    // 또는
	public int CurrentHP
	{
		private set => currentHP = value;
        get => currentHP;
	}
}

// 프로퍼티와 생성자
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

// 인터페이스의 프로퍼티
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

// 추상 클래스 프로퍼티
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