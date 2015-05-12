using UnityEngine;
using System.Collections;

public class BaseWizardClass : BaseCharacterClass {


	
	public BaseWizardClass()
	{
		CharacterClassName = "Wizard";
		CharacterClassDescription = "Chance to heal";

		BaseMinDamage = 2;
		BaseMaxDamage = 2;
		AttackSpeed = 2f;
		MaxHealth = 15;
		BaseCritChance = 3;
		BaseEvadeChance = 5;
	}
	
	

}
