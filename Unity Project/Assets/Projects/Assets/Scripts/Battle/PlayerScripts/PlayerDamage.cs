using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour 
{
	public MonsterHealth monsterHealth;
	

	public static bool holdAttack;
	private int something;
	
	
	void Start()
	{

		StartCoroutine (AutoTick ());


	}


	
	
	public void TakingDamage()
	{
		if (!PlayerHealth.playerIsDead)
		{
			if (PlayerHealth.currentHealth > PlayerHealth.maxHealth*0.3f)
				{
					if (!holdAttack)
					{
					Damage.PlayerAttackDamage ();
					monsterHealth.currentHealth -= Damage.playerDamage;
					Damage.damageDealt += Damage.playerDamage;
					GameObject FloatingPlayerDamage = Instantiate (Resources.Load ("Prefabs/PlayerDamageText")) as GameObject;
					FloatingPlayerDamage.GetComponent<FloatingPlayerDamage> ().DisplayDamage ((Damage.playerDamage.ToString ("f0") + " damage").ToString ());
					FloatingPlayerDamage.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
					
					
					//Assassin Skills
					SinLifeSteal.LifeSteal();
					CritChanceBoost.GetCritChance();
					CritDamageBoost.GetCritDamage();
					AttackSpeedBoost.AttackSpeed();
					Rampage.GetRampage();
					BleedEffect.Bleeding();
					//Warrior Skills
					WarriorDamageBoost.DamageBoost();
					//Wizard Skills
					WizardFreeze.Freeze();
					}
				}
			
			else {

				if (monsterHealth.currentHealth < monsterHealth.maxHealth)
					{
					
					
					Damage.PlayerAttackDamage ();
					monsterHealth.currentHealth -= Damage.playerDamage;			
					Damage.damageDealt += Damage.playerDamage;
					GameObject FloatingPlayerDamage = Instantiate (Resources.Load ("Prefabs/PlayerDamageText")) as GameObject;
					FloatingPlayerDamage.GetComponent<FloatingPlayerDamage> ().DisplayDamage ((Damage.playerDamage.ToString ("f0") + " damage").ToString ());
					FloatingPlayerDamage.transform.SetParent ((GameObject.Find ("TextDisplay").transform), false);
				
					
					//Assassin Skills
					SinLifeSteal.LifeSteal();
					CritChanceBoost.GetCritChance();
					CritDamageBoost.GetCritDamage();
					Rampage.GetRampage();
					BleedEffect.Bleeding();
					//Warrior Skills
					WarriorDamageBoost.DamageBoost();
					//Wizard Skills
					WizardFreeze.Freeze();




					}
					if (monsterHealth.currentHealth >= monsterHealth.maxHealth)
					{
						if (!holdAttack)
						{
							holdAttack = true;
							StartCoroutine(PlayerHealth.Regen());
						}
					}
				}
		}
	}



	
	void Update ()
	{
		if (PlayerHealth.currentHealth >= PlayerHealth.maxHealth){
			holdAttack = false;
		}
	
	
		
	}
	
	
	
	IEnumerator AutoTick()
	{
		while (true) {
			yield return new WaitForSeconds(Damage.playerAttackSpeed);
			if (!MonsterHealth.enemyDead){
			TakingDamage ();
			}
		}
	}
}








