using UnityEngine;
using System.Collections;

public class AssassinSave : MonoBehaviour {

	
	public UnityEngine.UI.Text classDisplay;
	public UnityEngine.UI.Text combatLevelDisplay;

	
	
	


	void Update()
	{

		classDisplay.text = "Assassin";

	


	}
	





	public void Continue()
	{
		Application.LoadLevel ("MainGame");
		
		
	}

}
