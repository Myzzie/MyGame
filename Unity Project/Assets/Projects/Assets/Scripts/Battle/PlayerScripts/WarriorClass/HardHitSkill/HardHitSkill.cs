using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HardHitSkill : MonoBehaviour {

	public static float hardHitChance;

	public static bool hitChance;
	public UnityEngine.UI.Text hardHitSkillNum;
	public static int cost = 25;
	public Transform button;
	public static int curSkillNum;
	public static int maxSkillNum = 5;
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
				if (Materials.materials.battleLevel >= 10)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			
			if (curSkillNum == 1)
			{
				if (Materials.materials.battleLevel >= 15)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 2)
			{
				if (Materials.materials.battleLevel >= 20)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 3)
			{
				if (Materials.materials.battleLevel >= 25)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 4)
			{
				if (Materials.materials.battleLevel >= 30)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 5)
			{
				if (Materials.materials.battleLevel >= 35)
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

		hardHitSkillNum.text = curSkillNum + "/" + maxSkillNum;
	}
	
	public void RaiseHardHitChance()
	{
		if (Materials.materials.gold >= cost) 
		{
			curSkillNum++;
			if (hardHitChance >= firstLevelBonus && curSkillNum < maxSkillNum){
				hardHitChance += nextLevel;
			}
			else hardHitChance += hardHitChance;
		}
		
		if (hardHitChance == 0) 
		{
			hardHitChance = firstLevelBonus;
		}
		Materials.materials.gold -= cost;
		cost = cost * 2;
	}


	public static int GetHardHit()
	{

		if (hitChance) 
			{

			return (int)Damage.playerDamage * 10;
			
			} else {

				return 0;
			
			}

	}




	public static void HitChance ()
	{
		int randomTemp = Random.Range (1, 101);
		if (randomTemp <= (int)hardHitChance) {
				hitChance = true;
			} 
		 else{
				hitChance = false;
			}
	}




	

}

	



