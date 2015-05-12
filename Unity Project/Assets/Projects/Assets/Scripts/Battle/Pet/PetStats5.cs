using UnityEngine;
using System.Collections;

public class PetStats5 : MonoBehaviour {


	// Use this for initialization
	void Awake () 
	{
		PetHealth.maxHealth = 75f;
		PetDamage.baseMinDamage = 30f;
		PetDamage.baseMaxDamage = 60f;
		PetDamage.basePetAttackSpeed = 2f;
		PetCriticalDamage.baseCritChance = 5f;
		PetEvasion.baseEvadeChance = 5f;

		SpawnPet.petSummoned = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
