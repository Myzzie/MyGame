using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RegenSkillInfo : MonoBehaviour {


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
		skillName.text = "Regeneration";
		skillDescription.text = "You regenerate 5% of \n your max health every second \n for 10 seconds";
		skillChance.text = "Chance to proc: " + RegenSkill.regenChance.ToString("f1") + "%";

		if (RegenSkill.curSkillNum < RegenSkill.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "You regenerate 5% of \n your max health every second \n for 10 seconds";
			nextSkillChance.text = "Chance to proc: " + (RegenSkill.regenChance + RegenSkill.nextLevel).ToString("f1") + "%";
			cost.text = "Cost: " + RegenSkill.cost.ToString() + " gold";
			if (RegenSkill.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.5";
			}
			if (RegenSkill.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.7";
			}
			if (RegenSkill.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.9";
			}
			if (RegenSkill.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.11";
			}
			if (RegenSkill.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.13";
			}
			if (RegenSkill.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.15";
			}
			if (RegenSkill.curSkillNum == 6)
			{
				skillRequirement.text = "Requires Lv.17";
			}
			if (RegenSkill.curSkillNum == 7)
			{
				skillRequirement.text = "Requires Lv.19";
			}
			if (RegenSkill.curSkillNum == 8)
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
			cost.text = "Cost: " + RegenSkill.cost.ToString() + " gold";
		}
		if (RegenSkill.curSkillNum == RegenSkill.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (RegenSkill.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "You regenerate 5% of \n your max health every second \n for 10 seconds";
			nextSkillChance.text = "Chance to proc: " + (RegenSkill.firstLevelBonus).ToString("f1") + "%";
		} 



	}
}
