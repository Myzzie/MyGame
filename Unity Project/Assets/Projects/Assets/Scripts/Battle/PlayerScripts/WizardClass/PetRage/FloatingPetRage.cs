using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingPetRage : MonoBehaviour {
	
	public Text myGUItext;
	private float guiTime = 15f;
	private float timer = 15f;
	
	
	
	
	
	void start ()
	{
		
		
	}
	
	void Update ()
	{
		
		
		timer -= Time.deltaTime;
		
		myGUItext.text = "RAGE" + " / " + "(" + timer.ToString("f0")+ ")";

	

		if (SpawnPet.petSummoned)
		{
			WizardPetRageSkill.rageOn = true;
			Destroy (gameObject);
		}
		if (PetHealth.petDead)
		{
			WizardPetRageSkill.rageOn = true;
			Destroy (gameObject);
		}

	}
	
	
	public void DisplayDamage()
	{
	
		
		// destory after time is up
		StartCoroutine(GuiDisplayTimer());
		
	}
	
	IEnumerator GuiDisplayTimer()
	{
		WizardPetRageSkill.rageOn = true;
		PetDamage.basePetAttackSpeed = PetDamage.basePetAttackSpeed /3f;
		yield return new WaitForSeconds(guiTime);

		PetDamage.basePetAttackSpeed = PetDamage.basePetAttackSpeed *3f;
		WizardPetRageSkill.rageOn = false;
		// destory game object
		Destroy(gameObject);
	}
	
	
	
	
}
