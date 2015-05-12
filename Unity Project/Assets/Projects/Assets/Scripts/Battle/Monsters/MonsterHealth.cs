using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MonsterHealth : MonoBehaviour {



	public UnityEngine.UI.Text healthAmount;
	public Image healthBar;
	public float maxHealth;
	public float currentHealth;
	public static bool takeDamage;
	public static bool enemyDead;



	void Awake ()
	{

	}

	// Use this for initialization
	void Start () 
	{
		currentHealth = maxHealth;//currentHealth equals maxHealth

		enemyDead = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
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

		if (PlayerHealth.resetMonster == true)
			currentHealth = maxHealth;
			PlayerHealth.resetMonster = false;


		//Enemy healthbar
		healthBar.fillAmount = (float)currentHealth / (float)maxHealth;
		//Enemy health in text
		healthAmount.text = (currentHealth.ToString("f0") + "/" + maxHealth);


	

	}

}
