using UnityEngine;
using System.Collections;

public class FishSpawner : MonoBehaviour {
	
	
	
	

	
	// Use this for initialization
	void Start () 
	{
		Spawn ();

	
	}
	
	// Update is called once per frame
	void Update () {
		

		
	}
	
	public void Spawn ()
	{
		
	
		GameObject Clone = Instantiate (Resources.Load ("Prefabs/Fishes/FishDots")) as GameObject;
		Clone.transform.SetParent ((GameObject.Find ("FishHolder").transform), false);
				


	}
	
}
