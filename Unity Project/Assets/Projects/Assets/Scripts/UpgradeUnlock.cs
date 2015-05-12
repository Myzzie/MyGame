using UnityEngine;
using System.Collections;

public class UpgradeUnlock : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Materials.materials.woodCuttingLevel >= 10) {
			WoodAmountManager.ShowWoodAmount ();
		}
		if (Materials.materials.woodCuttingLevel >= 25) {
			DoubleWoodChanceManager.ShowDoubleWoodChance ();
		}

		if (Materials.materials.mineLevel >= 10) {
			OreAmountManager.ShowOreAmount ();
		}
		if (Materials.materials.mineLevel >= 25) {
			DoubleOreChanceManager.ShowDoubleOreChance ();
		}
		if (Materials.materials.mineLevel >= 10) {

			Market.unlockIronMarket();
		}
		if (Materials.materials.mineLevel >= 20) {

			Market.unlockSilverMarket();
		}
		if (Materials.materials.mineLevel >= 30) {

			Market.unlockGoldOreMarket();
		}
		if (Materials.materials.mineLevel >= 40) {

			Market.unlockMithrilMarket();
		}
		if (Materials.materials.mineLevel >= 50) {

			Market.unlockAdamantiteMarket();
		}

		if (Materials.materials.fish1 >= 1) {
			EatingFish.ShowFish1 ();
		} 
		if (Materials.materials.battleLevel >= 10) 
		{
			UnlockFishing.ShowFishing();
		}
	
	
		

	}
}
