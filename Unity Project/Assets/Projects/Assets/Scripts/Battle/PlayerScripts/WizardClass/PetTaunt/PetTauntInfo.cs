using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PetTauntInfo : MonoBehaviour {


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
		skillName.text = "Pet Taunt";
		skillDescription.text = "Makes the pet take aggravation, \n and reduces all incoming damage on pet by 50%. \n Taunt lasts for 20 seconds";
		skillChance.text = "Chance to proc: " + WizardPetTauntSkill.petTauntChance.ToString("f1") + "%";

		if (WizardPetTauntSkill.curSkillNum < WizardPetTauntSkill.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Makes the pet take aggravation, \n and reduces all incoming damage on pet by 50%. \n Taunt lasts for 20 seconds";
			nextSkillChance.text = "Chance to proc: " + (WizardPetTauntSkill.petTauntChance + WizardPetTauntSkill.nextLevel).ToString("f1") + "%";
			cost.text = "Cost: " + WizardPetTauntSkill.cost.ToString() + " gold";
			if (WizardPetTauntSkill.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.25";
			}
			if (WizardPetTauntSkill.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.30";
			}
			if (WizardPetTauntSkill.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.35";
			}
			if (WizardPetTauntSkill.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.40";
			}
			if (WizardPetTauntSkill.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.45";
			}
			if (WizardPetTauntSkill.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.50";
			}
			if (WizardPetTauntSkill.curSkillNum == 6)
			{
				skillRequirement.text = "Requires Lv.55";
			}
			if (WizardPetTauntSkill.curSkillNum == 7)
			{
				skillRequirement.text = "Requires Lv.60";
			}
			if (WizardPetTauntSkill.curSkillNum == 8)
			{
				skillRequirement.text = "Requires Lv.65";
			}
			
		}
		else
		{
			nextLevel.text = "Max Level";
			nextSkillChance.text = "";
			nextSkillDescription.text = "Max Level doubles your chance to proc the skill";
			skillRequirement.text = "Requires Lv.70";
			cost.text = "Cost: " + WizardPetTauntSkill.cost.ToString() + " gold";
		}
		if (WizardPetTauntSkill.curSkillNum == WizardPetTauntSkill.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (WizardPetTauntSkill.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Makes the pet take aggravation, \n and reduces all incoming damage on pet by 50%. \n Taunt lasts for 20 seconds";
			nextSkillChance.text = "Chance to proc: " + (WizardPetTauntSkill.firstLevelBonus).ToString("f1") + "%";
		} 



	}
}
