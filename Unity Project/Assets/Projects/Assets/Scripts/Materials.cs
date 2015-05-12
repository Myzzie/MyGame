using UnityEngine;
using System.Collections;



public class Materials : MonoBehaviour{

	public static Materials materials;

	void Awake (){
		if (materials == null) 
		{
			materials = this;
			DontDestroyOnLoad(transform.gameObject);
			
		} 
		else if(materials != this) 
		{
			Destroy(gameObject);
		}
	}
	
	void Start ()
	{

		warrior = (PlayerPrefs.GetInt("Warrior") != 0);
		wizard = (PlayerPrefs.GetInt("Wizard") != 0);
		assassin = (PlayerPrefs.GetInt("Assassin") != 0);
	

	}


	void Update ()
	{
		combatLevel = (woodCuttingLevel + mineLevel + battleLevel + fishLevel + evasionLevel + critLevel + lifeLevel)/7;
	
	
	}



	public static bool warrior;
	public static bool wizard;
	public static bool assassin;

	public float combatLevel;
	//Coins
	public float gold = 0;
	//Mining
	public float copperOre = 0;
	public float ironOre = 0f;
	public float coalOre = 0f;
	public float silverOre = 0f;
	public float goldOre = 0f;
	public float mithrilOre = 0f;
	public float adamantiteOre = 0f;
	public float runiteOre = 0f;
	public float mineExp = 0f;
	public int mineLevel = 1;


	//Battle
	public float battleExp = 0f;
	public int battleLevel = 1;
	public float critExp = 0f;
	public int critLevel = 1;
	public float evasionExp = 0f;
	public int evasionLevel = 1;
	public float lifeExp;
	public int lifeLevel = 1;

	//Fishing
	public float fishExp = 0f;
	public int fishLevel = 1;
	public int fish1 = 1;
	public int fishAmount = 1;

	//WoodCutting
	public float wood = 0f;
	public float woodCuttingExp = 0f;
	public int woodCuttingLevel = 1;





}