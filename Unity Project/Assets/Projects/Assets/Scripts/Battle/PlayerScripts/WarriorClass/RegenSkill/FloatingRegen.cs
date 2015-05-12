using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingRegen : MonoBehaviour {


	public Text myGUItext;
	private float guiTime = 10f;
	private float timer = 10f;
	
	
	
	
	
	void start ()
	{
		
	}
	
	void Update ()
	{
		
		timer -= Time.deltaTime;
		myGUItext.text = "+Regeneration" + " / " + "(" + timer.ToString("f0")+ ")";

		

	}
	
	
	public void DisplayDamage()
	{
		
	


		// destory after time is up
		StartCoroutine(GuiDisplayTimer());
		
	}
	
	IEnumerator GuiDisplayTimer()
	{
		RegenSkill.regenOn = true;
		PlayerHealth.regenerationBoost += 0.05f;
		// Waits an amount of time
		yield return new WaitForSeconds(guiTime);
		PlayerHealth.regenerationBoost -= 0.05f;
		RegenSkill.regenOn = false;
		// destory game object
		Destroy(gameObject);
	
	}


	
	
}
