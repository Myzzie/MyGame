using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeStealInfo : MonoBehaviour {
	

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
		skillName.text = "Life Steal";
		skillDescription.text = "Steal life from your enemy \n equal to 10% of your damage";
		skillChance.text = "Chance to proc: " + SinLifeSteal.lifeStealChance + "%";
		
		
	
		if (SinLifeSteal.curSkillNum < SinLifeSteal.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Steal life from your enemy \n equal to 10% of your damage";
			nextSkillChance.text = "Chance to proc: " + (SinLifeSteal.lifeStealChance + SinLifeSteal.nextLevel) + "%";
			cost.text = "Cost: " + SinLifeSteal.cost.ToString() + " gold";
			if (SinLifeSteal.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.10";
			}
			if (SinLifeSteal.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.12";
			}
			if (SinLifeSteal.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.14";
			}
			if (SinLifeSteal.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.16";
			}
			if (SinLifeSteal.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.18";
			}
			if (SinLifeSteal.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.20";
			}
			if (SinLifeSteal.curSkillNum == 6)
			{
				skillRequirement.text = "Requires Lv.22";
			}
			if (SinLifeSteal.curSkillNum == 7)
			{
				skillRequirement.text = "Requires Lv.24";
			}
			if (SinLifeSteal.curSkillNum == 8)
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
			cost.text = "Cost: " + SinLifeSteal.cost.ToString() + " gold";
		}
		if (SinLifeSteal.curSkillNum == SinLifeSteal.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (SinLifeSteal.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Steal life from your enemy \n equal to 10% of your damage";
			nextSkillChance.text = "Chance to proc: " + (SinLifeSteal.firstLevelBonus) + "%";
		} 

		
	}
}
