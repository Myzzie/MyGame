using UnityEngine;
using System.Collections;

public class PetStats4 : MonoBehaviour {


	// Use this for initialization
	void Awake () 
	{
		PetHealth.maxHealth = 50f;
		PetDamage.baseMinDamage = 16f;
		PetDamage.baseMaxDamage = 32f;
		PetDamage.basePetAttackSpeed = 2f;
		PetCriticalDamage.baseCritChance = 10f;
		PetEvasion.baseEvadeChance = 5f;

		SpawnPet.petSummoned = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
