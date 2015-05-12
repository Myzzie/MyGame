using UnityEngine;
using System.Collections;

public class PetStats2 : MonoBehaviour {



	void Awake ()
	{
		PetHealth.maxHealth = 30f;
		PetDamage.baseMinDamage = 4f;
		PetDamage.baseMaxDamage = 8f;
		PetDamage.basePetAttackSpeed = 1f;
		PetCriticalDamage.baseCritChance = 5f;
		PetEvasion.baseEvadeChance = 11f;
		
		SpawnPet.petSummoned = false;
	}
	// Use this for initialization
	void Start () 
	{
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
