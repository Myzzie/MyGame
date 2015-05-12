using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EvasionBoostInfo : MonoBehaviour {
	

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
		skillName.text = "Evasion Boost";
		skillDescription.text = "Doubles your Evasion \n for 30 seconds";
		skillChance.text = "Chance to proc: " + EvasionBoost.evadeChance.ToString("f1") + "%";
		
		
		if (EvasionBoost.curSkillNum < EvasionBoost.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Doubles your Evasion \n for 30 seconds";
			nextSkillChance.text = "Chance to proc: " + (EvasionBoost.evadeChance + EvasionBoost.nextLevel).ToString("f1") + "%";
			cost.text = "Cost: " + EvasionBoost.cost.ToString() + " gold";
			if (EvasionBoost.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.5";
			}
			if (EvasionBoost.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.7";
			}
			if (EvasionBoost.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.9";
			}
			if (EvasionBoost.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.11";
			}
			if (EvasionBoost.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.13";
			}
			if (EvasionBoost.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.15";
			}
			if (EvasionBoost.curSkillNum == 6)
			{
				skillRequirement.text = "Requires Lv.17";
			}
			if (EvasionBoost.curSkillNum == 7)
			{
				skillRequirement.text = "Requires Lv.19";
			}
			if (EvasionBoost.curSkillNum == 8)
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
			cost.text = "Cost: " + EvasionBoost.cost.ToString() + " gold";
		}
		if (EvasionBoost.curSkillNum == EvasionBoost.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (EvasionBoost.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Doubles your Evasion \n for 30 seconds";
			nextSkillChance.text = "Chance to proc: " + (EvasionBoost.firstLevelBonus).ToString("f1") + "%";
		} 




		
		
		
	}
}
