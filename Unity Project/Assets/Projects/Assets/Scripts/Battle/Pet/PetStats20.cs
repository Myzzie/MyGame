using UnityEngine;
using System.Collections;

public class PetStats20 : MonoBehaviour {


	// Use this for initialization
	void Awake () 
	{
		PetHealth.maxHealth = 2000f;
		PetDamage.baseMinDamage = 120f;
		PetDamage.baseMaxDamage = 240f;
		PetDamage.basePetAttackSpeed = 1f;
		PetCriticalDamage.baseCritChance = 27f;
		PetEvasion.baseEvadeChance = 19f;

		SpawnPet.petSummoned = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
