using UnityEngine;
using System.Collections;

public class PetStats19 : MonoBehaviour {


	// Use this for initialization
	void Awake () 
	{
		PetHealth.maxHealth = 500f;
		PetDamage.baseMinDamage = 38f;
		PetDamage.baseMaxDamage = 76f;
		PetDamage.basePetAttackSpeed = 1f;
		PetCriticalDamage.baseCritChance = 11f;
		PetEvasion.baseEvadeChance = 48f;

		SpawnPet.petSummoned = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
