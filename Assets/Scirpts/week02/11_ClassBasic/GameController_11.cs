using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public Player_11 player01;
    public Player_11 player02;

    private void Awake()
    {
		// Ŭ���� ��ü ����
		player01 = new Player_11();
		player01.TakeDamage(100);

		// ������ �޼ҵ� �����ε�
        player01 = new Player_11();
        player02 = new Player_11("����Ƽ", 10);

		// ���� ����
		player01 = new Player_11();
		player02 = player01;
		player02.ID = "����Ƽ";

		Debug.Log($"ID : {player01.ID}"); // ��� : ����Ƽ
		Debug.Log($"ID : {player02.ID}"); // ��� : ����Ƽ

		// ���� ����
		player01 = new Player_11("��ڻ�", 1000);

		player02 = player01.DeepCopy();
		player02.ID = "����Ƽ";

		Debug.Log($"ID : {player01.ID}"); // ��� : ��ڻ�
		Debug.Log($"ID : {player02.ID}"); // ��� : ����Ƽ

		// this Ű���� 
		player01.SetID("����Ƽ");
	}
}
