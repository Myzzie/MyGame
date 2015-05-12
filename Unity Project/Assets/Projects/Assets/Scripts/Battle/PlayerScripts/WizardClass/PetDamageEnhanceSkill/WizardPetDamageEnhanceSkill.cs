using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WizardPetDamageEnhanceSkill : MonoBehaviour {
	

	public UnityEngine.UI.Text petDamageEnhanceSkillNum;
	public Transform button;
	public static int curSkillNum;
	public static int maxSkillNum = 6;
	public static int cost;
	public static float petDamageEnhance;
	public static float nextPetDamageEnhance = 10;

	
	

	
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
			cost = 5000;
		}
		if (curSkillNum == 3)
		{
			cost = 15000;
		}
		if (curSkillNum == 4)
		{
			cost = 50000;
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
				if (Materials.materials.battleLevel >= 40)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 3)
			{
				if (Materials.materials.battleLevel >= 50)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			
			if (curSkillNum == 4)
			{
				if (Materials.materials.battleLevel >= 60)
				{
					button.GetComponent<Button>().interactable = true;
				}
				else button.GetComponent<Button>().interactable = false;
			}
			if (curSkillNum == 5)
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

		petDamageEnhanceSkillNum.text = curSkillNum + "/" + maxSkillNum;
	}
	
	public void RaisePetDamageEnhance()
	{
		if (Materials.materials.gold >= cost) 
		{
			if (curSkillNum < maxSkillNum - 1){
				Materials.materials.gold -= cost;
				petDamageEnhance += nextPetDamageEnhance;
				PetDamage.petDamageEnhance += 0.1f;
			curSkillNum++;
			}
			else {
				PetDamage.petDamageEnhance += PetDamage.petDamageEnhance - 1;
				petDamageEnhance += petDamageEnhance;

				curSkillNum++;
			}
		}

	}





	
	


}

