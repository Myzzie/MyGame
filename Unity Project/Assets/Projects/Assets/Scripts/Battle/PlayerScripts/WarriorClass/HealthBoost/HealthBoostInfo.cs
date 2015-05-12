using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBoostInfo : MonoBehaviour {


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
		skillName.text = "Health Boost";
		skillDescription.text = "Increases your max health \n by 50%";
		skillChance.text = "Chance to proc: " + WarriorHealthBoost.healthBoostChance.ToString("f1") + "%";

		if (WarriorHealthBoost.curSkillNum < WarriorHealthBoost.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Increases your damage output \n by 50%";
			nextSkillChance.text = "Chance to proc: " + (WarriorHealthBoost.healthBoostChance + WarriorHealthBoost.nextLevel).ToString("f1") + "%";
			cost.text = "Cost: " + WarriorHealthBoost.cost.ToString() + " gold";
			if (WarriorHealthBoost.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.15";
			}
			if (WarriorHealthBoost.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.18";
			}
			if (WarriorHealthBoost.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.21";
			}
			if (WarriorHealthBoost.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.24";
			}
			if (WarriorHealthBoost.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.27";
			}
			if (WarriorHealthBoost.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.30";
			}
			if (WarriorHealthBoost.curSkillNum == 6)
			{
				skillRequirement.text = "Requires Lv.33";
			}
			if (WarriorHealthBoost.curSkillNum == 7)
			{
				skillRequirement.text = "Requires Lv.36";
			}
			if (WarriorHealthBoost.curSkillNum == 8)
			{
				skillRequirement.text = "Requires Lv.39";
			}
			
		}
		else
		{
			nextLevel.text = "Max Level";
			nextSkillChance.text = "";
			nextSkillDescription.text = "Max Level doubles your chance to proc the skill";
			skillRequirement.text = "Requires Lv.42";
			cost.text = "Cost: " + WarriorHealthBoost.cost.ToString() + " gold";
		}
		if (WarriorHealthBoost.curSkillNum == WarriorHealthBoost.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (WarriorHealthBoost.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Increases your max health \n by 50%";
			nextSkillChance.text = "Chance to proc: " + (WarriorHealthBoost.firstLevelBonus).ToString("f1") + "%";
		} 



	}
}
