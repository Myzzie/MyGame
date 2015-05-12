using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RegenSkill : MonoBehaviour {

	public static float regenChance;
	public static bool regenChance1;
	public static bool regenOn;
	public static int cost = 10;
	public Transform button;

	public UnityEngine.UI.Text regenSkillNum;
	public static int curSkillNum;
	public static int maxSkillNum = 10;
	public static float nextLevel = 0.4f;
	public static float firstLevelBonus = 0.8f;
	

	
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
	
		regenSkillNum.text = curSkillNum + "/" + maxSkillNum;
	}
	
	public void RaiseRegenChance()
	{
		if (Materials.materials.gold >= cost) 
		{
		curSkillNum++;
		if (regenChance >= firstLevelBonus && curSkillNum < maxSkillNum){
			regenChance += nextLevel;
		}
		else regenChance += regenChance;
		}
			
		if (regenChance == 0) 
		{
			regenChance = firstLevelBonus;
		}
		Materials.materials.gold -= cost;
		cost = cost * 2;
	}

	public static void RegenChance ()
	{
		int randomTemp = Random.Range (1, 101);
		if (randomTemp <= (int)regenChance) 
		{
			regenChance1 = true;
		}
		 else{
			regenChance1 = false;
	}
	}

	public static void Regeneration(){
		if (GameInformation.isWarriorClass) {
			RegenChance ();
		
			if (regenChance1) {
				if (!regenOn) {
				
					GameObject FloatingRegen = Instantiate (Resources.Load ("Prefabs/WarriorSkills/WarriorRegenText")) as GameObject;
					FloatingRegen.GetComponent<FloatingRegen> ().DisplayDamage ();
					FloatingRegen.transform.SetParent ((GameObject.Find ("Boosts").transform), false);
				}
			}
		
		}
	}

	
	
	
	
	
}