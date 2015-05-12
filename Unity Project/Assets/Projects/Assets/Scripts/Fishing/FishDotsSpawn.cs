using UnityEngine;
using System.Collections;

public class FishDotsSpawn : MonoBehaviour {


	
	// Update is called once per frame
	void Update () 
	{
		if (Fish1.Delay == true) {
			animation.Stop ("FishDotsMoving");
		} else 
		{
			animation.Play ("FishDotsMoving");
		}
	}




}
