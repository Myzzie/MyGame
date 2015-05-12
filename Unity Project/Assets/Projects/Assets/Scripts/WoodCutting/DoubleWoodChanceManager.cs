using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DoubleWoodChanceManager : MonoBehaviour {
	
	static DoubleWoodChanceManager doubleWoodChanceManager;
	public GameObject instance;
	public UnityEngine.UI.Text itemInfo;
	public static int count = 0;
	public Transform button;
	public string itemName;
	public int oreCost;
	public int goldCost;
	public int coalCost;
	public int woodCost;

	
	

	void Awake()
	{
	
		doubleWoodChanceManager = this;
		doubleWoodChanceManager.instance.SetActive(false);
	}

	
	void Start(){
	
	
	}

	public static void ShowDoubleWoodChance()
	{
		//if instance does not exists return from this function
		
		//enable the loading image object 
		doubleWoodChanceManager.instance.SetActive(true);
	}
	
	
	
	void Update()
	{
		
		
		
		if (count == 0) {
			oreCost = 100;
			woodCost = 50;
			goldCost = 200;
			itemInfo.text = itemName + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Copper ore" + "\nCost: " + goldCost + " gold";
			
			if (Materials.materials.copperOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost)
				
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
		} 
		else if (count == 1) 
		{
			oreCost = 200;
			woodCost = 100;
			goldCost = 400;
			itemInfo.text = itemName + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Iron ore" + "\nCost: " + goldCost + " gold";
			
			if (Materials.materials.ironOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost)
				
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
		}
		else if (count == 2) 
		{
			oreCost = 400;
			woodCost = 200;
			goldCost = 800;
			itemInfo.text = itemName + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Silver ore" + "\nCost: " + goldCost + " gold";
			
			if (Materials.materials.silverOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost)
				
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
		}
		else if (count == 3) 
		{
			oreCost = 800;
			woodCost = 400;
			goldCost = 1600;
			itemInfo.text = itemName + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Gold ore" + "\nCost: " + goldCost + " gold";
			
			if (Materials.materials.goldOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost)
				
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
		}
		else if (count == 4) 
		{
			oreCost = 1600;
			woodCost = 800;
			goldCost = 3200;
			itemInfo.text = itemName + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Mithril ore" + "\nCost: " + goldCost + " gold";
			
			if (Materials.materials.mithrilOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost)
				
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
		}
		else if (count == 5) 
		{
			oreCost = 3200;
			woodCost = 1600;
			goldCost = 6400;
			itemInfo.text = itemName + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Adamantite ore" + "\nCost: " + goldCost + " gold";
			
			if (Materials.materials.adamantiteOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost)
				
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
		}
		else if (count == 6) 
		{
			oreCost = 6400;
			woodCost = 3200;
			goldCost = 12800;
			itemInfo.text = itemName + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Runite ore" + "\nCost: " + goldCost + " gold";
			
			if (Materials.materials.runiteOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost)
				
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
		}
	}
	
	public void WoodPurchasedUpgrade()
	{
		
		if (count == 0) 
		{
			if (Materials.materials.copperOre >= oreCost) 
				if (Materials.materials.wood >= woodCost) 
					if (Materials.materials.gold >= goldCost) 
				{
					Materials.materials.copperOre -= oreCost;
					Materials.materials.wood -= woodCost;
					Materials.materials.gold -= goldCost;
					DoubleWood.doubleChance += 5;
					count++;
					
				}
		}
		else if (count == 1) 
		{
			if (Materials.materials.ironOre >= oreCost) 
				if (Materials.materials.wood >= woodCost) 
					if (Materials.materials.gold >= goldCost) 
				{
					Materials.materials.ironOre -= oreCost;
					Materials.materials.wood -= woodCost;
					Materials.materials.gold -= goldCost;
					DoubleWood.doubleChance += 5;
					count++;
				}
		}
		else if (count == 2) 
		{
			if (Materials.materials.silverOre >= oreCost) 
				if (Materials.materials.wood >= woodCost) 
					if (Materials.materials.gold >= goldCost) 
				{
					Materials.materials.silverOre -= oreCost;
					Materials.materials.wood -= woodCost;
					Materials.materials.gold -= goldCost;
					DoubleWood.doubleChance += 5;
					count++;
				}
		}
		else if (count == 3) 
		{
			if (Materials.materials.goldOre >= oreCost) 
				if (Materials.materials.wood >= woodCost) 
					if (Materials.materials.gold >= goldCost) 
				{
					Materials.materials.goldOre -= oreCost;
					Materials.materials.wood -= woodCost;
					Materials.materials.gold -= goldCost;
					DoubleWood.doubleChance += 5;
					count++;
				}
		}
		else if (count == 4) 
		{
			if (Materials.materials.mithrilOre >= oreCost) 
				if (Materials.materials.wood >= woodCost) 
					if (Materials.materials.gold >= goldCost) 
				{
					Materials.materials.mithrilOre -= oreCost;
					Materials.materials.wood -= woodCost;
					Materials.materials.gold -= goldCost;
					DoubleWood.doubleChance += 5;
					count++;
				}
		}
		else if (count == 5) 
		{
			if (Materials.materials.adamantiteOre >= oreCost) 
				if (Materials.materials.wood >= woodCost) 
					if (Materials.materials.gold >= goldCost) 
				{
					Materials.materials.adamantiteOre -= oreCost;
					Materials.materials.wood -= woodCost;
					Materials.materials.gold -= goldCost;
					DoubleWood.doubleChance += 5;
					count++;
				}
		}
		else if (count == 6) 
		{
			if (Materials.materials.runiteOre >= oreCost) 
				if (Materials.materials.wood >= woodCost) 
					if (Materials.materials.gold >= goldCost) 
				{
					Materials.materials.runiteOre -= oreCost;
					Materials.materials.wood -= woodCost;
					Materials.materials.gold -= goldCost;
					DoubleWood.doubleChance += 5;
					count++;
				}
		}
	}
	
}