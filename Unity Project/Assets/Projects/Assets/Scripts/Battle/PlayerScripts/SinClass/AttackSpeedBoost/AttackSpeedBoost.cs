using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AttackSpeedBoost : MonoBehaviour {

	public static float speedChance;
	public static bool speedChance1;
	public static bool speedOn;

	public UnityEngine.UI.Text speedSkillNum;
	public static int cost = 100;
	public Transform button;
	public static int curSkillNum;
	public static int maxSkillNum = 10;
	public static float skillPower;
	public static float nextLevel = 0.1f;
	public static float firstLevelBonus = 0.2f;

	

	void Awake ()
	{
		button.GetComponent<Button> ().interactable = false;
	}


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



	
		speedSkillNum.text = curSkillNum + "/" + maxSkillNum;
	}
	
	public void RaiseAttackSpeedChance()
	{
		if (Materials.materials.gold >= cost)
		{
			curSkillNum++;
			if (speedChance >= firstLevelBonus && curSkillNum < maxSkillNum){
				speedChance += nextLevel;
			}
			else speedChance += speedChance;
			
			if (speedChance == 0) 
			{
				speedChance = firstLevelBonus;
			}
			Materials.materials.gold -= cost;
			cost = cost * 2;
		}
	}
	
	
	public static void AttackSpeedChance ()
	{
		float randomTemp = Random.Range (0.1f, 101);
		if (randomTemp <= speedChance) {
			 
			speedChance1 = true;
		} else {
			speedChance1 = false;
		}
		
	}
	public static void AttackSpeed(){
		if (GameInformation.isAssassinClass) {
			AttackSpeedChance ();
		
			if (speedChance1) {
				if (!speedOn) {
				
				
					GameObject FloatingEvasion = Instantiate (Resources.Load ("Prefabs/SinSkills/AttackSpeedBoostText")) as GameObject;
					FloatingEvasion.GetComponent<FloatingAttackSpeed> ().DisplayDamage ();
					FloatingEvasion.transform.SetParent ((GameObject.Find ("Boosts").transform), false);
				
				
				}
			}
		}
	}
	

}
