using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SwordSpeedManager : MonoBehaviour {
	
	public UnityEngine.UI.Text itemInfo;
	public int cost;
	public float count = 0;
	public Color affordable;
	public string itemName;

	
	
	
	void Start()
	{

	}
	
	
	
	public void Update()
	{
		
		if (count == 0) {
			if (GameInformation.isWarriorClass) 
			{
				itemInfo.text = "Bronze Grip" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Copper ore" + "\nCost: " + cost + " gold";
			} 
			if (GameInformation.isWizardClass) 
			{
				itemInfo.text = "Bronze Jewel" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Copper ore" + "\nCost: " + cost + " gold";
			} 
			if (GameInformation.isAssassinClass) 
			{
				itemInfo.text = "Bronze Edge" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Copper ore" + "\nCost: " + cost + " gold";
			}
			
			
			if (Materials.materials.copperOre >= cost)
				if (Materials.materials.wood >= cost)
				if (Materials.materials.gold >= cost) {
					GetComponent<Image> ().color = affordable;
				} 
			
		} 
		if (count == 1) 
		{
			if (GameInformation.isWarriorClass) 
			{
				itemInfo.text = "Iron Grip" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Iron ore" + "\nCost: " + cost + " gold";
			} 
			if (GameInformation.isWizardClass) 
			{
				itemInfo.text = "Iron Jewel" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Iron ore" + "\nCost: " + cost + " gold";
			} 
			if (GameInformation.isAssassinClass) 
			{
				itemInfo.text = "Iron Edge" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Iron ore" + "\nCost: " + cost + " gold";
			}
			if (Materials.materials.ironOre >= cost)
				if (Materials.materials.wood >= cost)
					if (Materials.materials.gold >= cost) 
				{
					GetComponent<Image> ().color = affordable;
				} 
			
		}
		
		if (count == 2) 
		{
			if (GameInformation.isWarriorClass) 
			{
				itemInfo.text = "Silver Grip" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Silver ore" + "\nCost: " + cost + " gold";
			} 
			if (GameInformation.isWizardClass) 
			{
				itemInfo.text = "Silver Jewel" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Silver ore" + "\nCost: " + cost + " gold";
			} 
			if (GameInformation.isAssassinClass) 
			{
				itemInfo.text = "Silver Edge" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Silver ore" + "\nCost: " + cost + " gold";
			}
			
			if (Materials.materials.silverOre >= cost)
				if (Materials.materials.wood >= cost)
					if (Materials.materials.gold >= cost) 
				{
					GetComponent<Image> ().color = affordable;
				} 
			
		}
		
		if (count == 3) 
		{
			if (GameInformation.isWarriorClass) 
			{
				itemInfo.text = "Gold Grip" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Gold ore" + "\nCost: " + cost + " gold";
			} 
			if (GameInformation.isWizardClass) 
			{
				itemInfo.text = "Gold Jewel" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Gold ore" + "\nCost: " + cost + " gold";
			} 
			if (GameInformation.isAssassinClass) 
			{
				itemInfo.text = "Gold Edge" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Gold ore" + "\nCost: " + cost + " gold";
			}
			if (Materials.materials.goldOre >= cost)
				if (Materials.materials.wood >= cost)
					if (Materials.materials.gold >= cost) 
				{
					GetComponent<Image> ().color = affordable;
				} 
			
		}
		if (count == 4) 
		{
			if (GameInformation.isWarriorClass) 
			{
				itemInfo.text = "Mithril Grip" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Mithril ore" + "\nCost: " + cost + " gold";
			} 
			if (GameInformation.isWizardClass) 
			{
				itemInfo.text = "Mithril Jewel" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Mithril ore" + "\nCost: " + cost + " gold";
			} 
			if (GameInformation.isAssassinClass) 
			{
				itemInfo.text = "Mithril Edge" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Mithril ore" + "\nCost: " + cost + " gold";
			}
			if (Materials.materials.mithrilOre >= cost)
				if (Materials.materials.wood >= cost)
					if (Materials.materials.gold >= cost) 
				{
					GetComponent<Image> ().color = affordable;
				} 
			
		}
		if (count == 5) 
		{
			if (GameInformation.isWarriorClass) 
			{
				itemInfo.text = "Adamantium Grip" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Adamantite ore" + "\nCost: " + cost + " gold";
			} 
			if (GameInformation.isWizardClass) 
			{
				itemInfo.text = "Adamantium Jewel" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Adamantite ore" + "\nCost: " + cost + " gold";
			} 
			if (GameInformation.isAssassinClass) 
			{
				itemInfo.text = "Adamantium Edge" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Adamantite ore" + "\nCost: " + cost + " gold";
			}
			if (Materials.materials.adamantiteOre >= cost)
				if (Materials.materials.wood >= cost)
					if (Materials.materials.gold >= cost) 
				{
					GetComponent<Image> ().color = affordable;
				} 
			
		}
		if (count == 6) 
		{
			if (GameInformation.isWarriorClass) 
			{
				itemInfo.text = "Rune Grip" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Runite ore" + "\nCost: " + cost + " gold";
			} 
			if (GameInformation.isWizardClass) 
			{
				itemInfo.text = "Rune Jewel" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Runite ore" + "\nCost: " + cost + " gold";
			} 
			if (GameInformation.isAssassinClass) 
			{
				itemInfo.text = "Rune Edge" + "\nCost: " + cost + " wood" + "\nCost: " + cost + " Runite ore" + "\nCost: " + cost + " gold";
			}
			if (Materials.materials.runiteOre >= cost)
				if (Materials.materials.wood >= cost)
					if (Materials.materials.gold >= cost) 
				{
					GetComponent<Image> ().color = affordable;
				} 
			
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
				Damage.playerAttackSpeedEnhance += 0.01f;
				cost = 50;
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
					Damage.playerAttackSpeedEnhance += 0.01f;
					cost = 50;
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
					Damage.playerAttackSpeedEnhance += 0.01f;
					cost = 50;
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
					Damage.playerAttackSpeedEnhance += 0.01f;
					cost = 50;
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
					Damage.playerAttackSpeedEnhance += 0.01f;
					cost = 50;
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
					Damage.playerAttackSpeedEnhance += 0.01f;
					cost = 50;
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
					Damage.playerAttackSpeedEnhance += 0.01f;
					cost = 50;
					count++;
				}
		}
	}
}