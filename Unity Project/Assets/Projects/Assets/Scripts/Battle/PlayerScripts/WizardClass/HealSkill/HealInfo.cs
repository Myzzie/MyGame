using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealInfo : MonoBehaviour {


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
		skillName.text = "Heal";
		skillDescription.text = "Heals 25% of your max health";
		skillChance.text = "Chance to proc: " + WizardHealSkill.healChance.ToString("f1") + "%";

		if (WizardHealSkill.curSkillNum < WizardHealSkill.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Heals 25% of your max health";
			nextSkillChance.text = "Chance to proc: " + (WizardHealSkill.healChance + WizardHealSkill.nextLevel).ToString("f1") + "%";
			cost.text = "Cost: " + WizardHealSkill.cost.ToString() + " gold";
			if (WizardHealSkill.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.5";
			}
			if (WizardHealSkill.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.7";
			}
			if (WizardHealSkill.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.9";
			}
			if (WizardHealSkill.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.11";
			}
			if (WizardHealSkill.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.13";
			}
			if (WizardHealSkill.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.15";
			}
			if (WizardHealSkill.curSkillNum == 6)
			{
				skillRequirement.text = "Requires Lv.17";
			}
			if (WizardHealSkill.curSkillNum == 7)
			{
				skillRequirement.text = "Requires Lv.19";
			}
			if (WizardHealSkill.curSkillNum == 8)
			{
				skillRequirement.text = "Requires Lv.21";
			}
			
		}
		else
		{
			nextLevel.text = "Max Level";
			nextSkillChance.text = "";
			nextSkillDescription.text = "Max Level doubles your chance to proc the skill";
			skillRequirement.text = "Requires Lv.23";
			cost.text = "Cost: " + WizardHealSkill.cost.ToString() + " gold";
		}
		if (WizardHealSkill.curSkillNum == WizardHealSkill.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (WizardHealSkill.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Heals 25% of your max health";
			nextSkillChance.text = "Chance to proc: " + (WizardHealSkill.firstLevelBonus).ToString("f1") + "%";
		} 



	}
}
