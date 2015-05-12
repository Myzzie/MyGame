using UnityEngine;
using System.Collections;

public class WarriorSave : MonoBehaviour {

	
	public UnityEngine.UI.Text classDisplay;
	public UnityEngine.UI.Text combatLevelDisplay;

	
	
	


	void Update()
	{

		classDisplay.text = "Warrior";

	


	}
	





	public void Continue()
	{
		Application.LoadLevel ("MainGame");
		
		
	}

}
