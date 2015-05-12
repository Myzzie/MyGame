using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[System.Serializable]
public class OreUpgradeManager : MonoBehaviour {
	
	public UnityEngine.UI.Text itemInfo;
	public Transform button;
	public static int cost;
	public static int count;
	public static int count1;
	public string itemName;

	private int baseCost = 2;


	
	void Start()
	{
	}
	
	
	
	public void Update()
	{


	


		if (count == 0) {
			itemInfo.text = "Bronze PickAxe" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Copper ore" + "\nCost: " + cost + " gold";
			cost = (int)Mathf.Round (baseCost * Mathf.Pow(2f, count1));
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
			itemInfo.text = "Iron PickAxe" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Iron ore" + "\nCost: " + cost + " gold";
			baseCost = 10;
			cost = (int)Mathf.Round (baseCost * Mathf.Pow(2.1f, count1));
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
			itemInfo.text = "Silver PickAxe" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Silver ore" + "\nCost: " + cost + " gold";
			baseCost = 15;
			cost = (int)Mathf.Round (baseCost * Mathf.Pow(2.2f, count1));
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
			itemInfo.text = "Gold PickAxe" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Gold ore" + "\nCost: " + cost + " gold";
			baseCost = 25;
			cost = (int)Mathf.Round (baseCost * Mathf.Pow(2.3f, count1));
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
			itemInfo.text = "Mithril PickAxe" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Mithril ore" + "\nCost: " + cost + " gold";
			baseCost = 50;
			cost = (int)Mathf.Round (baseCost * Mathf.Pow(2.4f, count1));
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
			itemInfo.text = "Adamantium PickAxe" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Adamantite ore" + "\nCost: " + cost + " gold";
			baseCost = 100;
			cost = (int)Mathf.Round (baseCost * Mathf.Pow(2.5f, count1));
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
			itemInfo.text = "Rune PickAxe" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Runite ore" + "\nCost: " + cost + " gold";
			baseCost = 250;
			cost = (int)Mathf.Round (baseCost * Mathf.Pow(2.6f, count1));
			if (Materials.materials.runiteOre >= cost && Materials.materials.wood >= cost && Materials.materials.gold >= cost)
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
		}
		if (count1 == 10) {
			button.GetComponent<Button>().interactable = false;
		}
	}
	
	public void OrePurchasedUpgrade()
	{
		
		if (count == 0) 
		{
			if (Materials.materials.copperOre >= cost) 
				if (Materials.materials.wood >= cost) 
					if (Materials.materials.gold >= cost) 
				{
					Materials.materials.copperOre -= cost;
					Materials.materials.wood -= cost;
					Materials.materials.gold -= cost;
					OrePerSec.orePower += 0.1f;
					count1++;


				}
			if (count1 == 5)
			{
				count1 = 0;
				count += 1;
				
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
					OrePerSec.orePower += 0.1f;
					count1++;

				}
			if (count1 == 5)
			{
				count1 = 0;
				count += 1;
				
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
					OrePerSec.orePower += 0.1f;
					count1++;

				}
			if (count1 == 5)
			{
				count1 = 0;
				count += 1;
				
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
					OrePerSec.orePower += 0.1f;
					count1++;

				}
			if (count1 == 5)
			{
				count1 = 0;
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
					OrePerSec.orePower += 0.14f;
					count1++;

				}
			if (count1 == 5)
			{
				count1 = 0;
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
					OrePerSec.orePower += 0.16f;
					count1++;

				}
			if (count1 == 5)
			{
				count1 = 0;
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
					OrePerSec.orePower += 0.2f;
					count1++;

				}
			
		}
		
		
		
		
	}
}