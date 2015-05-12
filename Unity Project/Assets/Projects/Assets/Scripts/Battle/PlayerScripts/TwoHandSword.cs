using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TwoHandSword : MonoBehaviour {
	
	public UnityEngine.UI.Text itemInfo;
	public UnityEngine.UI.Text itemName;
	public static int cost;
	public static int count = 0;
	public static bool maxPurchased;
	public int damagePower;
	public Button button;
	public Button weapon;
	public Sprite brokenSword;
	public Sprite bronzeSword;
	public Sprite ironSword;
	public Sprite silverSword;
	public Sprite goldSword;
	public Sprite mithrilSword;
	public Sprite adamantiumSword;
	public Sprite runeSword;
	public static float twoHandSwordMinDamage;
	public static float twoHandSwordMaxDamage;
	public static float twoHandSwordAttackSpeed;



	
	
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
			itemInfo.text = "Bronze Sword" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Copper ore" + "\nCost: " + cost + " gold";
			itemName.text = "Repair Your Sword";
			weapon.image.overrideSprite = brokenSword;
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
			itemInfo.text = "Iron Sword" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Iron ore" + "\nCost: " + cost + " gold";
			itemName.text = "Bronze Sword";
			weapon.image.overrideSprite = bronzeSword;
			
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
			itemInfo.text = "Silver Sword" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Silver ore" + "\nCost: " + cost + " gold";
			itemName.text = "Iron Sword";
			weapon.image.overrideSprite = ironSword;
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
			itemInfo.text = "Gold Sword" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Gold ore" + "\nCost: " + cost + " gold";
			itemName.text = "Silver Sword";
			weapon.image.overrideSprite = silverSword;
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
			itemInfo.text = "Mithril Sword" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Mithril ore" + "\nCost: " + cost + " gold";
			itemName.text = "Gold Sword";
			weapon.image.overrideSprite = goldSword;
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
			itemInfo.text = "Adamantium Sword" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Adamantite ore" + "\nCost: " + cost + " gold";
			itemName.text = "Mithril Sword";
			weapon.image.overrideSprite = mithrilSword;
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
			itemInfo.text = "Rune Sword" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Runite ore" + "\nCost: " + cost + " gold";
			itemName.text = "Adamantium Sword";
			weapon.image.overrideSprite = adamantiumSword;
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
			itemName.text = "Rune Sword";
			weapon.image.overrideSprite = runeSword;
			button.GetComponent<Button>().interactable = false;
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

						twoHandSwordMinDamage += 6;
						twoHandSwordMaxDamage += 12;
						twoHandSwordAttackSpeed += 0.03f;
				
					cost = 10;
			
					count++;
				}
			
		} else if (count == 1) {
			if (Materials.materials.ironOre >= cost) 
				if (Materials.materials.wood >= cost) 
				if (Materials.materials.gold >= cost) {
					Materials.materials.ironOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;
				
						twoHandSwordMinDamage += 6;
						twoHandSwordMaxDamage += 12;
						twoHandSwordAttackSpeed += 0.03f;
				
					cost = 20;
					count++;
				}
			
		} else if (count == 2) {
			if (Materials.materials.silverOre >= cost) 
				if (Materials.materials.wood >= cost) 
				if (Materials.materials.gold >= cost) {
					Materials.materials.silverOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;

						twoHandSwordMinDamage += 12;
						twoHandSwordMaxDamage += 18;
						twoHandSwordAttackSpeed += 0.03f;
				
					cost = 40;

					count++;
				}
		} else if (count == 3) {
			if (Materials.materials.goldOre >= cost) 
				if (Materials.materials.wood >= cost) 
				if (Materials.materials.gold >= cost) {
					Materials.materials.goldOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;

						twoHandSwordMinDamage += 18;
						twoHandSwordMaxDamage += 24;
						twoHandSwordAttackSpeed += 0.03f;
				
					cost = 80;

					count++;
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
				
						twoHandSwordMinDamage += 36;
						twoHandSwordMaxDamage += 48;
						twoHandSwordAttackSpeed += 0.03f;
				
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

						twoHandSwordMinDamage += 66;
						twoHandSwordMaxDamage += 96;
						twoHandSwordAttackSpeed += 0.03f;
				
					cost = 320;

					count++;
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
				
					twoHandSwordMinDamage += 132;
					twoHandSwordMaxDamage += 192;
					twoHandSwordAttackSpeed += 0.03f;
					count++;
					maxPurchased = true;
				}
		}
	}
}