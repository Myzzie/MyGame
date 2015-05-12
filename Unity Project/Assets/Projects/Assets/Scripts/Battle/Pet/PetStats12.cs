using UnityEngine;
using System.Collections;

public class PetStats12 : MonoBehaviour {



	void Awake ()
	{
		PetHealth.maxHealth = 30f;
		PetDamage.baseMinDamage = 24f;
		PetDamage.baseMaxDamage = 48f;
		PetDamage.basePetAttackSpeed = 1f;
		PetCriticalDamage.baseCritChance = 5f;
		PetEvasion.baseEvadeChance = 18f;
		
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
