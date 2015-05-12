using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WoodItemManager : MonoBehaviour {
	
	public UnityEngine.UI.Text itemInfo;
	public int cost;
	public static int count;
	public Transform button;
	public string itemName;
	public static bool autoTick;
	public int oreCost;
	public int goldCost;
	public int woodCost;



	
	void Start()
	{

	}
	
	void Update ()
	{
		
		if (count == 0) 
		{
			oreCost = 10;
			woodCost = 20;
			goldCost = 30;
			itemInfo.text = itemName + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Copper Ore" + "\nCost: " + goldCost + " gold";
			
			if (Materials.materials.copperOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost)

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
			WoodPerSec.lumberJacks = 1;
			oreCost = 50;
			woodCost = 100;
			goldCost = 200;
			itemInfo.text = itemName + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Iron Ore" + "\nCost: " + goldCost + " gold";
			
			if (Materials.materials.ironOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost)
				
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
			WoodPerSec.lumberJacks = 2;
			oreCost = 100;
			woodCost = 200;
			goldCost = 400;
			itemInfo.text = itemName + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Silver Ore" + "\nCost: " + goldCost + " gold";
			
			if (Materials.materials.silverOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost)
				
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
			WoodPerSec.lumberJacks = 3;
			oreCost = 200;
			woodCost = 400;
			goldCost = 800;
			itemInfo.text = itemName + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Gold Ore" + "\nCost: " + goldCost + " gold";
			
			if (Materials.materials.goldOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost)
				
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
			WoodPerSec.lumberJacks = 4;
			oreCost = 400;
			woodCost = 800;
			goldCost = 1600;
			itemInfo.text = itemName + "\nCost: " + cost + " wood" + "\nCost: " + oreCost + " Mithril Ore" + "\nCost: " + goldCost + " gold";
			
			if (Materials.materials.mithrilOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost)
				
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
			WoodPerSec.lumberJacks = 5;
			oreCost = 800;
			woodCost = 1600;
			goldCost = 3200;
			itemInfo.text = itemName + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Adamantite Ore" + "\nCost: " + goldCost + " gold";
			
			if (Materials.materials.adamantiteOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost)
				
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
			WoodPerSec.lumberJacks = 6;
			oreCost = 1600;
			woodCost = 3200;
			goldCost = 6400;
			itemInfo.text = itemName + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Runite Ore" + "\nCost: " + goldCost + " gold";
			
			if (Materials.materials.runiteOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost)
				
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
			WoodPerSec.lumberJacks = 7;
			button.GetComponent<Button>().interactable = false;
		}
	}
	
	public void PurchasedItem ()
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
					count++;
					autoTick = true;
					WoodPerSec.lumberJack1 = true;
					StartCoroutine (WoodPerSec.FirstLumberJack());
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

					WoodPerSec.lumberJack2 = true;
			
					count++;
					StartCoroutine (WoodPerSec.SecondLumberJack ());
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

					WoodPerSec.lumberJack3 = true;
				
					count++;
					StartCoroutine (WoodPerSec.ThirdLumberJack ());
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

					WoodPerSec.lumberJack4 = true;
			
					count++;
					StartCoroutine (WoodPerSec.FourthLumberJack ());
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

					WoodPerSec.lumberJack5 = true;
				
					count++;
					StartCoroutine (WoodPerSec.FifthLumberJack ());
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

					WoodPerSec.lumberJack6 = true;
				
					count++;
					StartCoroutine (WoodPerSec.SixthLumberJack ());
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
					count++;
					WoodPerSec.lumberJack7 = true;
					StartCoroutine (WoodPerSec.SeventhLumberJack ());
				}
		
		}
	}



}