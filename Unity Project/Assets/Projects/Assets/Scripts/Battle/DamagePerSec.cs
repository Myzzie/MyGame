using UnityEngine;
using System.Collections;

public class DamagePerSec : MonoBehaviour {
	

	public UnityEngine.UI.Text dpsDisplay;




	
	
	void Start (){


	
	
	}
	
	void Update(){

	
		dpsDisplay.text = "Damage: " + PetDamage.minDamage + " / " + PetDamage.maxDamage + "\nAttack Speed: " + PetDamage.petAttackSpeed;

	
	}
	



}


