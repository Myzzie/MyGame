using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingDamageBoost : MonoBehaviour {


	public Text myGUItext;
	private float guiTime = 20f;
	private float timer = 20f;
	
	
	
	
	
	void start ()
	{
	
	}
	
	void Update ()
	{

		timer -= Time.deltaTime;
		myGUItext.text = "+Damage Boost" + " / " + "(" + timer.ToString("f0")+ ")";


	}
	
	
	public void DisplayDamage()
	{
	


		// destory after time is up
		StartCoroutine(GuiDisplayTimer());
		
	}
	
	IEnumerator GuiDisplayTimer()
	{
		WarriorDamageBoost.damageBoostOn = true;
		TwoHandSword.twoHandSwordMinDamage = TwoHandSword.twoHandSwordMinDamage*1.5f;
		TwoHandSword.twoHandSwordMaxDamage = TwoHandSword.twoHandSwordMaxDamage*1.5f;
		// Waits an amount of time
		yield return new WaitForSeconds(guiTime);
		TwoHandSword.twoHandSwordMinDamage = TwoHandSword.twoHandSwordMinDamage/1.5f;
		TwoHandSword.twoHandSwordMaxDamage = TwoHandSword.twoHandSwordMaxDamage/1.5f;
		WarriorDamageBoost.damageBoostOn = false;
		// destory game object
		Destroy(gameObject);
	
	}


	
	
}
