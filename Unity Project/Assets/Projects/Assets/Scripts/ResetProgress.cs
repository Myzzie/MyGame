using UnityEngine;
using System.Collections;

public class ResetProgress : MonoBehaviour {




	
	public void ResetGame()
	{
		PlayerPrefs.DeleteAll();
		
		//Levels
		PlayerPrefs.SetInt("MineLevel", 1);
		PlayerPrefs.SetInt("OreAmount", 1);
		PlayerPrefs.SetInt("BattleLevel", 1);
		PlayerPrefs.SetInt("CritLevel", 1);
		PlayerPrefs.SetInt("EvasionLevel", 1);
		PlayerPrefs.SetInt("LifeLevel", 1);
		PlayerPrefs.SetInt("FishLevel", 1);
		PlayerPrefs.SetInt("WoodCuttingLevel", 1);
		PlayerPrefs.SetFloat("LifeLevelHealth", 1);


		//Ores
		PlayerPrefs.SetFloat("OrePower", 1);
		PlayerPrefs.SetFloat("DoubleOreChance", 5);
		PlayerPrefs.SetFloat("OreAmount", 1);
		PlayerPrefs.SetFloat("BaseOreAmount", 1);
		
		PlayerPrefs.SetFloat("CopperOreDuration", 5);
		PlayerPrefs.SetFloat("IronOreDuration", 10);
		PlayerPrefs.SetFloat("SilverOreDuration", 20);
		PlayerPrefs.SetFloat("GoldOreDuration", 40);
		PlayerPrefs.SetFloat("MithrilOreDuration", 80);
		PlayerPrefs.SetFloat("AdamantiteOreDuration", 160);
		PlayerPrefs.SetFloat("RuniteOreDuration", 320);
		//Wood
		PlayerPrefs.SetFloat("WoodPower", 1);
		PlayerPrefs.SetFloat("DoubleWoodChance", 5);
		PlayerPrefs.SetFloat("WoodAmount", 1);
		PlayerPrefs.SetFloat("BaseWoodAmount", 1);
		//Pet
		PlayerPrefs.SetFloat("PetAttackSpeedEnhance", 1);
		PlayerPrefs.SetFloat("PetDamageEnhance", 1);
		PlayerPrefs.SetFloat("PetCritEnhance", 1);
		PlayerPrefs.SetFloat("PetEvadeEnhance", 1);
		//Player
		PlayerPrefs.SetFloat("PlayerEvadeEnhance", 1);
		PlayerPrefs.SetFloat("PlayerCritEnhance", 1);
		//Fish
		PlayerPrefs.SetInt("FishAmount", 1);
		

		
		GameInformation.isWarriorClass = false;
		GameInformation.isWizardClass = false;
		GameInformation.isAssassinClass = false;
		Application.LoadLevel (0);
	}



}
