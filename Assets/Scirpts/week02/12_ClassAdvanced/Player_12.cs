using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_12 : Entity_12
{
    private string ID;

    //public Player_12(string id, int hp)
    //{
    //    base.ID = "Noname";
    //    ID = id;
    //    currentHP = hp;

    //    RecoveryHP(1000);

    //    //// private�̱� ������ ��� �Ұ�
    //    // Initialize();
    //}

    public void SetCurrentHP(int hp)
    {
        if(hp > 0)
        {
            currentHP = hp;
        }
    }

    public int GetCurrentHP()
    {
        return currentHP;
    }

    private int damage = 10;

	//   public void Hit(Goblin_12 goblin)
	//   {
	//       goblin.TakeDamage(damage);
	//   }

	//public void Hit(Slime_12 slime)
	//{
	//	slime.TakeDamage(damage);
	//}

	//public void Hit(Dragon_12 dragon)
	//{
	//	dragon.TakeDamage(damage);
	//}

	public void Hit(Enemy_12 enemy)
    {
		enemy.TakeDamage(damage);
    }
}
