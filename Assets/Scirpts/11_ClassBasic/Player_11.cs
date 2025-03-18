using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_11
{
    public string ID;
    private int currentHP;
    private int currentMP;

    // 생성자
    public Player_11()
    {
		ID = "고박사";
		currentHP = 1000;
	}

    // 생성자 메소드 오버로딩
    public Player_11(string id, int hp)
    {
        ID = id;
        currentHP = hp;
    }

    // 소멸자
    ~Player_11()
    {
        // 삭제됨
    }

    // 깊은 복사
	public Player_11 DeepCopy()
    {
        Player_11 clone = new Player_11();
        clone.ID = ID;
        clone.currentHP = currentHP;

        return clone;
    }

	// this 키워드 
	public void SetID(string ID)
    {
        Debug.Log($"ID : {ID}");
        Debug.Log($"ID : {this.ID}");
    }

    //// this() 생성자
    //public Player_11()
    //{
    //    ID = "고박사";
    //}

    //public Player_11(int hp):this()
    //{
    //    currentHP = hp;
    //}

    //public Player_11(int hp, int mp):this(hp)
    //{
    //    currentMP = mp;
    //}

	private void Awake()
    {
        TakeDamage(100);
    }

    void RecoveryHP(int hp)
    {
        currentHP += hp;
    }

    public void TakeDamage(int damage)
    {
        if(currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}
