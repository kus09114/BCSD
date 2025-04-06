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
        // 메소드 숨기기
        Parent p = new Parent();
        p.Method01();   // Parent

        Child c = new Child();
        c.Method01();   // Child

        Parent pc = new Child();
        pc.Method01();  // Parent

        // 구조체
        Stats_13 player01 = new Stats_13();
        Stats_13 player02;

        player02.ID = "고박사";
        player02.currentHP = 100000;
        player02.damage = 99999;

        Debug.Log($"{player01.ID}, 체력 : {player01.currentHP}, 공격력 : {player01.damage}");
        Debug.Log($"{player02.ID}, 체력 : {player02.currentHP}, 공격력 : {player02.damage}");

        // 튜플
        Tuple_13_1();
        Tuple_13_2();
        Tuple_13_3();
        Tuple_13_4();

		// 정적(static) 메소드
		int j = Enemy_13_StaticMethod.StaticRun();
		Enemy_13_StaticMethod enemy_13_static = new Enemy_13_StaticMethod();
        int i = enemy_13_static.InstanceRun();

        //enemy_13_static.StaticRun(); // 호출 불가능

        // 정적(Static) 변수
        // instance 변수 사용
        Enemy_13_StaticVariable enemy_13_staticVariable_01 = new Enemy_13_StaticVariable();
        enemy_13_staticVariable_01.numeric = 0;
		Enemy_13_StaticVariable enemy_13_staticVariable_02 = new Enemy_13_StaticVariable();
        enemy_13_staticVariable_02.numeric = 1;

        Debug.Log(enemy_13_staticVariable_01.numeric);
        Debug.Log(enemy_13_staticVariable_02.numeric);

        // static 변수 사용
        Enemy_13_StaticVariable.specise = "고블린";
		Debug.Log(Enemy_13_StaticVariable.specise);

        // 정적(static) 클래스
        // static 클래스의 메소드 호출
        Debug.Log(Calculator_13_StaticClass.Sum(20, 55));
		// static 클래스의 변수 사용
		Debug.Log(Calculator_13_StaticClass.num);

        // 확장 메소드
        string str = "안녕하세요. 고박사입니다.";
        str.PrintData();

        // 이름 공간
        // MySpace에 정의된 Player 사용(using MySpace 때문에)
        Player_13_namespace player01_np;
        // YourSpace에 정의된 Player 사용
        YourSpace_13.Player_13_namespace player02_np;
	}


	// 튜플
	public void Tuple_13_1()
    {
        var a = ( "고박사", 35 );
        Debug.Log($"{a.Item1}, {a.Item2}");

        a.Item2 = 36;
		Debug.Log($"{a.Item1}, {a.Item2}");
	}

	public void Tuple_13_2()
	{
		var a = (Name:"고박사", Age:35);
		Debug.Log($"{a.Name}, {a.Age}");
	}

	public void Tuple_13_3()
	{
		var a = (Name: "고박사", Age: 35);
        var (name, age) = a;
		Debug.Log($"{name}, {age}");
	}

	public void Tuple_13_4()
	{
		var a = (Name: "고박사", Age: 35);
		var (name, _) = a;
        // 나이필드 무시 => age 사용 불가능
		//Debug.Log($"{name}, {age}");
	}
}

// 메소드 숨기기
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

// 오버라이딩 봉인하기
public class Entity_13_seal
{
    public virtual void TakeDamage(int damage)
    {
        Debug.Log($"Entity : {damage}만큼 체력 감소");
    }
}

public class MovingEntity_13_seal : Entity_13_seal
{
	public override void TakeDamage(int damage)
	{
		Debug.Log($"Entity : {damage}만큼 체력 감소");
	}
}

public class Player_13_seal : MovingEntity_13_seal
{
	public virtual void TakeDamage(int damage)
	{
		Debug.Log($"Entity : {damage}만큼 체력 감소");
	}
}

// 구조체
public struct Stats_13
{
    public string ID;
    public int currentHP;
    public int damage;
}

// 정적(Static) 메소드
public class Enemy_13_StaticMethod
{
    public int InstanceRun() { return 1; }
    public static int StaticRun()
    {
        // 호출 불가능
        //InstanceRun();
        return 1;
	}
}

// 정적(Static) 변수
public class Enemy_13_StaticVariable
{
    public int numeric;
    public static string specise;
}

// 정적(static) 클래스
public static class Calculator_13_StaticClass
{
    public static int num;

    // static 생성자
    static Calculator_13_StaticClass()
    {
        num = 1;
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}

// 확장 메소드
// string 클래스에 PrintData() 메소드를 추가하는 확장 메소드 추가
public static class StringExtension_13_ExtensionMethod
{
    // 첫 번째 매개변수는 확장하려고 하는 대상
	public static void PrintData(this string str)
    {
        Debug.Log(str);
    }
}

// 이름 공간
// 이름 공간 선언
namespace MySpace_13
{
    public class Player_13_namespace
    {
        // 변수, 메소드
    }
}
// 이름 공간 선언
namespace YourSpace_13
{
	public class Player_13_namespace
	{
		// 변수, 메소드
	}
}