using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HardHitInfo : MonoBehaviour {
	
	
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
		skillName.text = "Hard Hit";
		skillDescription.text = "Hard Hit deal 10x of your damage";
		skillChance.text = "Chance to proc: " + HardHitSkill.hardHitChance + "%";
		
		
		
		if (HardHitSkill.curSkillNum < HardHitSkill.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Hard Hit deal 10x of your damage";
			nextSkillChance.text = "Chance to proc: " + (HardHitSkill.hardHitChance + HardHitSkill.nextLevel) + "%";
			cost.text = "Cost: " + HardHitSkill.cost.ToString() + " gold";
			if (HardHitSkill.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.10";
			}
			if (HardHitSkill.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.15";
			}
			if (HardHitSkill.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.20";
			}
			if (HardHitSkill.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.25";
			}
			if (HardHitSkill.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.30";
			}
			if (HardHitSkill.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.35";
			}
		}
		else
		{
			nextLevel.text = "Max Level";
			nextSkillChance.text = "";
			nextSkillDescription.text = "Max Level doubles your chance to proc the skill";
			skillRequirement.text = "Requires Lv.40";
			cost.text = "Cost: " + HardHitSkill.cost.ToString() + " gold";
		}
		if (HardHitSkill.curSkillNum == HardHitSkill.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (HardHitSkill.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Hard Hit deal 10x of your damage";
			nextSkillChance.text = "Chance to proc: " + (HardHitSkill.firstLevelBonus) + "%";
		} 
		
		
		
	}
}
