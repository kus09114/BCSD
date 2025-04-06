using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController_12 : MonoBehaviour
{
	//private Entity_12_abs goblin_abs;
	//private Entity_12_abs slime_abs;

	private IMovingEntity_12 gobline_12_interface;
	private IMovingEntity_12 slime_12_interface;
	private IMovingEntity_12 butterfly_12_interface;

    private void Awake()
    {
		//Player_12 player = new Player_12();

		//// private 멤버 변수에 접근 불가. Error
		//player.currentHP = 100;
		//Debug.Log($"{player.currentHP}");

		// currentHP의 Set, Get 메소드 접근
		//player.SetCurrentHP(100);
		//Debug.Log($"{player.GetCurrentHP()}");

		//Player_12 player = new Player_12();

		//Goblin_12 goblin = new Goblin_12();
		//Slime_12 slime = new Slime_12();
		//Dragon_12 dragon = new Dragon_12();

		//Enemy_12 goblin = new Goblin_12();
		//Enemy_12 slime = new Slime_12();
		//Enemy_12 dragon = new Dragon_12();

		//player.Hit(goblin);
		//player.Hit(slime);
		//player.Hit(dragon);

		//Entity_12 entity_isas = new Slime_12_ISAS();
		//if(entity_isas is Slime_12_ISAS)
		//{
		//	Debug.Log("Entity type is Slime");
		//}

		//Goblin_12_ISAS goblin_isas = entity_isas as Goblin_12_ISAS;
		//if (goblin_isas == null)
		//{
		//	Debug.Log("Entity type is Slime");
		//}

		//goblin_abs = new Goblin_12_abs(5, 100);
		//slime_abs = new Slime_12_abs(10, 50);

		//goblin_abs.Attack(slime_abs);
		//slime_abs.Attack(goblin_abs);

		gobline_12_interface = new Goblin_12_interface();
		slime_12_interface = new Slime_12_interface();
		butterfly_12_interface = new Butterfly_12_interface();

		gobline_12_interface.MoveTo(new Vector3(1, 2, 3));
		slime_12_interface.MoveTo(new Vector3(4, 5, 6));
		butterfly_12_interface.MoveTo(new Vector3(7, 8, 9));

	}
}
