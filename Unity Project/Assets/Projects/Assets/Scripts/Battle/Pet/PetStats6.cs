using UnityEngine;
using System.Collections;

public class PetStats6 : MonoBehaviour {


	void Awake ()
	{
		PetHealth.maxHealth = 100;
		PetDamage.baseMinDamage = 12f;
		PetDamage.baseMaxDamage = 24f;		
		PetDamage.basePetAttackSpeed = 1f;
		PetCriticalDamage.baseCritChance = 10f;
		PetEvasion.baseEvadeChance = 10f;
	
		SpawnPet.petSummoned = false;
	}


}
