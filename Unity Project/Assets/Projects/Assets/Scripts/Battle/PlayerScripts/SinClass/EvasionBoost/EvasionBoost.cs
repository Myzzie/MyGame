using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EvasionBoost : MonoBehaviour {

	public static float evadeChance;
	public static bool evadeChance1;
	public static bool evasionOn;

	public UnityEngine.UI.Text evadeSkillNum;

	public static int cost = 10;
	public Transform button;
	public static int curSkillNum;
	public static int maxSkillNum = 10;
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
		if (Materials.materials.gold > cost) 
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
	
		
		if (curSkillNum == maxSkillNum) 
		{
			curSkillNum = maxSkillNum;
			button.GetComponent<Button>().interactable = false;
		}
	
		evadeSkillNum.text = curSkillNum + "/" + maxSkillNum;
	}
	
	public void RaiseEvadeChance()
	{
		if (Materials.materials.gold >= cost) 
		{
			curSkillNum++;
			if (evadeChance >= firstLevelBonus && curSkillNum < maxSkillNum)
			{
				evadeChance += nextLevel;
			}
			else evadeChance += evadeChance;

			if (evadeChance == 0) 
			{
				evadeChance = firstLevelBonus;
			}
			Materials.materials.gold -= cost;
			cost = cost * 2;
		}
	}
	
	
	public static void EvadeChance ()
	{
		float randomTemp = Random.Range (0.1f, 101);
		if (randomTemp <= evadeChance) {
			 
			evadeChance1 = true;
		} else {
			evadeChance1 = false;
		}
		
	}
	public static void Evasion(){
		if (GameInformation.isAssassinClass) {
			EvadeChance ();
		
			if (evadeChance1) {
				if (!evasionOn) {
				
				
					GameObject FloatingEvasion = Instantiate (Resources.Load ("Prefabs/SinSkills/EvasionBoostText")) as GameObject;
					FloatingEvasion.GetComponent<FloatingEvasion> ().DisplayDamage ();
					FloatingEvasion.transform.SetParent ((GameObject.Find ("Boosts").transform), false);
				
				
				}
			}
		}
	}
	

}
