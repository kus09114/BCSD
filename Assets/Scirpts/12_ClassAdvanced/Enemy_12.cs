using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_12
{
	public void TakeDamage(int damage)
	{
		Debug.Log($"�� : {damage}��ŭ ü�� ����");
	}
}

public class Goblin_12 : Enemy_12
{
	public void TakeDamage(int damage)
	{
		Debug.Log($"��� : {damage}��ŭ ü�� ����");
	}
}

public class Slime_12 : Enemy_12
{
	public void TakeDamage(int damage)
	{
		Debug.Log($"������ : {damage}��ŭ ü�� ����");
	}
}

public class Dragon_12 : Enemy_12
{
	public void TakeDamage(int damage)
	{
		Debug.Log($"�巡�� : {damage}��ŭ ü�� ����");
	}
}
