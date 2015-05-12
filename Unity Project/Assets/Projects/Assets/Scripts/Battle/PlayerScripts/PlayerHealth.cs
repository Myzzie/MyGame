using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {


	public UnityEngine.UI.Text healthAmount;

	public EnemySpawner enemySpawner;
	public GameObject playerHealth;
	public Image healthBar;
	public static float maxHealth;
	public static float baseMaxHealth;
	public static float currentHealth;
	public BattleExperience battleExperience;
	private float baseHealth;
	public static float regeneration;
	public static float regenerationBoost;
	public static bool resetMonster;
	public static bool regenerating;
	public static bool playerIsDead;

	


	void Start ()
	{
		maxHealth = (baseMaxHealth + Helmet.helmetBonus) * LifeExperience.lifeLevelHealth;
		currentHealth = maxHealth;
	}

	public void Update()
	{

		maxHealth = (baseMaxHealth + Helmet.helmetBonus) * LifeExperience.lifeLevelHealth;

		if (currentHealth >= maxHealth)
		{
			regenerating = false;
			currentHealth = maxHealth;
		}

		if (MonsterHealth.takeDamage)
		{
			regenerating = false;
			
		}
	

		if (currentHealth != maxHealth) 
		{
			currentHealth += regeneration * Time.deltaTime;
		}
	
		
		if (currentHealth <= 0)
		{
			currentHealth = 0;
			Materials.materials.battleExp -= Materials.materials.battleExp/20;
			healthBar.fillAmount += maxHealth;
			resetMonster = true;
			enemySpawner.count --;
			enemySpawner.Spawn ();
		}
		if (currentHealth <= 0) 
		{
			
			if (!playerIsDead)
			{
				PlayerDying();
			}
			else
			{
				return;
			}
		}
	



		healthBar.fillAmount = (float)currentHealth / (float)maxHealth;
		regeneration = maxHealth * (regenerationBoost + Armour.armourBonus);
		healthAmount.text = (currentHealth.ToString("f0") + "/" + maxHealth.ToString("f0"));
	
		if (currentHealth <= maxHealth*0.3f) {
			playerHealth.GetComponent<Image> ().color = Color.red;
		} else 
		{
			playerHealth.GetComponent<Image> ().color = Color.green;
		}
		if (regenerating)
		{
			currentHealth += maxHealth/10 * Time.deltaTime;
		}



	}



	




	public static IEnumerator Regen()
	{

		yield return new WaitForSeconds(10);
		if (!MonsterHealth.takeDamage)
		{
			regenerating = true;

		}
	}

	 void Respawn()
	{

		currentHealth = maxHealth;
		GameObject FloatingDamage = Instantiate (Resources.Load ("Prefabs/PlayerDeath")) as GameObject;
		FloatingDamage.GetComponent<FloatingPlayerDeath> ().DisplayDamage ();
		FloatingDamage.transform.SetParent ((GameObject.Find ("CanvasBattle").transform), false);
	}

	public void PlayerDying () //Enemy is dying
	{
		
			playerIsDead = true;
		{
			Respawn (); //Spawn new enemy
		}
	}

		
}




	


	

	
	
	


	

