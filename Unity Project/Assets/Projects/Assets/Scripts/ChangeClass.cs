using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeClass : MonoBehaviour {


	public Button warrior;
	public Button wizard;
	public Button assassin;





	void Update()
	{
		if (GameInformation.isWarriorClass)
		{
			warrior.GetComponent<Button>().interactable = false;
			GameInformation.isWizardClass = false;
			GameInformation.isAssassinClass = false;
			Destroy(GameObject.Find("WizardSkillTree(Clone)"));
			Destroy(GameObject.Find("SinSkillTree(Clone)"));
		}
		else warrior.GetComponent<Button>().interactable = true;
		if (GameInformation.isWizardClass)
		{
			wizard.GetComponent<Button>().interactable = false;
			GameInformation.isWarriorClass = false;
			GameInformation.isAssassinClass = false;
			Destroy(GameObject.Find("WarriorSkillTree(Clone)"));
			Destroy(GameObject.Find("SinSkillTree(Clone)"));
		}
		else wizard.GetComponent<Button>().interactable = true;
		if (GameInformation.isAssassinClass)
		{
			assassin.GetComponent<Button>().interactable = false;
			GameInformation.isWarriorClass = false;
			GameInformation.isWizardClass = false;
			Destroy(GameObject.Find("WarriorSkillTree(Clone)"));
			Destroy(GameObject.Find("WizardSkillTree(Clone)"));
		}
		else assassin.GetComponent<Button>().interactable = true;


	}





	public void WarriorClass()
	{
		GameInformation.isWarriorClass = true;
		GameInformation.isWizardClass = false;
		GameInformation.isAssassinClass = false;

		GameObject Skills = Instantiate (Resources.Load ("Prefabs/WarriorSkills/WarriorSkillTree")) as GameObject;
		Skills.transform.SetParent ((GameObject.Find ("Canvas3").transform), false);


		Destroy(GameObject.Find("WizardSkillTree(Clone)"));
		Destroy(GameObject.Find("SinSkillTree(Clone)"));

		if (GameInformation.isWarriorClass)
		{
		warrior.GetComponent<Button>().interactable = false;
		wizard.GetComponent<Button>().interactable = true;
		assassin.GetComponent<Button>().interactable = true;
		}
	}

	public void WizardClass()
	{
		GameObject Skills = Instantiate (Resources.Load ("Prefabs/WizardSkills/WizardSkillTree")) as GameObject;
		Skills.transform.SetParent ((GameObject.Find ("Canvas3").transform), false);

		GameInformation.isWarriorClass = false;
		GameInformation.isWizardClass = true;
		GameInformation.isAssassinClass = false;
		Destroy(GameObject.Find("WarriorSkillTree(Clone)"));
		Destroy(GameObject.Find("SinSkillTree(Clone)"));
		if (GameInformation.isWizardClass)
		{
			warrior.GetComponent<Button>().interactable = true;
			wizard.GetComponent<Button>().interactable = false;
			assassin.GetComponent<Button>().interactable = true;
		}

	}

	public void AssassinClass()
	{
		GameObject Skills = Instantiate (Resources.Load ("Prefabs/SinSkills/SinSkillTree")) as GameObject;
		Skills.transform.SetParent ((GameObject.Find ("Canvas3").transform), false);

		GameInformation.isWarriorClass = false;
		GameInformation.isWizardClass = false;
		GameInformation.isAssassinClass = true;
		Destroy(GameObject.Find("WarriorSkillTree(Clone)"));
		Destroy(GameObject.Find("WizardSkillTree(Clone)"));
		if (GameInformation.isAssassinClass)
		{
			warrior.GetComponent<Button>().interactable = true;
			wizard.GetComponent<Button>().interactable = true;
			assassin.GetComponent<Button>().interactable = false;
		}
	}




}
