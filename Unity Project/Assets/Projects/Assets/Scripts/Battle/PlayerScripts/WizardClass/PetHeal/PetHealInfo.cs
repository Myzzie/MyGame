using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PetHealInfo : MonoBehaviour {


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
		skillName.text = "Pet Heal";
		skillDescription.text = "Heals 25% of pets max health";
		skillChance.text = "Chance to proc: " + WizardPetHealSkill.petHealChance.ToString("f1") + "%";

		if (WizardPetHealSkill.curSkillNum < WizardPetHealSkill.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Heals 25% of pets max health";
			nextSkillChance.text = "Chance to proc: " + (WizardPetHealSkill.petHealChance + WizardPetHealSkill.nextLevel).ToString("f1") + "%";
			cost.text = "Cost: " + WizardPetHealSkill.cost.ToString() + " gold";
			if (WizardPetHealSkill.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.10";
			}
			if (WizardPetHealSkill.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.12";
			}
			if (WizardPetHealSkill.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.14";
			}
			if (WizardPetHealSkill.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.16";
			}
			if (WizardPetHealSkill.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.18";
			}
			if (WizardPetHealSkill.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.20";
			}
			if (WizardPetHealSkill.curSkillNum == 6)
			{
				skillRequirement.text = "Requires Lv.22";
			}
			if (WizardPetHealSkill.curSkillNum == 7)
			{
				skillRequirement.text = "Requires Lv.24";
			}
			if (WizardPetHealSkill.curSkillNum == 8)
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
			cost.text = "Cost: " + WizardPetHealSkill.cost.ToString() + " gold";
		}
		if (WizardPetHealSkill.curSkillNum == WizardPetHealSkill.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (WizardPetHealSkill.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Heals 25% of pets max health";
			nextSkillChance.text = "Chance to proc: " + (WizardPetHealSkill.firstLevelBonus).ToString("f1") + "%";
		} 



	}
}
