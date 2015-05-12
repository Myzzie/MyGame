using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WarriorStoneShield : MonoBehaviour {


		public static float stoneShieldChance;
		public static bool stoneShieldChance1;
		public static bool stoneShieldOn;
		public static int cost = 100;
		public Transform button;
		
		public UnityEngine.UI.Text stoneShieldNum;
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
			cost = 1000;
		}
		if (curSkillNum == 1)
		{
			cost = 2000;
		}
		if (curSkillNum == 2)
		{
			cost = 4000;
		}
		if (curSkillNum == 3)
		{
			cost = 8000;
		}
		if (curSkillNum == 4)
		{
			cost = 16000;
		}
		if (curSkillNum == 5)
		{
			cost = 32000;
		}
		if (curSkillNum == 6)
		{
			cost = 64000;
		}
		if (curSkillNum == 7)
		{
			cost = 128000;
		}
		if (curSkillNum == 8)
		{
			cost = 256000;
		}
		if (curSkillNum == 9)
		{
			cost = 512000;
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
			
		stoneShieldNum.text = curSkillNum + "/" + maxSkillNum;
		}
		
		public void RaiseStoneShieldChance()
		{
		if (Materials.materials.gold >= cost) 
		{
			curSkillNum++;
			if (stoneShieldChance >= firstLevelBonus && curSkillNum < maxSkillNum){
				stoneShieldChance += nextLevel;
			}
			else stoneShieldChance += stoneShieldChance;
		}
		
		if (stoneShieldChance == 0) 
		{
			stoneShieldChance = firstLevelBonus;
		}
		Materials.materials.gold -= cost;
		cost = cost * 2;
		}
		
		
		
		
		
	public static void StoneShieldChance ()
		{
			int randomTemp = Random.Range (1, 101);
		if (randomTemp <= (int)stoneShieldChance) 
			{
			stoneShieldChance1 = true;
			}
			else{
			stoneShieldChance1 = false;
			}
		}
		
		public static void StoneShield(){
			if (GameInformation.isWarriorClass) {
			StoneShieldChance ();
				
			if (stoneShieldChance1) {
				if (!stoneShieldOn) {
						
					GameObject FloatingStoneShield = Instantiate (Resources.Load ("Prefabs/WarriorSkills/StoneShieldText")) as GameObject;
					FloatingStoneShield.GetComponent<FloatingStoneShield> ().DisplayDamage ();
					FloatingStoneShield.transform.SetParent ((GameObject.Find ("Boosts").transform), false);
					}
				}
				
			}
		}
		
		
		
		
		
		
	}