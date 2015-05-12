using UnityEngine;
using System.Collections;

public class PetStats15 : MonoBehaviour {


	// Use this for initialization
	void Awake () 
	{
		PetHealth.maxHealth = 300f;
		PetDamage.baseMinDamage = 10f;
		PetDamage.baseMaxDamage = 20f;
		PetDamage.basePetAttackSpeed = 2f;
		PetCriticalDamage.baseCritChance = 5f;
		PetEvasion.baseEvadeChance = 5f;

		SpawnPet.petSummoned = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
