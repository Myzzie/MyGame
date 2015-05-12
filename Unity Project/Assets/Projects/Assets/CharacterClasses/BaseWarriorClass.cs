using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass {




	public  BaseWarriorClass()
	{
		CharacterClassName = "Warrior";
		CharacterClassDescription = "Strong and slow";

		BaseMinDamage = 2;
		BaseMaxDamage = 4;
		AttackSpeed = 3;
		MaxHealth = 20;
		BaseCritChance = 2;
		BaseEvadeChance = 3;
	}



}
