using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FloatingPetTaunt : MonoBehaviour {
	
	public Text myGUItext;
	private float guiTime = 20f;
	private float timer = 20f;
	
	
	
	
	
	void start ()
	{
		
		
	}
	
	void Update ()
	{
		
		
		timer -= Time.deltaTime;
		
		myGUItext.text = "TAUNT" + " / " + "(" + timer.ToString("f0")+ ")";

	


		if (SpawnPet.petSummoned)
		{
			PetDealDamage.petTaunting = false;
			Destroy (gameObject);
		}
		if (PetHealth.petDead)
		{
			PetDealDamage.petTaunting = false;
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
		PetDealDamage.petTaunting = true;
		yield return new WaitForSeconds(guiTime);
		PetDealDamage.petTaunting = false;
		// destory game object
		Destroy(gameObject);
	}
	
	
	
	
}
