using UnityEngine;
using System.Collections;

public class PetStats11 : MonoBehaviour {



	void Awake ()
	{

		PetHealth.maxHealth = 1750;
		PetDamage.baseMinDamage = 22f;
		PetDamage.baseMaxDamage = 44f;		
		PetDamage.basePetAttackSpeed = 1f;
		PetCriticalDamage.baseCritChance = 10f;
		PetEvasion.baseEvadeChance = 10f;

		SpawnPet.petSummoned = false;
	}


}
