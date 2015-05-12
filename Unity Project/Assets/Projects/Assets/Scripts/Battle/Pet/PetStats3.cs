using UnityEngine;
using System.Collections;

public class PetStats3 : MonoBehaviour {


	// Use this for initialization
	void Awake () 
	{
		
		PetHealth.maxHealth = 40f;
		PetDamage.baseMinDamage = 6f;
		PetDamage.baseMaxDamage = 12f;
		PetDamage.basePetAttackSpeed = 1f;
		PetCriticalDamage.baseCritChance = 10f;
		PetEvasion.baseEvadeChance = 12f;

		SpawnPet.petSummoned = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
