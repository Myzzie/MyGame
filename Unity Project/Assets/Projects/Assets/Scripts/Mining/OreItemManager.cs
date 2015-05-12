using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[System.Serializable]
public class OreItemManager : MonoBehaviour {
	
	public UnityEngine.UI.Text itemInfo;
	public Transform button;
	public string itemName;
	public static int count;
	public static bool autoTick;
	public static bool ironReady;
	public static bool silverReady;
	public static bool goldOreReady;
	public static bool mithrilReady;
	public static bool adamantiteReady;
	public static bool runiteReady;
	public int oreCost;
	public int goldCost;
	public int coalCost;
	public int woodCost;


	void Start(){

	}
	
	void Update ()
	{

		if (count == 0) 
		{
			oreCost = 20;
			woodCost = 10;
			goldCost = 30;
			itemInfo.text = "Copper Minecart" + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Copper Ore" + "\nCost: " + goldCost + " gold";
		
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
			oreCost = 100;
			coalCost = 3;
			woodCost = 50;
			goldCost = 200;
			itemInfo.text = "Iron Minecart" + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Copper Ore" + "\nCost: " + goldCost + " gold" + "\nCost: " + coalCost + " coal";
			
			if (Materials.materials.copperOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost && Materials.materials.coalOre >= coalCost)
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
			oreCost = 200;
			coalCost = 15;
			woodCost = 100;
			goldCost = 400;
			itemInfo.text = "Silver Minecart" + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Iron Ore" + "\nCost: " + goldCost + " gold" + "\nCost: " + coalCost + " coal";
			
		
			if (Materials.materials.ironOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost && Materials.materials.coalOre >= coalCost)
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
			oreCost = 400;
			coalCost = 30;
			woodCost = 200;
			goldCost = 800;
			itemInfo.text = "Golden Minecart" + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Silver Ore" + "\nCost: " + goldCost + " gold" + "\nCost: " + coalCost + " coal";
			
			if (Materials.materials.silverOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost && Materials.materials.coalOre >= coalCost)
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
			oreCost = 800;
			coalCost = 60;
			woodCost = 400;
			goldCost = 1600;
			itemInfo.text = "Mithril Minecart" + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Gold Ore" + "\nCost: " + goldCost + " gold" + "\nCost: " + coalCost + " coal";
			
			if (Materials.materials.goldOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost && Materials.materials.coalOre >= coalCost)
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
			oreCost = 1600;
			coalCost = 150;
			woodCost = 800;
			goldCost = 3200;
			itemInfo.text = "Adamantium Minecart" + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Mithril Ore" + "\nCost: " + goldCost + " gold" + "\nCost: " + coalCost + " coal";
			
			if (Materials.materials.mithrilOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost && Materials.materials.coalOre >= coalCost)
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
			oreCost = 3200;
			coalCost = 300;
			woodCost = 1600;
			goldCost = 6400;
			itemInfo.text = "Rune Minecart" + "\nCost: " + woodCost + " wood" + "\nCost: " + oreCost + " Adamantite Ore" + "\nCost: " + goldCost + " gold" + "\nCost: " + coalCost + " coal";
			
			if (Materials.materials.adamantiteOre >= oreCost && Materials.materials.wood >= woodCost && Materials.materials.gold >= goldCost && Materials.materials.coalOre >= coalCost)
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
		}


	}
	
	public void OrePurchasedItem ()
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
				autoTick = true;
				count++;
			}
		}


			else if (count == 1) 
		{
			if (Materials.materials.copperOre >= oreCost)
			if (Materials.materials.coalOre >= coalCost)
			if (Materials.materials.wood >= woodCost) 
			if (Materials.materials.gold >= goldCost) 
			{
				Materials.materials.copperOre -= oreCost;
				Materials.materials.coalOre -= coalCost;
				Materials.materials.wood -= woodCost;
				Materials.materials.gold -= goldCost;
				IronOre.ShowIronOre ();
				ironReady = true;
				count++;

			}
		
		}
		else if (count == 2) 
		{
			if (Materials.materials.ironOre >= oreCost)
				if (Materials.materials.coalOre >= coalCost)
					if (Materials.materials.wood >= woodCost) 
						if (Materials.materials.gold >= goldCost) 
					{
						Materials.materials.ironOre -= oreCost;
						Materials.materials.coalOre -= coalCost;
						Materials.materials.wood -= woodCost;
						Materials.materials.gold -= goldCost;
						SilverOre.ShowSilverOre ();
						silverReady = true;
						count++;
				}
		
		}
		else if (count == 3) 
		{
			if (Materials.materials.silverOre >= oreCost)
				if (Materials.materials.coalOre >= coalCost)
					if (Materials.materials.wood >= woodCost) 
						if (Materials.materials.gold >= goldCost) 
					{
						Materials.materials.silverOre -= oreCost;
						Materials.materials.coalOre -= coalCost;
						Materials.materials.wood -= woodCost;
						Materials.materials.gold -= goldCost;
						GoldOre.ShowGoldOre ();
						goldOreReady = true;
						count++;
				}
		}
		else if (count == 4) 
		{
			if (Materials.materials.goldOre >= oreCost)
				if (Materials.materials.coalOre >= coalCost)
					if (Materials.materials.wood >= woodCost) 
						if (Materials.materials.gold >= goldCost) 
					{
						Materials.materials.goldOre -= oreCost;
						Materials.materials.coalOre -= coalCost;
						Materials.materials.wood -= woodCost;
						Materials.materials.gold -= goldCost;
						MithrilOre.ShowMithrilOre ();
						mithrilReady = true;
						count++;
				}
		}
		else if (count == 5) 
		{
			if (Materials.materials.mithrilOre >= oreCost)
				if (Materials.materials.coalOre >= coalCost)
					if (Materials.materials.wood >= woodCost) 
						if (Materials.materials.gold >= goldCost) 
					{
						Materials.materials.mithrilOre -= oreCost;
						Materials.materials.coalOre -= coalCost;
						Materials.materials.wood -= woodCost;
						Materials.materials.gold -= goldCost;
						AdamantiteOre.ShowAdamantiteOre ();
						adamantiteReady = true;
						count++;

				}
		}
		else if (count == 6) 
		{
			if (Materials.materials.adamantiteOre >= oreCost)
				if (Materials.materials.coalOre >= coalCost)
					if (Materials.materials.wood >= woodCost) 
						if (Materials.materials.gold >= goldCost) 
					{
						Materials.materials.adamantiteOre -= oreCost;
						Materials.materials.coalOre -= coalCost;
						Materials.materials.wood -= woodCost;
						Materials.materials.gold -= goldCost;
						RuniteOre.ShowRuniteOre ();
						runiteReady = true;
						count++;

						Destroy (gameObject);
				}
		}

		
	}
}