using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class FloatingCritChance : MonoBehaviour {
	
	public Text myGUItext;
	private float guiTime = 20f;
	private float timer = 20f;
	
	
	
	
	
	
	void start ()
	{
		
	}
	
	void Update ()
	{
		
		
		timer -= Time.deltaTime;
		myGUItext.text = "+Crit Chance" + " / " + "(" + timer.ToString("f0")+ ")";
		
	
	}
	
	
	public void DisplayDamage()
	{
		
	
		
		
		// destory after time is up
		StartCoroutine(GuiDisplayTimer());
		
	}
	
	IEnumerator GuiDisplayTimer()
	{
		CritChanceBoost.critChanceOn = true;
		CriticalDamage.baseCritChance = CriticalDamage.baseCritChance * 2;
		// Waits an amount of time
		yield return new WaitForSeconds(guiTime);
		CriticalDamage.baseCritChance = CriticalDamage.baseCritChance / 2;
		CritChanceBoost.critChanceOn = false;
		// destory game object
		Destroy(gameObject);
		
	}
	
	
	
	
}
