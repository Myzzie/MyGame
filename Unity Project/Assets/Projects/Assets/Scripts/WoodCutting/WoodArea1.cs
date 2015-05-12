using UnityEngine;
using System.Collections;

public class WoodArea1 : MonoBehaviour {




	void Update(){

		if (Materials.materials.woodCuttingLevel >= 100) 
		{
		
				Application.LoadLevel("WoodArea1");
		}



	
	
	}
	
	
}
