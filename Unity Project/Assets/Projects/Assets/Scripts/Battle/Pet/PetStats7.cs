using UnityEngine;
using System.Collections;

public class PetStats7 : MonoBehaviour {



	void Awake ()
	{
		PetHealth.maxHealth = 150f;
		PetDamage.baseMinDamage = 14f;
		PetDamage.baseMaxDamage = 28f;
		PetDamage.basePetAttackSpeed = 1f;
		PetCriticalDamage.baseCritChance = 14f;
		PetEvasion.baseEvadeChance = 23f;
		
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
