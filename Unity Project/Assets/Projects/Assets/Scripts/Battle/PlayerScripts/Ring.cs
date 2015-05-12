using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ring : MonoBehaviour {
	
	public UnityEngine.UI.Text itemInfo;
	public UnityEngine.UI.Text itemName;
	public static int cost;
	public static int count;
	public static bool maxPurchased;
	public static float ringAttackSpeed;
	public Button button;
	public Button ring;
	public Sprite repairRing;
	public Sprite bronzeRing;
	public Sprite ironRing;
	public Sprite silverRing;
	public Sprite goldRing;
	public Sprite mithrilRing;
	public Sprite adamantiumRing;
	public Sprite runeRing;
	
	
	
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
			itemInfo.text = "Bronze Ring" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Copper ore" + "\nCost: " + cost + " gold";
			itemName.text = "Repair Ring";
			ring.image.overrideSprite = repairRing;
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
			cost = 25;
			itemInfo.text = "Iron Ring" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Iron ore" + "\nCost: " + cost + " gold";
			itemName.text = "Bronze Ring";
			ring.image.overrideSprite = bronzeRing;
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
			cost = 50;
			itemInfo.text = "Silver Ring" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Silver ore" + "\nCost: " + cost + " gold";
		
			itemName.text = "Iron Ring";
			ring.image.overrideSprite = ironRing;
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
			cost = 100;
			itemInfo.text = "Gold Ring" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Gold ore" + "\nCost: " + cost + " gold";
			itemName.text = "Silver Ring";
			ring.image.overrideSprite = silverRing;
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
			cost = 200;
			itemInfo.text = "MithrilOre Ring" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Mithril ore" + "\nCost: " + cost + " gold";
			itemName.text = "Gold Ring";
			ring.image.overrideSprite = goldRing;
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
			cost = 400;
			itemInfo.text = "Adamantium Ring" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Adamantite ore" + "\nCost: " + cost + " gold";
			itemName.text = "Mithril Ring";
			ring.image.overrideSprite = mithrilRing;
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
			cost = 800;
			itemInfo.text = "Rune Ring" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Runite ore" + "\nCost: " + cost + " gold";
			itemName.text = "Adamantium Ring";
			ring.image.overrideSprite = adamantiumRing;
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
			itemName.text = "Rune Ring";
			ring.image.overrideSprite = runeRing;
			button.GetComponent<Button>().interactable = false;
		}
	}
	
	
	
	public void SpeedPurchasedUpgrade()
	{
		
		if (count == 0) {
			if (Materials.materials.copperOre >= cost) 
				if (Materials.materials.wood >= cost) 
				if (Materials.materials.gold >= cost) {
					Materials.materials.copperOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;
					ringAttackSpeed += 0.1f;

					count++;
				}
		}
		
		else if (count == 1) 
		{
			if (Materials.materials.ironOre >= cost) 
				if (Materials.materials.wood >= cost) 
					if (Materials.materials.gold >= cost) 
				{
					Materials.materials.ironOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;
					ringAttackSpeed += 0.1f;

					count++;
				}
		}
		else if (count == 2) 
		{
			if (Materials.materials.silverOre >= cost) 
				if (Materials.materials.wood >= cost) 
					if (Materials.materials.gold >= cost) 
				{
					Materials.materials.silverOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;
					ringAttackSpeed += 0.1f;

					count++;

				}
		}
		else if (count == 3) 
		{
			if (Materials.materials.goldOre >= cost) 
				if (Materials.materials.wood >= cost) 
					if (Materials.materials.gold >= cost) 
				{
					Materials.materials.goldOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;
					ringAttackSpeed += 0.1f;
				
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
					ringAttackSpeed += 0.1f;

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
					ringAttackSpeed += 0.1f;
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
					ringAttackSpeed += 0.1f;
					count++;
					maxPurchased = true;
				}
		}
	}
}