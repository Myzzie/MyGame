using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BleedEffect : MonoBehaviour {


	public static float bleedEffectChance;
	public static bool bleedChance;
	public UnityEngine.UI.Text bleedEffectSkillNum;
	public static int cost = 50;
	public Transform button;
	public static int curSkillNum;
	public static int maxSkillNum = 5;
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
			cost = 5000;
		}


			if (Materials.materials.gold >= cost)  
			{
				if (curSkillNum == 0)
				{
					if (Materials.materials.battleLevel >= 20)
					{
						button.GetComponent<Button>().interactable = true;
					}
					else button.GetComponent<Button>().interactable = false;
				}
				
				
				if (curSkillNum == 1)
				{
					if (Materials.materials.battleLevel >= 25)
					{
						button.GetComponent<Button>().interactable = true;
					}
					else button.GetComponent<Button>().interactable = false;
				}
				if (curSkillNum == 2)
				{
					if (Materials.materials.battleLevel >= 30)
					{
						button.GetComponent<Button>().interactable = true;
					}
					else button.GetComponent<Button>().interactable = false;
				}
				
				if (curSkillNum == 3)
				{
					if (Materials.materials.battleLevel >= 35)
					{
						button.GetComponent<Button>().interactable = true;
					}
					else button.GetComponent<Button>().interactable = false;
				}
				
				if (curSkillNum == 4)
				{
					if (Materials.materials.battleLevel >= 40)
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
		bleedEffectSkillNum.text = curSkillNum + "/" + maxSkillNum;
	}
	
	public void RaiseBleedEffectChance()
	{
		if (Materials.materials.gold >= cost) 
		{
			curSkillNum++;
			if (bleedEffectChance >= firstLevelBonus && curSkillNum < maxSkillNum)
			{
				bleedEffectChance += nextLevel;
			}
			else
			{
				bleedEffectChance += bleedEffectChance;
			}

			if (bleedEffectChance == 0) 
			{
				bleedEffectChance = firstLevelBonus;
			}
			Materials.materials.gold -= cost;
			cost = cost * 2;
		}
	}





		 



	
	public static void BleedEffectChance ()
	{
		float randomTemp = Random.Range (0.1f, 101);
		if (randomTemp <= bleedEffectChance) {
			bleedChance = true;
				
		} else
			bleedChance = false;

		
	}

	public static void Bleeding()
	{
		if (GameInformation.isAssassinClass)
		{
			BleedEffectChance ();
			if (bleedChance)
			{
				if (!Bleed.startCoroutine)
				{
				GameObject FloatingBleed = Instantiate (Resources.Load ("Prefabs/SinSkills/BleedEffectText")) as GameObject;
				FloatingBleed.GetComponent<FloatingBleed> ().DisplayDamage ();
				FloatingBleed.transform.SetParent ((GameObject.Find ("Boosts").transform), false);
				}
				
			}
		}
	}
}

