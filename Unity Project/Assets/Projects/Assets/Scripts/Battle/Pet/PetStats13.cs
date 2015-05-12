using UnityEngine;
using System.Collections;

public class PetStats13 : MonoBehaviour {


	// Use this for initialization
	void Awake () 
	{
		
		PetHealth.maxHealth = 250f;
		PetDamage.baseMinDamage = 26f;
		PetDamage.baseMaxDamage = 52f;
		PetDamage.basePetAttackSpeed = 1f;
		PetCriticalDamage.baseCritChance = 10f;
		PetEvasion.baseEvadeChance = 20f;

		SpawnPet.petSummoned = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
