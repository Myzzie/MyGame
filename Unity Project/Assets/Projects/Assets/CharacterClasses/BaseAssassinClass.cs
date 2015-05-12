using UnityEngine;
using System.Collections;

public class BaseAssassinClass : BaseCharacterClass {


	public BaseAssassinClass()
	{
		CharacterClassName = "Assassin";
		CharacterClassDescription = "Quick and deadly";
		
		BaseMinDamage = 1;
		BaseMaxDamage = 2;
		AttackSpeed = 1;
		MaxHealth = 10;
		BaseCritChance = 5;
		BaseEvadeChance = 7;
	}


}
