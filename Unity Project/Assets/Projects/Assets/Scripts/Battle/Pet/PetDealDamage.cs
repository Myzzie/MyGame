using UnityEngine;
using System.Collections;

public class PetDealDamage : MonoBehaviour {



	public MonsterHealth monsterHealth;
	

	public static bool holdAttack;
	public static float damageDealt;
	public static bool petTaunting;


	// Use this for initialization
	void Start () 
	{

		StartCoroutine (AutoTick ());


	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if (PlayerHealth.currentHealth >= PlayerHealth.maxHealth){
			holdAttack = false;
		}
	}




	
	
	public void TakingDamage()
	{
		if (!PetHealth.petDead)
		{
			if (SpawnPet.petSpawned)
			{
				
				if (PlayerHealth.currentHealth > PlayerHealth.maxHealth/3)
				{
					if (holdAttack == false)
					{
						PetDamage.PetDamage1 ();
						monsterHealth.currentHealth -= PetDamage.petDamage;
						damageDealt += PetDamage.petDamage;
						GameObject FloatingPetDamage = Instantiate (Resources.Load ("Prefabs/PetDamageText")) as GameObject;
						FloatingPetDamage.GetComponent<FloatingPetDamage> ().DisplayDamage ((PetDamage.petDamage).ToString ());
						FloatingPetDamage.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
					}

					//Wizard Pet Skills
					WizardPetTauntSkill.PetTaunt();
					WizardPetRageSkill.PetRage();
				
				}
				else
				{
					if (monsterHealth.currentHealth < monsterHealth.maxHealth)
					{
						PetDamage.PetDamage1 ();
						monsterHealth.currentHealth -= PetDamage.petDamage;
						damageDealt += PetDamage.petDamage;
						GameObject FloatingPetDamage = Instantiate (Resources.Load ("Prefabs/PetDamageText")) as GameObject;
						FloatingPetDamage.GetComponent<FloatingPetDamage> ().DisplayDamage ((PetDamage.petDamage).ToString ());
						FloatingPetDamage.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
					
						//Wizard Pet Skills
						WizardPetTauntSkill.PetTaunt();
						WizardPetRageSkill.PetRage();
					}
					if (monsterHealth.currentHealth >= monsterHealth.maxHealth)
					{
						if (!holdAttack)
						{
							holdAttack = true;
							StartCoroutine(PetHealth.Regen());
						}
					}
					
				}
				
			}
		}
	}
	
	IEnumerator AutoTick()
	{
		while (true) {
			
			yield return new WaitForSeconds(PetDamage.petAttackSpeed);
			if (!PlayerHealth.playerIsDead){
			TakingDamage ();
			}
			
		}
	}
	
	
	

}


