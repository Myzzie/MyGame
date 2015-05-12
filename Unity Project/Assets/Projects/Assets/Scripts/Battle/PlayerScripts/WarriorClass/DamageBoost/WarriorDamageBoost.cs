using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WarriorDamageBoost : MonoBehaviour {


		public static float damageBoostChance;
		public static bool damageChance1;
		public static bool damageBoostOn;
		public static int cost = 25;
		public Transform button;
		
		public UnityEngine.UI.Text damageSkillNum;
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
	
	
		if (curSkillNum == maxSkillNum) {
			curSkillNum = maxSkillNum;
			button.GetComponent<Button>().interactable = false;
		}

	
			
		damageSkillNum.text = curSkillNum + "/" + maxSkillNum;
		}
		
		public void RaiseDamageBoostChance()
	{
		if (Materials.materials.gold >= cost) 
		{
			curSkillNum++;
			if (damageBoostChance >= firstLevelBonus && curSkillNum < maxSkillNum){
				damageBoostChance += nextLevel;
			}
			else damageBoostChance += damageBoostChance;
		}
		
		if (damageBoostChance == 0) 
		{
			damageBoostChance = firstLevelBonus;
		}
		Materials.materials.gold -= cost;
		cost = cost * 2;
	}
		
		
		
		
		
		public static void DamageBoostChance ()
		{
			int randomTemp = Random.Range (1, 101);
		if (randomTemp <= (int)damageBoostChance) 
			{
			damageChance1 = true;
			}
			else{
			damageChance1 = false;
			}
		}
		
		public static void DamageBoost(){
			if (GameInformation.isWarriorClass) {
			DamageBoostChance ();
				
			if (damageChance1) {
				if (!damageBoostOn) {
						
					GameObject FloatingDamage = Instantiate (Resources.Load ("Prefabs/WarriorSkills/WarriorDamageText")) as GameObject;
					FloatingDamage.GetComponent<FloatingDamageBoost> ().DisplayDamage();
					FloatingDamage.transform.SetParent ((GameObject.Find ("Boosts").transform), false);
					}
				}
				
			}
		}
		
		
		
		
		
		
	}