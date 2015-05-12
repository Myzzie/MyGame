using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PetRageInfo : MonoBehaviour {


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
		skillName.text = "Pet Rage";
		skillDescription.text = "Triple your pets attack speed \n for 15 seconds";
		skillChance.text = "Chance to proc: " + WizardPetRageSkill.petRageChance.ToString("f1") + "%";

		if (WizardPetRageSkill.curSkillNum < WizardPetRageSkill.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Triple your pets attack speed \n for 15 seconds";
			nextSkillChance.text = "Chance to proc: " + (WizardPetRageSkill.petRageChance + WizardPetRageSkill.nextLevel).ToString("f1") + "%";
			cost.text = "Cost: " + WizardPetRageSkill.cost.ToString() + " gold";
			if (WizardPetRageSkill.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.15";
			}
			if (WizardPetRageSkill.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.17";
			}
			if (WizardPetRageSkill.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.19";
			}
			if (WizardPetRageSkill.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.21";
			}
			if (WizardPetRageSkill.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.23";
			}
			if (WizardPetRageSkill.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.25";
			}
			if (WizardPetRageSkill.curSkillNum == 6)
			{
				skillRequirement.text = "Requires Lv.27";
			}
			if (WizardPetRageSkill.curSkillNum == 7)
			{
				skillRequirement.text = "Requires Lv.29";
			}
			if (WizardPetRageSkill.curSkillNum == 8)
			{
				skillRequirement.text = "Requires Lv.31";
			}
			
		}
		else
		{
			nextLevel.text = "Max Level";
			nextSkillChance.text = "";
			nextSkillDescription.text = "Max Level doubles your chance to proc the skill";
			skillRequirement.text = "Requires Lv.33";
			cost.text = "Cost: " + WizardPetRageSkill.cost.ToString() + " gold";
		}
		if (WizardPetRageSkill.curSkillNum == WizardPetRageSkill.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (WizardPetRageSkill.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Triple your pets attack speed \n for 15 seconds";
			nextSkillChance.text = "Chance to proc: " + (WizardPetRageSkill.firstLevelBonus).ToString("f1") + "%";
		} 



	}
}
