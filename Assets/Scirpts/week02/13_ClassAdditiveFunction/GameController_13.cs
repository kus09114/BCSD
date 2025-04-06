using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

using MySpace_13;

public class GameController_13 : MonoBehaviour
{
    private void Awake()
    {
        // �޼ҵ� �����
        Parent p = new Parent();
        p.Method01();   // Parent

        Child c = new Child();
        c.Method01();   // Child

        Parent pc = new Child();
        pc.Method01();  // Parent

        // ����ü
        Stats_13 player01 = new Stats_13();
        Stats_13 player02;

        player02.ID = "��ڻ�";
        player02.currentHP = 100000;
        player02.damage = 99999;

        Debug.Log($"{player01.ID}, ü�� : {player01.currentHP}, ���ݷ� : {player01.damage}");
        Debug.Log($"{player02.ID}, ü�� : {player02.currentHP}, ���ݷ� : {player02.damage}");

        // Ʃ��
        Tuple_13_1();
        Tuple_13_2();
        Tuple_13_3();
        Tuple_13_4();

		// ����(static) �޼ҵ�
		int j = Enemy_13_StaticMethod.StaticRun();
		Enemy_13_StaticMethod enemy_13_static = new Enemy_13_StaticMethod();
        int i = enemy_13_static.InstanceRun();

        //enemy_13_static.StaticRun(); // ȣ�� �Ұ���

        // ����(Static) ����
        // instance ���� ���
        Enemy_13_StaticVariable enemy_13_staticVariable_01 = new Enemy_13_StaticVariable();
        enemy_13_staticVariable_01.numeric = 0;
		Enemy_13_StaticVariable enemy_13_staticVariable_02 = new Enemy_13_StaticVariable();
        enemy_13_staticVariable_02.numeric = 1;

        Debug.Log(enemy_13_staticVariable_01.numeric);
        Debug.Log(enemy_13_staticVariable_02.numeric);

        // static ���� ���
        Enemy_13_StaticVariable.specise = "���";
		Debug.Log(Enemy_13_StaticVariable.specise);

        // ����(static) Ŭ����
        // static Ŭ������ �޼ҵ� ȣ��
        Debug.Log(Calculator_13_StaticClass.Sum(20, 55));
		// static Ŭ������ ���� ���
		Debug.Log(Calculator_13_StaticClass.num);

        // Ȯ�� �޼ҵ�
        string str = "�ȳ��ϼ���. ��ڻ��Դϴ�.";
        str.PrintData();

        // �̸� ����
        // MySpace�� ���ǵ� Player ���(using MySpace ������)
        Player_13_namespace player01_np;
        // YourSpace�� ���ǵ� Player ���
        YourSpace_13.Player_13_namespace player02_np;
	}


	// Ʃ��
	public void Tuple_13_1()
    {
        var a = ( "��ڻ�", 35 );
        Debug.Log($"{a.Item1}, {a.Item2}");

        a.Item2 = 36;
		Debug.Log($"{a.Item1}, {a.Item2}");
	}

	public void Tuple_13_2()
	{
		var a = (Name:"��ڻ�", Age:35);
		Debug.Log($"{a.Name}, {a.Age}");
	}

	public void Tuple_13_3()
	{
		var a = (Name: "��ڻ�", Age: 35);
        var (name, age) = a;
		Debug.Log($"{name}, {age}");
	}

	public void Tuple_13_4()
	{
		var a = (Name: "��ڻ�", Age: 35);
		var (name, _) = a;
        // �����ʵ� ���� => age ��� �Ұ���
		//Debug.Log($"{name}, {age}");
	}
}

// �޼ҵ� �����
public class Parent
{
    public void Method01()
    {
        Debug.Log("Parent");
    }
}

public class Child : Parent
{
    public new void Method01()
    {
        Debug.Log("Child");
    }
}

// �������̵� �����ϱ�
public class Entity_13_seal
{
    public virtual void TakeDamage(int damage)
    {
        Debug.Log($"Entity : {damage}��ŭ ü�� ����");
    }
}

public class MovingEntity_13_seal : Entity_13_seal
{
	public override void TakeDamage(int damage)
	{
		Debug.Log($"Entity : {damage}��ŭ ü�� ����");
	}
}

public class Player_13_seal : MovingEntity_13_seal
{
	public virtual void TakeDamage(int damage)
	{
		Debug.Log($"Entity : {damage}��ŭ ü�� ����");
	}
}

// ����ü
public struct Stats_13
{
    public string ID;
    public int currentHP;
    public int damage;
}

// ����(Static) �޼ҵ�
public class Enemy_13_StaticMethod
{
    public int InstanceRun() { return 1; }
    public static int StaticRun()
    {
        // ȣ�� �Ұ���
        //InstanceRun();
        return 1;
	}
}

// ����(Static) ����
public class Enemy_13_StaticVariable
{
    public int numeric;
    public static string specise;
}

// ����(static) Ŭ����
public static class Calculator_13_StaticClass
{
    public static int num;

    // static ������
    static Calculator_13_StaticClass()
    {
        num = 1;
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}

// Ȯ�� �޼ҵ�
// string Ŭ������ PrintData() �޼ҵ带 �߰��ϴ� Ȯ�� �޼ҵ� �߰�
public static class StringExtension_13_ExtensionMethod
{
    // ù ��° �Ű������� Ȯ���Ϸ��� �ϴ� ���
	public static void PrintData(this string str)
    {
        Debug.Log(str);
    }
}

// �̸� ����
// �̸� ���� ����
namespace MySpace_13
{
    public class Player_13_namespace
    {
        // ����, �޼ҵ�
    }
}
// �̸� ���� ����
namespace YourSpace_13
{
	public class Player_13_namespace
	{
		// ����, �޼ҵ�
	}
}