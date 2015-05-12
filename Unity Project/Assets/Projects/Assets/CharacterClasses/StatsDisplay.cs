using UnityEngine;
using System.Collections;

public class StatsDisplay : MonoBehaviour {


	public UnityEngine.UI.Text health;
	public UnityEngine.UI.Text baseDamage;
	public UnityEngine.UI.Text attackSpeed;
	public UnityEngine.UI.Text baseCritChance;
	public UnityEngine.UI.Text baseEvadeChance;
	public UnityEngine.UI.Text classDescription;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Display Class Health!
		if (GameInformation.isWarriorClass) 
		{
			BaseCharacterClass tempClass = new BaseWarriorClass();
			health.text = "Health: " + tempClass.MaxHealth;
			baseDamage.text = "Min/Max Damage: " + tempClass.BaseMinDamage + "-" + tempClass.BaseMaxDamage;
			attackSpeed.text = "Attack Speed: 0.33/sec";
			baseCritChance.text = "Crit Chance: " + tempClass.BaseCritChance + "%";
			baseEvadeChance.text = "Evade Chance: " + tempClass.BaseEvadeChance + "%";
			classDescription.text = "Warrior has high health and high damage but slow Attack Speed";
		}
		if (GameInformation.isWizardClass) 
		{
			BaseCharacterClass tempClass = new BaseWizardClass();
			health.text = "Health: " + tempClass.MaxHealth;
			baseDamage.text = "Min/Max Damage: " + tempClass.BaseMinDamage + "-" + tempClass.BaseMaxDamage;
			attackSpeed.text = "Attack Speed: 0.5/sec";
			baseCritChance.text = "Crit Chance: " + tempClass.BaseCritChance + "%";
			baseEvadeChance.text = "Evade Chance: " + tempClass.BaseEvadeChance + "%";
			classDescription.text = "Wizard has a chance to heal self, how cool is that?";

		}
		if (GameInformation.isAssassinClass) 
		{
			BaseCharacterClass tempClass = new BaseAssassinClass();
			health.text = "Health: " + tempClass.MaxHealth;
			baseDamage.text = "Min/Max Damage: " + tempClass.BaseMinDamage + "-" + tempClass.BaseMaxDamage;
			attackSpeed.text = "Attack Speed: 1/sec";
			baseCritChance.text = "Crit Chance: " + tempClass.BaseCritChance + "%";
			baseEvadeChance.text = "Evade Chance: " + tempClass.BaseEvadeChance + "%";
			classDescription.text = "Assassin, Life Steal, Crit, all that..";
		}

	}
}
