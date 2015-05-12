using UnityEngine;
using System.Collections;

public class PetDamage : MonoBehaviour 
{


	public static float petDamage;
	public static float minDamage;
	public static float maxDamage;
	public static float baseMinDamage;
	public static float baseMaxDamage;
	public static float petDamageEnhance;
	public static float petAttackSpeed;
	public static float basePetAttackSpeed;
	public static float petAttackSpeedEnhance;
	public static float APS;




	void Start()
	{

		
	}


	void Update ()
	{
		petAttackSpeed = basePetAttackSpeed  / petAttackSpeedEnhance;
		
		minDamage = baseMinDamage  * petDamageEnhance;
		maxDamage = baseMaxDamage  * petDamageEnhance;
		
		PetEvasion.petEvadeChance = PetEvasion.baseEvadeChance * PetEvasion.evadeEnhance;
		PetCriticalDamage.petCritChance = PetCriticalDamage.baseCritChance * PetCriticalDamage.critEnhance;
	
		APS = 1/petAttackSpeed;
	
	}
	public static void PetDamage1 ()
	{
		petDamage = (int)Random.Range (minDamage, maxDamage + 1);

		PetCriticalDamage.CritChance ();
		if (PetCriticalDamage.petCritChance1) 
		{
			petDamage = (float)petDamage * (float)PetCriticalDamage.GetCritHit ();
		
		}
	}





	
	
	

}








