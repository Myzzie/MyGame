using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DamageItemManager : MonoBehaviour {

	public UnityEngine.UI.Text itemInfo;
	public int cost;
	public int tickValue;
	public static int count;
	public Transform button;
	public string itemName;
	public static bool petReady;
	public GameObject bunny;
	public GameObject rat;
	public GameObject snake;
	public GameObject wolf;

	void Start()
	{

	}

	public void Update()
	{
		
		if (count == 0) {
			itemInfo.text = "Bunny" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Copper ore" + "\nCost: " + cost + " gold";
			
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
			itemInfo.text = "Rat" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Iron ore" + "\nCost: " + cost + " gold";
			
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
			itemInfo.text = "Snake" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Silver ore" + "\nCost: " + cost + " gold";
			
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
			itemInfo.text = "Wolf" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Gold ore" + "\nCost: " + cost + " gold";
			
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
			itemInfo.text = itemName + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Mithril ore" + "\nCost: " + cost + " gold";
			
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
			itemInfo.text = itemName + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Adamantite ore" + "\nCost: " + cost + " gold";
			
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
			itemInfo.text = itemName + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Runite ore" + "\nCost: " + cost + " gold";
			
			if (Materials.materials.runiteOre >= cost && Materials.materials.wood >= cost && Materials.materials.gold >= cost)
				
			{
				button.GetComponent<Button>().interactable = true;
			} 
			else 
			{
				button.GetComponent<Button>().interactable = false;
			}
		}
	}

	public void DamagePurchasedItem ()
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

				
				GameObject Bunny = Instantiate (Resources.Load ("Prefabs/Pets/Bunny")) as GameObject;
				Bunny.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				Bunny.name = "Bunny";
				bunny = GameObject.Find("Bunny");
				PetDamage.minDamage = 1f;
				PetDamage.maxDamage = 2f;		
				PetDamage.petAttackSpeed = 3f;
				PetCriticalDamage.petCritChance = 3f;
				PetEvasion.petEvadeChance = 5f;
				PetHealth.maxHealth = 5f;
				cost = 10;
				petReady = true;
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
				
				Destroy (bunny);
			
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Pets/Rat")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				Clone.name = "Rat";
				rat = GameObject.Find("Rat");
					

				PetDamage.minDamage = 1f;
				PetDamage.maxDamage = 2f;
				PetDamage.petAttackSpeed = 1.5f;
				PetCriticalDamage.petCritChance = 8f;
				PetEvasion.petEvadeChance = 10f;
				PetHealth.maxHealth = 15f;
				cost = 15;
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
				
				
				Destroy (rat);
				
				GameObject Clone = Instantiate (Resources.Load ("Prefabs/Pets/Snake")) as GameObject;
				Clone.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
				Clone.name = "Snake";
				snake = GameObject.Find("Snake");
				PetDamage.minDamage = 5f;
				PetDamage.maxDamage = 15f;
				PetDamage.petAttackSpeed = 5f;
				PetCriticalDamage.petCritChance = 15f;
				PetEvasion.petEvadeChance = 20f;
				PetHealth.maxHealth = 30f;
				cost = 25;
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
					
				
					Destroy (GameObject.Find ("Snake"));
			
					GameObject Clone = Instantiate (Resources.Load ("Prefabs/Pets/Wolf")) as GameObject;
					Clone.transform.SetParent ((GameObject.Find ("PetHolder").transform), false);
					Clone.name = "Wolf";
					wolf = GameObject.Find("Wolf");
					PetDamage.minDamage = 1f;
					PetDamage.maxDamage = 20f;
					PetDamage.petAttackSpeed = 2f;
					PetCriticalDamage.petCritChance = 9f;
					PetEvasion.petEvadeChance = 6f;
					PetHealth.maxHealth = 50f;
					cost = 50;
					count += 1;
				}

			}
		} 


}