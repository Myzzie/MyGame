using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WizardHealSkill : MonoBehaviour {
	
	public static float healChance;
	public static bool healChance1;
	public UnityEngine.UI.Text healSkillNum;
	public Transform button;
	public static int curSkillNum;
	public static int maxSkillNum = 10;
	public static int cost = 10;
	public static float nextLevel = 0.25f;
	public static float firstLevelBonus = 0.5f;
	
	

	
	void Update()
	{

		if (curSkillNum == 0)
		{
			cost = 50;
		}
		if (curSkillNum == 1)
		{
			cost = 100;
		}
		if (curSkillNum == 2)
		{
			cost = 200;
		}
		if (curSkillNum == 3)
		{
			cost = 250;
		}
		if (curSkillNum == 4)
		{
			cost = 500;
		}
		if (curSkillNum == 5)
		{
			cost = 1000;
		}
		if (curSkillNum == 6)
		{
			cost = 2000;
		}
		if (curSkillNum == 7)
		{
			cost = 4000;
		}
		if (curSkillNum == 8)
		{
			cost = 8000;
		}
		if (curSkillNum == 9)
		{
			cost = 16000;
		}
		if (Materials.materials.gold >= cost)
		{
			if (curSkillNum == 0)
			{
				if (Materials.materials.battleLevel >= 5)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			
			if (curSkillNum == 1)
			{
				if (Materials.materials.battleLevel >= 7)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 2)
			{
				if (Materials.materials.battleLevel >= 9)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 3)
			{
				if (Materials.materials.battleLevel >= 11)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 4)
			{
				if (Materials.materials.battleLevel >= 13)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 5)
			{
				if (Materials.materials.battleLevel >= 15)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 6)
			{
				if (Materials.materials.battleLevel >= 17)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 7)
			{
				if (Materials.materials.battleLevel >= 19)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 8)
			{
				if (Materials.materials.battleLevel >= 21)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 9)
			{
				if (Materials.materials.battleLevel >= 23)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
		}
		else button.GetComponent<Button>().interactable = false;
		if (curSkillNum == maxSkillNum) {
			curSkillNum = maxSkillNum;
			button.GetComponent<Button>().interactable = false;
		}

		healSkillNum.text = curSkillNum + "/" + maxSkillNum;
	}
	
	public void RaiseHealChance()
	{
		if (Materials.materials.gold >= cost) 
		{
			curSkillNum++;
			if (healChance >= firstLevelBonus && curSkillNum < maxSkillNum){
				healChance += nextLevel;
			}
			else healChance += healChance;
		}
		
		if (healChance == 0) 
		{
			healChance = firstLevelBonus;
		}
		Materials.materials.gold -= cost;
		cost = cost * 2;
	}




	public static float GetHealed()
	{
		
		if (healChance1) 
		{
			
			return PlayerHealth.maxHealth /4;
			
		} else {
			
			return 0;
			
		}
		
	}
	
	
	public static void HealChance ()
	{
		int randomTemp = Random.Range (1, 101);
		if (randomTemp <= (int)healChance) {
				healChance1 = true;
			} 
		 else{
			healChance1 = false;
		}
	}

	public static void Heal()
	{
		if (GameInformation.isWizardClass) {
			HealChance ();
			if (healChance1) {
				
				
				GameObject FloatingHeal = Instantiate (Resources.Load ("Prefabs/WizardSkills/HealText")) as GameObject;
				FloatingHeal.GetComponent<FloatingHeal> ().DisplayDamage (("+" + GetHealed ().ToString ("G")).ToString ());
				FloatingHeal.transform.SetParent ((GameObject.Find ("PlayerHealth").transform), false);
				
				PlayerHealth.currentHealth += GetHealed ();
			}
		}
	}
}

