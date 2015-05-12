using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BleedInfo : MonoBehaviour {
	

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
		skillName.text = "Bleed Effect";
		skillDescription.text = "Applies bleed on enemy \n equal to 25% of your damage";
		skillChance.text = "Chance to proc: " + BleedEffect.bleedEffectChance + "%";
		
		
	
		if (BleedEffect.curSkillNum < BleedEffect.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Applies bleed on enemy \n equal to 25% of your damage";
			nextSkillChance.text = "Chance to proc: " + (BleedEffect.bleedEffectChance + BleedEffect.nextLevel) + "%";
			cost.text = "Cost: " + BleedEffect.cost.ToString() + " gold";
			if (BleedEffect.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.15";
			}
			if (BleedEffect.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.20";
			}
			if (BleedEffect.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.25";
			}
			if (BleedEffect.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.30";
			}
			if (BleedEffect.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.35";
			}
			if (BleedEffect.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.40";
			}
		}
		else
		{
			nextLevel.text = "Max Level";
			nextSkillChance.text = "";
			nextSkillDescription.text = "Max Level doubles your chance to proc the skill";
			skillRequirement.text = "Requires Lv.45";
			cost.text = "Cost: " + BleedEffect.cost.ToString() + " gold";
		}
		if (BleedEffect.curSkillNum == BleedEffect.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (BleedEffect.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Applies bleed on enemy \n equal to 25% of your damage";
			nextSkillChance.text = "Chance to proc: " + (BleedEffect.firstLevelBonus) + "%";
		} 

		
	}
}
