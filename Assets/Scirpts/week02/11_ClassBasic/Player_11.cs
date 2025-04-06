using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_11
{
    public string ID;
    private int currentHP;
    private int currentMP;

    // ������
    public Player_11()
    {
		ID = "��ڻ�";
		currentHP = 1000;
	}

    // ������ �޼ҵ� �����ε�
    public Player_11(string id, int hp)
    {
        ID = id;
        currentHP = hp;
    }

    // �Ҹ���
    ~Player_11()
    {
        // ������
    }

    // ���� ����
	public Player_11 DeepCopy()
    {
        Player_11 clone = new Player_11();
        clone.ID = ID;
        clone.currentHP = currentHP;

        return clone;
    }

	// this Ű���� 
	public void SetID(string ID)
    {
        Debug.Log($"ID : {ID}");
        Debug.Log($"ID : {this.ID}");
    }

    //// this() ������
    //public Player_11()
    //{
    //    ID = "��ڻ�";
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
