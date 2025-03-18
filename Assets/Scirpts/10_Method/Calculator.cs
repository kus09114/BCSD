using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    int a, b, c, d, e = 0;

    void Awake()
    {
        // Add
        Debug.Log("===== Add =====");
		Add(1, 2);

		// Multiple
		Debug.Log("===== Multiple =====");
		Multiple(3, 2);

		// Max
		Debug.Log("===== Max =====");
        Max(5, 10);

		// Divide
		Debug.Log("===== Divide =====");
		Divide(3, 2);

		// Swap
		Debug.Log("===== Swap =====");
		a = 3;
        b = 4;
        Debug.Log($"a = {a}, b = {b}");
        Swap(ref a, ref b);

		// Divide1
		Debug.Log("===== 출력 전용 매개 변수 Divide =====");
        a = 5;
        b = 4;
        int result1 = 0, result2 = 0;
        Divide1(a, b, ref result1, ref result2);
		Debug.Log($"몫={result1}, 나머지={result2}");

		// Divide2
		Debug.Log("===== 출력 전용 매개 변수 out Divide =====");
		a = 5;
		b = 4;
		result1 = 0;
		result2 = 0;
		Divide2(a, b, out result1, out result2);
		Debug.Log($"몫={result1}, 나머지={result2}");


		// Sum
		Debug.Log("===== 가변 길이 매개 변수 Sum =====");
		Sum(1, 2);
		Sum(1, 2, 3);
		Sum(1, 2, 3, 4);
		Sum(1, 2, 3, 4, 5);


		// 명명된 매개 변수
		Debug.Log("===== 명명된 매개 변수 =====");
		Debug.Log("일반적인 매개 변수 사용");
		Player("고박사", 100);
		Debug.Log("명명된 매개 변수 사용");
		Player(ID:"고박사", health:100);
		Player(health: 100, ID:"고박사");

		// 선택적 매개 변수
		Debug.Log("===== 명명된 매개 변수 =====");
		Player2("고박사");
		Player2("고박사", 3000);
	}

	public void Add(int num1, int num2)
    {
        int result = num1 + num2;
		Debug.Log($"{num1} + {num2} = {result}");
	}

	public void Add(float num1, float num2)
	{
		float result = num1 + num2;
		Debug.Log($"{num1} + {num2} = {result}");
	}

	public void Multiple(int num1, int num2)
    {
		int result = num1 - num2;
        Debug.Log($"{num1} x {num2} = {result}");
	}

    public void Max(int num1, int num2)
    {
        if(num1 > num2)
        {
			Debug.Log($"{num1} > {num2}, max = {num1}");
		}
		Debug.Log($"{num1} < {num2}, max = {num2}");
	}

    public void Divide(int num1, int num2)
    {
        if(num2 == 0)
        {
            Debug.Log("나누려는 값이 0이기 때문에 프로그램 종료");
            return;
        }

        float result = num1 / num2;
		Debug.Log($"{num1} / {num2} = {result}");
	}

    public void Divide1(int num1, int num2, ref int result1, ref int result2)
    {
        result1 = num1 / num2;
        result2 = num1 % num2;
    }

	public void Divide2(int num1, int num2, out int result1, out int result2)
	{
		result1 = num1 / num2;
		result2 = num1 % num2;
	}

	public void Swap(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

	public void Sum(params int[] nums)
	{
		int sum = 0;
		for(int i = 0; i < nums.Length; i++)
		{
			sum += nums[i];
		}
		Debug.Log($"합계 : {sum}");
	}

	public void Player(string ID, int health)
	{
		Debug.Log($"ID : {ID}, HP : {health}");
	}

	public void Player2(string ID, int health=1000)
	{
		Debug.Log($"ID : {ID}, HP : {health}");
	}
}
