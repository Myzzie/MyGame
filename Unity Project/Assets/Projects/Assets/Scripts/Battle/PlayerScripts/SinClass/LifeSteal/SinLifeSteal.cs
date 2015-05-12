using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SinLifeSteal : MonoBehaviour {

	public static float lifeStealChance;
	public static bool stealChance;
	public UnityEngine.UI.Text lifeStealSkillNum;
	public static int cost = 25;
	public Transform button;
	public static int curSkillNum;
	public static int maxSkillNum = 10;
	public static float nextLevel = 0.75f;
	public static float firstLevelBonus = 1.5f;

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
			

		if (curSkillNum == maxSkillNum) 
			{
				curSkillNum = maxSkillNum;
				
				button.GetComponent<Button>().interactable = false;
			}
		lifeStealSkillNum.text = curSkillNum + "/" + maxSkillNum;
	}
	
	public void RaiseLifeStealChance()
	{
		if (Materials.materials.gold >= cost) 
		{
			curSkillNum++;
			if (lifeStealChance >= firstLevelBonus && curSkillNum < maxSkillNum)
			{
				lifeStealChance += nextLevel;
			}
			else
			{
				lifeStealChance += lifeStealChance;
			}

			if (lifeStealChance == 0) 
			{
				lifeStealChance = firstLevelBonus;
			}
			Materials.materials.gold -= cost;
			cost = cost * 2;
		}
	}


	public static float GetStealHit()
	{

		if (stealChance) 
		{
			return (float)Damage.playerDamage/10;
			}else {
		
			return 0;
			
		}
	}


	
	public static void StealHealthChance ()
	{
		float randomTemp = Random.Range (1, 101);
		if (randomTemp <= lifeStealChance) {
				stealChance = true;
		} else
			stealChance = false;
		
	}

	public static void LifeSteal()
	{
		if (GameInformation.isAssassinClass)
		{
			StealHealthChance ();
			if (stealChance)
			{
				
				GameObject FloatingLifeSteal = Instantiate (Resources.Load ("Prefabs/SinSkills/LifeStealText")) as GameObject;
				FloatingLifeSteal.GetComponent<FloatingLifeSteal> ().DisplayDamage (("+" + GetStealHit().ToString("G")).ToString ());
				FloatingLifeSteal.transform.SetParent ((GameObject.Find ("CanvasBattle").transform), false);
				
				PlayerHealth.currentHealth += GetStealHit();
				
			}
		}
	}
}

