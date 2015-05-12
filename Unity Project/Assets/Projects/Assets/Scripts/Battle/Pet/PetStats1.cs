using UnityEngine;
using System.Collections;

public class PetStats1 : MonoBehaviour {



	void Awake ()
	{

		PetHealth.maxHealth = 10;
		PetDamage.baseMinDamage = 2f;
		PetDamage.baseMaxDamage = 4f;		
		PetDamage.basePetAttackSpeed = 1f;
		PetCriticalDamage.baseCritChance = 10f;
		PetEvasion.baseEvadeChance = 10f;

		SpawnPet.petSummoned = false;
	}


}
