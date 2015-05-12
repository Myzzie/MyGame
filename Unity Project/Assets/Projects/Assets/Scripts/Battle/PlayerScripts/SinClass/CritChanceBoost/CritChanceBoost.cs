using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CritChanceBoost : MonoBehaviour {

	public static float critChance;
	public static bool critChance1;
	public static bool critChanceOn;

	public UnityEngine.UI.Text critSkillNum;
	public static int cost = 25;
	public Transform button;
	public static int curSkillNum;
	public static int maxSkillNum = 10;
	public static float nextLevel = 0.2f;
	public static float firstLevelBonus = 0.4f;

	
	void Awake ()
	{
		button.GetComponent<Button> ().interactable = false;
	}

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
			if (curSkillNum == maxSkillNum) 
			{
				curSkillNum = maxSkillNum;
				button.GetComponent<Button>().interactable = false;
			}

		critSkillNum.text = curSkillNum + "/" + maxSkillNum;
	}
	
	public void RaiseCritChance()
	{
		if (Materials.materials.gold >= cost)
		{
			curSkillNum++;
			if (critChance >= firstLevelBonus && curSkillNum < maxSkillNum){
				critChance += nextLevel;
			}
			else critChance += critChance;

			if (critChance == 0) 
			{
				critChance = firstLevelBonus;
			}
			Materials.materials.gold -= cost;
			cost = cost * 2;
		}
	}
	
	
	public static void CritChance ()
	{
		float randomTemp = Random.Range (0.1f, 101);
		if (randomTemp <= critChance) {
			 
			critChance1 = true;
		} else {
			critChance1 = false;
		}
		
	}
	public static void GetCritChance(){
		if (GameInformation.isAssassinClass) {
			CritChance ();
		
			if (critChance1) {
				if (!critChanceOn) {
				
				
					GameObject FloatingCrit = Instantiate (Resources.Load ("Prefabs/SinSkills/CritChanceBoostText")) as GameObject;
					FloatingCrit.GetComponent<FloatingCritChance> ().DisplayDamage ();
					FloatingCrit.transform.SetParent ((GameObject.Find ("Boosts").transform), false);
				
				
				}
			}
		}
	}
	

}
