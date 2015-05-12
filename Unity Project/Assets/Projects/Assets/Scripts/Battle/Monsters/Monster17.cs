using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Monster17 : MonoBehaviour {
	
	public MonsterDamage monsterDamage;
	public MonsterHealth monsterHealth;
	private int coinDrop;
	public static int enemyDeathCount;
	private float attackSpeed;
	public static float captureChance = 10;
	public Sprite frozen;
	public Button button;
	
	
	//Start happens at the start
	void Start()
	{
		Damage.damageDealt = 0;
		PetDealDamage.damageDealt = 0;
		MonsterHealth.enemyDead = false; //Enemy is not dead
		
		StartCoroutine (AutoTick ());//Enemy is ready to deal damage to player
		
	}
	
	
	//Update happens every frame
	public void Update()
	{
		//If current health is 0 Enemy is dying
		if (monsterHealth.currentHealth <= 0) 
		{
			
			if (!MonsterHealth.enemyDead)
			{
				EnemyDying();
				WizardFreeze.frozen = false;
			}
			else
			{
				return;
			}
		}
		
		if (WizardFreeze.frozen)
		{
			button.image.overrideSprite = frozen;
		}
		else button.image.overrideSprite = null;
		
	}
	
	
	public void AutoPetDamagePersec()
	{
		if (!WizardFreeze.frozen){
		if (SpawnPet.petSpawned)
		{
			if (!PetHealth.petDead)
			{
				if (monsterHealth.currentHealth < monsterHealth.maxHealth) 
				{	
					if (!PetEvasion.EvadeChance ()) 
					{
						monsterDamage.EnemyDamage();
						PetHealth.currentHealth -= MonsterDamage.monsterDamage; //Amount of damage dealt to Player
						GameObject FloatingDamage = Instantiate (Resources.Load ("Prefabs/MonsterPetDamageText")) as GameObject;
						FloatingDamage.GetComponent<FloatingMonsterDamage> ().DisplayDamage (("-" + MonsterDamage.monsterDamage).ToString ());
						FloatingDamage.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
						
					
					}
					else
					{
						GameObject FloatingDamage = Instantiate (Resources.Load ("Prefabs/MonsterPetDamageText")) as GameObject;
						FloatingDamage.GetComponent<FloatingMonsterDamage> ().DisplayDamage (("Miss").ToString ());
						FloatingDamage.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
					}
					WizardPetHealSkill.PetHeal();
				}
			}
		}
		}
	}
	
	public void AutoDamagePerSec ()
	{
		if (!WizardFreeze.frozen){
		
		if (monsterHealth.currentHealth < monsterHealth.maxHealth) 
		{ //When currentHealth is less than maxHealth enemy will deal damage
			
			if (!Evasion.EvadeChance ()) 
			{
				monsterDamage.EnemyDamage();
				PlayerHealth.currentHealth -= MonsterDamage.monsterDamage; //Amount of damage dealt to Player
				GameObject FloatingDamage = Instantiate (Resources.Load ("Prefabs/MonsterDamageText")) as GameObject;
				FloatingDamage.GetComponent<FloatingMonsterDamage> ().DisplayDamage (("-" + MonsterDamage.monsterDamage).ToString ());
				FloatingDamage.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
				Materials.materials.lifeExp += MonsterDamage.monsterDamage;
		
				if (WarriorSpikeShield.spikeShieldOn)
				{
					monsterHealth.currentHealth -= MonsterDamage.monsterDamage /2;
					GameObject FloatingReflect = Instantiate (Resources.Load ("Prefabs/ReflectText")) as GameObject;
					FloatingReflect.GetComponent<FloatingReflect> ().DisplayDamage (("Reflect -" + MonsterDamage.monsterDamage/2).ToString ());
					FloatingReflect.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				}
			}
			//Monster Miss
			else
			{
				GameObject FloatingDamage = Instantiate (Resources.Load ("Prefabs/MonsterDamageText")) as GameObject;
				FloatingDamage.GetComponent<FloatingMonsterDamage> ().DisplayDamage (("Miss").ToString ());
				FloatingDamage.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
			
					Materials.materials.evasionExp += MonsterDamage.monsterDamage;
				}

			//Wizard Skill
			WizardHealSkill.Heal ();
			//Warrior Skill
			RegenSkill.Regeneration ();WarriorHealthBoost.HealthBoost ();WarriorStoneShield.StoneShield();WarriorSpikeShield.SpikeShield();
			//Assassin Skill
			EvasionBoost.Evasion ();
		}
		}
		
	}
	
	
	
	
	
	
	
	
	public void EnemyDying () //Enemy is dying
	{
		
		MonsterHealth.enemyDead = true;
		{
			StopCoroutine(AutoTick());
			animation.Play ("EnemyDeathAnim"); //Enemy is dead and will play animation to show so
			EnemyDrops();
		}
	}
	
	void Respawn ()
	{
		enemyDeathCount++;
		Destroy (gameObject);
		GameObject Clone = Instantiate (Resources.Load ("Prefabs/Enemies/Monster17")) as GameObject;
		Clone.transform.SetParent ((GameObject.Find ("Battle").transform), false);
		
	}
	
	IEnumerator AutoTick()//Deal damage to player every second
	{
		while (true)	
		{
		
			attackSpeed = Random.Range (1,2);
			yield return new WaitForSeconds (attackSpeed);
			if (!MonsterHealth.enemyDead)
			{
				if (!PlayerHealth.playerIsDead)
				{
					if (Damage.damageDealt >= PetDealDamage.damageDealt)
					{
						if (PetDealDamage.petTaunting)
						{
							AutoPetDamagePersec();
						}
						else AutoDamagePerSec ();
						
					}
					else AutoPetDamagePersec();
				}
			}
		}
		
	}
	
	
	private void EnemyDrops()
	{
		
		//Exp reward for killing enemy
		Materials.materials.battleExp += monsterHealth.maxHealth / 2;
		//Gold reward for killing enemy
		Materials.materials.gold += coinDrop = Random.Range ((int)monsterHealth.maxHealth / 20,(int)monsterHealth.maxHealth / 10);
		GameObject FloatingGold = Instantiate (Resources.Load ("Prefabs/MonsterGoldDrop")) as GameObject;
		FloatingGold.GetComponent<FloatingGold> ().DisplayDamage (("+"+coinDrop+(" Gold")).ToString ());
		FloatingGold.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
	}
	
	
	
	
	
	
}





