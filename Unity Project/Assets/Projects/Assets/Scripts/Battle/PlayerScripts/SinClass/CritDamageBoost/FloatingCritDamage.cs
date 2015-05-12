using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class FloatingCritDamage : MonoBehaviour {
	
	public Text myGUItext;
	private float guiTime = 20f;
	private float timer = 20f;
	
	
	
	
	
	
	void start ()
	{
		
	}
	
	void Update ()
	{
		timer -= Time.deltaTime;
		myGUItext.text = "+Crit Damage" + " / " + "(" + timer.ToString("f0")+ ")";
		
	
	}
	
	
	public void DisplayDamage()
	{
		
	
			
			

		
		
		// destory after time is up
		StartCoroutine(GuiDisplayTimer());
		
	}
	
	IEnumerator GuiDisplayTimer()
	{
		CritDamageBoost.critDamageOn = true;
		CriticalDamage.critDamage = CriticalDamage.critDamage + 1f;
		// Waits an amount of time
		yield return new WaitForSeconds(guiTime);
		CriticalDamage.critDamage = CriticalDamage.critDamage - 1f;
		CritDamageBoost.critDamageOn = false;
		// destory game object
		Destroy(gameObject);
		
	}
	
	
	
	
}
