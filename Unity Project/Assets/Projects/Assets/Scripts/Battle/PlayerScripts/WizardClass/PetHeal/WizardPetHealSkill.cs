using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WizardPetHealSkill : MonoBehaviour {
	
	public static float petHealChance;
	public static bool petHealChance1;
	public UnityEngine.UI.Text petHealSkillNum;
	public Transform button;
	public static int curSkillNum;
	public static int maxSkillNum = 10;
	public static int cost = 25;
	public static float nextLevel = 0.4f;
	public static float firstLevelBonus = 0.8f;
	
	

	
	void Update()
	{
		if (curSkillNum == 0)
		{
			cost = 100;
		}
		if (curSkillNum == 1)
		{
			cost = 200;
		}
		if (curSkillNum == 2)
		{
			cost = 400;
		}
		if (curSkillNum == 3)
		{
			cost = 800;
		}
		if (curSkillNum == 4)
		{
			cost = 1600;
		}
		if (curSkillNum == 5)
		{
			cost = 3200;
		}
		if (curSkillNum == 6)
		{
			cost = 6400;
		}
		if (curSkillNum == 7)
		{
			cost = 12800;
		}
		if (curSkillNum == 8)
		{
			cost = 25600;
		}
		if (curSkillNum == 9)
		{
			cost = 51200;
		}
		if (Materials.materials.gold >= cost)
		{
			if (curSkillNum == 0)
			{
				if (Materials.materials.battleLevel >= 10)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			
			if (curSkillNum == 1)
			{
				if (Materials.materials.battleLevel >= 12)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 2)
			{
				if (Materials.materials.battleLevel >= 14)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 3)
			{
				if (Materials.materials.battleLevel >= 16)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 4)
			{
				if (Materials.materials.battleLevel >= 18)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 5)
			{
				if (Materials.materials.battleLevel >= 20)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 6)
			{
				if (Materials.materials.battleLevel >= 22)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 7)
			{
				if (Materials.materials.battleLevel >= 24)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 8)
			{
				if (Materials.materials.battleLevel >= 26)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 9)
			{
				if (Materials.materials.battleLevel >= 28)
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

		petHealSkillNum.text = curSkillNum + "/" + maxSkillNum;
	}
	
	public void RaiseHealChance()
	{
		if (Materials.materials.gold >= cost) 
		{
			curSkillNum++;
			if (petHealChance >= firstLevelBonus && curSkillNum < maxSkillNum){
				petHealChance += nextLevel;
			}
			else petHealChance += petHealChance;
		}
		
		if (petHealChance == 0) 
		{
			petHealChance = firstLevelBonus;
		}
		Materials.materials.gold -= cost;
		cost = cost * 2;
	}




	public static float GetHealed()
	{
		
		if (petHealChance1) 
		{
			
			return PetHealth.maxHealth /4;
			
		} else {
			
			return 0;
			
		}
		
	}
	
	
	public static void PetHealChance ()
	{
		int randomTemp = Random.Range (1, 101);
		if (randomTemp <= (int)petHealChance) {
			petHealChance1 = true;
			} 
		 else{
			petHealChance1 = false;
		}
	}

	public static void PetHeal()
	{
		if (GameInformation.isWizardClass) {
			PetHealChance ();
			if (petHealChance1) {
				
				
				GameObject FloatingPetHeal = Instantiate (Resources.Load ("Prefabs/WizardSkills/PetHealText")) as GameObject;
				FloatingPetHeal.GetComponent<FloatingPetHeal> ().DisplayDamage (("+" + GetHealed ().ToString ("G")).ToString ());
				FloatingPetHeal.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				
				PetHealth.currentHealth += GetHealed ();
			}
		}
	}
}

