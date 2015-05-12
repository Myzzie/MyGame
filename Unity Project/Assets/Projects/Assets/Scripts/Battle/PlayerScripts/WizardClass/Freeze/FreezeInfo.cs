using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FreezeInfo : MonoBehaviour {


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
		skillName.text = "Freeze";
		skillDescription.text = "Freezes the enemy, making it unable \n to attack for 10 seconds";
		skillChance.text = "Chance to proc: " + WizardFreeze.freezeChance.ToString("f1") + "%";

		if (WizardFreeze.curSkillNum < WizardFreeze.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Freezes the enemy, making it unable \n to attack for 10 seconds";
			nextSkillChance.text = "Chance to proc: " + (WizardFreeze.freezeChance + WizardFreeze.nextLevel).ToString("f1") + "%";
			cost.text = "Cost: " + WizardFreeze.cost.ToString() + " gold";
			if (WizardFreeze.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.10";
			}
			if (WizardFreeze.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.12";
			}
			if (WizardFreeze.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.14";
			}
			if (WizardFreeze.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.16";
			}
			if (WizardFreeze.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.18";
			}
			if (WizardFreeze.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.20";
			}
			if (WizardFreeze.curSkillNum == 6)
			{
				skillRequirement.text = "Requires Lv.22";
			}
			if (WizardFreeze.curSkillNum == 7)
			{
				skillRequirement.text = "Requires Lv.24";
			}
			if (WizardFreeze.curSkillNum == 8)
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
			cost.text = "Cost: " + WizardFreeze.cost.ToString() + " gold";
		}
		if (WizardFreeze.curSkillNum == WizardFreeze.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (WizardFreeze.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Freezes the enemy, making it unable \n to attack for 10 seconds";
			nextSkillChance.text = "Chance to proc: " + (WizardFreeze.firstLevelBonus).ToString("f1") + "%";
		} 



	}
}
