using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DamageBoostInfo : MonoBehaviour {


	public UnityEngine.UI.Text skillName;
	public UnityEngine.UI.Text skillDescription;
	public UnityEngine.UI.Text skillChance;
	public UnityEngine.UI.Text nextLevel;
	public UnityEngine.UI.Text nextSkillDescription;
	public UnityEngine.UI.Text nextSkillChance;
	public UnityEngine.UI.Text skillRequirement;
	public UnityEngine.UI.Text cost;
	

	
	// Update is called once per frame
	void Update () 
	{
		skillName.text = "Damage Boost";
		skillDescription.text = "Enhance your weapon damage \n by 50% for 20 seconds";
		skillChance.text = "Chance to proc: " + WarriorDamageBoost.damageBoostChance.ToString("f1") + "%";

		if (WarriorDamageBoost.curSkillNum < WarriorDamageBoost.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Enhance your weapon damage \n by 50% for 20 seconds";
			nextSkillChance.text = "Chance to proc: " + (WarriorDamageBoost.damageBoostChance + WarriorDamageBoost.nextLevel).ToString("f1") + "%";
			cost.text = "Cost: " + WarriorDamageBoost.cost.ToString() + " gold";
			if (WarriorDamageBoost.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.10";
			}
			if (WarriorDamageBoost.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.12";
			}
			if (WarriorDamageBoost.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.14";
			}
			if (WarriorDamageBoost.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.16";
			}
			if (WarriorDamageBoost.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.18";
			}
			if (WarriorDamageBoost.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.20";
			}
			if (WarriorDamageBoost.curSkillNum == 6)
			{
				skillRequirement.text = "Requires Lv.22";
			}
			if (WarriorDamageBoost.curSkillNum == 7)
			{
				skillRequirement.text = "Requires Lv.24";
			}
			if (WarriorDamageBoost.curSkillNum == 8)
			{
				skillRequirement.text = "Requires Lv.26";
			}
			
		}
		else
		{
			nextLevel.text = "Max Level";
			nextSkillChance.text = "";
			nextSkillDescription.text = "Max Level doubles your chance to proc the skill";
			skillRequirement.text = "Requires Lv.28";
			cost.text = "Cost: " + WarriorDamageBoost.cost.ToString() + " gold";
		}
		if (WarriorDamageBoost.curSkillNum == WarriorDamageBoost.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (WarriorDamageBoost.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Enhance your weapon damage \n by 50% for 20 seconds";
			nextSkillChance.text = "Chance to proc: " + (WarriorDamageBoost.firstLevelBonus).ToString("f1") + "%";
		} 



	}
}
