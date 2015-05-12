using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpikeShieldInfo : MonoBehaviour {


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
		skillName.text = "Spike Shield";
		skillDescription.text = "Reflect 50% of incoming damage \n for 15 seconds";
		skillChance.text = "Chance to proc: " + WarriorSpikeShield.spikeShieldChance.ToString("f1") + "%";

		if (WarriorSpikeShield.curSkillNum < WarriorSpikeShield.maxSkillNum - 1) 
		{
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Reflect 50% of incoming damage \n for 15 seconds";
			nextSkillChance.text = "Chance to proc: " + (WarriorSpikeShield.spikeShieldChance + WarriorSpikeShield.nextLevel).ToString("f1") + "%";
			cost.text = "Cost: " + WarriorSpikeShield.cost.ToString() + " gold";
			if (WarriorSpikeShield.curSkillNum == 0)
			{
				skillRequirement.text = "Requires Lv.15";
			}
			if (WarriorSpikeShield.curSkillNum == 1)
			{
				skillRequirement.text = "Requires Lv.20";
			}
			if (WarriorSpikeShield.curSkillNum == 2)
			{
				skillRequirement.text = "Requires Lv.25";
			}
			if (WarriorSpikeShield.curSkillNum == 3)
			{
				skillRequirement.text = "Requires Lv.30";
			}
			if (WarriorSpikeShield.curSkillNum == 4)
			{
				skillRequirement.text = "Requires Lv.35";
			}
			if (WarriorSpikeShield.curSkillNum == 5)
			{
				skillRequirement.text = "Requires Lv.40";
			}
			if (WarriorSpikeShield.curSkillNum == 6)
			{
				skillRequirement.text = "Requires Lv.45";
			}
			if (WarriorSpikeShield.curSkillNum == 7)
			{
				skillRequirement.text = "Requires Lv.50";
			}
			if (WarriorSpikeShield.curSkillNum == 8)
			{
				skillRequirement.text = "Requires Lv.55";
			}
			
		}
		else
		{
			nextLevel.text = "Max Level";
			nextSkillChance.text = "";
			nextSkillDescription.text = "Max Level doubles your chance to proc the skill";
			skillRequirement.text = "Requires Lv.60";
			cost.text = "Cost: " + WarriorSpikeShield.cost.ToString() + " gold";
		}
		if (WarriorSpikeShield.curSkillNum == WarriorSpikeShield.maxSkillNum)
		{
			nextLevel.text = "";
			nextSkillDescription.text = "";
			nextSkillChance.text = "";
			skillRequirement.text = "";
			cost.text = "";
		}
		if (WarriorSpikeShield.curSkillNum <= 0) {
			nextLevel.text = "Next Level";
			nextSkillDescription.text = "Reflect 50% of incoming damage \n for 15 seconds";
			nextSkillChance.text = "Chance to proc: " + (WarriorSpikeShield.firstLevelBonus).ToString("f1") + "%";
		} 



	}
}
