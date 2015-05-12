using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Market : MonoBehaviour {





	private int convertAdamantiteCost = 2;

	private int convertMithrilCost = 3;

	private int convertGoldOreCost = 4;

	private int convertSilverCost = 5;

	private int convertIronCost = 5;

	private int convertCopperCost = 5;


	private int convertAmount = 1;


	private bool convertOneMineral;
	private bool convertTenMinerals;
	private bool convertHundredMinerals;

	public GameObject tooltip;
	public UnityEngine.UI.Text Tooltip;
	public static bool ironMarketUnlock;
	public static bool silverMarketUnlock;
	public static bool goldOreMarketUnlock;
	public static bool mithrilMarketUnlock;
	public static bool adamantiteMarketUnlock;



	public GameObject ironMarketConvert;

	public GameObject silverMarketConvert;

	public GameObject goldOreMarketConvert;

	public GameObject mithrilMarketConvert;

	public GameObject adamantiteMarketConvert;




	public GameObject convertAllIron;
	public GameObject convertAllSilver;
	public GameObject convertAllGoldOre;
	public GameObject convertAllMithril;
	public GameObject convertAllAdamantite;

	public Button convertOneMineralButton;
	public Button convertTenMineralsButton;
	public Button convertHundredMineralsButton;


	
	void Awake()
	{
		ironMarketConvert.SetActive(false);

		silverMarketConvert.SetActive(false);
	
		goldOreMarketConvert.SetActive(false);
	
		mithrilMarketConvert.SetActive(false);

		adamantiteMarketConvert.SetActive(false);



		convertAllIron.SetActive(false);
		convertAllSilver.SetActive(false);
		convertAllGoldOre.SetActive(false);
		convertAllMithril.SetActive(false);
		convertAllAdamantite.SetActive(false);


		convertOneMineral = true;

		convertOneMineralButton.GetComponent<Button>().interactable = false;
		convertTenMineralsButton.GetComponent<Button>().interactable = true;
		convertHundredMineralsButton.GetComponent<Button>().interactable = true;

	}

	// Update is called once per frame
	void Update () 
	{
		if (ironMarketUnlock)
		{
			ironMarketConvert.SetActive(true);
		
			convertAllIron.SetActive(true);

		}
		if (silverMarketUnlock)
		{
			silverMarketConvert.SetActive(true);
		
			convertAllSilver.SetActive(true);
		}
		if (goldOreMarketUnlock)
		{
			goldOreMarketConvert.SetActive(true);
		
			convertAllGoldOre.SetActive(true);
		}
		if (mithrilMarketUnlock)
		{
			mithrilMarketConvert.SetActive(true);
	
			convertAllMithril.SetActive(true);
		}
		if (adamantiteMarketUnlock)
		{
			adamantiteMarketConvert.SetActive(true);
		
			convertAllAdamantite.SetActive(true);
		}
		/*
		if (runiteMarketUnlock)
		{
			runiteMarketConvert.SetActive(true);
		
			convertAllRunite.SetActive(true);
		}
		*/


	


	}

	
	// Use this for initialization
	void Start () {
		tooltip.SetActive (false);
		
	}

	public static void unlockIronMarket()
	{
		ironMarketUnlock = true;
	}
	public static void unlockSilverMarket()
	{
		silverMarketUnlock = true;
	}
	public static void unlockGoldOreMarket()
	{
		goldOreMarketUnlock = true;
	}
	public static void unlockMithrilMarket()
	{
		mithrilMarketUnlock = true;
	}
	public static void unlockAdamantiteMarket()
	{
		adamantiteMarketUnlock = true;
	}
	/*
	public static void unlockRuniteMarket()
	{
		runiteMarketUnlock = true;
	}
	*/

	//Convert Ore Hover
	public void ConvertCopperHover () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Convert " + convertCopperCost + " Copper Ore into " + convertAmount + " Iron Ore";
	}
	public void ConvertIronHover () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Convert " + convertIronCost + " Iron Ore into " + convertAmount + " Silver Ore";
	}
	public void ConvertSilverHover () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Convert " + convertSilverCost + " Silver Ore into " + convertAmount + " Gold Ore";
	}
	public void ConvertGoldHover () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Convert " + convertGoldOreCost + " Gold Ore into " + convertAmount + " Mithril Ore";
	}
	public void ConvertMithrilHover () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Convert " + convertMithrilCost + " Mithril Ore into " + convertAmount + " Adamantite Ore";
	}
	public void ConvertAdamantiteHover () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Convert " + convertAdamantiteCost + " Adamantite Ore into " + convertAmount + " Runite Ore";
	}
	/*
	public void ConvertRuniteHover () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Convert " + convertAmount + " Runite Ore for " + convertRuniteCost + " gold";
	}




	// Ore Hover
	public void CopperHover () 
	{
		tooltip.SetActive(true);
		Tooltip.text = " " + Amount + " Copper Ore for " + CopperCost + " gold";
	}
	public void IronHover () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Convert " + Amount + " Iron Ore into " + CopperCost + " Copper Ore";
	}
	public void SilverHover () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Convert " + Amount + " Silver Ore into " + IronCost + " Iron Ore";
	}
	public void GoldHover () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Convert " + Amount + " Gold Ore into " + SilverCost + " Silver Ore";
	}
	public void MithrilHover () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Convert " + Amount + " Mithril Ore into " + GoldOreCost + " Gold Ore";
	}
	public void AdamantiteHover () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Convert " + Amount + " Adamantite Ore into " + MithrilCost + " Mithril Ore";
	}
	public void RuniteHover () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Convert " + Amount + " Runite Ore for " + AdamantiteCost + " Adamantite Ore";
	}

	// Convert Wood Hover
	public void ConvertWoodHover () 
	{
		tooltip.SetActive(true);
		Tooltip.text = "Convert " + convertAmount + " Wood for " + convertWoodCost + " gold";
	}

	// Wood Hover
	public void WoodHover () 
	{
		tooltip.SetActive(true);
		Tooltip.text = " " + Amount + " Wood for " + WoodCost + " gold";
	}
	*/
	//OnMouseExit
	public void OnMouseExit ()
	{
		tooltip.SetActive(false);
	}

	//Convert Ore
	public void ConvertCopperUp()
	{
		if (Materials.materials.copperOre >= convertCopperCost )
		{
			if (convertOneMineral){
			Materials.materials.ironOre += convertAmount;
				Materials.materials.copperOre -= convertCopperCost ;
			}
			else if (convertTenMinerals){
				Materials.materials.ironOre += convertAmount;
				Materials.materials.copperOre -= convertCopperCost ;
			}
			else if (convertHundredMinerals){
				Materials.materials.ironOre += convertAmount;
				Materials.materials.copperOre -= convertCopperCost ;
			}
		}
	
	}
	public void ConvertIronUp()
	{
		if (Materials.materials.ironOre >= convertIronCost )
		{
			if (convertOneMineral){
				Materials.materials.silverOre += convertAmount;
				Materials.materials.ironOre -= convertIronCost ;
			}
			if (convertTenMinerals){
				Materials.materials.silverOre += convertAmount;
				Materials.materials.ironOre -= convertIronCost ;
			}
			if (convertHundredMinerals){
				Materials.materials.silverOre += convertAmount;
				Materials.materials.ironOre -= convertIronCost ;
			}
		}
	}
	public void ConvertSilverUp()
	{
		if (Materials.materials.silverOre >= convertSilverCost)
		{
			if (convertOneMineral){
				Materials.materials.goldOre += convertAmount;
				Materials.materials.silverOre -= convertSilverCost ;
			}
			if (convertTenMinerals){
				Materials.materials.goldOre += convertAmount;
				Materials.materials.silverOre -= convertSilverCost ;
			}
			if (convertHundredMinerals){
				Materials.materials.goldOre += convertAmount;
				Materials.materials.silverOre -= convertSilverCost ;
			}
		}
	}
	public void ConvertGoldUp()
	{
		if (Materials.materials.goldOre >= convertGoldOreCost )
		{
			if (convertOneMineral){
				Materials.materials.mithrilOre += convertAmount;
				Materials.materials.goldOre -= convertGoldOreCost ;
			}
			if (convertTenMinerals){
				Materials.materials.mithrilOre += convertAmount;
				Materials.materials.goldOre -= convertGoldOreCost ;
			}
			if (convertHundredMinerals){
				Materials.materials.mithrilOre += convertAmount;
				Materials.materials.goldOre -= convertGoldOreCost ;
			}
		}
	}
	public void ConvertMithrilUp()
	{
		if (Materials.materials.mithrilOre >= convertMithrilCost )
		{
			if (convertOneMineral){
				Materials.materials.adamantiteOre += convertAmount;
				Materials.materials.mithrilOre -= convertMithrilCost ;
			}
			if (convertTenMinerals){
				Materials.materials.adamantiteOre += convertAmount;
				Materials.materials.mithrilOre -= convertMithrilCost ;
			}
			if (convertHundredMinerals){
				Materials.materials.adamantiteOre += convertAmount;
				Materials.materials.mithrilOre -= convertMithrilCost ;
			}
		}
	}
	public void ConvertAdamantiteUp()
	{
		if (Materials.materials.adamantiteOre >= convertAdamantiteCost )
		{
			if (convertOneMineral){
				Materials.materials.runiteOre += convertAmount;
				Materials.materials.adamantiteOre -= convertAdamantiteCost ;
			}
			if (convertTenMinerals){
				Materials.materials.runiteOre += convertAmount;
				Materials.materials.adamantiteOre -= convertAdamantiteCost ;
			}
			if (convertHundredMinerals){
				Materials.materials.runiteOre += convertAmount;
				Materials.materials.adamantiteOre -= convertAdamantiteCost ;
			}
		}
	}
	/*
	public void ConvertRunite()
	{
		if (Materials.materials.runiteOre >= convertAmount)
		{
			if (convertOneMineral){
				Materials.materials.gold += convertRuniteCost;
				Materials.materials.runiteOre -= convertAmount;
			}
			if (convertTenMinerals){
				Materials.materials.gold += convertRuniteCost;
				Materials.materials.runiteOre -= convertAmount;
			}
			if (convertHundredMinerals){
				Materials.materials.gold += convertRuniteCost;
				Materials.materials.runiteOre -= convertAmount;
			}
		}
	}

	// Ore
	public void Copper()
	{
		if (Materials.materials.gold >= CopperCost)
		{
			if (convertOneMineral){
			Materials.materials.copperOre++;
				Materials.materials.gold -= CopperCost;
			}
			if (convertTenMinerals){
				Materials.materials.copperOre += convertAmount;
				Materials.materials.gold -= CopperCost;
			}
			if (convertHundredMinerals){
				Materials.materials.copperOre += convertAmount;
				Materials.materials.gold -= CopperCost;
			}
		}
	}

	public void ConvertIronDown()
	{
		if (Materials.materials.ironOre >= convertAmount)
		{
			if (convertOneMineral){
				Materials.materials.copperOre += IronCost;
				Materials.materials.ironOre -= convertAmount;
			}
			if (convertTenMinerals){
				Materials.materials.copperOre += IronCost;
				Materials.materials.ironOre -= convertAmount;
			}
			if (convertHundredMinerals){
				Materials.materials.copperOre += IronCost;
				Materials.materials.ironOre -= convertAmount ;
			}
		}
	}
	public void ConvertSilverDown()
	{
		if (Materials.materials.silverOre >= convertAmount )
		{
			if (convertOneMineral){
				Materials.materials.ironOre += SilverCost;
				Materials.materials.silverOre -= convertAmount ;
			}
			if (convertTenMinerals){
				Materials.materials.ironOre += SilverCost;
				Materials.materials.silverOre -= convertAmount ;
			}
			if (convertHundredMinerals){
				Materials.materials.ironOre += SilverCost;
				Materials.materials.silverOre -= convertAmount ;
			}
		}
	}
	public void ConverGoldDown()
	{
		if (Materials.materials.goldOre >= convertAmount )
		{
			if (convertOneMineral){
				Materials.materials.silverOre += GoldOreCost;
				Materials.materials.goldOre -= convertAmount ;
			}
			if (convertTenMinerals){
				Materials.materials.silverOre += GoldOreCost;
				Materials.materials.goldOre -= convertAmount ;
			}
			if (convertHundredMinerals){
				Materials.materials.silverOre += GoldOreCost;
				Materials.materials.goldOre -= convertAmount ;
			}
		}
	}
	public void ConvertMithrilDown()
	{
		if (Materials.materials.mithrilOre >= convertAmount )
		{
			if (convertOneMineral){
				Materials.materials.goldOre += MithrilCost;
				Materials.materials.mithrilOre -= convertAmount ;
			}
			if (convertTenMinerals){
				Materials.materials.goldOre += MithrilCost;
				Materials.materials.mithrilOre -= convertAmount ;
			}
			if (convertHundredMinerals){
				Materials.materials.goldOre += MithrilCost;
				Materials.materials.mithrilOre -= convertAmount ;
			}
		}
	}
	public void ConvertAdamantiteDown()
	{
		if (Materials.materials.adamantiteOre >= convertAmount )
		{
			if (convertOneMineral){
				Materials.materials.mithrilOre += AdamantiteCost;
				Materials.materials.adamantiteOre -= convertAmount ;
			}
			if (convertTenMinerals){
				Materials.materials.mithrilOre += AdamantiteCost;
				Materials.materials.adamantiteOre -= convertAmount ;
			}
			if (convertHundredMinerals){
				Materials.materials.mithrilOre += AdamantiteCost;
				Materials.materials.adamantiteOre -= convertAmount ;
			}
		}
	}
	public void ConvertRuniteDown()
	{
		if (Materials.materials.runiteOre >= convertAmount )
		{
			if (convertOneMineral){
				Materials.materials.adamantiteOre += RuniteCost;
				Materials.materials.runiteOre -= convertAmount ;
			}
			if (convertTenMinerals){
				Materials.materials.adamantiteOre += RuniteCost;
				Materials.materials.runiteOre -= convertAmount ;
			}
			if (convertHundredMinerals){
				Materials.materials.adamantiteOre += RuniteCost;
				Materials.materials.runiteOre -= convertAmount ;
			}
		}
	}


	//Convert Wood
	public void ConvertWood()
	{
		if (Materials.materials.wood >= convertAmount)
		{
			if (convertOneMineral){
				Materials.materials.gold += convertAmount;
				Materials.materials.wood -= convertWoodCost;
			}
			if (convertTenMinerals){
				Materials.materials.gold += convertAmount;
				Materials.materials.wood -= convertWoodCost;
			}
			if (convertHundredMinerals){
				Materials.materials.gold += convertAmount;
				Materials.materials.wood -= convertWoodCost;
			}
		}
	}

	// Wood
	public void Wood()
	{
		if (Materials.materials.gold >= WoodCost)
		{
			if (convertOneMineral){
				Materials.materials.wood += convertAmount;
				Materials.materials.gold -= WoodCost;
			}
			if (convertTenMinerals){
				Materials.materials.wood += convertAmount;
				Materials.materials.gold -= WoodCost;
			}
			if (convertHundredMinerals){
				Materials.materials.wood += convertAmount;
				Materials.materials.gold -= WoodCost;
			}
		}
	}
	*/
	public void ConvertOneMineral()
	{
		convertOneMineral = true;
		convertTenMinerals = false;
		convertHundredMinerals = false;




		convertAdamantiteCost = 2;

		convertMithrilCost = 3;

		convertGoldOreCost = 4;

		convertSilverCost = 5;

		convertIronCost = 5;

		convertCopperCost = 5;


		convertAmount = 1;


		convertOneMineralButton.GetComponent<Button>().interactable = false;
		convertTenMineralsButton.GetComponent<Button>().interactable = true;
		convertHundredMineralsButton.GetComponent<Button>().interactable = true;
	}
	public void ConvertTenMinerals()
	{
		convertOneMineral = false;
		convertTenMinerals = true;
		convertHundredMinerals = false;



	

		convertAdamantiteCost = 20;

		convertMithrilCost = 30;

		convertGoldOreCost = 40;

		convertSilverCost = 50;

		convertIronCost = 50;

		convertCopperCost = 50;


		convertAmount = 10;


		convertOneMineralButton.GetComponent<Button>().interactable = true;
		convertTenMineralsButton.GetComponent<Button>().interactable = false;
		convertHundredMineralsButton.GetComponent<Button>().interactable = true;
	}
	public void ConvertHundredMinerals()
	{
		convertOneMineral = false;
		convertTenMinerals = false;
		convertHundredMinerals = true;




	

		convertAdamantiteCost = 200;

		convertMithrilCost = 300;

		convertGoldOreCost = 400;

		convertSilverCost = 500;

		convertIronCost = 500;
	
		convertCopperCost = 500;


		convertAmount = 100;


		convertOneMineralButton.GetComponent<Button>().interactable = true;
		convertTenMineralsButton.GetComponent<Button>().interactable = true;
		convertHundredMineralsButton.GetComponent<Button>().interactable = false;
	}







}
