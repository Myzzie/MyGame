using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Staff : MonoBehaviour {
	
	public UnityEngine.UI.Text itemInfo;
	public UnityEngine.UI.Text itemName;
	public static int cost;
	public static int count;
	public static bool maxPurchased;
	public int damagePower;
	public Button button;
	public Button weapon;
	public Sprite brokenStaff;
	public Sprite bronzeStaff;
	public Sprite ironStaff;
	public Sprite silverStaff;
	public Sprite goldStaff;
	public Sprite mithrilStaff;
	public Sprite adamantiumStaff;
	public Sprite runeStaff;
	public static float staffMinDamage;
	public static float staffMaxDamage;
	public static float staffAttackSpeed;


	
	
	void Start()
	{



	}
	
	
	
	public void Update()
	{

		if (maxPurchased)
		{
			button.GetComponent<Button>().interactable = false;
		}
		
		if (count == 0) {

			cost = 10;
			itemInfo.text = "Bronze Staff" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Copper ore" + "\nCost: " + cost + " gold";
			itemName.text = "Repair Your Staff";
			weapon.image.overrideSprite = brokenStaff;
			if (Materials.materials.copperOre >= cost && Materials.materials.wood >= cost && Materials.materials.gold >= cost)
				
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
			
		} 
		if (count == 1) 
		{
		
			cost = 20;
			itemInfo.text = "Iron Staff" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Iron ore" + "\nCost: " + cost + " gold";
			itemName.text = "Bronze Staff";
			weapon.image.overrideSprite = bronzeStaff;

			if (Materials.materials.ironOre >= cost && Materials.materials.wood >= cost && Materials.materials.gold >= cost)
				
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
			
		}
		
		if (count == 2) 
		{
			cost = 40;
			itemInfo.text = "Silver Staff" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Silver ore" + "\nCost: " + cost + " gold";
			itemName.text = "Iron Staff";
			weapon.image.overrideSprite = ironStaff;
			if (Materials.materials.silverOre >= cost && Materials.materials.wood >= cost && Materials.materials.gold >= cost)
				
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
			
		}
		
		if (count == 3) 
		{
		
			cost = 80;
			itemInfo.text = "Gold Staff" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Gold ore" + "\nCost: " + cost + " gold";
			itemName.text = "Silver Staff";
			weapon.image.overrideSprite = silverStaff;
			if (Materials.materials.goldOre >= cost && Materials.materials.wood >= cost && Materials.materials.gold >= cost)
				
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
			
		}
		if (count == 4) 
		{
		
			cost = 160;
			itemInfo.text = "Mithril Staff" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Mithril ore" + "\nCost: " + cost + " gold";
			itemName.text = "Gold Staff";
			weapon.image.overrideSprite = goldStaff;
			if (Materials.materials.mithrilOre >= cost && Materials.materials.wood >= cost && Materials.materials.gold >= cost)
				
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
			
		}
		if (count == 5) 
		{
		
			cost = 320;
			itemInfo.text = "Adamantium Staff" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Adamantite ore" + "\nCost: " + cost + " gold";
			itemName.text = "Mithril Staff";
			weapon.image.overrideSprite = mithrilStaff;
			if (Materials.materials.adamantiteOre >= cost && Materials.materials.wood >= cost && Materials.materials.gold >= cost)
				
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
			
		}
		if (count == 6) 
		{
		
			cost = 640;
			itemInfo.text = "Rune Staff" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Runite ore" + "\nCost: " + cost + " gold";
			itemName.text = "Adamantium Staff";
			weapon.image.overrideSprite = adamantiumStaff;
			if (Materials.materials.runiteOre >= cost && Materials.materials.wood >= cost && Materials.materials.gold >= cost)
				
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
			
		}
		if (count == 7) 
		{
			itemName.text = "Rune Staff";
			weapon.image.overrideSprite = runeStaff;
		}
	
	}
	
	
	
	public void GoldPurchasedUpgrade()
	{
		
		if (count == 0) {
			if (Materials.materials.copperOre >= cost) 
				if (Materials.materials.wood >= cost) 
				if (Materials.materials.gold >= cost) {
					Materials.materials.copperOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;
				
					staffMinDamage += 4;
					staffMaxDamage += 8;
					staffAttackSpeed += 0.02f;
					cost = 10;
					count ++;
				}
			
		} else if (count == 1) {
			if (Materials.materials.ironOre >= cost) 
				if (Materials.materials.wood >= cost) 
				if (Materials.materials.gold >= cost) {
					Materials.materials.ironOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;
			
					staffMinDamage += 4;
					staffMaxDamage += 8;
					staffAttackSpeed += 0.02f;
					cost = 20;
					count ++;
				}
			
		} else if (count == 2) {
			if (Materials.materials.silverOre >= cost) 
				if (Materials.materials.wood >= cost) 
				if (Materials.materials.gold >= cost) {
					Materials.materials.silverOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;
			
					staffMinDamage += 8;
					staffMaxDamage += 12;
					staffAttackSpeed += 0.02f;
					cost = 40;
					count ++;
				}
		} else if (count == 3) {
			if (Materials.materials.goldOre >= cost) 
				if (Materials.materials.wood >= cost) 
				if (Materials.materials.gold >= cost) {
					Materials.materials.goldOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;
			
					staffMinDamage += 12;
					staffMaxDamage += 16;
					staffAttackSpeed += 0.02f;
					cost = 80;
					count ++;
				}
		}
		else if (count == 4) 
		{
			if (Materials.materials.mithrilOre >= cost) 
				if (Materials.materials.wood >= cost) 
					if (Materials.materials.gold >= cost) 
				{
					Materials.materials.mithrilOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;
			
					staffMinDamage += 24;
					staffMaxDamage += 32;
					staffAttackSpeed += 0.02f;
					cost = 160;
					count++;
				}
		}
		else if (count == 5) 
		{
			if (Materials.materials.adamantiteOre >= cost) 
				if (Materials.materials.wood >= cost) 
					if (Materials.materials.gold >= cost) 
				{
					Materials.materials.adamantiteOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;
			
					staffMinDamage += 44;
					staffMaxDamage += 64;
					staffAttackSpeed += 0.02f;
					cost = 320;
					count ++;
				}
		}
		else if (count == 6) 
		{
			if (Materials.materials.runiteOre >= cost) 
				if (Materials.materials.wood >= cost) 
					if (Materials.materials.gold >= cost) 
				{
					Materials.materials.runiteOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;

					staffMinDamage += 88;
					staffMaxDamage += 128;
					staffAttackSpeed += 0.02f;
					count ++;
					maxPurchased = true;
				}
		}
	}
}