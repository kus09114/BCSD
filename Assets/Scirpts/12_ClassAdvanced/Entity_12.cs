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
        Debug.Log("적을 공격한다");
    }

	public void Heal()
	{
		Debug.Log("체력을 회복한다.");
	}

	public void TakeDamage(int damage)
	{
		Debug.Log($"적 : {damage}만큼 체력 감소");
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
            Debug.Log($"체력이 {damage} 감소");
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
        Debug.Log("고블린의 몽둥이 스매시!");
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
		Debug.Log("슬라임의 몸통 박치기!");
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
        Debug.Log($"{destination}까지 걸어서 이동");
    }
}

public class Slime_12_interface : IMovingEntity_12
{
	public void MoveTo(Vector3 destination)
	{
		Debug.Log($"{destination}까지 기어서 이동");
	}
}

public class Butterfly_12_interface : IMovingEntity_12
{
	public void MoveTo(Vector3 destination)
	{
		Debug.Log($"{destination}까지 날아서 이동");
	}
}