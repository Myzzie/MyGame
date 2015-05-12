using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingSpikeShield : MonoBehaviour {


	public Text myGUItext;
	private float guiTime = 15f;
	private float timer = 15f;
	
	
	
	
	
	void start ()
	{
		
	}
	
	void Update ()
	{
		
		timer -= Time.deltaTime;
		myGUItext.text = "+Spike Shield" + " / " + "(" + timer.ToString("f0")+ ")";

	}
	
	
	public void DisplayDamage()
	{
	


		// destory after time is up
		StartCoroutine(GuiDisplayTimer());
		
	}
	
	IEnumerator GuiDisplayTimer()
	{
		WarriorSpikeShield.spikeShieldOn = true;
		// Waits an amount of time
		yield return new WaitForSeconds(guiTime);
		WarriorSpikeShield.spikeShieldOn = false;
		// destory game object
		Destroy(gameObject);
	
	}


	
	
}
