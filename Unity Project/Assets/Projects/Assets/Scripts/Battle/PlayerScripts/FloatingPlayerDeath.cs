using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingPlayerDeath : MonoBehaviour {

	public Text myGUItext;
	private float guiTime = 2f;
	
	
	
	
	
	
	
	void Start ()
	{
		animation.Play ("FloatingPlayerDamageAnim");
		
	}
	
	void Update ()
	{
		

		
		
		Color myColor = myGUItext.color;
		myColor.a -= Time.deltaTime / 2;
		myGUItext.color = myColor;
		
		
	}
	
	
	
	public void DisplayDamage()
	{
	
		myGUItext.text = "You died!";
		
		// destory after time is up
		StartCoroutine(GuiDisplayTimer());
	}
	
	IEnumerator GuiDisplayTimer()
	{
		// Waits an amount of time
		yield return new WaitForSeconds(guiTime);

		PlayerHealth.currentHealth += PlayerHealth.maxHealth;

		PlayerHealth.playerIsDead = false;
		// destory game object
		Destroy(gameObject);
	}
	
	

}
