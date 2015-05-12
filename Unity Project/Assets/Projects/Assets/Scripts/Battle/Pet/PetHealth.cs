using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PetHealth : MonoBehaviour {
	
	
	
	public UnityEngine.UI.Text healthAmount;
	public Image healthBar;
	public static float maxHealth;
	public static float currentHealth;
	public static bool takeDamage;
	public static bool petDead;
	public static bool takePetDamage;
	public static bool regenerating;

	
	

	
	// Use this for initialization
	void Start () 
	{
		currentHealth = maxHealth;//currentHealth equals maxHealth
		
		petDead = false;
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (currentHealth >= maxHealth)
		{
			currentHealth = maxHealth;
			regenerating = false;
		}

		
		if (MonsterHealth.takeDamage)
		{
			regenerating = false;
			
		}

		if (currentHealth <= 0) //If current health is 0 then it stays 0
		{
			currentHealth = 0;
		}
		
		if (currentHealth < maxHealth) 
		{
			takeDamage = true;
			
			
		}
		if (currentHealth == maxHealth) 
		{
			takeDamage = false;
		}


			//If current health is 0 Enemy is dying
			if (currentHealth <= 0) 
			{
				
				if (!petDead)
				{
					PetDying();
				}
				else
				{
					return;
				}
			}
			
		if (regenerating)
		{
			currentHealth += maxHealth/10 * Time.deltaTime;
		}
			

		
		//Enemy healthbar
		healthBar.fillAmount = (float)currentHealth / (float)maxHealth;
		//Enemy health in text
		healthAmount.text = (currentHealth.ToString("f0") + "/" + maxHealth);
	}


	
	




	public static IEnumerator Regen()
	{
		yield return new WaitForSeconds(10);
		if (!MonsterHealth.takeDamage)
		{
			regenerating = true;
			
		}
		
	}

	public void PetDying () //Enemy is dying
	{
		
		petDead = true;
		{

			takePetDamage = false; 
			takeDamage = false;
			PetDealDamage.damageDealt = 0;
			Invoke ("Respawn", .5f ); //Spawn new enemy
			Destroy (gameObject, .6f);
		}
	}
	
	void Respawn ()
	{
		GameObject Clone = Instantiate (Resources.Load ("Prefabs/Pets/PetSpawn")) as GameObject;
		Clone.GetComponent<PetSpawn> ().DisplayDamage ();
		Clone.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
	}


	
}
