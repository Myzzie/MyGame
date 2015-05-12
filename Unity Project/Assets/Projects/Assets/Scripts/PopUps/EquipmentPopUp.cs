using UnityEngine;
using System.Collections;

public class EquipmentPopUp : MonoBehaviour {



	
	public static bool Open;
	private bool warrior;
	private bool wizard;
	private bool sin;

	
	
	
	void Start ()
	{
		Open = false;
	
	}
	
	
	
	public void OpenEquipment()
	{
		
		if (!Open) 
		{

			ClassPurchaseManager.show ();
			Open = true;
			MarketManager.hide ();
			PetStashManager.hide ();
			StatsManager.hide ();

			MarketPopUp.Open = false;
			PetStashPopUp.Open = false;
			StatsPopUp.Open = false;
			if (GameInformation.isWarriorClass && !warrior)
			{
				warrior = true;
				wizard = false;
				sin = false;
				Destroy (GameObject.Find ("WizardPurchase(Clone)"));
				Destroy (GameObject.Find ("SinPurchase(Clone)"));
				GameObject Skills = Instantiate (Resources.Load ("Prefabs/WarriorPurchase")) as GameObject;
				Skills.transform.SetParent ((GameObject.Find ("ClassPurchase").transform), false);
			}
			else if (GameInformation.isWizardClass && !wizard)
			{
				wizard = true;
				warrior = false;
				sin = false;
				Destroy (GameObject.Find ("WarriorPurchase(Clone)"));
				Destroy (GameObject.Find ("SinPurchase(Clone)"));
				GameObject Skills = Instantiate (Resources.Load ("Prefabs/WizardPurchase")) as GameObject;
				Skills.transform.SetParent ((GameObject.Find ("ClassPurchase").transform), false);
			}
			else if (GameInformation.isAssassinClass && !sin)
			{
				sin = true;
				warrior = false;
				wizard = false;
				Destroy (GameObject.Find ("WarriorPurchase(Clone)"));
				Destroy (GameObject.Find ("WizardPurchase(Clone)"));
				GameObject Skills = Instantiate (Resources.Load ("Prefabs/SinPurchase")) as GameObject;
				Skills.transform.SetParent ((GameObject.Find ("ClassPurchase").transform), false);
			}
		
		}
		else if (Open) 
		{
		
			ClassPurchaseManager.hide ();
			Open = false;
			Debug.Log ("Window Close");
		
		}
		
	} 
}
