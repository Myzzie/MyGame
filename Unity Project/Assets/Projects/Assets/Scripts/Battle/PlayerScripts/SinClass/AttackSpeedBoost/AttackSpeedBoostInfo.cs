using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AttackSpeedBoostInfo : MonoBehaviour {
	

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
		skillName.text = "Attack Speed Boost";
		skillDescription.text = "Doubles your Attack Speed \n for 7 seconds";
		skillChance.text = "Chance to proc: " + AttackSpeedBoost.speedChance.ToString("f1") + "%";

		
		if (AttackSpeedBoost.curSkillNum < AttackSpeedBoost.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Doubles your Attack Speed \n for 7 seconds";
			nextSkillChance.text = "Chance to proc: " + (AttackSpeedBoost.speedChance + AttackSpeedBoost.nextLevel).ToString("f1") + "%";
			cost.text = "Cost: " + AttackSpeedBoost.cost.ToString() + " gold";
			if (AttackSpeedBoost.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.25";
			}
			if (AttackSpeedBoost.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.30";
			}
			if (AttackSpeedBoost.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.35";
			}
			if (AttackSpeedBoost.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.40";
			}
			if (AttackSpeedBoost.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.45";
			}
			if (AttackSpeedBoost.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.50";
			}
			if (AttackSpeedBoost.curSkillNum == 6)
			{
				skillRequirement.text = "Requires Lv.55";
			}
			if (AttackSpeedBoost.curSkillNum == 7)
			{
				skillRequirement.text = "Requires Lv.60";
			}
			if (AttackSpeedBoost.curSkillNum == 8)
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
			cost.text = "Cost: " + AttackSpeedBoost.cost.ToString() + " gold";
		}
		if (AttackSpeedBoost.curSkillNum == AttackSpeedBoost.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (AttackSpeedBoost.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Doubles your Attack Speed \n for 7 seconds";
			nextSkillChance.text = "Chance to proc: " + (AttackSpeedBoost.firstLevelBonus).ToString("f1") + "%";
		} 
		


		
	
		
	}
}
