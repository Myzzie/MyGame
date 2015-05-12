using UnityEngine;
using System.Collections;

public class ShowHide : MonoBehaviour {


	private bool openMarket;
	private bool openStats;
	private bool openPetUpgrade;
	private bool openSwordUpgrade;
	
	
	
	void Start ()
	{

	}

	public void OpenSwordUpgrade()
	{
		
		if (!openSwordUpgrade) 
		{
			
		
			openSwordUpgrade = true;
		
			openMarket = false;
			openStats = false;
			openPetUpgrade = false;
		}
		else if (openSwordUpgrade) 
		{
			

			openSwordUpgrade = false;
			Debug.Log ("Window Close");
		}
		
	} 


	public void OpenPetUpgrade()
	{
		
		if (!openPetUpgrade) 
		{
			

			openPetUpgrade = true;
		
			openMarket = false;
			openStats = false;
			openSwordUpgrade = false;
		}
		else if (openPetUpgrade) 
		{
			
		
			openPetUpgrade = false;
			Debug.Log ("Window Close");
		}
		
	} 
	
	
	public void OpenMarket()
	{
		
		if (!openMarket) 
		{
		
			openMarket = true;
		
			openSwordUpgrade = false;
			openPetUpgrade = false;
			openStats = false;

			
		}
		else if (openMarket) 
		{
			

			openMarket = false;
			
			
		}
		
	} 

	

	public void OpenStats()
	{
		
		if (!openStats) 
		{

			openStats = true;
		
			openSwordUpgrade = false;
			openPetUpgrade = false;
			openMarket = false;
			
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
		else if (openStats) 
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

			openStats = false;
			
			
		}
		
	} 
	




}
