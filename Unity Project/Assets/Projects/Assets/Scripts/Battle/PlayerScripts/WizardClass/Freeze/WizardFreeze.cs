using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WizardFreeze : MonoBehaviour {
	
	public static float freezeChance;
	public static bool freezeChance1;
	public UnityEngine.UI.Text freezeSkillNum;
	public Transform button;
	public static int curSkillNum;
	public static int maxSkillNum = 5;
	public static int cost;
	public static float nextLevel = 0.4f;
	public static float firstLevelBonus = 0.8f;
	public static bool frozen;
	
	

	
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
			cost = 5000;
		}
		if (Materials.materials.gold >= cost)
		{
			if (curSkillNum == 0)
			{
				if (Materials.materials.battleLevel >= 20)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			
			if (curSkillNum == 1)
			{
				if (Materials.materials.battleLevel >= 25)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 2)
			{
				if (Materials.materials.battleLevel >= 30)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 3)
			{
				if (Materials.materials.battleLevel >= 35)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 4)
			{
				if (Materials.materials.battleLevel >= 40)
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

		freezeSkillNum.text = curSkillNum + "/" + maxSkillNum;
	}
	
	public void RaiseFreezeChance()
	{
		if (Materials.materials.gold >= cost) 
		{
			curSkillNum++;
			if (freezeChance >= firstLevelBonus && curSkillNum < maxSkillNum){
				freezeChance += nextLevel;
			}
			else freezeChance += freezeChance;
		}
		
		if (freezeChance == 0) 
		{
			freezeChance = firstLevelBonus;
		}
		Materials.materials.gold -= cost;
		cost = cost * 2;
	}




	
	
	public static void FreezeChance ()
	{
		int randomTemp = Random.Range (1, 101);
		if (randomTemp <= (int)freezeChance) {
			freezeChance1 = true;
			} 
		 else{
			freezeChance1 = false;
		}
	}

	public static void Freeze()
	{
		if (GameInformation.isWizardClass) {
			FreezeChance ();
			if (freezeChance1) {
				
				if (!frozen){

			
				GameObject FloatingFreeze = Instantiate (Resources.Load ("Prefabs/WizardSkills/FreezeText")) as GameObject;
				FloatingFreeze.GetComponent<FloatingFreeze> ().DisplayDamage ();
				FloatingFreeze.transform.SetParent ((GameObject.Find ("Boosts").transform), false);
				}
			}
		}
	}
}

