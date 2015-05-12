using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class FloatingRampage : MonoBehaviour {
	
	public Text myGUItext;
	private float guiTime = 10f;
	private float timer = 10f;
	
	
	
	
	
	
	void start ()
	{
		
	}
	
	void Update ()
	{
		
		timer -= Time.deltaTime;

		myGUItext.text = "+RAMPAGE" + " / " + "(" + timer.ToString("f0")+ ")";
			


	}
	
	
	public void DisplayDamage()
	{
	
		StartCoroutine(GuiDisplayTimer());
		
	}
	
	IEnumerator GuiDisplayTimer()
	{
		Rampage.rampageOn = true;
		Evasion.baseEvadeChance = Evasion.baseEvadeChance * 1.3f;
		CriticalDamage.baseCritChance = CriticalDamage.baseCritChance * 1.5f;
		Dagger1.dagger1MinDamage = Dagger1.dagger1MinDamage*1.2f;
		Dagger1.dagger1MaxDamage = Dagger1.dagger1MaxDamage*1.2f;
		Dagger2.dagger2MinDamage = Dagger2.dagger2MinDamage*1.2f;
		Dagger2.dagger2MaxDamage = Dagger2.dagger2MaxDamage*1.2f;
		Damage.basePlayerAttackSpeed = Damage.basePlayerAttackSpeed /1.4f;
		// Waits an amount of time
		yield return new WaitForSeconds(guiTime);
		Evasion.baseEvadeChance = Evasion.baseEvadeChance /1.3f;
		CriticalDamage.baseCritChance = CriticalDamage.baseCritChance / 1.5f;
		Dagger1.dagger1MinDamage = Dagger1.dagger1MinDamage/1.2f;
		Dagger1.dagger1MaxDamage = Dagger1.dagger1MaxDamage/1.2f;
		Dagger2.dagger2MinDamage = Dagger2.dagger2MinDamage/1.2f;
		Dagger2.dagger2MaxDamage = Dagger2.dagger2MaxDamage/1.2f;
		Damage.basePlayerAttackSpeed = Damage.basePlayerAttackSpeed *1.4f;
		Rampage.rampageOn = false;
		// destory game object
		Destroy(gameObject);
		
	}
	
	
	
	
}
