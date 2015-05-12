using UnityEngine;
using System.Collections;

public class PetStats9 : MonoBehaviour {


	// Use this for initialization
	void Awake () 
	{
		PetHealth.maxHealth = 300f;
		PetDamage.baseMinDamage = 18f;
		PetDamage.baseMaxDamage = 36f;
		PetDamage.basePetAttackSpeed = 1f;
		PetCriticalDamage.baseCritChance = 11f;
		PetEvasion.baseEvadeChance = 24f;

		SpawnPet.petSummoned = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
