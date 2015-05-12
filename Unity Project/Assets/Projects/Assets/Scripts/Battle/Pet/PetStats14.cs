using UnityEngine;
using System.Collections;

public class PetStats14 : MonoBehaviour {


	// Use this for initialization
	void Awake () 
	{
		PetHealth.maxHealth = 275f;
		PetDamage.baseMinDamage = 56f;
		PetDamage.baseMaxDamage = 112f;
		PetDamage.basePetAttackSpeed = 2f;
		PetCriticalDamage.baseCritChance = 13f;
		PetEvasion.baseEvadeChance = 7f;

		SpawnPet.petSummoned = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
