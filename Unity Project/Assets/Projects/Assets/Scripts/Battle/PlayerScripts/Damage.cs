using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Damage : MonoBehaviour {


	public MonsterHealth monsterHealth;
	public static float playerDamage;
	public static float minDamage;
	public static float maxDamage;
	public static float baseMinDamage;
	public static float baseMaxDamage;
	public static int expperdeath = 1;
	public static float playerAttackSpeed;
	public static float basePlayerAttackSpeed;
	public static float playerAttackSpeedEnhance = 1f;
	public static float playerDamageEnhance = 1f;
	public Transform button;
	public bool Delay;
	public static float damageDealt;
	public static float DPS;



	void Start ()
	{
	

	}

	void Update ()
	{


		if (GameInformation.isAssassinClass){
			playerAttackSpeed = basePlayerAttackSpeed / (playerAttackSpeedEnhance + Dagger1.dagger1AttackSpeed + Dagger2.dagger2AttackSpeed + Ring.ringAttackSpeed);

			minDamage = ((baseMinDamage + Dagger1.dagger1MinDamage + Dagger2.dagger2MinDamage) * playerDamageEnhance);
			maxDamage = ((baseMaxDamage + Dagger1.dagger1MaxDamage + Dagger2.dagger2MaxDamage) * playerDamageEnhance);
		}
		if (GameInformation.isWizardClass){
			playerAttackSpeed = basePlayerAttackSpeed / (Staff.staffAttackSpeed + Ring.ringAttackSpeed + playerAttackSpeedEnhance);
			
			minDamage = (baseMinDamage + Staff.staffMinDamage) * playerDamageEnhance;
			maxDamage = (baseMaxDamage + Staff.staffMaxDamage) * playerDamageEnhance;
		}
		if (GameInformation.isWarriorClass){
			playerAttackSpeed = basePlayerAttackSpeed / (TwoHandSword.twoHandSwordAttackSpeed + Ring.ringAttackSpeed + playerAttackSpeedEnhance);
			
			minDamage = (baseMinDamage + TwoHandSword.twoHandSwordMinDamage) * playerDamageEnhance;
			maxDamage = (baseMaxDamage + TwoHandSword.twoHandSwordMaxDamage) * playerDamageEnhance;
		}


		Evasion.evadeChance = (Evasion.baseEvadeChance + Boots.bootsBonus) * Evasion.evadeEnhance;
		CriticalDamage.critChance = (CriticalDamage.baseCritChance + Gloves.glovesBonus) * CriticalDamage.critEnhance;
	
		DPS = 1/playerAttackSpeed;
	}


	//Damage Formula put here!!!
	public static void PlayerAttackDamage ()
	{
		playerDamage = (int)Random.Range (minDamage, (maxDamage + 1));

		HardHitSkill.HitChance();
		if (GameInformation.isWarriorClass && HardHitSkill.hitChance) 
		{
			playerDamage = playerDamage + HardHitSkill.GetHardHit ();
			Debug.Log ("HardHit");
		}
		CriticalDamage.CritChance ();
		if (CriticalDamage.critChance1) 
		{
			playerDamage = (float)playerDamage * (float)CriticalDamage.GetCritHit ();
			Debug.Log ("Crit");
			Materials.materials.critExp += (int)Damage.playerDamage;
		}
	}

	//This happens when I click on the enemy
	public void Attack ()
		
	{
		if (!Delay) 
		{
			if (!PlayerHealth.playerIsDead)
			{
				if (!MonsterHealth.enemyDead)
				{
					PlayerDamage.holdAttack = false;
					PlayerAttackDamage ();
					monsterHealth.currentHealth -= playerDamage;
					damageDealt += playerDamage;
					GameObject FloatingDamage = Instantiate (Resources.Load ("Prefabs/PlayerClickDamageText")) as GameObject;
					FloatingDamage.GetComponent<FloatingPlayerDamage> ().DisplayDamage ((Damage.playerDamage.ToString ("f0") + " damage").ToString ());
					FloatingDamage.transform.SetParent  ((GameObject.Find ("TextDisplay").transform), false);

					//Assassin Skills
					SinLifeSteal.LifeSteal();
					CritChanceBoost.GetCritChance();
					CritDamageBoost.GetCritDamage();
					AttackSpeedBoost.AttackSpeed();
					BleedEffect.Bleeding();
					Rampage.GetRampage();
					//Warrior Skills
					WarriorDamageBoost.DamageBoost();
					//Wizard Skills
					WizardFreeze.Freeze();

					StartCoroutine (ClickDelay ());
				}
			}
		}
	}
	
	public IEnumerator ClickDelay()//This is delay to prevent clicking faster than playerAttackSpeed
	{
		Delay = true;
		button.GetComponent<Button>().interactable = false;
		yield return new WaitForSeconds(Damage.playerAttackSpeed);
		Delay = false; 
	
		button.GetComponent<Button>().interactable = true;
	}
	
	


}