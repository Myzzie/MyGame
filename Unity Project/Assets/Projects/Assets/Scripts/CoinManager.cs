using UnityEngine;
using System.Collections;

public class CoinManager : MonoBehaviour {
	


	public UnityEngine.UI.Text goldDisplay;

	



	


	
	void Start ()
	{

		
	

	}


	void Update () {


		goldDisplay.text = "" + Materials.materials.gold;

	
	
		if (Materials.materials.gold < 0)
		{
			Materials.materials.gold = 0;
		}

	

	}
	
	

	
}
