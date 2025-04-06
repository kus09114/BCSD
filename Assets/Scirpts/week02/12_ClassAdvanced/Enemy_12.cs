using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_12
{
	public void TakeDamage(int damage)
	{
		Debug.Log($"적 : {damage}만큼 체력 감소");
	}
}

public class Goblin_12 : Enemy_12
{
	public void TakeDamage(int damage)
	{
		Debug.Log($"고블린 : {damage}만큼 체력 감소");
	}
}

public class Slime_12 : Enemy_12
{
	public void TakeDamage(int damage)
	{
		Debug.Log($"슬라임 : {damage}만큼 체력 감소");
	}
}

public class Dragon_12 : Enemy_12
{
	public void TakeDamage(int damage)
	{
		Debug.Log($"드래곤 : {damage}만큼 체력 감소");
	}
}
