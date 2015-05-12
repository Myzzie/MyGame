using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	public static GameInformation gameInformation;



	void Awake (){
		if (gameInformation == null) 
		{
			gameInformation = this;
			DontDestroyOnLoad(transform.gameObject);
			
		} 
		else if(gameInformation != this) 
		{
			Destroy(gameObject);
		}
	}


	public static bool isWarriorClass;
	public static bool isWizardClass;
	public static bool isAssassinClass;
	public static int PlayerLevel{ get; set;}
	public static BaseCharacterClass PlayerClass{ get; set;}
	public static float BaseMinDamage { get; set;}
	public static float BaseMaxDamage { get; set;}
	public static float AttackSpeed{ get; set;}
	public static float MaxHealth { get; set;}
	public static float BaseCritChance { get; set;}
	public static float BaseEvadeChance { get; set;}


}
