using UnityEngine;
using System.Collections;

public class PetStats10 : MonoBehaviour {


	// Use this for initialization
	void Awake () 
	{
		PetHealth.maxHealth = 600f;
		PetDamage.baseMinDamage = 60f;
		PetDamage.baseMaxDamage = 120f;
		PetDamage.basePetAttackSpeed = 2f;
		PetCriticalDamage.baseCritChance = 5f;
		PetEvasion.baseEvadeChance = 5f;

		SpawnPet.petSummoned = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
