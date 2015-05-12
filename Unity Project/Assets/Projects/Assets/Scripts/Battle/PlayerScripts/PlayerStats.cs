using UnityEngine;
using System.Collections;


public class PlayerStats : MonoBehaviour {


	public UnityEngine.UI.Text classDisplay;
	public UnityEngine.UI.Text health;
	public UnityEngine.UI.Text regen;
	public UnityEngine.UI.Text damage;
	public UnityEngine.UI.Text attackSpeed;
	public UnityEngine.UI.Text critChance;
	public UnityEngine.UI.Text evadeChance;
	public UnityEngine.UI.Text combatLevel;







	void Update()
	{
		if (GameInformation.isWarriorClass) {
			classDisplay.text = "Warrior";
		}
		if (GameInformation.isWizardClass) {
			classDisplay.text = "Wizard";
		}
		if (GameInformation.isAssassinClass) {
			classDisplay.text = "Assassin";
		}

		health.text = "Health: " + PlayerHealth.maxHealth.ToString("f0");
		regen.text = "Regeneration: " + System.Math.Round (PlayerHealth.regeneration, 2)+ " health" + "/sec";
		damage.text = "Damage: " + (int)Damage.minDamage + "-" + (int)Damage.maxDamage;
		attackSpeed.text = "Attack Speed: " + Damage.DPS.ToString("f2") + "/sec";
		critChance.text = "Crit Chance: " + CriticalDamage.critChance.ToString("f1") + "%";
		evadeChance.text = "Evade Chance: " + Evasion.evadeChance.ToString("f1") + "%";
		combatLevel.text = "Combat Level: " + Materials.materials.combatLevel.ToString("f0");

	}
}
