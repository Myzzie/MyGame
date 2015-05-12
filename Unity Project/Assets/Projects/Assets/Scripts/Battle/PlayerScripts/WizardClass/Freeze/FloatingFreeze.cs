using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingFreeze : MonoBehaviour {
	
	public Text myGUItext;
	private float guiTime = 10f;
	private float timer = 10f;
	
	
	
	
	
	void start ()
	{
		
		
	}
	
	void Update ()
	{
		
		timer -= Time.deltaTime;
		myGUItext.text = "Freeze" + " / " + "(" + timer.ToString("f0")+ ")";



		// destory game object
		if (!WizardFreeze.frozen)
		{
			Destroy(gameObject);
		}
	}
	
	
	public void DisplayDamage()
	{
		
	

		// destory after time is up
		StartCoroutine(GuiDisplayTimer());
		
	}
	
	IEnumerator GuiDisplayTimer()
	{
		WizardFreeze.frozen = true;
		// Waits an amount of time
		yield return new WaitForSeconds(guiTime);

		WizardFreeze.frozen = false;
		


	}
	
	
	
	
}
