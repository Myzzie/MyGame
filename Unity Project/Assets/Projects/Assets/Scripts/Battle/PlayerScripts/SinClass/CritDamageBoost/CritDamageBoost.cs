using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CritDamageBoost : MonoBehaviour {

	public static float critDamage;
	public static bool critDamage1;
	public static bool critDamageOn;

	public UnityEngine.UI.Text critDamageSkillNum;
	public static int cost = 50;
	public Transform button;
	public static int curSkillNum;
	public static int maxSkillNum = 10;
	public static float nextLevel = 0.15f;
	public static float firstLevelBonus = 0.3f;

	void Awake ()
	{
		button.GetComponent<Button> ().interactable = false;
	}

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
				if (Materials.materials.battleLevel >= 18)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 2)
			{
				if (Materials.materials.battleLevel >= 21)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 3)
			{
				if (Materials.materials.battleLevel >= 24)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 4)
			{
				if (Materials.materials.battleLevel >= 27)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 5)
			{
				if (Materials.materials.battleLevel >= 30)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 6)
			{
				if (Materials.materials.battleLevel >= 33)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 7)
			{
				if (Materials.materials.battleLevel >= 36)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 8)
			{
				if (Materials.materials.battleLevel >= 39)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 9)
			{
				if (Materials.materials.battleLevel >= 42)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
		}
		else button.GetComponent<Button>().interactable = false;

			if (curSkillNum == maxSkillNum ) 
			{
				curSkillNum = maxSkillNum;
				button.GetComponent<Button>().interactable = false;
			}
		critDamageSkillNum.text = curSkillNum + "/" + maxSkillNum;
	}
	
	public void RaiseCritDamage()
	{
		if (Materials.materials.gold >= cost)
		{
			curSkillNum++;
			if (critDamage >= firstLevelBonus && curSkillNum < maxSkillNum){
				critDamage += nextLevel;
			}
			else critDamage += critDamage;

			if (critDamage == 0) 
			{
				critDamage = firstLevelBonus;
			}
			Materials.materials.gold -= cost;
			cost = cost * 2;
		}
	}
	
	
	public static void CritDamageChance ()
	{
		float randomTemp = Random.Range (0.1f, 101);
		if (randomTemp <= critDamage) {
			 
			critDamage1 = true;
		} else {
			critDamage1 = false;
		}
		
	}
	public static void GetCritDamage(){
		if (GameInformation.isAssassinClass) {
			CritDamageChance ();
		
			if (critDamage1) {
				if (!critDamageOn) {
				
				
					GameObject FloatingCrit = Instantiate (Resources.Load ("Prefabs/SinSkills/CritDamageBoostText")) as GameObject;
					FloatingCrit.GetComponent<FloatingCritDamage> ().DisplayDamage ();
					FloatingCrit.transform.SetParent ((GameObject.Find ("Boosts").transform), false);
				
				
				}
			}
		}
	}
	

}
