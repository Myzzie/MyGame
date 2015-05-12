using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CritChanceBoostInfo : MonoBehaviour {
	

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
		skillName.text = "Critical Chance Boost";
		skillDescription.text = "Doubles your Critical Chance \n for 20 seconds";
		skillChance.text = "Chance to proc: " + CritChanceBoost.critChance.ToString("f1") + "%";
		
		
		
		if (CritChanceBoost.curSkillNum < CritChanceBoost.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Doubles your Critical Chance \n for 20 seconds";
			nextSkillChance.text = "Chance to proc: " + (CritChanceBoost.critChance + CritChanceBoost.nextLevel).ToString("f1") + "%";
			cost.text = "Cost: " + CritChanceBoost.cost.ToString() + " gold";
			if (CritChanceBoost.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.10";
			}
			if (CritChanceBoost.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.12";
			}
			if (CritChanceBoost.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.14";
			}
			if (CritChanceBoost.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.16";
			}
			if (CritChanceBoost.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.18";
			}
			if (CritChanceBoost.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.20";
			}
			if (CritChanceBoost.curSkillNum == 6)
			{
				skillRequirement.text = "Requires Lv.22";
			}
			if (CritChanceBoost.curSkillNum == 7)
			{
				skillRequirement.text = "Requires Lv.24";
			}
			if (CritChanceBoost.curSkillNum == 8)
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
			cost.text = "Cost: " + CritChanceBoost.cost.ToString() + " gold";
		}
		if (CritChanceBoost.curSkillNum == CritChanceBoost.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (CritChanceBoost.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Doubles your Critical Chance \n for 20 seconds";
			nextSkillChance.text = "Chance to proc: " + (CritChanceBoost.firstLevelBonus).ToString("f1") + "%";
		} 

		
	
	}
}
