using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateNewCharacter : MonoBehaviour {

	private BasePlayer newPlayer;
	public UnityEngine.UI.Text selectClass;
	public static bool newGame;

	



	void Start ()
	{
		newPlayer = gameObject.AddComponent<BasePlayer>();
	}




	public void Warrior ()
	{
		GameInformation.isWarriorClass = !GameInformation.isWarriorClass;

	}
	public void Wizard ()
	{
		GameInformation.isWizardClass = !GameInformation.isWizardClass;
	}
	public void Assassin ()
	{
		GameInformation.isAssassinClass = !GameInformation.isAssassinClass;;
	}

	private void StoreNewPlayerInfo()
	{

		PlayerHealth.baseMaxHealth = newPlayer.MaxHealth;
		Damage.baseMinDamage = newPlayer.BaseMinDamage;
		Damage.baseMaxDamage = newPlayer.BaseMaxDamage;
		Damage.basePlayerAttackSpeed = newPlayer.AttackSpeed;
		CriticalDamage.baseCritChance = newPlayer.BaseCritChance;
		Evasion.baseEvadeChance = newPlayer.BaseEvadeChance;
	
		if (GameInformation.isWarriorClass){
			Materials.warrior = true;
		}
		else Materials.warrior = false;
		if (GameInformation.isWizardClass){
			Materials.wizard = true;
		}
		else Materials.wizard = false;
		if (GameInformation.isAssassinClass){
			Materials.assassin = true;
		}
		else Materials.assassin = false;

		PlayerPrefs.SetInt("Warrior", (Materials.warrior ? 1 : 0));
		PlayerPrefs.SetInt("Wizard", (Materials.wizard ? 1 : 0));
		PlayerPrefs.SetInt("Assassin", (Materials.assassin ? 1 : 0));
	}



	public void CreateCharacter()
	{


		if (GameInformation.isWarriorClass) 
		{
			GameInformation.PlayerClass = new BaseWarriorClass ();
			GameInformation.isWizardClass = false;
			GameInformation.isAssassinClass = false;

		} 
		else if (GameInformation.isWizardClass) 
		{
			GameInformation.PlayerClass = new BaseWizardClass ();
			GameInformation.isWarriorClass = false;
			GameInformation.isAssassinClass = false;
		} 
		else if (GameInformation.isAssassinClass) 
		{
			GameInformation.PlayerClass = new BaseAssassinClass ();
			GameInformation.isWarriorClass = false;
			GameInformation.isWizardClass = false;
		} else 
			return;


		newPlayer.MaxHealth = GameInformation.PlayerClass.MaxHealth;
		newPlayer.AttackSpeed = GameInformation.PlayerClass.AttackSpeed;
		newPlayer.BaseMinDamage = GameInformation.PlayerClass.BaseMinDamage;
		newPlayer.BaseMaxDamage = GameInformation.PlayerClass.BaseMaxDamage;
		newPlayer.BaseCritChance = GameInformation.PlayerClass.BaseCritChance;
		newPlayer.BaseEvadeChance = GameInformation.PlayerClass.BaseEvadeChance;

		PlayerPrefs.SetInt("Warrior", (GameInformation.isWarriorClass ? 1 : 0));
		PlayerPrefs.SetInt("Wizard", (GameInformation.isWizardClass ? 1 : 0));
		PlayerPrefs.SetInt("Assassin", (GameInformation.isAssassinClass ? 1 : 0));
		StoreNewPlayerInfo ();
		SaveInformation.SavePlayerStats();
		
		if (Application.loadedLevel <= 0)
		{
			newGame = true;
			PlayerPrefs.SetInt("NewGame", (CreateNewCharacter.newGame ? 1 : 0));

		Application.LoadLevel ("MainGame");
		}
	


	}
}
