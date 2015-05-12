using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CritDamageBoostInfo : MonoBehaviour {
	

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
		skillName.text = "Critical Damage Boost";
		skillDescription.text = "Increases your critical multiplier \n by 100% for 20 seconds";
		skillChance.text = "Chance to proc: " + CritDamageBoost.critDamage.ToString("f1") + "%";
		
		
		
		if (CritDamageBoost.curSkillNum < CritDamageBoost.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Increases your critical multiplier \n by 100% for 20 seconds";
			nextSkillChance.text = "Chance to proc: " + (CritDamageBoost.critDamage + CritDamageBoost.nextLevel).ToString("f1") + "%";
			cost.text = "Cost: " + CritDamageBoost.cost.ToString() + " gold";
			if (CritDamageBoost.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.15";
			}
			if (CritDamageBoost.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.18";
			}
			if (CritDamageBoost.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.21";
			}
			if (CritDamageBoost.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.24";
			}
			if (CritDamageBoost.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.27";
			}
			if (CritDamageBoost.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.30";
			}
			if (CritDamageBoost.curSkillNum == 6)
			{
				skillRequirement.text = "Requires Lv.33";
			}
			if (CritDamageBoost.curSkillNum == 7)
			{
				skillRequirement.text = "Requires Lv.36";
			}
			if (CritDamageBoost.curSkillNum == 8)
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
			cost.text = "Cost: " + CritDamageBoost.cost.ToString() + " gold";
		}
		if (CritDamageBoost.curSkillNum == CritDamageBoost.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (CritDamageBoost.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Increases your critical multiplier \n by 100% for 20 seconds";
			nextSkillChance.text = "Chance to proc: " + (CritDamageBoost.firstLevelBonus).ToString("f1") + "%";
		} 
	


		
		
	}
}
