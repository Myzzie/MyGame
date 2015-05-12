using UnityEngine;
using System.Collections;

public class PetStats : MonoBehaviour {
		
		
		public UnityEngine.UI.Text petNameDisplay;
		public UnityEngine.UI.Text health;
		public UnityEngine.UI.Text damage;
		public UnityEngine.UI.Text attackSpeed;
		public UnityEngine.UI.Text critChance;
		public UnityEngine.UI.Text evadeChance;
		
		
		
		
		void Update()
		{
			if (DamageItemManager.count == 1) {
			petNameDisplay.text = "Bunny";
			}
		if (DamageItemManager.count == 2) {
			petNameDisplay.text = "Rat";
		}
		if (DamageItemManager.count == 3) {
			petNameDisplay.text = "Snake";
		}
		if (DamageItemManager.count == 4) {
			petNameDisplay.text = "Wolf";
		}



			health.text = "Health: " + PetHealth.maxHealth.ToString("f0");
			damage.text = "Damage: " + (int)PetDamage.minDamage + "-" + (int)PetDamage.maxDamage;
			attackSpeed.text = "Attack Speed: " + PetDamage.APS.ToString("f2") + "/sec";
			critChance.text = "Crit Chance: " + PetCriticalDamage.petCritChance.ToString("f1") + "%";
			evadeChance.text = "Evade Chance: " + PetEvasion.petEvadeChance.ToString("f1") + "%";
	
		}
	}
