using UnityEngine;
using System.Collections;

public class StatsPopUp : MonoBehaviour {


	public static bool Open;
	
	

	void Start ()
	{
		Open = false;
	}




	public void OpenStats()
	{

		if (!Open) 
		{
		
			StatsManager.show ();
			Open = true;
			ClassPurchaseManager.hide ();
			MarketManager.hide ();
			PetStashManager.hide ();
			EquipmentPopUp.Open = false;
			MarketPopUp.Open = false;
			PetStashPopUp.Open = false;

			if (GameInformation.isWarriorClass){
			GameObject Skills = Instantiate (Resources.Load ("Prefabs/WarriorSkills/WarriorSkillTree")) as GameObject;
			Skills.transform.SetParent ((GameObject.Find ("Canvas3").transform), false);
			}
			else if (GameInformation.isWizardClass){
				GameObject Skills = Instantiate (Resources.Load ("Prefabs/WizardSkills/WizardSkillTree")) as GameObject;
				Skills.transform.SetParent ((GameObject.Find ("Canvas3").transform), false);
			}
			else if (GameInformation.isAssassinClass){
				GameObject Skills = Instantiate (Resources.Load ("Prefabs/SinSkills/SinSkillTree")) as GameObject;
				Skills.transform.SetParent ((GameObject.Find ("Canvas3").transform), false);
			}

		}
		else if (Open) 
		{
			if (GameInformation.isWarriorClass){
			Destroy(GameObject.Find("WarriorSkillTree(Clone)"));
			}
			if (GameInformation.isWizardClass){
				Destroy(GameObject.Find("WizardSkillTree(Clone)"));
			}
			if (GameInformation.isAssassinClass){
				Destroy(GameObject.Find("SinSkillTree(Clone)"));
			}
			StatsManager.hide ();
			Open = false;
		

		}

	} 

	

	



}
