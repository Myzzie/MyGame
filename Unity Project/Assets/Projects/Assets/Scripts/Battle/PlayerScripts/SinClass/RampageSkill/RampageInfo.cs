using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RampageInfo : MonoBehaviour {

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
		skillName.text = "Rampage";
		skillDescription.text = "Your stats are increased for 10sec";
		skillChance.text = "Chance to proc: " + Rampage.rampageChance.ToString("f1") + "%";
		
		
		if (Rampage.curSkillNum < Rampage.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Your stats are increased for 10sec";
			nextSkillChance.text = "Chance to proc: " + (Rampage.rampageChance + Rampage.nextLevel).ToString("f1") + "%";
			cost.text = "Cost: " + Rampage.cost.ToString() + " gold";
			if (Rampage.curSkillNum == 0)
			{
			skillRequirement.text = "Requires Lv.25";
			}
			if (Rampage.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.30";
			}
			if (Rampage.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.35";
			}
			if (Rampage.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.40";
			}
			if (Rampage.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.45";
			}
			if (Rampage.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.50";
			}
			if (Rampage.curSkillNum == 6)
			{
				skillRequirement.text = "Requires Lv.55";
			}
			if (Rampage.curSkillNum == 7)
			{
				skillRequirement.text = "Requires Lv.60";
			}
			if (Rampage.curSkillNum == 8)
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
			cost.text = "Cost: " + Rampage.cost.ToString() + " gold";
		}
		if (Rampage.curSkillNum == Rampage.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (Rampage.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Your stats are increased for 10sec";
			nextSkillChance.text = "Chance to proc: " + (Rampage.firstLevelBonus).ToString("f1") + "%";
		} 




		
		
		
	}
}
