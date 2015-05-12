using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class FloatingEvasion : MonoBehaviour {
	
	public Text myGUItext;
	private float guiTime = 30f;
	private float timer = 30f;
	
	
	
	
	
	
	void start ()
	{
		
	}
	
	void Update ()
	{
		
		timer -= Time.deltaTime;

		myGUItext.text = "+Evasion" + " / " + "(" + timer.ToString("f0")+ ")";
			


	}
	
	
	public void DisplayDamage()
	{
	
		StartCoroutine(GuiDisplayTimer());
		
	}
	
	IEnumerator GuiDisplayTimer()
	{
		EvasionBoost.evasionOn = true;
		Evasion.baseEvadeChance = Evasion.baseEvadeChance * 2f;
		// Waits an amount of time
		yield return new WaitForSeconds(guiTime);
		Evasion.baseEvadeChance = Evasion.baseEvadeChance /2;
		EvasionBoost.evasionOn = false;
		// destory game object
		Destroy(gameObject);
		
	}
	
	
	
	
}
