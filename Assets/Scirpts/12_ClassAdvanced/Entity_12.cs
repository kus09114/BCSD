using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class Entity_12
{
    public string ID;
    protected int currentHP;

    private void Initialize()
    {
        ID = "Noname";
    }

    public void RecoveryHP(int hp)
    {
        currentHP += hp;
    }

    public void Attack()
    {
        Debug.Log("���� �����Ѵ�");
    }

	public void Heal()
	{
		Debug.Log("ü���� ȸ���Ѵ�.");
	}

	public void TakeDamage(int damage)
	{
		Debug.Log($"�� : {damage}��ŭ ü�� ����");
	}
}

public class Slime_12_ISAS : Entity_12
{

}

public class Goblin_12_ISAS : Entity_12
{

}

public abstract class Entity_12_abs
{
    protected int damage;
    protected int currentHP;

    public abstract void Attack(Entity_12_abs target);
    public void TakeDamage(int damage)
    {
        if(currentHP > 0)
        {
            currentHP -= damage;
            Debug.Log($"ü���� {damage} ����");
        }
        else
        {
            Debug.Log("Die");
        }
    }
}

public abstract class Goblin_12_abs : Entity_12_abs
{
    public Goblin_12_abs(int damage, int hp)
    {
        base.damage = damage;
        currentHP = hp;
    }

    public override void Attack(Entity_12_abs target)
    {
        Debug.Log("����� ������ ���Ž�!");
        target.TakeDamage(damage);
    }
}

public abstract class Slime_12_abs : Entity_12_abs
{
	public Slime_12_abs(int damage, int hp)
	{
		base.damage = damage;
		currentHP = hp;
	}

	public override void Attack(Entity_12_abs target)
	{
		Debug.Log("�������� ���� ��ġ��!");
		target.TakeDamage(damage);
	}
}

interface IMovingEntity_12
{
    void MoveTo(Vector3 destination);
}

public class Goblin_12_interface : IMovingEntity_12
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}���� �ɾ �̵�");
    }
}

public class Slime_12_interface : IMovingEntity_12
{
	public void MoveTo(Vector3 destination)
	{
		Debug.Log($"{destination}���� �� �̵�");
	}
}

public class Butterfly_12_interface : IMovingEntity_12
{
	public void MoveTo(Vector3 destination)
	{
		Debug.Log($"{destination}���� ���Ƽ� �̵�");
	}
}