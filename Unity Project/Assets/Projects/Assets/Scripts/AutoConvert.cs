using UnityEngine;
using System.Collections;

public class AutoConvert : MonoBehaviour {

	public Market market;


	private float allWood;
	private float allRunite;

	private bool autoSellAllWood;
	private bool autoConvertAllCopper;
	private bool autoConvertAllIron;
	private bool autoConvertAllSilver;
	private bool autoConvertAllGoldOre;
	private bool autoConvertAllMithril;
	private bool autoConvertAllAdamantite;
	private bool autoSellAllRunite;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{


		/*
		if (autoSellAllWood)
		{
			allWood = Materials.materials.wood;
			Materials.materials.wood -= allWood;
			Materials.materials.gold += allWood;
			
		}
		*/
		if (autoConvertAllCopper)
		{
			market.ConvertCopperUp();

		}
		if (autoConvertAllIron)
		{
			market.ConvertIronUp();
		}
		if (autoConvertAllSilver)
		{
			market.ConvertSilverUp();
		}
		if (autoConvertAllGoldOre)
		{
			market.ConvertGoldUp();
		}
		if (autoConvertAllMithril)
		{
			market.ConvertMithrilUp();
		}
		if (autoConvertAllAdamantite)
		{
			market.ConvertAdamantiteUp();
		}
		/*
		if (autoSellAllRunite)
		{
			allRunite = Materials.materials.runiteOre;
			Materials.materials.runiteOre -= allRunite;
			Materials.materials.gold += allRunite * 160;
		}
		*/

	
	}


	/*
	public void SellAllWood()
	{
		autoSellAllWood = !autoSellAllWood; 
		
	}
	*/
	public void ConvertAllCopper()
	{
		autoConvertAllCopper = !autoConvertAllCopper;
		
	}
	public void ConvertAllIron()
	{
		autoConvertAllIron = !autoConvertAllIron;
		
	}
	public void ConvertAllSilver()
	{
		autoConvertAllSilver = !autoConvertAllSilver;
		
	}
	public void ConvertAllGoldOre()
	{
		autoConvertAllGoldOre = !autoConvertAllGoldOre;
		
	}
	public void ConvertAllMithril()
	{
		autoConvertAllMithril = !autoConvertAllMithril;
		
	}
	public void ConvertAllAdamantite()
	{
		autoConvertAllAdamantite = !autoConvertAllAdamantite;
		
	}
	/*
	public void SellAllRunite()
	{
		autoSellAllRunite = !autoSellAllRunite;
		
	}
	*/
}
