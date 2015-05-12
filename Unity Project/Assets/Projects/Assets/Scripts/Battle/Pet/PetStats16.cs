using UnityEngine;
using System.Collections;

public class PetStats16 : MonoBehaviour {


	void Awake ()
	{
		PetHealth.maxHealth = 300;
		PetDamage.baseMinDamage = 32f;
		PetDamage.baseMaxDamage = 64f;		
		PetDamage.basePetAttackSpeed = 1f;
		PetCriticalDamage.baseCritChance = 10f;
		PetEvasion.baseEvadeChance = 10f;
	
		SpawnPet.petSummoned = false;
	}


}
