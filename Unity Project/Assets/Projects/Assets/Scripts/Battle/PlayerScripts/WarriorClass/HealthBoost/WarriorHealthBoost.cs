using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WarriorHealthBoost : MonoBehaviour {


		public static float healthBoostChance;
		public static bool healthChance1;
		public static bool healthBoostOn;
		public static int cost = 50;
		public Transform button;
		
		public UnityEngine.UI.Text healthSkillNum;
		public static int curSkillNum;
		public static int maxSkillNum = 10;
		public static float nextLevel = 0.25f;
		public static float firstLevelBonus = 0.5f;
		
		
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
		
		if (curSkillNum == maxSkillNum) {
			curSkillNum = maxSkillNum;
			button.GetComponent<Button>().interactable = false;
		}
			
		healthSkillNum.text = curSkillNum + "/" + maxSkillNum;
		}
		
		public void RaiseHealthBoostChance()
		{
		if (Materials.materials.gold >= cost) 
		{
			curSkillNum++;
			if (healthBoostChance >= firstLevelBonus && curSkillNum < maxSkillNum){
				healthBoostChance += nextLevel;
			}
			else healthBoostChance += healthBoostChance;
		}
		
		if (healthBoostChance == 0) 
		{
			healthBoostChance = firstLevelBonus;
		}
		Materials.materials.gold -= cost;
		cost = cost * 2;
		}
		
		
		
		
		
	public static void HealthBoostChance ()
		{
			int randomTemp = Random.Range (1, 101);
		if (randomTemp <= (int)healthBoostChance) 
			{
			healthChance1 = true;
			}
			else{
			healthChance1 = false;
			}
		}
		
		public static void HealthBoost(){
			if (GameInformation.isWarriorClass) {
			HealthBoostChance ();
				
			if (healthChance1) {
				if (!healthBoostOn) {
						
					GameObject FloatingHealth = Instantiate (Resources.Load ("Prefabs/WarriorSkills/WarriorHealthText")) as GameObject;
					FloatingHealth.GetComponent<FloatingHealthBoost> ().DisplayDamage ();
					FloatingHealth.transform.SetParent ((GameObject.Find ("Boosts").transform), false);
					}
				}
				
			}
		}
		
		
		
		
		
		
	}