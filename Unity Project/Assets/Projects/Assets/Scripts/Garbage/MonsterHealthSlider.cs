using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MonsterHealthSlider : MonoBehaviour {

	public Slider healthBar;
	public int healthAmount = 10;
	private int currentHealth;

	void Start()
	{
		currentHealth = healthAmount;
	}


	public void Attack ()
	{
		currentHealth--;
		healthBar.value = (float)currentHealth / (float)healthAmount;
	}

}





