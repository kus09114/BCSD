using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public Player_11 player01;
    public Player_11 player02;

    private void Awake()
    {
		// 클래스 객체 생성
		player01 = new Player_11();
		player01.TakeDamage(100);

		// 생성자 메소드 오버로딩
        player01 = new Player_11();
        player02 = new Player_11("유니티", 10);

		// 얕은 복사
		player01 = new Player_11();
		player02 = player01;
		player02.ID = "유니티";

		Debug.Log($"ID : {player01.ID}"); // 결과 : 유니티
		Debug.Log($"ID : {player02.ID}"); // 결과 : 유니티

		// 깊은 복사
		player01 = new Player_11("고박사", 1000);

		player02 = player01.DeepCopy();
		player02.ID = "유니티";

		Debug.Log($"ID : {player01.ID}"); // 결과 : 고박사
		Debug.Log($"ID : {player02.ID}"); // 결과 : 유니티

		// this 키워드 
		player01.SetID("유니티");
	}
}
