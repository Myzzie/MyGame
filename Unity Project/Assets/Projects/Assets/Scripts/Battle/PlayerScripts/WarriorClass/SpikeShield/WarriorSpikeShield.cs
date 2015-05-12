using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WarriorSpikeShield : MonoBehaviour {


		public static float spikeShieldChance;
		public static bool spikeShieldChance1;
		public static bool spikeShieldOn;
		public static int cost = 100;
		public Transform button;
		
		public UnityEngine.UI.Text spikeShieldNum;
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
				if (Materials.materials.battleLevel >= 15)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			
			if (curSkillNum == 1)
			{
				if (Materials.materials.battleLevel >= 20)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 2)
			{
				if (Materials.materials.battleLevel >= 25)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 3)
			{
				if (Materials.materials.battleLevel >= 30)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 4)
			{
				if (Materials.materials.battleLevel >= 35)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 5)
			{
				if (Materials.materials.battleLevel >= 40)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 6)
			{
				if (Materials.materials.battleLevel >= 45)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 7)
			{
				if (Materials.materials.battleLevel >= 50)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 8)
			{
				if (Materials.materials.battleLevel >= 55)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 9)
			{
				if (Materials.materials.battleLevel >= 60)
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
			
		spikeShieldNum.text = curSkillNum + "/" + maxSkillNum;
		}
		
		public void RaiseSpikeShieldChance()
		{
		if (Materials.materials.gold >= cost) 
		{
			curSkillNum++;
			if (spikeShieldChance >= firstLevelBonus && curSkillNum < maxSkillNum){
				spikeShieldChance += nextLevel;
			}
			else spikeShieldChance += spikeShieldChance;
		}
		
		if (spikeShieldChance == 0) 
		{
			spikeShieldChance = firstLevelBonus;
		}
		Materials.materials.gold -= cost;
		cost = cost * 2;
		}
		
		
		
		
		
	public static void StoneShieldChance ()
		{
			int randomTemp = Random.Range (1, 101);
		if (randomTemp <= (int)spikeShieldChance) 
			{
			spikeShieldChance1 = true;
			}
			else{
			spikeShieldChance1 = false;
			}
		}
		
		public static void SpikeShield(){
			if (GameInformation.isWarriorClass) {
			StoneShieldChance ();
				
			if (spikeShieldChance1) {
				if (!spikeShieldOn) {
						
					GameObject FloatingSpikeShield = Instantiate (Resources.Load ("Prefabs/WarriorSkills/SpikeShieldText")) as GameObject;
					FloatingSpikeShield.GetComponent<FloatingSpikeShield> ().DisplayDamage ();
					FloatingSpikeShield.transform.SetParent ((GameObject.Find ("Boosts").transform), false);
					}
				}
				
			}
		}
		
		
		
		
		
		
	}