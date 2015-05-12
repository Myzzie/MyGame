using UnityEngine;
using System.Collections;

public class PetStats18 : MonoBehaviour {


	// Use this for initialization
	void Awake () 
	{
		
		PetHealth.maxHealth = 450f;
		PetDamage.baseMinDamage = 36f;
		PetDamage.baseMaxDamage = 72f;
		PetDamage.basePetAttackSpeed = 2f;
		PetCriticalDamage.baseCritChance = 22f;
		PetEvasion.baseEvadeChance = 13f;

		SpawnPet.petSummoned = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
