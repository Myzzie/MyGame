using UnityEngine;
using System.Collections;

public class OrePerSec : MonoBehaviour {


	public UnityEngine.UI.Text opcDisplay;
	public UnityEngine.UI.Text doubleOreChanceDisplay;
	public OreItemManager [] items;
	public OreItemManager oreItemManager;
	public CopperOre copperOre;
	public IronOre ironOre;
	public SilverOre silverOre;
	public GoldOre goldOre;
	public MithrilOre mithrilOre;
	public AdamantiteOre adamantiteOre;
	public RuniteOre runiteOre;
	public static  float orePower = 1;
	public static  float pickaxeSpeed = 3f;






	void Start ()
	{


	}

	void Update(){

		Mathf.RoundToInt (orePower);
		opcDisplay.text = "Pickaxe Power: " + (orePower).ToString ("f1");
		doubleOreChanceDisplay.text = "Double Ore Chance: " + (DoubleOre.doubleChance).ToString ("f0") + ("%");

	}



	public static IEnumerator GetCopperOre()
	{
		while (true) 
		{
			if(OreItemManager.autoTick)
			{
				yield return new WaitForSeconds(OreDuration.CopperDuration());
				CopperOre.BreakOre();
			}
			else yield return null;
		}
	}
	public static IEnumerator GetIronOre()
	{
		while (true) 
		{
			if(OreItemManager.ironReady)
			{
				yield return new WaitForSeconds(OreDuration.IronDuration());
				IronOre.BreakOre();
			}
			else yield return null;
		}
	}	
	public static IEnumerator GetSilverOre()
	{
		while (true) 
		{
			if(OreItemManager.silverReady)
			{
				yield return new WaitForSeconds(OreDuration.SilverDuration());
				SilverOre.BreakOre();
			}
			else yield return null;
		}
	}
	public static IEnumerator GetGoldOre()
	{
		while (true) 
		{
			if(OreItemManager.goldOreReady)
			{
				yield return new WaitForSeconds(OreDuration.GoldDuration());
				GoldOre.BreakOre();
			}
			else yield return null;
		}
	}
	public static IEnumerator GetMithrilOre()
	{
		while (true) 
		{
			if(OreItemManager.mithrilReady)
			{
				yield return new WaitForSeconds(OreDuration.MithrilDuration());
				MithrilOre.BreakOre();
			}
			else yield return null;
		}
	}
	public static IEnumerator GetAdamantiteOre()
	{
		while (true) 
		{
			if(OreItemManager.adamantiteReady)
			{
				yield return new WaitForSeconds(OreDuration.AdamantiteDuration());
				AdamantiteOre.BreakOre();
			}
			else yield return null;
		}
	}
	public static IEnumerator GetRuniteOre()
	{
		while (true) 
		{
			if(OreItemManager.runiteReady)
			{
				yield return new WaitForSeconds(OreDuration.RuniteDuration());
				RuniteOre.BreakOre();
			}
			else yield return null;
		}
	}

}


