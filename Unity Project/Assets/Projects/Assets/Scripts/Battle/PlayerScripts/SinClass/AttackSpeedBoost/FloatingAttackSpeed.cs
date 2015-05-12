using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class FloatingAttackSpeed : MonoBehaviour {
	
	public Text myGUItext;
	private float guiTime = 7f;
	private float timer = 7f;
	
	
	
	
	
	
	void start ()
	{
		
	}
	
	void Update ()
	{
		
		timer -= Time.deltaTime;
		myGUItext.text = "+Attack Speed" + " / " + "(" + timer.ToString("f0")+ ")";
		
		
	
	}
	
	
	public void DisplayDamage()
	{
	
		
		
		// destory after time is up
		StartCoroutine(GuiDisplayTimer());
		
	}
	
	IEnumerator GuiDisplayTimer()
	{
		AttackSpeedBoost.speedOn = true;
		Damage.basePlayerAttackSpeed = Damage.basePlayerAttackSpeed /2;
		// Waits an amount of time
		yield return new WaitForSeconds(guiTime);
		Damage.basePlayerAttackSpeed = Damage.basePlayerAttackSpeed * 2;
		AttackSpeedBoost.speedOn = false;
		// destory game object
		Destroy(gameObject);
		
	}
	
	
	
	
}
