using UnityEngine;
using System.Collections;

public class WizardSave : MonoBehaviour {

	
	public UnityEngine.UI.Text classDisplay;
	public UnityEngine.UI.Text combatLevelDisplay;

	
	
	


	void Update()
	{

		classDisplay.text = "Wizard";

	


	}
	





	public void Continue()
	{
		Application.LoadLevel ("MainGame");
		
		
	}

}
