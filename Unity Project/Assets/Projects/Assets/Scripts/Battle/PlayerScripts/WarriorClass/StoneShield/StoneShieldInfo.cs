using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StoneShieldInfo : MonoBehaviour {


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
		skillName.text = "Stone Shield";
		skillDescription.text = "Reduces all incoming damage \n by 50% for 15 seconds";
		skillChance.text = "Chance to proc: " + WarriorStoneShield.stoneShieldChance.ToString("f1") + "%";

		if (WarriorStoneShield.curSkillNum < WarriorStoneShield.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Reduces all incoming damage \n by 50% for 15 seconds";
			nextSkillChance.text = "Chance to proc: " + (WarriorStoneShield.stoneShieldChance + WarriorStoneShield.nextLevel).ToString("f1") + "%";
			cost.text = "Cost: " + WarriorStoneShield.cost.ToString() + " gold";
			if (WarriorStoneShield.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.25";
			}
			if (WarriorStoneShield.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.30";
			}
			if (WarriorStoneShield.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.35";
			}
			if (WarriorStoneShield.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.40";
			}
			if (WarriorStoneShield.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.45";
			}
			if (WarriorStoneShield.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.50";
			}
			if (WarriorStoneShield.curSkillNum == 6)
			{
				skillRequirement.text = "Requires Lv.55";
			}
			if (WarriorStoneShield.curSkillNum == 7)
			{
				skillRequirement.text = "Requires Lv.60";
			}
			if (WarriorStoneShield.curSkillNum == 8)
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
			cost.text = "Cost: " + WarriorStoneShield.cost.ToString() + " gold";
		}
		if (WarriorStoneShield.curSkillNum == WarriorStoneShield.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (WarriorStoneShield.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Reduces all incoming damage \n by 50% for 15 seconds";
			nextSkillChance.text = "Chance to proc: " + (WarriorStoneShield.firstLevelBonus).ToString("f1") + "%";
		} 



	}
}
