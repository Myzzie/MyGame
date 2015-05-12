using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PetDamageEnhanceInfo : MonoBehaviour {


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
		skillName.text = "Pet Damage";
		skillDescription.text = "Permanently increases your pets damage";
		skillChance.text = "Current Pet Damage Enhance: " + WizardPetDamageEnhanceSkill.petDamageEnhance.ToString("f0") + "%";

		if (WizardPetDamageEnhanceSkill.curSkillNum < WizardPetDamageEnhanceSkill.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Permanently increases your pets damage";
			nextSkillChance.text = "Increase Pet Damage: 10%";
			cost.text = "Cost: " + WizardPetDamageEnhanceSkill.cost.ToString() + " gold";
			if (WizardPetDamageEnhanceSkill.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.25";
			}
			if (WizardPetDamageEnhanceSkill.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.30";
			}
			if (WizardPetDamageEnhanceSkill.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.40";
			}
			if (WizardPetDamageEnhanceSkill.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.50";
			}
			if (WizardPetDamageEnhanceSkill.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.60";
			}
		}
		else
		{
			nextLevel.text = "Max Level";
			nextSkillChance.text = "";
			nextSkillDescription.text = "Max Level doubles current increased damage";
			skillRequirement.text = "Requires Lv.70";
			cost.text = "Cost: " + WizardPetDamageEnhanceSkill.cost.ToString() + " gold";
		}
		if (WizardPetDamageEnhanceSkill.curSkillNum == WizardPetDamageEnhanceSkill.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (WizardPetDamageEnhanceSkill.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Permanently increases your pets damage";
			nextSkillChance.text = "Increase Pet Damage: " + (WizardPetDamageEnhanceSkill.petDamageEnhance + WizardPetDamageEnhanceSkill.nextPetDamageEnhance) + "%";
		} 



	}
}
