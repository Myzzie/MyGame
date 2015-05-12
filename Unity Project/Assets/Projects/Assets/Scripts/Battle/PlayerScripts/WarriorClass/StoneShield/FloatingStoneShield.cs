using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingStoneShield : MonoBehaviour {


	public Text myGUItext;
	private float guiTime = 15f;
	private float timer = 15f;
	
	
	
	
	
	void start ()
	{
		
	}
	
	void Update ()
	{
		
		timer -= Time.deltaTime;
		myGUItext.text = "+Stone Shield" + " / " + "(" + timer.ToString("f0")+ ")";

	
	}
	
	
	public void DisplayDamage()
	{
	


		// destory after time is up
		StartCoroutine(GuiDisplayTimer());
		
	}
	
	IEnumerator GuiDisplayTimer()
	{
		WarriorStoneShield.stoneShieldOn = true;
		// Waits an amount of time
		yield return new WaitForSeconds(guiTime);
		WarriorStoneShield.stoneShieldOn = false;
		// destory game object
		Destroy(gameObject);
	
	}


	
	
}
