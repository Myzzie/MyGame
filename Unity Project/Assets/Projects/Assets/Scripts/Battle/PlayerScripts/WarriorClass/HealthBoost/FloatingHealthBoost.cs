using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingHealthBoost : MonoBehaviour {


	public Text myGUItext;
	private float guiTime = 30f;
	private float timer = 30f;
	
	
	
	
	
	void start ()
	{
		
	}
	
	void Update ()
	{
		
		timer -= Time.deltaTime;
		myGUItext.text = "+Max Health" + " / " + "(" + timer.ToString("f0")+ ")";


	}
	
	
	public void DisplayDamage()
	{
	


		// destory after time is up
		StartCoroutine(GuiDisplayTimer());
		
	}
	
	IEnumerator GuiDisplayTimer()
	{
		WarriorHealthBoost.healthBoostOn = true;
		PlayerHealth.baseMaxHealth = PlayerHealth.baseMaxHealth*1.5f;
		Helmet.helmetBonus = Helmet.helmetBonus*1.5f;
		// Waits an amount of time
		yield return new WaitForSeconds(guiTime);
		PlayerHealth.baseMaxHealth = PlayerHealth.baseMaxHealth/1.5f;
		Helmet.helmetBonus = Helmet.helmetBonus/1.5f;
		WarriorHealthBoost.healthBoostOn = false;
		// destory game object
		Destroy(gameObject);
	
	}


	
	
}
