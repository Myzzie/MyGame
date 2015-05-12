using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Rampage : MonoBehaviour {

	public static float rampageChance;
	public static bool rampageChance1;
	public static bool rampageOn;

	public UnityEngine.UI.Text rampageSkillNum;
	public static int cost = 100;
	public Transform button;
	public static int curSkillNum;
	public static int maxSkillNum = 10;
	public static float nextLevel = 0.1f;
	public static float firstLevelBonus = 0.2f;



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
		
		if (curSkillNum == maxSkillNum) 
		{
			curSkillNum = maxSkillNum;
			button.GetComponent<Button>().interactable = false;
		}
	
		rampageSkillNum.text = curSkillNum + "/" + maxSkillNum;
	}
	
	public void RaiseRampageChance()
	{
		if (Materials.materials.gold >= cost) 
		{
			curSkillNum++;
			if (rampageChance >= firstLevelBonus && curSkillNum < maxSkillNum)
			{
				rampageChance += nextLevel;
			}
			else rampageChance += rampageChance;
		
			if (rampageChance == 0) 
			{
				rampageChance = firstLevelBonus;
			}
			Materials.materials.gold -= cost;
			cost = cost * 2;
		}
	}
	
	
	public static void RampageChance ()
	{
		float randomTemp = Random.Range (0.1f, 101);
		if (randomTemp <= rampageChance) {
			 
			rampageChance1 = true;
		} else {
			rampageChance1 = false;
		}
		
	}
	public static void GetRampage(){
		if (GameInformation.isAssassinClass) {
			RampageChance ();
		
			if (rampageChance1) {
				if (!rampageOn) {
				
				
					GameObject FloatingRampage = Instantiate (Resources.Load ("Prefabs/SinSkills/RampageText")) as GameObject;
					FloatingRampage.GetComponent<FloatingRampage> ().DisplayDamage ();
					FloatingRampage.transform.SetParent ((GameObject.Find ("Boosts").transform), false);
				
				
				}
			}
		}
	}
	

}
