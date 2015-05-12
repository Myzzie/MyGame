using UnityEngine;
using System.Collections;

public class PetStats8 : MonoBehaviour {


	// Use this for initialization
	void Awake () 
	{
		
		PetHealth.maxHealth = 600f;
		PetDamage.baseMinDamage = 16f;
		PetDamage.baseMaxDamage = 32f;
		PetDamage.basePetAttackSpeed = 2f;
		PetCriticalDamage.baseCritChance = 15f;
		PetEvasion.baseEvadeChance = 8f;

		SpawnPet.petSummoned = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
