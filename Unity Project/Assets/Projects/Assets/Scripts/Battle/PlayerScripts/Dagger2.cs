using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Dagger2 : MonoBehaviour {
	
	public UnityEngine.UI.Text itemInfo;
	public UnityEngine.UI.Text itemName;
	public static int cost;
	public static int count;
	public static bool maxPurchased;
	public int damagePower;
	public Button button;
	public Button weapon;
	public Sprite brokenDagger;
	public Sprite bronzeDagger;
	public Sprite ironDagger;
	public Sprite silverDagger;
	public Sprite goldDagger;
	public Sprite mithrilDagger;
	public Sprite adamantiumDagger;
	public Sprite runeDagger;
	public static float dagger2MinDamage;
	public static float dagger2MaxDamage;
	public static float dagger2AttackSpeed;
	
	
	
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
			itemInfo.text = "Bronze Dagger" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Copper ore" + "\nCost: " + cost + " gold";
			itemName.text = "Repair Dagger";
			weapon.image.overrideSprite = brokenDagger;
			
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
			itemInfo.text = "Iron Dagger" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Iron ore" + "\nCost: " + cost + " gold";
			itemName.text = "Bronze Dagger";
			weapon.image.overrideSprite = bronzeDagger;
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
			itemInfo.text = "Silver Dagger" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Silver ore" + "\nCost: " + cost + " gold";
			itemName.text = "Iron Dagger";
			weapon.image.overrideSprite = ironDagger;
			
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
			itemInfo.text = "Gold Dagger" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Gold ore" + "\nCost: " + cost + " gold";
			itemName.text = "Silver Dagger";
			weapon.image.overrideSprite = silverDagger;
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
			itemInfo.text = "Mithril Dagger" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Mithril ore" + "\nCost: " + cost + " gold";
			itemName.text = "Gold Dagger";
			weapon.image.overrideSprite = goldDagger;
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
			itemInfo.text = "Adamantium Dagger" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Adamantite ore" + "\nCost: " + cost + " gold";
			itemName.text = "Mithril Dagger";
			weapon.image.overrideSprite = mithrilDagger;
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
			itemInfo.text = "Rune Dagger" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Runite ore" + "\nCost: " + cost + " gold";
			itemName.text = "Adamantium Dagger";
			weapon.image.overrideSprite = adamantiumDagger;
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
			itemName.text = "Rune Dagger";
			weapon.image.overrideSprite = runeDagger;
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
					dagger2MinDamage += 1;
					dagger2MaxDamage += 2;
					dagger2AttackSpeed += 0.01f;
					count++;
				}
			
		} else if (count == 1) {
			if (Materials.materials.ironOre >= cost) 
				if (Materials.materials.wood >= cost) 
				if (Materials.materials.gold >= cost) {
					Materials.materials.ironOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;
					
					dagger2MinDamage += 1;
					dagger2MaxDamage += 2;
					dagger2AttackSpeed += 0.01f;
					
					count++;
				}
			
		} else if (count == 2) {
			if (Materials.materials.silverOre >= cost) 
				if (Materials.materials.wood >= cost) 
				if (Materials.materials.gold >= cost) {
					Materials.materials.silverOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;
					
					dagger2MinDamage += 2;
					dagger2MaxDamage += 3;
					dagger2AttackSpeed += 0.01f;
					count++;
				}
		} else if (count == 3) {
			if (Materials.materials.goldOre >= cost) 
				if (Materials.materials.wood >= cost) 
				if (Materials.materials.gold >= cost) {
					Materials.materials.goldOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;
					
					dagger2MinDamage += 3;
					dagger2MaxDamage += 4;
					dagger2AttackSpeed += 0.01f;
					
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
					
					dagger2MinDamage += 6;
					dagger2MaxDamage += 8;
					dagger2AttackSpeed += 0.01f;
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
					
					dagger2MinDamage += 11;
					dagger2MaxDamage += 16;
					dagger2AttackSpeed += 0.01f;
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
					
					dagger2MinDamage += 22;
					dagger2MaxDamage += 32;
					dagger2AttackSpeed += 0.01f;
					count++;
					maxPurchased = true;
				}
		}
	}
}