using UnityEngine;
using System.Collections;

public class PetStats17 : MonoBehaviour {



	void Awake ()
	{
		PetHealth.maxHealth = 400f;
		PetDamage.baseMinDamage = 34f;
		PetDamage.baseMaxDamage = 68f;
		PetDamage.basePetAttackSpeed = 2f;
		PetCriticalDamage.baseCritChance = 21f;
		PetEvasion.baseEvadeChance = 41f;
		
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
