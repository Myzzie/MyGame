using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WizardPetTauntSkill : MonoBehaviour {
	
	public static float petTauntChance;
	public static bool petTauntChance1;
	public UnityEngine.UI.Text petTauntSkillNum;
	public Transform button;
	public static int curSkillNum;
	public static int maxSkillNum = 10;
	public static int cost = 100;
	public static float nextLevel = 0.4f;
	public static float firstLevelBonus = 0.8f;
	
	

	
	void Update()
	{
		if (curSkillNum == 0)
		{
			cost = 500;
		}
		if (curSkillNum == 1)
		{
			cost = 1000;
		}
		if (curSkillNum == 2)
		{
			cost = 2000;
		}
		if (curSkillNum == 3)
		{
			cost = 4000;
		}
		if (curSkillNum == 4)
		{
			cost = 8000;
		}
		if (curSkillNum == 5)
		{
			cost = 16000;
		}
		if (curSkillNum == 6)
		{
			cost = 32000;
		}
		if (curSkillNum == 7)
		{
			cost = 64000;
		}
		if (curSkillNum == 8)
		{
			cost = 128000;
		}
		if (curSkillNum == 9)
		{
			cost = 256000;
		}
		if (Materials.materials.gold >= cost)
		{
			if (curSkillNum == 0)
			{
				if (Materials.materials.battleLevel >= 25)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			
			if (curSkillNum == 1)
			{
				if (Materials.materials.battleLevel >= 30)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 2)
			{
				if (Materials.materials.battleLevel >= 35)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 3)
			{
				if (Materials.materials.battleLevel >= 40)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 4)
			{
				if (Materials.materials.battleLevel >= 45)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 5)
			{
				if (Materials.materials.battleLevel >= 50)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 6)
			{
				if (Materials.materials.battleLevel >= 55)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 7)
			{
				if (Materials.materials.battleLevel >= 60)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 8)
			{
				if (Materials.materials.battleLevel >= 65)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 9)
			{
				if (Materials.materials.battleLevel >= 70)
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

		petTauntSkillNum.text = curSkillNum + "/" + maxSkillNum;
	}
	
	public void RaiseTauntChance()
	{
		if (Materials.materials.gold >= cost) 
		{
			curSkillNum++;
			if (petTauntChance >= firstLevelBonus && curSkillNum < maxSkillNum){
				petTauntChance += nextLevel;
			}
			else petTauntChance += petTauntChance;
		}
		
		if (petTauntChance == 0) 
		{
			petTauntChance = firstLevelBonus;
		}
		Materials.materials.gold -= cost;
		cost = cost * 2;
	}





	
	
	public static void PetTauntChance ()
	{
		int randomTemp = Random.Range (1, 101);
		if (randomTemp <= (int)petTauntChance) {
			petTauntChance1 = true;
			} 
		 else{
			petTauntChance1 = false;
		}
	}

	public static void PetTaunt()
	{
		if (GameInformation.isWizardClass) {
			PetTauntChance ();
			if (petTauntChance1) {
				if (!PetDealDamage.petTaunting){
				
				GameObject FloatingPetHeal = Instantiate (Resources.Load ("Prefabs/WizardSkills/PetTauntText")) as GameObject;
				FloatingPetHeal.GetComponent<FloatingPetTaunt> ().DisplayDamage();
				FloatingPetHeal.transform.SetParent ((GameObject.Find ("PetBoosts").transform), false);
				}
			}
		}
	}
}

