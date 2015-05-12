using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WizardPetRageSkill : MonoBehaviour {
	
	public static float petRageChance;
	public static bool petRageChance1;
	public UnityEngine.UI.Text petRageSkillNum;
	public Transform button;
	public static int curSkillNum;
	public static int maxSkillNum = 10;
	public static int cost = 50;
	public static float nextLevel = 0.4f;
	public static float firstLevelBonus = 0.8f;
	public static bool rageOn;
	
	

	
	void Update()
	{
		if (curSkillNum == 0)
		{
			cost = 250;
		}
		if (curSkillNum == 1)
		{
			cost = 500;
		}
		if (curSkillNum == 2)
		{
			cost = 1000;
		}
		if (curSkillNum == 3)
		{
			cost = 2000;
		}
		if (curSkillNum == 4)
		{
			cost = 4000;
		}
		if (curSkillNum == 5)
		{
			cost = 8000;
		}
		if (curSkillNum == 6)
		{
			cost = 16000;
		}
		if (curSkillNum == 7)
		{
			cost = 32000;
		}
		if (curSkillNum == 8)
		{
			cost = 64000;
		}
		if (curSkillNum == 9)
		{
			cost = 128000;
		}
		if (Materials.materials.gold >= cost)
		{
			if (curSkillNum == 0)
			{
				if (Materials.materials.battleLevel >= 15)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			
			if (curSkillNum == 1)
			{
				if (Materials.materials.battleLevel >= 17)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 2)
			{
				if (Materials.materials.battleLevel >= 19)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 3)
			{
				if (Materials.materials.battleLevel >= 21)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 4)
			{
				if (Materials.materials.battleLevel >= 23)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 5)
			{
				if (Materials.materials.battleLevel >= 25)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 6)
			{
				if (Materials.materials.battleLevel >= 27)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 7)
			{
				if (Materials.materials.battleLevel >= 29)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 8)
			{
				if (Materials.materials.battleLevel >= 31)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 9)
			{
				if (Materials.materials.battleLevel >= 33)
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

		petRageSkillNum.text = curSkillNum + "/" + maxSkillNum;
	}
	
	public void RaiseRageChance()
	{
		if (Materials.materials.gold >= cost) 
		{
			curSkillNum++;
			if (petRageChance >= firstLevelBonus && curSkillNum < maxSkillNum){
				petRageChance += nextLevel;
			}
			else petRageChance += petRageChance;
		}
		
		if (petRageChance == 0) 
		{
			petRageChance = firstLevelBonus;
		}
		Materials.materials.gold -= cost;
		cost = cost * 2;
	}





	
	
	public static void PetRageChance ()
	{
		int randomTemp = Random.Range (1, 101);
		if (randomTemp <= (int)petRageChance) {
			petRageChance1 = true;
			} 
		 else{
			petRageChance1 = false;
		}
	}

	public static void PetRage()
	{
		if (GameInformation.isWizardClass) {
			PetRageChance ();
			if (petRageChance1) {
				if (!rageOn){
				
				GameObject FloatingPetHeal = Instantiate (Resources.Load ("Prefabs/WizardSkills/PetRageText")) as GameObject;
				FloatingPetHeal.GetComponent<FloatingPetRage> ().DisplayDamage();
					FloatingPetHeal.transform.SetParent ((GameObject.Find ("PetBoosts").transform), false);
				}
			}
		}
	}
}

