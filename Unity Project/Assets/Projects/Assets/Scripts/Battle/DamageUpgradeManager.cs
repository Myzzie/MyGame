using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DamageUpgradeManager : MonoBehaviour {
	
	public UnityEngine.UI.Text itemInfo;
	public int cost;
	public float count = 0;
	public Color affordable;
	public int damagePower;
	public string itemName;


	
	void Start()
	{

	}
	
	
	
	public void Update()
	{
		
		if (count == 0) {
			itemInfo.text = "Bronze Sword" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Copper ore" + "\nCost: " + cost + " gold";
			
			if (Materials.materials.copperOre >= cost)
				if (Materials.materials.wood >= cost)
				if (Materials.materials.gold >= cost) {
					GetComponent<Image> ().color = affordable;
				} 
		
		} 
		if (count == 1) 
		{
			itemInfo.text = "Iron Sword" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Iron ore" + "\nCost: " + cost + " gold";
			
			if (Materials.materials.ironOre >= cost)
				if (Materials.materials.wood >= cost)
					if (Materials.materials.gold >= cost) 
				{
					GetComponent<Image> ().color = affordable;
				} 
		
		}
		
		if (count == 2) 
		{
			itemInfo.text = "Silver Sword" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Silver ore" + "\nCost: " + cost + " gold";
			
			if (Materials.materials.silverOre >= cost)
				if (Materials.materials.wood >= cost)
					if (Materials.materials.gold >= cost) 
				{
					GetComponent<Image> ().color = affordable;
				} 
	
		}
		
		if (count == 3) 
		{
			itemInfo.text = "Gold Sword" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Gold ore" + "\nCost: " + cost + " gold";
			
			if (Materials.materials.goldOre >= cost)
				if (Materials.materials.wood >= cost)
					if (Materials.materials.gold >= cost) 
				{
					GetComponent<Image> ().color = affordable;
				} 
	
		}
		if (count == 4) 
		{
			itemInfo.text = "Mithril Sword" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Mithril ore" + "\nCost: " + cost + " gold";
			
			if (Materials.materials.mithrilOre >= cost)
				if (Materials.materials.wood >= cost)
					if (Materials.materials.gold >= cost) 
				{
					GetComponent<Image> ().color = affordable;
				} 
		
		}
		if (count == 5) 
		{
			itemInfo.text = "Adamantium Sword" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Adamantite ore" + "\nCost: " + cost + " gold";
			
			if (Materials.materials.adamantiteOre >= cost)
				if (Materials.materials.wood >= cost)
					if (Materials.materials.gold >= cost) 
				{
					GetComponent<Image> ().color = affordable;
				} 
		
		}
		if (count == 6) 
		{
			itemInfo.text = "Rune Sword" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Runite ore" + "\nCost: " + cost + " gold";
			
			if (Materials.materials.runiteOre >= cost)
				if (Materials.materials.wood >= cost)
					if (Materials.materials.gold >= cost) 
				{
					GetComponent<Image> ().color = affordable;
				} 
		
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
				Damage.baseMinDamage += 0.1f;
				Damage.baseMaxDamage += 0.2f;
				cost = 10;
				count += 1;
			}
		
		} else if (count == 1) {
			if (Materials.materials.ironOre >= cost) 
			if (Materials.materials.wood >= cost) 
			if (Materials.materials.gold >= cost) {
				Materials.materials.ironOre -= cost;
				Materials.materials.wood -= cost;
				Materials.materials.gold -= cost;
					Damage.baseMinDamage += 0.1f;
					Damage.baseMaxDamage += 0.2f;
				cost = 10;
				count += 1;
			}
		
		} else if (count == 2) {
			if (Materials.materials.silverOre >= cost) 
			if (Materials.materials.wood >= cost) 
			if (Materials.materials.gold >= cost) {
				Materials.materials.silverOre -= cost;
				Materials.materials.wood -= cost;
				Materials.materials.gold -= cost;
					Damage.baseMinDamage += 0.1f;
					Damage.baseMaxDamage += 0.2f;
				cost = 10;
				count += 1;
			}
		} else if (count == 3) {
			if (Materials.materials.goldOre >= cost) 
			if (Materials.materials.wood >= cost) 
			if (Materials.materials.gold >= cost) {
				Materials.materials.goldOre -= cost;
				Materials.materials.wood -= cost;
				Materials.materials.gold -= cost;
					Damage.baseMinDamage += 0.1f;
					Damage.baseMaxDamage += 0.2f;
				cost = 10;
				count += 1;
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
					Damage.baseMinDamage += 0.1f;
					Damage.baseMaxDamage += 0.2f;
					cost = 10;
					count += 1;
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
					Damage.baseMinDamage += 0.1f;
					Damage.baseMaxDamage += 0.2f;
					cost = 10;
					count += 1;
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
					Damage.baseMinDamage += 0.1f;
					Damage.baseMaxDamage += 0.2f;
					cost = 10;
					count += 1;
				}
		}
	}
}