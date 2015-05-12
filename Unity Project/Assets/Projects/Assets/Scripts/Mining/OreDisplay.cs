using UnityEngine;
using System.Collections;

public class OreDisplay : MonoBehaviour {
	
	public UnityEngine.UI.Text expDisplay;
	public UnityEngine.UI.Text copperOreDisplay;
	public UnityEngine.UI.Text ironOreDisplay;
	public UnityEngine.UI.Text coalOreDisplay;
	public UnityEngine.UI.Text silverOreDisplay;
	public UnityEngine.UI.Text goldOreDisplay;
	public UnityEngine.UI.Text mithrilOreDisplay;
	public UnityEngine.UI.Text adamantiteOreDisplay;
	public UnityEngine.UI.Text runiteOreDisplay;


	void Start ()
	{
		
		StartCoroutine (OrePerSec.GetCopperOre ());
		StartCoroutine (OrePerSec.GetIronOre ());
		StartCoroutine (OrePerSec.GetSilverOre ());
		StartCoroutine (OrePerSec.GetGoldOre ());
		StartCoroutine (OrePerSec.GetMithrilOre ());
		StartCoroutine (OrePerSec.GetAdamantiteOre ());
		StartCoroutine (OrePerSec.GetRuniteOre ());

		if (OreItemManager.ironReady)
		{
			IronOre.ShowIronOre();
		}
		if (OreItemManager.silverReady)
		{
			SilverOre.ShowSilverOre();
		}
		if (OreItemManager.goldOreReady)
		{
			GoldOre.ShowGoldOre();
		}
		if (OreItemManager.mithrilReady)
		{
			MithrilOre.ShowMithrilOre();
		}
		if (OreItemManager.adamantiteReady)
		{
			AdamantiteOre.ShowAdamantiteOre();
		}
		if (OreItemManager.runiteReady)
		{
			RuniteOre.ShowRuniteOre();
		}
	}



	void Update () {
		copperOreDisplay.text = "" + Materials.materials.copperOre;
		ironOreDisplay.text = "" + Materials.materials.ironOre;
		coalOreDisplay.text = "" + Materials.materials.coalOre;
		silverOreDisplay.text = "" + Materials.materials.silverOre;
		goldOreDisplay.text = "" + Materials.materials.goldOre;
		mithrilOreDisplay.text = "" + Materials.materials.mithrilOre;
		adamantiteOreDisplay.text = "" + Materials.materials.adamantiteOre;
		runiteOreDisplay.text = "" + Materials.materials.runiteOre;
	

	}
	
	

	
}